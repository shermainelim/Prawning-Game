using System;
using System.Collections.Generic;
using System.Text;

namespace PrawningPlace
{
    public interface Action
    {
        int Fighting();
        void Resting();

         int GenerateRandomNumber();
    }
}
