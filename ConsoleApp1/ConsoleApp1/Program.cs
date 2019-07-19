using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static(int,int,int,char) LocalFunc(int[]x,string lStr)
        {
            int max = x[0];
            int min = x[0];
            int sum = 0;
            char ch = lStr[0];
            for(int i=0;i<x.Length;i++)
            {
                if (x[i] > max) max = x[i];
                if (x[i] < min) min = x[i];
                sum += x[i];
            }
            return (max, min, sum, ch);
        }
        static void Main(string[] args)
        {
            ////1.а
            //int first = 12;
            //float firstFloat = 12.5f;
            //double firstDouble = 12.5454;
            //char firstChar = 'c';
            //bool firstBool = true;
            //string firstString="This if first string";
            ////----------------------------------------------------------

            ////1.b
            //Int32 number = 10;
            //Int64 number1 = number;

            //short snumber = 40;
            //int num = snumber;

            //float fl = 14.2f;
            //double d = fl;

            //int uNumber = 2145;
            //long ddd = uNumber;

            //byte bbb = 13;
            //int err = bbb;
            ////-----------------------------------------------------------------------
            //float stk = 123.4f; ;
            //int stk_i = (int)stk;

            //bool flag = true;
            //string flagS = flag.ToString();

            //char w= 'w';
            //int w_i = (int)w;

            //double double1 = 2134.2134;
            //float dfe = (float)double1;

            //long longNum = -153;
            //byte byteNum=(byte)longNum;
            ////----------------------------------------------------------------
            ////1.c
            //int x = 5;
            //Object dx = x;
            //x = (int)dx;

            //short s = 10;
            //Object ds = s;
            //byte sb = (byte)(short)ds;
            ////--------------------------------------
            ////1.d
            //float defaultFloat = 123.54f;
            //Console.WriteLine($"{defaultFloat},объявленная как float");

            //var untip = 123.54f;
            //Console.WriteLine($"{untip},объявленная как var");
            ////------------------------------------------------------
            ////1.e
            //int? n = null;
            //int? newN = n ?? 3;
            //Console.WriteLine(newN);
            //int newNew = newN ?? 10000;
            //Console.WriteLine(newNew);
            ////-------------------------------------------------------------------



            ////2.a
            //string str1 = "Два", str2 = "Три";
            //if(str1==str2)
            //{
            //    Console.WriteLine("Строки одинаковы");
            //}
            //else
            //{
            //    Console.WriteLine("Строки не одинаковы");
            //}

            //int resString= str2.CompareTo(str2);
            //Console.WriteLine(resString);
            ////2.b
            //string str3 = string.Concat(str2,str1);
            //Console.WriteLine(str3);

            //string str4 = string.Copy(str3);
            //Console.WriteLine(str4);

            //string str5 = str4.Substring(3, 2);
            //Console.WriteLine(str5);

            //string str6 = "Строка которая будет разделена на слова";
            
            //string[] arr = str6.Split(' ');
            //foreach (string str7 in arr)
            //{
            //    Console.Write(str7 + " ");
            //}

            //string str8 = "Сегодня чудесный день";
            //str8 = str8.Remove(8, 8);
            //str8 = str8.Insert(8, "прекрасный");
            //Console.WriteLine("\n"+str8);
            ////---------------------------------------------
            ////2.c
            //string Empty1 = "";
            //string Empty2 = null;
            //bool Eq = Empty1 == Empty2;
            //Console.WriteLine(Eq);
            //str8 = string.Concat(Empty1, Empty2);
            //Console.WriteLine(str8);
            ////-------------------------------------------------
            ////2.d
            //StringBuilder strBuild = new StringBuilder("This is new string", 100);
            //Console.WriteLine(strBuild);

            //strBuild = strBuild.Remove(4, 7);
            //Console.WriteLine(strBuild);

            //strBuild = strBuild.Append(" is new.");
            //Console.WriteLine(strBuild);

            //strBuild = strBuild.Insert(0, "Oooooooooh, ");
            //Console.WriteLine(strBuild);
            ////------------------------------------------------
            ////3.a
            //int[,] IntArr = new int[3, 3] { {10,30,1000 },{ 123214,4,45},
            //    {213,999999,1 } };
            
            //Console.WriteLine("Поученный массив: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{IntArr[i, j]}\t");
            //    }
            //    Console.Write('\n');
            //}
            ////3.b
            //Console.WriteLine($"Введите размер массива:");
            //int size= Convert.ToInt32(Console.ReadLine());
            //string[] strArr = new string[size];
            //Console.WriteLine($"Размер массива:{strArr.Length}");
            //for(int i=0;i<strArr.Length;i++)
            //{
            //    Console.WriteLine($"Введите строку {i}:");
            //    strArr[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine($"{i}.{strArr[i]}");
            //}
            //Console.WriteLine("Введите номер элемента массива,который хотите поменять");
            //int choice=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите новую строку");
            //string newStr = Console.ReadLine();
            //strArr[choice] = newStr;
            //for(int i=0;i<strArr.Length;i++)
            //{
            //    Console.WriteLine($"{i}.{strArr[i]}");
            //}
            ////----------------------------------------------
            ////3.c
            //double[][] zub = new double[3][];
            //zub[0] = new double[2];
            //zub[1] = new double[3];
            //zub[2] = new double[4];
            //int count = 0;
            //for (int i = 0; i < zub.Length; i++)
            //{
            //    for (int j = 0; j < zub[i].Length; j++)
            //    {
            //        Console.WriteLine($"Введите число типа Double #{ count++}");
            //        zub[i][j]=Convert.ToDouble(Console.ReadLine());
            //    }
                
            //}
            //for (int i = 0; i < zub.Length; i++)
            //{
            //    Console.Write("#"+i + "\t");
            //    for (int j = 0; j < zub[i].Length; j++)
            //    {
            //        Console.Write($"{zub[i][j]}\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //----------------------------------------
            //3.d
            char[] masss = new char[] { 'm', 'a', 's', 's', 'i', 'v', };
            var strVar = new string(masss);
            var mass = new string[3] { "Это", "массив", "строк" };
            //-------------------------------------------
            //4.a

            (int q, string w, char e, string r , ulong t) tuple = (123, "first str",
                'c', "second str", 1241);
            Console.WriteLine(tuple);

            Console.WriteLine(tuple.q);
            Console.WriteLine(tuple.e);
            Console.WriteLine(tuple.r);
            Console.Write("-----------------------------");
            var (l1,l2,l3,l4,l5)= tuple;
            var tuple2 = Tuple.Create<int, char>(7, '0');
            var tuple3 = Tuple.Create<char, int>('7', 0);

            if ((tuple2.Item1 == tuple3.Item1) && (tuple2.Item1 == tuple3.Item1))
                {
                     Console.WriteLine("Кортежи равны");
                }
            else
                {
                     Console.WriteLine("Кортежи ne равны");
                }
            //-------------------------------------------------------
            const int SIZE = 10;
            int[] A = new int[SIZE] { 5, 8, -1000, 4, 70, 10, 7, 12, 3, 40 };
            string local = "i61";
            (int, int, int, char) locTuple = LocalFunc(A,local);
            Console.WriteLine($"Максимальный элемент:{locTuple.Item1}");
            Console.WriteLine($"Минимальный элемент:{locTuple.Item2}");
            Console.WriteLine($"Сумма элементов массива:{locTuple.Item3}");
            Console.WriteLine($"Первый символ строки:{locTuple.Item4}");
 }
    }
}
