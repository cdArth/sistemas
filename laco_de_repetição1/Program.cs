using System;

namespace laco_de_repetição1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double grausC, grausF;
            
            Console.WriteLine("Informe uma temperatura em Celsius:");
            string resp = Console.ReadLine();
            resp = resp.Replace(".", ",");
            Double.TryParse(resp, out grausC);

            while (grausC!=0)
            {
                grausF=grausC * 1.8 + 32;
                Console.WriteLine($"Em Celsius: {grausC:N5} - Em Fahrenheit: {grausF:N5}");
                Console.WriteLine("Informe outra temperatura:");
                resp = Console.ReadLine();
                Double.TryParse(resp, out grausC);


            }
            Console.WriteLine("Hasta la vista");
            
            double grausC, grausF;
            string resp;
            int n = 0;
            do
            {
                Console.WriteLine("Informe uma temperatura em Celsius:");
                resp = Console.ReadLine();
                resp = resp.Replace(".", ",");
                Double.TryParse(resp, out grausC);
                grausF = grausC * 1.8 + 32;
                Console.WriteLine($"Em Celsius: {grausC:N5} - Em Fahrenheit: {grausF:N5}");
                n++;
            } while (n <=3);
            

            int n, dig, num;
            Console.WriteLine("Insira um número decimal:");
            Int32.TryParse(Console.ReadLine(), out n);
            string saida = "";
            
            num = n;
            do
            {
                dig = n % 2;
                saida = dig+ saida;
                num = n;
                n = n / 2;
                
                Console.WriteLine("Número decimal:" + num + "/2 ="+ n + " - Dígito:" + dig);
            } while (n!=0);
            Console.WriteLine("Saída:"+saida);
            //Console.WriteLine("Número decimal:"+num+" - Saída:"+saida);
            

            var n = 1;
            var r = 7;
            for (int i = 1; i <= r; i++)
            {
                n *= i;
            }
            Console.WriteLine("Multiplicando do 1 até o "+ r+" é igual a "+n );
            

            
            //variar de 7 a 77 em incrementos de 7

            for (int i = 7; i < 78; i += 7)
               Console.Write(i+" ");
            
            Console.WriteLine();
            //de 20 a 2 em incremento -2
            
            for (int i = 20; i > 1; i-=2)
                Console.Write(i + " ");
            
            Console.WriteLine();
            //assumir os valores: 2, 5, 8, 11, 14, 17, 20

            for (int i = 0; i <= 20; i += 3)
                Console.Write(i + " ");
            
                Console.WriteLine();

            //assumir os valores: 99,88,77,66,55,44,33,22,11,0
            for (int i = 99; i >= 0; i -= 11)
                Console.Write(i + " ");


            //a = 1; b = -20; c = 100; /// delta zero, raiz 10
            //a = 1; b = 1; c = -90; /// delta posit. -10 e 9
            //a = 1; b = 2; c = 3; /// delta neg

            double a, b, c, delta, x1, x2;
            Console.WriteLine("Insira o a da equação:");
            Double.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Insira o b da equação:");
            Double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Insira o c da equação:");
            Double.TryParse(Console.ReadLine(), out c);

            delta = Math.Pow(b, 2) - 4 * a * c;


            if (delta < 0)
                Console.WriteLine("Não existem raízes reais");
            else if (delta == 0)
                Console.WriteLine("delta=" + 0 + " x1=x2=" + (-b / 2 * a));
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("delta=" + delta + " x1=" + x1 + " x2=" + x2);
            }
            
            Random random = new Random();
            int result, lado1 = 0, lado2 = 0, lado3 = 0, lado4 = 0, lado5 = 0, lado6 = 0;

            for (int i = 0; i < 6000; i++)
            {
                result = random.Next(1, 7);

                if (result == 1)
                    lado1++;
                else if (result == 2)
                    lado2++;
                else if (result == 3)
                    lado3++;
                else if (result == 4)
                    lado4++;
                else if (result == 5)
                    lado5++;
                else
                    lado6++;
            }
            Console.WriteLine("Frêquencia dos lados:\n" +
                "Lado           Frêquencia" +
                "\n1                " + lado1+
                "\n2                " + lado2+
                "\n3                " + lado3 +
                "\n4                " + lado4 +
                "\n5                " + lado5 +
                "\n6                " + lado6);

            */
            Random random = new Random();

            int result, result2;

            int[] frequencia = new int[11];


            for (int i = 0; i < 6000; i++)
            {
                result = random.Next(1, 7);
                result2 = random.Next(1, 7);
                var soma = result + result2;
                frequencia[soma - 2]= frequencia[soma - 2]+1;

            }

            Console.WriteLine("Frêquencia dos lados:\n" +
                "Soma de Lados          Frêquencia");

            for (int i = 0; i < 11; i++)
                Console.WriteLine((i+2)+"                       "+ frequencia[i]);

            Console.ReadKey();
        }
    }
}
