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
        public void massive() //массивы
        {
            string[] array = new string[5];
            array = new string[] {"Hello", "Hi", "g", "h", "j"};
            foreach (var i in array)
            {
                
                if ((i== "Hello")||(i== "Hi"))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                
            }
        }
        public void massive2()
        {        
            int[] array = new int[5] {5,9,4,1,3};
            int max = 0;
            int min2 = array[0];// первый элемент массива, считается с нуля
            foreach (var i in array)
            {
                if (i>max)
                {
                    max = i;
                }
                if (min2 > i)
                {
                    min2 = i;
                }

            }
            Console.WriteLine("Минимальное число равняется" + " " + min2);
            Console.WriteLine("Максимальное число равняется" + " " + max);
            /*int min = max;
            foreach (var i in array)
            {
                if (i<min)
                {
                    min = i;
                    
                }
            }
               Console.WriteLine("Минимальное число равняется" + " " + min);*/
        }
        public int summ2(string num1, string num2)
        {
            int a = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            return a;
        }
        public void info()
        {
            Console.WriteLine("Введите свое имя");
            string? a = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string? b = Console.ReadLine();
            int e = 0;
            while ((e>100) || (e<1))
            {
                Console.WriteLine("Введите год рождения");
                string? c = Console.ReadLine();
                int d = Convert.ToInt32(c);
                 e = (2022 -d);
                if ((d>2022)||(e>100))
                {
                    Console.WriteLine("Вы ввели недействительный год рождения");               
                }
                           
            }
            Console.Clear();
            Console.Write("Имя:" + a + " " + "Фамилия:" + b + ", " + e + "лет");
        }
        public string back(string a, string b)
        {
           
            return a + b;
        }
        public string back2( )
        {
            string c = "";            
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            string[] array = new string[b];
            for (int i = 0; i < b; i++)
            {
                c = Console.ReadLine();
                array[i] = c; 
            }
            string d = "";
            foreach (var item in array)
            {
                d += item + " ";
            }
                return d;  
        }
        struct FIO
        {
            public string name;
            public string surname;
            public string secondname;


            public override string ToString()
            {
                return ("Имя "+name + " " + " Фамилия "+surname + " Отчество " + secondname);
            }

        }
        public void structures()
        {
            FIO FIO1 = new FIO();
            FIO1.name = "Vitalya";
            FIO1.surname = "Filippov";
            FIO1.secondname = "Viktorovich";
            Console.WriteLine(FIO1);
        }
        public void uravnenie()
        {
            string a;
            string b;
            string c;
            Console.WriteLine("Введите коэффициенты  a, b и c");
            a = Console.ReadLine();          
            int a1 = Convert.ToInt32(a);
            b = Console.ReadLine();
            int b1 = Convert.ToInt32(b);
            c = Console.ReadLine();
            int c1 = Convert.ToInt32(c);
            if (a1==0)
            {
                double d = (0 - c1);
                Console.WriteLine("x=" + (double)(d/b1));

            }
            if (a1==0 && b1==0)
            {
                Console.WriteLine("Решение невозможно");
            }
            double discreminant = b1 ^ 2 - 4 * a1 * c1;
            Console.WriteLine(discreminant);
            if (discreminant<1)
            {
                Console.WriteLine("Решение невозможно, попробуйте еще раз");
               
            }
            else
            {
            double coren_discreminant = Math.Sqrt(discreminant);
            double x1 = (-b1 + coren_discreminant) / (2 * a1);
            Console.WriteLine("Первый корень равняется"+ " " + x1);
            double x2 = (-b1 - coren_discreminant) / (2 * a1);
            Console.WriteLine("Второй корень равняется" + " " + x2);

            }
        }
    }
}
