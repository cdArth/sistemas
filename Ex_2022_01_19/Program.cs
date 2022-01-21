using System;

namespace Ex_2022_01_19
{
    class Program
    {
        #region enunciadoCarro
        /*Dois carros(X e Y) partem na mesma direção, O carro X anda a uma velocidade constante de 60 Km/h e o carro Y anda a uma velocidade 
         * constante de 90 Km/h
        Em uma hora(60 minutos), o carro Y fica a uma distância de 30 Km em relação ao carro X,. 
        Seu programa deve aceitar um valor da distância “d” (em quilômetros) e calcular quanto tempo leva(em minutos) na qual o carro Y ficará distante “d” Kms do carro X;

        Exemplo
        Se eu entrar com 30 a resposta deve ser 60 minutos.
        */
        #endregion
        public static double MostraTempo(double v1, double v2, double distancia)
        {
            double tempo = 0, dif = 0;

            dif = v1 - v2;
            if (dif < 0)
                dif *= -1;

            tempo = distancia / dif * 60.0;

            return tempo;

        }
        public static void ExibirTempoCarro()
        {
            double v1 = 90, v2 = 60, distancia;


            Console.WriteLine("Insira uma distancia, em quilometros, entre um carro a " + v1 + "km/h e um carro a " + v2 + "km/h \npara saber quanto tempo se passou em minutos!");
            Double.TryParse(Console.ReadLine(), out distancia);
            Console.WriteLine("Passaram-se " + MostraTempo(v1, v2, distancia) + " minutos");
        }

        #region enunciado area volume
        /*
            A fórmula para calcular a área de uma círculo é definida como A = Pi * R ^ 2.
            A fórmula para calcular o volume de uma esfera é 4 / 3 * PI * R ^ 3
            Seu programa deve aceitar um valor em ponto flutuante(double), que será o valor de R e

            exibir “A = “ seguido do valor com 4 casas decimais. 

            Exibir “V = “ seguindo do valor do volume, com 4 casas decimais;
            */
        #endregion
        public static void ExibirAreaVolume()
        {
            double r;
            Console.WriteLine("Insira um raio de uma esfera");
            Double.TryParse(Console.ReadLine(), out r);

            CalculaArea(r);
            CalculaVolume(r);
        }
        public static void CalculaArea(double r)
        {

            r = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"A={r:N4}");
        }
        public static void CalculaVolume(double r)
        {

            r = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"V={r:N4}");
        }

        #region triangulo enunciado
        /*
         Leia (aceite via teclado) três números representando os lados de um triângulo, e os arrange em ordem decrescente, para que o lado A seja o 
        maior lado dos três. Depois determine o tipo de triângulo que eles podem formar. Baseado nos casos abaixo: 
        A ≥ B + C,: NAO FORMA TRIANGULO 
        A2 = B2 + C2,: TRIANGULO RETANGULO 
        A2 > B2 + C2,: TRIANGULO OBTUSANGULO 
        A2 < B2 + C2,: TRIANGULO ACUTANGULO 
        Se os três lados são iguais: TRIANGULO EQUILATERO 
        Se apenas dois lados são iguais: TRIANGULO ISOSCELES 
        Veja que um mesmo triângulo pode cair em mais do que uma categoria, exemplo. ACUTANGULO ISOSCELES 
        
         */
        #endregion
        public static void ExibirTriangulo()
        {
            int A, B, C, aux;
            Console.WriteLine("Insira o primeiro lado");
            Int32.TryParse(Console.ReadLine(), out A);

            Console.WriteLine("Insira o segundo lado");
            Int32.TryParse(Console.ReadLine(), out B);

            Console.WriteLine("Insira o terceiro lado");
            Int32.TryParse(Console.ReadLine(), out C);

            if (B > A)
            {
                aux = B;
                B = A;
                A = aux;
            }
            else if (C > A)
            {
                aux = C;
                C = A;
                A = aux;
            }


            InformaTriangulo(A, B, C);

        }
        public static void InformaTriangulo(int A, int B, int C)
        {
            string resp = "Triângulo";

            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                resp += " Retângulo";
            if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                resp += " Obtusângulo";
            if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                resp += " Acutângulo";
            if (A == B && B == C)
                resp += " Equilátero";
            if (A == B || B == C || A == C)
                resp += " Isósceles";
            if (A >= B + C)
                resp = "Não forma triângulo";

            Console.WriteLine(resp);
        }

        public static void ExibirLEDs()
        {
            int n;

            Console.WriteLine("Digite a quantidade de números:");
            Int32.TryParse(Console.ReadLine(), out n);
            int[] vs = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Escreva o numero " + i + ":");
                Int32.TryParse(Console.ReadLine(), out vs[i - 1]);
            }
            NumeroLEDs(vs);

        }
        public static void NumeroLEDs(int[] vs)
        {
            int[] leds = new int[vs.Length];
            int i = 0;
            foreach (var item in vs)
            {

                foreach (var numero in item.ToString())
                {

                    if (numero == '1')
                        leds[i] += 2;
                    else if (numero == '2' || numero == '3' || numero == '5')
                        leds[i] += 5;
                    else if (numero == '4')
                        leds[i] += 4;
                    else if (numero == '6' || numero == '9' || numero == '0')
                        leds[i] += 6;
                    else if (numero == '7')
                        leds[i] += 3;
                    else
                        leds[i] += 7;
                }
                Console.WriteLine(leds[i] + " leds");
                i++;
            }


        }

        //Encontre a diferença entre a soma dos quadrados e o quadrado da soma dos 100 primeiros números naturais. 
        public static void ExibirDiferencaSomaQuadrado(int n, double soma, double soma1)
        {

            if (n > 0)
            {

                soma1 += n;
                soma += Math.Pow(n, 2);
                ExibirDiferencaSomaQuadrado(n - 1, soma, soma1);
            }
            else
            {
                soma1 = Math.Pow(soma1, 2);
                soma1 -= soma;
                Console.WriteLine("A diferença é igual a " + soma1);
            }



        }

        /* Menor múltiplo enunciado
            O menor número que é divisível por todos os números de 1 a 10 é o número 2520. 
            Encontre o menor número que é divisível por todos os números de 1 a 20. 
         */
        public static void ExibirMenorMultiplo()
        {
            int inicial = 9;
            bool divisivel;

            do
            {
                divisivel = true;
                inicial++;
                for (int i = 1; i <= 20; i++)//i poderia começar do 10, mas como isso foi dado no enunciado comecei do 1 mesmo - for (int i = 10; i <= 20; i++)
                {
                    if (inicial % i != 0)
                    {
                        divisivel = false;
                        break;
                    }
                }

            } while (!divisivel);
            Console.WriteLine(inicial);
        }

        public static void Descriptografar()
        {
            string palavra = "5535#rljäwvh#rwhmruS#0#dflwäpuriqL#hfdpdwdG", resp1="";

            foreach (char letra in palavra)
            {
                var codigo = (int)letra;
                resp1+= (char)(codigo - 3);//testei os outros e esse foi o que resultou em algo plausivel rsrs
            }

            string resp2 = "";
            int i = resp1.Length-1;
            do
            {
                resp2 += resp1[i];
                i--;
            } while (i>=0);

            Console.WriteLine("A resposta é: " + resp2); // Datamace Informática - Projeto estágio 2022
            

        }
        static void Main(string[] args)
        {
            //ExibirTempoCarro();
            //ExibirAreaVolume();
            //ExibirTriangulo();
            //Descriptografar();
            //ExibirLEDs();
            //ExibirDiferencaSomaQuadrado(100,0,0);
            //ExibirMenorMultiplo();
            

            Console.ReadKey();
        }
    }
}
