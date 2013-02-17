using System;

class Program
{
    static void Main()
    {
        int n0 = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        int n6 = int.Parse(Console.ReadLine());
        int n7 = int.Parse(Console.ReadLine());
        int temp = 0;
        int sum = 0;
        int counterPigs = 0;
        int counterPath = 0;
        int[,] a = new int[8,16];
        for (int i = 0; i < 8; i++)
        {
            switch (i)
            {
                case 0: temp = n0; break;
                case 1: temp = n1; break;
                case 2: temp = n2; break;
                case 3: temp = n3; break;
                case 4: temp = n4; break;
                case 5: temp = n5; break;
                case 6: temp = n6; break;
                case 7: temp = n7; break;
            }
            for (int j = 0; j<16; j++)
            {
                if ((temp >> j & 1) == 1)
                {
                    a[i, 15-j] = 1;
                    if (j <8)
                    {
                        sum++;
                    }
                }
                else
                {
                    a[i, 15-j] = 0;
                }
            }
        }
 
        int points = 0;
        for (int j = 7; j >= 0; j--)
        {
            counterPigs = 0; counterPath = 0;
            for (int i = 0; i < 8; i++)
            {
                if (a[i, j] == 1)
                {
                    a[i, j] = 0;
                    int p = i; int v = j;
                    while (p > 0 && v < 16)
                    {

                        if (v >= 8 && a[p, v] == 1)
                        {
                            counterPigs++;
                            a[p, v] = 0;
                            if (p > 0 && a[p - 1, v] == 1)
                            {
                                a[p - 1, v] = 0;
                                counterPigs++;
                            }
                            if (p <= 6&& a[p + 1, v] == 1 )
                            {
                                a[p + 1, v] = 0;
                                counterPigs++;
                            }
                            if ( v <= 14 && a[p, v + 1] == 1)
                            {
                                a[p, v + 1] = 0;
                                counterPigs++;
                            }
                            if (v>0&&a[p, v - 1] == 1)
                            {
                                a[p, v - 1] = 0;
                                counterPigs++;
                            }
                            if (p <= 6&& v <= 14&&a[p + 1, v + 1] == 1  )
                            {
                                a[p + 1, v + 1] = 0;
                                counterPigs++;
                            }
                            if (v > 0 && p>0&&a[p - 1, v - 1] == 1)
                            {
                                a[p - 1, v - 1] = 0;
                                counterPigs++;
                            }
                            if (v>0&&p <= 6&&a[p + 1, v - 1] == 1 )
                            {
                                a[p + 1, v - 1] = 0;
                                counterPigs++;
                            }
                            if (v <= 14&& p>0&& a[p - 1, v + 1] == 1) { a[p - 1, v + 1] = 0; counterPigs++; };
                            points += (counterPath) * counterPigs;
                            counterPath = 0; sum -= counterPigs;  counterPigs = 0; break;
                        }
                        v++;
                        p--;
                        counterPath++;
                    }
                    
                    while (p < 8 && v < 16)
                    {
                        if (v >= 8 && a[p, v] == 1)
                        {
                            a[p, v] = 0;
                            counterPigs++;
                            if (p>0&&a[p - 1, v] == 1)
                            {
                                
                                a[p - 1, v] = 0;
                                counterPigs++;
                            }
                            if (p <= 6&& a[p + 1, v] == 1 )
                            {
                                a[p + 1, v] = 0;
                                counterPigs++;
                            }
                            if ( v <= 14 && a[p, v + 1] == 1)
                            {
                                a[p, v + 1] = 0;
                                counterPigs++;
                            }
                            if (v > 0 && a[p, v - 1] == 1)
                            {
                                a[p, v - 1] = 0;
                                counterPigs++;
                            }
                            if (p <= 6&& v <= 14&&a[p + 1, v + 1] == 1  )
                            {
                                a[p + 1, v + 1] = 0;
                                counterPigs++;
                            }
                            if (v > 0 && p > 0 && a[p - 1, v - 1] == 1)
                            {
                                a[p - 1, v - 1] = 0;
                                counterPigs++;
                            }
                            if (v>0&&p <= 6&&a[p + 1, v - 1] == 1 )
                            {
                                a[p + 1, v - 1] = 0;
                                counterPigs++;
                            }
                            if (v <= 14 && p > 0 && a[p - 1, v + 1] == 1) { a[p - 1, v + 1] = 0; counterPigs++; }
                            points += (counterPath) * counterPigs;  sum -= counterPigs; counterPath = 0; counterPigs = 0; break;
                        }
                        v++;
                        p++;
                        counterPath++;
                    }
                    counterPath = 0;
                    counterPigs = 0;
                    
                } 
            }
            
           
        }
        if (sum == 0)
        {
            if (points == 0)
            {
                Console.WriteLine("0 No");
            }
            else
            {
                Console.WriteLine(points + " " + "Yes");
            }
        }
        else
        {
            Console.WriteLine(points + " " + "No");
            
        }

    }  
    }
