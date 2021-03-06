using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    class TigerPrawns:Prawn,Action
    {
        public TigerPrawns(int healthPt, int id) : base(healthPt, id)
        {

        }
             public override void DisplayStats()
        {
            Console.WriteLine("ID: {0} and HP:{1}", id, healthPt);
        }

        public int Fighting()
        {
            int hit = GenerateRandomNumber();
            return hit;
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
