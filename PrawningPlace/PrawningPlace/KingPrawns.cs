using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    class KingPrawns:Prawn,Action
    {
        public KingPrawns(int healthPt,int id) : base(healthPt, id)
        {

        }
        public override void DisplayStats()
        {
            Console.WriteLine("ID: {0} and HP:{1}", id, healthPt);
        }

        public int Fighting()
        {
            int hit = GenerateRandomNumber();
            int hit1 = GenerateRandomNumber();
            return hit + hit1;
        }

        public void Resting()
        {
            int restpt = GenerateRandomNumber();
            healthPt += restpt;
        }

        public int GenerateRandomNumber()
        {
            Random random = new Random();
            int num = random.Next(1, 11);
            return num;
        }
    }
}
