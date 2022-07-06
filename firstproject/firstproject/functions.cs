using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace firstproject
{
    public class functions
    {
        public void test()
        {
            Console.WriteLine("i'm function");

        }
        public void takingout()
        {
            Console.WriteLine("Введите что-то");
            string? a = Console.ReadLine();
            Console.WriteLine(a);

        }
        public void constants()
        {
            var b = 5;
            const double c = 3.14;

        }
        public void plus()
        {
            Console.WriteLine("Введите число");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? b = Console.ReadLine();
            int d = Int32.Parse(a);
            int e = Int32.Parse(b);
           
            Console.WriteLine(d + e);
        }
        public void minus()
        {
            Console.WriteLine("Введите число");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? b = Console.ReadLine();
            int d = Int32.Parse(a);
            int e = Int32.Parse(b);
            if (d>=e)
            {
                Console.WriteLine(d-e);
            }
            else
            {
                Console.WriteLine("Невозможное значение");
            }
        }
        public void paw() //степень
        {
            Console.WriteLine("Введите число");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? b = Console.ReadLine();
            int d = Int32.Parse(a);
            int e = Int32.Parse(b);
            
            Console.WriteLine(Math.Pow(d, e));
        }
        public void multiplier() //умножение
        {
            Console.WriteLine("Введите число");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? b = Console.ReadLine();
            int d = Int32.Parse(a);
            int e = Int32.Parse(b);
            Console.WriteLine(d * e);
        }
        public void separation() //деление
        {
            Console.WriteLine("Введите число");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? b = Console.ReadLine();
            double d = Double.Parse(a);
            double e = Double.Parse(b);
            Console.WriteLine(Math.Round(d / e,2));
        }
        public void calculator()
        {
            Console.WriteLine("Введите знак");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? b = Console.ReadLine();
            Console.WriteLine("Введите число");
            string? c = Console.ReadLine();
            switch (a)
            {
                case "+":
                    {
                        int d = Int32.Parse(b);
                        int e = Int32.Parse(c);
                        int f = (d + e);
                        Console.WriteLine("Результат выполнения функции " + d + " " + a + " " + e + " = " + f);
                        break;
                    }
                case "-":
                    {
                        int d = Int32.Parse(b);
                        int e = Int32.Parse(c);
                        int f = (d + e);
                        Console.WriteLine("Результат выполнения функции " + d + " " + a + " " + e + " = " + f);
                        break;
                    }
                case "*":
                    {
                        int d = Int32.Parse(b);
                        int e = Int32.Parse(c);
                        int f = (d * e);
                        Console.WriteLine("Результат выполнения функции " + d + " " + a + " " + e + " = " + f);
                        break;
                    }
                case "/":
                    {
                        double d = Double.Parse(b);
                        double e = Double.Parse(c);
                        double f = Math.Round((d / e),3);
                        Console.WriteLine("Результат выполнения функции "+d+" "+a+" "+e+" = "+f); 
                        break;
                    }
                case "^":
                    {
                        int d = Int32.Parse(b);
                        int e = Int32.Parse(c);
                        double f = (Math.Pow(d, e));
                        Console.WriteLine("Результат выполнения функции " + d + " " + a + " " + e + " = " + f);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такой функции нет");

                    }
                    break;
            }
            Console.ReadLine();
        }
        public void playwhile()
        {
            int a = 0;
            while (a<100)
            {              
                a = a + 13;
                Console.Write(a+" ");
                if (a+13>100)
                {
                    break;
                }
            }
        }
        public void playfor()
        {
            for (int i = 13; i < 100; i +=13)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}
