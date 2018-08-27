using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_Variables_and_Comparators
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                String hw = "Hello";
                String name = "Kabin";

                uint noNegative = 65U;//this can only store Positive values, Need to add U/u
                sbyte sb = 125;//Signed 8 bit integer -128 to 127

                Console.WriteLine(hw + " " + name);
                Console.WriteLine("The unsigned uint Assigned = " + noNegative);
                Console.WriteLine("the Signed sbyte Number = " + sb);



                int weight = 400;
                Console.WriteLine(weight >= 500); // Return False


                int a = 5;
                int b = 7;
                bool condition = (b > a) && (a + b < a * b);// Returns True
                Console.WriteLine(condition);

                String str1 = "beer";
                String str2 = str1;
                String str3 = "bee";
                str3 = str3 + 'r';

                Console.WriteLine("Str1 =" + str1);
                Console.WriteLine("Str2 ={0}", str2);
                Console.WriteLine("Str3= {0}", str3);
                Console.WriteLine(str2 == str1);//true
                Console.WriteLine(str1 == str3);//true

                Console.WriteLine((object)str1 == (object)str2); //True
                Console.WriteLine((object)str1 == (object)(str3));//false

                //Exclusive Or (Either or But not Both) VS regular Or
                Console.WriteLine((2 < 3) ^ (4 > 3));//Returns false

                Console.WriteLine((2 < 3) || (4 > 3));//returns true




                Console.ReadLine();
            }
        }

    }