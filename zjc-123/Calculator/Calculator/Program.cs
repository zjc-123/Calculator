using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AchaoCalculator
{
    public class Program
    {
        private static string[] s = { "+", "-", "*", "/" };
        static void Main(string[] args)
        {
            Console.WriteLine("输入题目数量：");
            int n = Convert.ToInt32(Console.ReadLine());

            Calculator(n);

            Console.ReadLine();

        }
        public static double MainCal(string xx)//在网上看到的解决最后计算结果时小数的问题
        {
            DataTable d = new DataTable();

            return double.Parse(d.Compute(xx, null).ToString());
        }
       /* public static void Calculator(int n)
        {
            Random r = new Random();
            for (int j = 0; j < n; j++)
            {
                int c = r.Next(2, 4);
                int[] num = new int[10];
               string[] x = new string[2*c+1];
                for (int i = 0; i <= 2 * c; i++)
                {
                    if (i % 2 == 0)
                        num[i] = r.Next(1, 101);
                    else 
                        num[i]=s[r.Next(0,4)];
                }
                for (int i = 0; i <= 2 * c; i++)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Administrator\Desktop\test.txt", true))
                {
                    if (i % 2 == 0)
                    {
                        x[i] = num[i].ToString();
                        Console.Write(num[i]);
                        file.Write(num[i]);

                    }
                    else if (num[i] == 0)
                    {
                        x[i] = "+";
                        Console.Write("+");
                        file.Write("+");
                    }

                    else if (num[i] == 1)
                    {
                        x[i] = "-";
                     Console.Write("-");
                        file.Write("-");
                    }

                    else if (num[i] == 2)
                    {
                        x[i] = "*";
                       Console.Write("*");
                        file.Write("*");
                    }

                    else
                    {
                        x[i] = "/";
                       Console.Write("/");
                        file.Write("/");
                    }
                    if(i==2*c)
                        file.WriteLine("=");
                    
                }
                   
                   
                }
               Console.WriteLine("=");
            }
            
        }*/
        public static void Calculator(int n)
        {
            Random r = new Random();
            for (int  i= 0;  i< n; i++)
            {
                int c = r.Next(2, 4);
                int[] num = new int[10];

                for (int j = 0; j< c + 1; j++)
                {
                    num[j] = r.Next(1, 101);
                }
                string[] x = new string[c * 2 + 1];
                for (int k = 0; k < c * 2 + 1; k++)
                {
                    if (k % 2 == 0)
                    {
                        x[k] = num[k / 2].ToString();
                    }
                    else
                    {
                        x[k] = s[r.Next(0, 4)];
                    }
                }
                string xx = x[0];
                for (int z = 0; z < c * 2 + 1; z++)
                {
                    if (z != 0)
                    {
                        xx += x[z];
                    }
                }
                if (MainCal(xx) < 0 || MainCal(xx) % 1 != 0)
                {
                    i--;
                    continue;
                }
               xx += "=" + MainCal(xx).ToString();
                Console.WriteLine(xx);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Administrator\Desktop\test.txt", true))
                {
                    file.WriteLine(xx);

                } 
            }
        }
       
    }
}