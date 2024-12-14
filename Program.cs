using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            5.Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

               *
              * * 
             * * *
            * * * *

            */
            
            int num = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;

            if (num % 2 == 1)
            {
                while (i < num)
                {
                    while (j < num)
                    {
                        if (i == num - 1 || j == num / 2 || j >num - i && j != num - 1 && j != 0)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                        j++;
                    }

                    j = 0;
                    i++;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter even number");
            }
            
            // ??????????????????????????????????????????????????????????????????


            /* 1. Write a program in C# Sharp to display a right angle triangle with an asterisk.
            The pattern like:

            *
            **
            ***
            ****

            */
            /*
            int num = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;

            while (i < num)
            {
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                j = 0;
                i++;
                Console.WriteLine();
            }
            */

            /* 2. Write a program in C# Sharp to display a pattern like a right-angle triangle with a number.
            The pattern like :

            1
            12
            123
            1234
            */
            /*
            int num = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;

            while (i < num)
            {
                while (j <= i)
                {
                    if(j > 0)
                    {
                        Console.Write(j);
                    }

                    j++;
                }
                j = 0;
                i++;
                Console.WriteLine();
            }
            */
            /*
            3.Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
                 pattern like :

            1
            22
            333
            4444
            */
            /*
            int num = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;
            int digit = 0;

            while (i < num)
            {
                while (j <= i)
                {
                    digit = i;
                    if (j > 0)
                    {
                        Console.Write(digit);
                    }

                    j++;
                }
                j = 0;
                i++;
                Console.WriteLine();
            }
            */

            /* 
             4. Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
            The pattern like :

            1
            2 3
            4 5 6
            7 8 9 10 
             */
            /*
            int num = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;
            int digit = 0;

            while (i < num)
            {
                while (j <= i)
                {
                    digit++;
                    Console.Write(digit + " ");
                    j++;
                }
                j = 0;
                i++;
                Console.WriteLine();
            }
            */

            /*
             6.&& 15 Write a C# Sharp program to determine whether a given number is prime or not.
                 Test Data :
                Input a number: 13
                Expected Output :
                13 is a prime number.
             */
            /*
            int num = int.Parse(Console.ReadLine());
            int i = 2;

            while (true)
            {
                if (i > Math.Sqrt(num))
                {
                    Console.WriteLine("Number is prime");
                    break;
                }
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    break;
                }
                i++;
            }
            */

            /*
            8. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
            Test Data :
            Input number of terms : 5
            Expected Output :
            The even numbers are :2 4 6 8 10
            The Sum of even Natural Number upto 5 terms : 30*/
            /*
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;
            int digit = 9;

            while(i< num)
            {
                sum = sum + digit;
                digit = digit * 10 + 9;
                i++;
                Console.Write(" "+digit);
            }
            */

            /*
           7. Write a program in C# Sharp to display the n terms of even natural number and their sum.
            Test Data :
            Input number of terms : 5
            Expected Output :
            The even numbers are :2 4 6 8 10
            The Sum of even Natural Number upto 5 terms : 30
            */
            /*
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;


            while (i <= num)
            {
               int evenNumber = 2 * i;
                Console.Write(" " + evenNumber);
                sum = sum + evenNumber;
                i++;
                
            }
            Console.WriteLine($"Sum : {sum}");
            */

            /*
             10․ Գրել ծրագիր, որը կոնսոլից կստանա n, m բնական թվերը և n անգամ կտպի 1-m թվերը։
             */
            /*
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int result = 0;

            int i = 1;

            while (n >= i) 
            {
                while (i <= m)
                {
                    result = i;
                    result.ToString();
                    Console.Write(result);
                    i++;
                };
                i = 1;
                Console.WriteLine();
                n--;
            };
            */

            /*
             11, 12․  Գրել ծրագիր, որը console ից կստանա n բնական թիվ և կտպի այդ թվի թվանշանները (հակառակ դասավարվածությամբ)։
                Օրինակ՝
                Մուտք 123
                Ելք 
                3
                2
                1
             */
            /*
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            int i = 1;
            while (n>=1) 
            {
                result = n % 10;
                n = n/10;
                result.ToString();
                Console.Write(result);
            };
            */

            /*
             13․ Write a program to calculate the factorial of a number using a while loop.
             */
            /*
            int number = int.Parse(Console.ReadLine());

            int i = number;
            int result = 0;

            while (i >= 1) 
            {
                result = number * (number - i);
                i--;
            };
            Console.WriteLine(result);
            */

            /*
             14. Create a program that prints the even numbers from 1 to 20 using a while loop
             */
            /*
            int i = 1;

            while(i <= 20)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */

           
            /*
             16. Create a program to find the sum of digits of a number using a for loop.
             */
            /*
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int sum = 0;

            int i = 1;
            while (n >= 1)
            {
                result = n % 10;
                n = n / 10;
                sum += result;
            };
            Console.Write(sum);
            */

            /*
             17. Write a program to calculate the average of numbers entered by the user using a do-while loop.
             */
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;  
            int i = 0;
            

            if(a< b)
            {
                while (a <= b)
                {
                    sum = sum + a;
                    a++;
                    i++;
                    Console.Write(" " + sum);
                    Console.WriteLine();
                }
                Console.WriteLine("Result: " + sum/i);
            }
            else
            {
                Console.WriteLine("You enter wrong numbers");
            };
            */

            /*
             18. Գրել ծրագիր, որը console ից անընդմեջ կստանա թիվ և կհաշվի այդ թվերի քանակը քանի դեռ մուտք արած թիվը 0 չէ,
                0 ի դեպքում թող ավարտվի ծրագիրը։

               
                Մուտք 78, 61, 45, 1, 5874, 6479, 15, 0
                Ելք 7(0-ն չենք հաշվում)
             */
            /*
            int num;
            int i = 0;

            while(true) {
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("You can not enter a zero");
                    break;
                }
            };
            Console.WriteLine("Entered numbers count: " +i);
            */

        }
    }
}
