using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    class Child:Human,Action
    {
        public Child(int healthPt, string name) : base(healthPt, name)
        {
            
        }
        public override void DisplayStats()
        {
            Console.WriteLine("Name: {0} and HP:{1} and CatchCount{2}", Name, HealthPt, CatchCount);
        }
        public int Fighting()
        {
            int hit = GenerateRandomNumber();
            Resting();
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
            int num = random.Next(1, 7);
            return num;
        }
    }
}
