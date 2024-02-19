using System;

namespace C__projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] s = new int[10];
            int[] d = new int[10];
            int[] e = new int[10];
            Random ra = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ra.Next(25);
                e[i] = d[i] = s[i] = b[i] = a[i];
                
            }
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+" ");
                Console.WriteLine();

            // bubble SORT 
            int tmp;
            int a_s = 0, a_p = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a_s++;
                for(int j = 0; j < b.Length - 1; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        a_p++;
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("\nbubbl:");
            for (int i = 0; i < a.Length; i++)
             Console.Write(a[i] + " ");
             Console.WriteLine("\nСортировка=" + a_s+" "+"Перестановки="+a_p);

             //Усовершенствованый 
            Console.WriteLine("\nУсовершенствованный bubbl:");
            int tmpb; 
            int b_s=0, b_p=0;
            bool flag = true;
            while (flag)
            {

                flag = false;
                for (int j = 0; j < b.Length - 1; j++)
                {
                    b_s++;
                    if (b[j] > b[j + 1])
                       
                    {
                        b_p++;
                        tmpb = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = tmpb;
                        flag = true;
                    }
                }
            }
          
            for (int i = 0; i < b.Length; i++)
            Console.Write(b[i] + " ");
            Console.WriteLine("\nСортировка=" + b_s + " " + "Перестановки" + b_p);


            //Шейкер
            Console.WriteLine("\nШейкер:");
            int l = 1;
            int r = s.Length - 1;
            int k = 0;
            int tmps;
            int s_s = 0, s_p = 0;
            do
            {
                
                for (int i = r; i >= l; i--)
                {
                    s_s++;
                    if (s[i - 1] > s[i])
                    {
                        s_p++;
                        tmps = s[i];
                        s[i] = s[i - 1];
                        s[i - 1] = tmps;
                        k = i;
                    }

                }
                l = k + 1;
                for (int i = l; i <= r; i++)
                {
                    s_s++;
                    if (s[i - 1] > s[i])
                    {
                        s_p++;
                        tmps = s[i];
                        s[i] = s[i - 1];
                        s[i - 1] = tmps;
                        k = i;
                    }
                    
                }
                r = k - 1;
            } while (l < r);

            for (int i = 0; i < s.Length; i++)
                Console.Write(s[i] + " ");
                Console.WriteLine("\nСортировка=" + s_s + " " + "Перестановки" + s_p);

            //Выбор
            Console.WriteLine("\nВыборка:");
            int min= 90;
            int i_min = 10;
            int d_s = 0, d_p = 0;
            for (int i = 0; i < d.Length - 1; i++)
            {
                d_s++;
                min = d[i];
                i_min = i;
                for (int j = i + 1; j < d.Length; j++)
                
                    
                    if (min > s[j])
                    {
                        d_p++;
                        min = d[j];
                        i_min = j;
                    }
                    d[i_min] = d[i];
                    d[i] = min;
                
            }
            for (int i = 0; i < d.Length; i++)
                Console.Write(d[i] + " ");
            Console.WriteLine("\nСортировка=" + d_s + " " + "Перестановки" + d_p);



            //Вставка
            Console.WriteLine("\nВставка:");
            int copy;
            int e_s = 0, e_p = 0;
            for (int i = 1; i < e.Length; i++)
            {
                e_s++;
                copy = e[i];
                int j;
                for(j=i-1;j>=0 && e[j] > copy; j--)
                {
                    e_p++;
                    e[j + 1] = e[j];
                }
                e[j + 1] = copy;
            }
            for (int i = 0; i < e.Length; i++)
                Console.Write(e[i] + " ");
            Console.WriteLine("\nСортировка=" + e_s + " " + "Перестановки" + e_p);

        }
    }
}
