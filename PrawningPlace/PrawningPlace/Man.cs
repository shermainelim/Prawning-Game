using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    class Man:Human,Action
    {
        public Man(int healthPt, string name) : base(healthPt, name)
        {

        }
        public override void DisplayStats()
        {//improvise to display catch count
            Console.WriteLine("Name: {0} and HP:{1} and CatchCount{2}", Name, HealthPt,CatchCount);
        }
        public int Fighting()
        {
            int hit = GenerateRandomNumber();
            return hit;
        }

        public void Resting()
        {
            int restpt = GenerateRandomNumber();
            HealthPt += restpt;
        }

        public int GenerateRandomNumber()
        {
            Random random = new Random();
            int num = random.Next(5, 11);
            return num;
        }
    }
}
