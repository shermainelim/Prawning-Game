using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    abstract class Prawn
    {
        //healthpoints,id
        protected int healthPt;
        protected int id;

        public Prawn(int healthPt, int id)
        {
            this.healthPt = healthPt;
            this.id = id;
        }
        public int HealthPt { get => healthPt; set => healthPt = value; }
        public int Id { get => id; set => id = value; }
        public abstract void DisplayStats();
    }
}
