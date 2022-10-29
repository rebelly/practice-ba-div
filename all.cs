using System;
public class Program
{
    static bool isdivided(int a, int q)
    {
        return a % q != 0;
    }
    static void mutually_simple(int a, int q)
    {
        for (int i = 2; i <= a/2+1; i++)
            
        {
            if (a % i == 0 && isdivided(q, i) )
            {
                Console.Write($"{i}\t");
            } 
        }
        Console.WriteLine();
    }
    static int sum_divis(int a)
    {
        int sum = 0;
        for (int i = 1; i <= (int)Math.Sqrt(a); i++)

        {
            if (a % i == 0)
            {
                sum += i;
                if (a / i != i)
                {
                    sum += a / i;
                }
            }
        }
        return sum;
    }
    static int sum_div(int x)
    {
        int sum = 0;
        
        return sum;
    }
    static int alternating_sign(int a)
    {
        int sum = 0;
        int cur_num = a % 10;
        char cur_sign = '+';
        while (a > 0)
        {
            if (cur_sign == '+')
            {
                sum += cur_num;
                cur_sign = '-';
            }
            else if (cur_sign == '-') {
                sum -= cur_num;
                cur_sign = '+';
            }
            a /= 10;
            cur_num = a % 10;
        }
        return sum;
    }
    public static void Main()
    {



        /* 1:
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine($"Все делители числа {p} которые не являются делителями числа {q} : ");
        mutually_simple(p, q);
        */

        /* 2:
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма делителей числа {x}: {sum_divis(x)}");
         */
         /* 3:
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Знакочередующаяся сумма числа: {a} равна {alternating_sign(a)}");
        */
    }
}
