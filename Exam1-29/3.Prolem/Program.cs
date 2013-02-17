using System;

class Program
{
    static void Main()
    {
        int[] array = new int[5];
        int temp;
        int temp2=0;
        int counter = 0;
        int pair = 0;
        int three = 0;
        int four = 0;
        bool straight = false;
        for (int i = 0; i < 5; i++)
        {
            string temp1 = (Console.ReadLine());
            switch (temp1)
            {
                case "A":temp2=14;break;
                    case "2":temp2=2;break;
                    case "3":temp2=3;break;
                    case "4":temp2=4;break;
                    case "5":temp2=5;break;
                    case "6":temp2=6;break;
                    case "7":temp2=7;break;
                    case "8":temp2=8;break;
                    case "9":temp2=9;break;
                    case "10":temp2=10;break;
                    case "J":temp2=11;break;
                    case "Q":temp2=12;break;
                    case "K":temp2=13;break;
                 
            }
            array[i] = temp2;
        }
        if (array[0] == array[1] && array[1] == array[2] && array[2] == array[3] && array[3] == array[4])
        {
            Console.WriteLine("Impossible");
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            for (int i = 0; i <= 4; i++)
            {
                if (i == 4)
                {
                    if (counter == 1)
                    {
                        pair++;
                    }
                    else if (counter == 2)
                    {
                        three++;
                    }
                    else if (counter == 3)
                    {
                        four++;
                    }
                    counter = 0;
                }
                else
                {
                    if (array[i] == array[i + 1])
                    {
                        counter++;
                    }

                    else
                    {
                        if (counter == 1)
                        {
                            pair++;
                        }
                        else if (counter == 2)
                        {
                            three++;
                        }
                        else if (counter == 3)
                        {
                            four++;
                        }
                        counter = 0;
                    }
                }
            }
            if ((array[0] == (array[1] - 1) && array[1] == (array[2] - 1) && array[2] == (array[3] - 1) && array[3] == (array[4] - 1)) ||
                (array[0] == 2 && array[1] == 3 && array[2] == 4 && array[3] == 5 && array[4] == 14))
            {
                straight = true;
            }
            if (straight == true)
            {
                Console.WriteLine("Straight");
            }
            else
            {
                if (four == 1)
                {
                    Console.WriteLine("Four of a Kind");
                }
                else if (three == 1 && pair == 1)
                {
                    Console.WriteLine("Full House");
                }
                else if (three == 1)
                {
                    Console.WriteLine("Three of a Kind");
                }
                else if (pair == 1)
                {
                    Console.WriteLine("One Pair");
                }
                else if (pair == 2)
                {
                    Console.WriteLine("Two Pairs");
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
        }
    }
}