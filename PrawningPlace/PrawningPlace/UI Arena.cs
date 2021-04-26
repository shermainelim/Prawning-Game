using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    public static class UI_Arena //why  need use static class here? cos the main is always the static/global so this class has to always be static
    {
         static void Main(string[] args)
        {
            List<Human> Hero = new List<Human>();
            Hero.Add(new Man(10000, "Hary"));
            Hero.Add(new Woman(8000, "Sary"));
            Hero.Add(new Child(5000, "Bary"));
            Hero.Add(new Child(5000, "Bara"));

            List<Prawn> PrawnList = new List<Prawn>();

            for (int i = 0; i < 2; i++)
            {
                TigerPrawns tig = new TigerPrawns(GenerateRandomNumber(3, 5), i);
                PrawnList.Add(tig);
            }
            for (int i = 0; i < 2; i++)
            {
                Longkan longprawn = new Longkan(GenerateRandomNumber(3, 7), i);
                PrawnList.Add(longprawn);
            }
            for (int i = 0; i < 2; i++)
            {
                KingPrawns king = new KingPrawns(GenerateRandomNumber(3, 9), i);
                PrawnList.Add(king);
            }

            Shuffle(PrawnList);
            //create current hero index
            int heroIndex = 0;
            //create current prawn index
            int prawnIndex = 0;
            //take one prawn
            Prawn currentPrawn = PrawnList[prawnIndex];
            //infinite loop 
            while (true)
            {
                //take one hero based on current hero index
                Human currentHero = Hero[heroIndex];

                //get hero fighting
                int HeroHitPt = 0;
                if (currentHero is Man) //is a is polymorphism concept, call dynamic binding, trying to find out the underlying class of the derived(child) class(this not parent class)
                    HeroHitPt = ((Man)currentHero).Fighting();
                else if (currentHero is Woman)
                    HeroHitPt = ((Woman)currentHero).Fighting();
                else if (currentHero is Child)
                    HeroHitPt = ((Child)currentHero).Fighting();//how to add 2 child here?

                //get prawn fighting
                int PrawnHitPt = 0;
                if (currentPrawn is TigerPrawns)
                    PrawnHitPt = ((TigerPrawns)currentPrawn).Fighting();
                else if (currentPrawn is Longkan)
                    PrawnHitPt = ((Longkan)currentPrawn).Fighting();
                else if (currentPrawn is KingPrawns)
                    PrawnHitPt = ((KingPrawns)currentPrawn).Fighting();
                
                //compare hit point
                if (HeroHitPt > PrawnHitPt)
                {
                    //if hero higher
                    //hit prawn
                    Console.WriteLine("Hero hits Prawn");
                    currentPrawn.HealthPt-=HeroHitPt;
                    currentHero.DisplayStats();
                    currentPrawn.DisplayStats();

                    //if prawn die
                    if (currentPrawn.HealthPt <= 0)
                    {
                        //hero catch count ++
                        currentHero.CatchCount++;

                        //remove prawn from list
                        PrawnList.Remove(currentPrawn);
                        Console.WriteLine("One Prawn has been eliminated");

                        //check if prawn list is empty
                        if (PrawnList.Count == 0)
                        {//break
                            Console.WriteLine("All prawns eliminated");
                            break;
                        }
                        else
                        {
                            //else
                            //get next prawn
                            currentPrawn = PrawnList[prawnIndex];
                        }
                    }

                    //current hero index++
                    heroIndex++;
                    //if(current hero index == Hero.Count -1)
                    if (heroIndex == Hero.Count - 1)
                    {
                        //reset current hero index
                        heroIndex = 0;
                    }
                }
                else if(PrawnHitPt>HeroHitPt )
                {
                    //if prawn higher
                    //hit hero
                    Console.WriteLine("Prawn hits human");
                    currentHero.HealthPt -= PrawnHitPt;
                    currentHero.DisplayStats();
                    currentPrawn.DisplayStats();

                    //current hero index++
                    heroIndex++;
                    //if(current hero index == Hero.Count -1)
                    if (heroIndex == Hero.Count - 1)
                    {
                        //reset current hero index
                        heroIndex = 0;
                    }
                }
            }
            //display stats per hero and prawn caught
            foreach(var hero in Hero)
            {
               hero.DisplayStats();
            }
        }
        static int GenerateRandomNumber(int start, int end)
        {
                Random random = new Random();
                int num = random.Next(start, end);
                return num;
        }

        private static Random rng = new Random();
        static void Shuffle<T>(this IList<T> list)
        {
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    T value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
        }
    }
    
    
}
