using System;
using System.Collections.Generic;
using System.Text;

namespace CarRace
{
    abstract class Betters
    {
        public int total_amount;
        public string name1;
        public abstract int whowon(int[] betno,int no);
        public abstract void setName(string name, int total_amount);
        public abstract string getName(int betterNo);
    }
}
