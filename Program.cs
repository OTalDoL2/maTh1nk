using System;

namespace MaThink
{
    class Program
    {
        public static void Bhask(double a, double b, double c){
            double delta = (b*b - 4*a*c);
            double[] x = new double[2];
            double raizDelta = Math.Sqrt(delta);

            //Resolução
            System.Console.WriteLine("delta = b² - 4.a.c");
            System.Console.WriteLine("delta = " + b + "² - 4." + a + "." + c);
            



            if(raizDelta < 0){
                System.Console.WriteLine("Esta equação não possui raízes reais, uma vez que a raiz de Delta é menor que 0");
            }
            else if(raizDelta > 0 && raizDelta == delta*delta) {
                x[0] = (-1*b + raizDelta)/2*a;
                x[1] = (-1*b - raizDelta)/2*a;
                System.Console.WriteLine("x = -b ± √delta / 2.a");
                System.Console.WriteLine("a raiz de delta = " + raizDelta);
                System.Console.WriteLine("x = -" + b + " ± " +raizDelta + " / 2." + a);
                System.Console.WriteLine("x¹ = -" + b + " + " + raizDelta + " / 2." + a );
                System.Console.WriteLine("x¹ = " + x[0]);
                System.Console.WriteLine("x² = -" + b + " - " + raizDelta + " / 2." + a );
                System.Console.WriteLine("x² = " + x[1]);                


                System.Console.WriteLine("O conjunto solução de raízes é S={" + x[0] + ", " + x[1] + "}");
            }
            else if(delta*delta != raizDelta && raizDelta != 0){
                System.Console.WriteLine("A raiz de Delta não é exata.");
            }
            else if(raizDelta == 0){
                x[0] = -1*b /2*a;
                System.Console.WriteLine("delta = 0");
                System.Console.WriteLine("logo, equação possui uma única raíz");
                System.Console.WriteLine("x = -b / 2.a");
                System.Console.WriteLine("x = -" + b + " / 2." + a);
                System.Console.WriteLine("x = " + x[0]);

            }
            
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Primeiro, localize os termos, na questão. Ex: ax² + bx + c = 0");
            
            
            //3x² - 4x + 2;
            double a, b, c;
            
            System.Console.Write("o termo A é " );
            a = double.Parse(Console.ReadLine());

            System.Console.Write("o termo B é " );
            b = double.Parse(Console.ReadLine());

            System.Console.Write("o termo C é " );
            c = double.Parse(Console.ReadLine());
            
            Bhask(a,b,c);
        }
    }
}
