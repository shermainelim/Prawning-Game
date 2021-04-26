using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    abstract class Human
    {
        private int healthPt;
        private string name;
        private int catchCount;

        public int HealthPt { get => healthPt; set => healthPt = value; }
        public string Name { get => name; set => name = value; }
        public int CatchCount { get => catchCount; set => catchCount = value; }

        public Human(int healthPt, string name)
        {
            this.healthPt = healthPt;
            this.name = name;
            this.catchCount = 0;
        }
        public abstract void DisplayStats();
            

      
    }
}
