using System;

namespace Blinmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minEgg = 1;
            int minmilk = 50; /* milliliters*/
            int minFlour = 50;

            System.Console.WriteLine("insert number of eggs");
            int Egg = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("insert quantity of milk (in milliliters)");
            int Milk = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("insert quantity of Flour (in grams)");
            int Flour = int.Parse(System.Console.ReadLine());

            if (Egg < minEgg || Milk < minmilk || Flour < minFlour)
            {
                System.Console.WriteLine("Sorry, no blin today!");
            }
            else
            {
                Egg = Egg / minEgg;
                Milk = Milk / minmilk;
                Flour = Flour / minFlour;


                System.Console.WriteLine("You have " + Egg + " portions of eggs");
                System.Console.WriteLine("You have " + Milk + " portions of milk");
                System.Console.WriteLine("You have " + Flour + " portions of flour");

                if (Egg < Milk)
                {
                    if (Egg < Flour)
                    {
                        System.Console.WriteLine("You can cook " + Egg + " blins");
                    }
                    else
                    {
                        System.Console.WriteLine("You can cook " + Flour + " blins");
                    }
                }
                else
                {
                    if (Milk < Egg)
                    {
                        if (Milk < Flour)
                        {
                            System.Console.WriteLine("You can cook " + Milk + " blins");
                        }
                        else
                        {
                            System.Console.WriteLine("You can cook " + Flour + " blins");
                        }
                    }
                    else
                    {
                        if (Flour < Egg)
                        {
                            if (Flour < Milk)
                            {
                                System.Console.WriteLine("You can cook " + Flour + " blins");
                            }
                            else
                            {
                                System.Console.WriteLine("You can cook " + Milk + " blins");
                            }
                        }
                    }
                }
            }
        }
    }
}
