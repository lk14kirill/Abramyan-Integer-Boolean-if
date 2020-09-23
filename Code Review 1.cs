using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace Dz
{
    class Program
    {
        static void IntegerNum3()
        {

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a /= 1024);
        }
        static void IntegerNum6()
        {
            Console.WriteLine("Введите двухзначное число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество десяток:" + a / 10);
            Console.WriteLine("Количество единиц:" + a % 10);
        }

        static void IntegerNum9()
        {
            Console.WriteLine("Введите трехзначное число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество сотен:" + a / 100);
        }
        static void IntegerNum12()
        {
            Console.WriteLine("Введите трехзначное число");
            int a = int.Parse(Console.ReadLine());
            int b, c, d;
            b = a / 100; c = (a % 100) / 10; d = a % 10;
            Console.WriteLine("Ваше перевернутое число {0}{1}{2}", d, c, b);
        }
        static void IntegerNum15()
        {
            Console.WriteLine("Введите трехзначное число");
            int a = int.Parse(Console.ReadLine());
            int b, c, d;
            b = a / 100; c = (a % 100) / 10; d = a % 10;
            Console.WriteLine("Ваше перевернутое число {0}{1}{2}", c, b, d);
        }
        static void IntegerNum18()
        {
            Console.WriteLine("Введите трехзначное число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Число тысяч:" + (a / 1000) % 10);
        }
        static void IntegerNum21()
        {
            Console.WriteLine("Введите количество секунд");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество секунд,прошедших с последней минуты:" + N % 60);
        }
        static void IntegerNum24()
        {
            Console.WriteLine("Введите номер дня в диапозоне(1-365) ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("День недели этого года " + K % 7);
        }
        static void IntegerNum27()
        {
            Console.WriteLine("Введите номер дня в диапозоне(1-365) ");
            int K = int.Parse(Console.ReadLine());
            K = (K + 4) % 7 + 1;
            Console.WriteLine("День недели этого года " + K);
        }
        static void IntegerNum30()
        {
            Console.WriteLine("Введите любой год ");
            int K = int.Parse(Console.ReadLine());
            K = (K - 1) / 100 + 1;
            Console.WriteLine("Номер столетия " + K);
        }
        static void BooleanNum3()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int K = int.Parse(Console.ReadLine());
            check = K % 2 == 0 ? (true) : (false);
            Console.WriteLine("Число является четным, " + check);
        }
        static void BooleanNum6()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            check = a < b && b < c ? (true) : (false);
            Console.WriteLine("Cправедливо ли двойное неравенство A<B<C, " + check);
        }
        static void BooleanNum9()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            check = a % 2 == 1 || b%2 == 1 ? (true) : (false);
            Console.WriteLine("Хотя бы одно из чисел A и B нечетное, " + check);
        }
        static void BooleanNum12()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            check = a >= 0 && b >= 0 && c >= 0  ? (true) : (false);
            Console.WriteLine("Каждое из чисел A,B,C положительное , " + check);
        }
        static void BooleanNum15()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            check = a >= 0 && b >= 0 || c >= 0 && a >= 0 || b >= 0 && c >= 0 ? (true) : (false);
            Console.WriteLine("Ровно два из чисел A,B,C являются положительными, " + check);
        }
        static void BooleanNum18()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            check = a == b || a == c || b == c ? (true) : (false);
            Console.WriteLine("Среди трех данных целых чисел есть хотя бы одна пара совпадающих, " + check);
        }
        static void BooleanNum21()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int k = int.Parse(Console.ReadLine());
            int a, b, c;
            a = k / 100;b = (k % 100) / 10;c = k % 10;
            check =  a<b && b<c ? (true) : (false);
            Console.WriteLine("Цифры данного числа образуют возрастающую последовательность, " + check);
        }
        static void BooleanNum24()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            uint A = uint.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(B, 2) - 4 * A * C);
            check = d > 0 || d == 0 ? (true) : (false);
            Console.WriteLine("Квадратное уравнения Ax*x + Bx + C = 0 имеет вещественные корни, " + check);
        }
        static void BooleanNum27()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            
            check = x < 0 ? (true) : (false);
            Console.WriteLine("Точка с координатами(x,y) лежит во второй или третьей координатой четверти, " + check);
        }
        static void BooleanNum30()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            check = a == b && a ==c  ? (true) : (false);
            Console.WriteLine("Треугольник со сторонами a,b,c является равносторонним, " + check);
        }
        static void BooleanNum33()
        {
            bool check;
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            check = a+b >c  && a+c > b  && b+c > a? (true) : (false);
            Console.WriteLine("Cуществует треугольник со сторонами a,b,c, " + check);
        }
        static void BooleanNum36()
        {
            bool check;
            Console.WriteLine("Введите первые координаты диапозон (1-8) ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторые координаты диапозон (1-8) ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            check = x1 == x2 || y1 == y2 ? (true) : (false);
            Console.WriteLine("Cуществует треугольник со сторонами a,b,c, " + check);
        }
        static void BooleanNum39()
        {
            bool check;
            Console.WriteLine("Введите первые координаты диапозон (1-8) ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторые координаты диапозон (1-8) ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            check = x1 == x2 || y1 == y2 ? (true) : (false);
            Console.WriteLine("Cуществует треугольник со сторонами a,b,c, " + check);
        }
        static void IfNum3()
        {
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                a += 1;
            if (a < 0)
                a -= 2;
            if(a == 0)
            {
                a = 10;
            }
            Console.WriteLine(a);
        }
        static void IfNum6()
        {
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            
                Console.WriteLine(a);
            
            if(a< b)
                Console.WriteLine(b);
        }
        static void IfNum9()
        {
            Console.WriteLine("Введите любое число ");
            int x, y;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                x = b;
                y = a;
                Console.WriteLine("Меньшая переменная {0}, большая переменная {1}", x, y);
            }
            if (a < b)
            {
                x = a;
                y = b;
                Console.WriteLine("Меньшая переменная {0}, большая переменная {1}", x, y);
            }
        }
        static void IfNum12()
        {
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && b> c || b > a && a> c)
                Console.WriteLine("Наименьшая переменная " + c);
            if (b>c && c>a || c > b && b >a)
                Console.WriteLine("Наименьшая переменная " + a);
            if (c > a && a > b || a>c && c > b)
                Console.WriteLine("Наименьшая переменная " + b);
        }
        static void IfNum15()
        {
            Console.WriteLine("Введите любое число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(".");
            if (a  > c && b  > c)
                Console.WriteLine("Cумма наибольших из них " + (a + b));
            if (b> a && c > a)
                Console.WriteLine("Cумма наибольших из них " + (c + b));
            if (c > b && a > b)
                Console.WriteLine("Cумма наибольших из них " + (a + c));
        }
        static void IfNum18()
        {
            Console.WriteLine("Введите два одинаковых и одно отличное от других число ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(".");
            if (a == c)
                Console.WriteLine("Номер числа отличного от других " + b);
            if (b == c)
                Console.WriteLine("Номер числа отличного от других " + a);
            if (a == b)
                Console.WriteLine("Номер числа отличного от других " + c);
        }
        static void IfNum21()
        {
            Console.WriteLine("Введите координаты");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(".");
            if (x == 0 && y == 0)
                Console.WriteLine("0");
            if (x == 0 && y != 0)
                Console.WriteLine("1");
            if (x != 0 && y == 0)
                Console.WriteLine("2");
            if (x != 0 && y != 0)
                Console.WriteLine("3");
        }
        static void IfNum24()
        {
            Console.WriteLine("Введите х ");
            double x = double.Parse(Console.ReadLine());
            double f;
            if (x > 0)
            {
                f = 2 * Math.Sin(x);
                Console.WriteLine("f(" + x + ") = " + f);
            }
            if (x <= 0)                                       //Тут не уверен,что правильно сделал.Либо не помню правильно формулу,либо не проходили еще
            {
                f = 6 - x;
                Console.WriteLine("f(" + x + ") = " + f);
            }
 
        }
        static void IfNum27()
        {
          // не понял
        }
        static void IfNum30()
        {
            Console.WriteLine("Введите число в диапозоне 1 - 999 ");
            int x = int.Parse(Console.ReadLine());
            int a =0;
            Console.WriteLine("Описание\n ");
            if (x % 2 == 0)
            {
                Console.WriteLine("-Четное");
            }
            else
            {
                Console.WriteLine("-Нечетное");
            }

            if (x/100 >=1)                                       
            {
                Console.WriteLine("-Трехзначное");
                a = 1;
            }
            if((x % 100)/10 >= 1 && a != 1)
            {
                Console.WriteLine("-Двухзначное");
                a = 2;
            }
            if (x % 10 >= 1 && a != 2 && a != 1 )
            {
                Console.WriteLine("-Однозначное");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
