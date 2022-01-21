using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasMatematica1
{
    class Program
    {
        public static double Fatorial(int num)
        {
            int num2 = num;
            for (int i = 1; i < num2; i++)
                num *= i;

            return num;
        }

        public static int Maximo(int[] array)
        {
            int maior = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maior < array[i])
                    maior = array[i];
            }
            return maior;
        }

        public static int Potencial(int base1, int exp)
        {
            int base2 = base1;

            if (exp == 1)
                return base1;

            for (int i = 2; i <= exp; i++)
            {
                base1 *= base2;

            }
            return base1;
        }

        public static int Multiplo(int m1, int m2, int limite)
        {
            int soma = 0;

            for (int i = 1; i < limite; i++)
            {
                if (i % m1 == 0 || i % m2 == 0)
                    soma += i;
            }

            return soma;
        }

        public static int Fib(int n)
        {
            int fib = 1, fib2 = 1, p = 1;

            for (int i = 3; i <= n; i++)
            {
                p = fib + fib2;
                fib = fib2;
                fib2 = p;
            }

            return p;
        }

        public static int[] DescobreFib(int limite)
        {
            int fib = 1, fib2 = 1, p = 1, i = 2, soma = 0;
            int[] array = new int[2];
            while (p < limite)
            {
                p = fib + fib2;
                fib = fib2;
                fib2 = p;
                if (p % 2 == 0)
                    soma += p;
                i++;
            }
            array[0] = i;
            array[1] = soma;
            return array;
        }

        static void Exibir(int[] pArray)
        {
            foreach (var item in pArray)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static int[] BubbleSort(int[] ns)
        {
            for (int i = 1; i < ns.Length; i++)
            {
                var trocou = false;
                for (int j = 0; j < ns.Length - i; j++)
                {
                    if (ns[j] > ns[j + 1])
                    {
                        var aux = ns[j];
                        ns[j] = ns[j + 1];
                        ns[j + 1] = aux;
                        trocou = true;
                    }
                }
                if (!trocou)
                {
                    return ns;
                }
            }
            return ns;
        }

        public static int[] DescobreIdadePeloProduto(int produto,int[] vs,int i)
        {

            int n = produto,k = 1;
            while (produto!=1)
            {
                if (produto % k == 0)
                {
                    produto /= k;
                    vs[i] = k;
                    k++;
                    vs = DescobreIdadePeloProduto(produto, vs, i++);
                    return vs;
                }
                
            }

            return vs;
        }

        public static void Hanoi(int pDiscos, int pOrigem, int pDestino, int pAux)
        {

            if (pDiscos == 1)
            {
                Console.WriteLine($"{pOrigem} -> {pDestino}");
            }
            else
            {
                Hanoi(pDiscos - 1, pOrigem, pAux, pDestino);
                Hanoi(1, pOrigem, pDestino, pAux);
                Hanoi(pDiscos - 1, pAux, pDestino, pOrigem);
            }

        }

        public static int BAR(int a, int b)
        {
            if (b == 1)
                return a;
            else
                return a + BAR(a, b - 1); ;
        }

        

        static void Main(string[] args)
        {
            /*double cateto1, cateto2, hip;

            Console.WriteLine("Digite o valor do primeiro cateto:");
            cateto1 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o valor do segundo cateto:");
            cateto2 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            hip =Math.Sqrt(Math.Pow(cateto1,2) + Math.Pow(cateto2,2));

            Console.WriteLine("Hipotenusa = "+hip);
            Console.ReadKey();*/




            /*int x, y, z;

            Random random = new Random();
            x = random.Next(1, 101);
            y = random.Next(1, 101);
            z=random.Next(1, 101);
            Console.WriteLine("1º número="+x+ "\n2º número=" + y + "\n3º número=" + z + "\nMédia=" +(x+y+z)/3.0);
            


            Random random = new Random();
            int x = 1, y = random.Next(1, 101), z = random.Next(1, 101), soma = x++ + y + z;

            Console.WriteLine("X=" + x + "\nY=" + y + "\nZ=" + z + "\nSoma=" + soma);
            Console.ReadKey();
*/





            //double e = 0.0, ereal = Math.Exp(1);
            //for (int i = 0; i <= 8; i++)
            //{
            //    if (i == 0)
            //        e = 1.0;
            //    else
            //    {
            //        e += 1.0 /Fatorial(i);
            //    }
            //    Console.WriteLine("e("+(i+1)+")="+e+ "  erro:"+(ereal-e));
            //}




            //var E = Math.Exp(1);
            //Console.WriteLine($"Math.Exp(1) = {E}");
            //var e = 1.0;
            //var c = 1;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e = e + e / 1;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e += 1.0 / 2;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e +=1.0 / 6;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e +=1.0 / 24;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e +=1.0 / 120;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e +=1.0 / 720;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e +=1.0 / 5040;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            //e +=1.0 / 40320;
            //Console.WriteLine($"e({c++}) = {e:N15} ... erro: {E - e:N15}");
            
            
            
            
            /*
            int n = 2;
            var ereal = Math.Exp(n);
            Console.WriteLine($"Math.Exp("+n+$") = {ereal}");
            var e = 1.0;
            var cont = 1;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -   erro: {ereal - e:N15}");
            e += Math.Pow(n,cont++) / 1;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -   erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 2;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 6;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 24;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 120;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 720;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} - erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 5040;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} - erro: {ereal - e:N15}");
            e += Math.Pow(n, cont++) / 40320;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} - erro: {ereal - e:N15}");


            
            int n;
            Console.WriteLine("manda");
            Int32.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(Fatorial(n));
            




            int n = 2;
            var ereal = Math.Exp(n);
            Console.WriteLine($"Math.Exp(" + n + $") = {ereal}");
            var e = 1.0;
            var cont = 1;
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -   erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -   erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} -  erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} - erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} - erro: {ereal - e:N15}");
            e += Math.Pow(n, cont) / Fatorial(cont++);
            Console.WriteLine($"Exponencial({cont}) = {e:N15} - erro: {ereal - e:N15}");





            int[] array = new int[] { 12, 30, 27, 100, -5, 11 };
            Console.WriteLine("Maior número do array é igual a " + Maximo(array));





            int base1 = 5, exp = 3;
            Console.WriteLine("\nO resultado de " + base1 + " elevado a " + exp + " é igual a " + Potencial(base1, exp));




            int multiplo1 = 3, multiplo2 = 5, limite = 1000;
            Console.WriteLine("\nA soma dos multiplos de " + multiplo1 + " ou " + multiplo2 + " até " + limite + " é " + Multiplo(multiplo1, multiplo2, limite));




            int n = 10;
            Console.WriteLine("A sequência de Fibonacci até o " + n + " é " + Fib(n));



            int[] resp = DescobreFib(4000000);
            Console.WriteLine("\n A soma  da sequência até a posição " + resp[0]+" é igual a "+resp[1]);

            */
            /*
        primeira passada: 4 passos.
            [10, 9], 8, 7, 5  j  =0
    9, [10, 8], 7, 5 j = 1
    9, 8, [10, 7], 5 j =2
    9, 8, 7, [10, 5] j = 3
    9, 8, 7, 5, 10 

    3 comparações
   [9, 8], 7, 5, 10
   8, [9, 7], 5, 10
   8, 7, [9, 5], 10
  
            8, 7, 5, 9, 10

            2 comparações
          [8, 7], 5, 9, 10
            7, [8, 5],     9, 10
            7, 5, 8, 9, 10

            1 comaração
            [7, 5], 8    , 9, 10
            5, 7, 8, 9, 10;
   

            int[] ns = new int[] { 10, 9, 8, 7, 5, 4, 1, 2, 3, 4, 1, 4, 5, 20, 3 };
            Exibir(ns);
            ns = BubbleSort(ns);
            //ns = ns.Where(c => c % 2 == 0).OrderBy(c => c).Skip(1).Take(2).ToArray();

            Exibir(ns);


            

        
 
            */

            //int ndiscos = 4, origem = 1, destino = 3, aux = 2;
            //Hanoi(ndiscos,origem,destino,aux);




            int[] vs = new int[] { 1, 1, 1 };
            Console.WriteLine(DescobreIdadePeloProduto(36,vs,0));

            Console.ReadKey();

        }
    }
}
