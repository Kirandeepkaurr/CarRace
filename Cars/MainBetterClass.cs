using System;
using System.Collections.Generic;
using System.Text;

namespace CarRace
{
    class MainBetterClass : Betters
    {
        
        public override int whowon(int[] betno,int no)
        {
            int result=-1;
            if (betno[0] == no)
                result = 0;
            if (betno[1] == no)
                result = 1;
            if (betno[2] == no)
                result = 2;
            return result;
        }

        public override void setName(string name,int totalAmount)
        {
            name1 = name;
            total_amount = totalAmount; //
        }

        public override string getName(int betterNo) 
        {
            string name1 = "";
            if(betterNo == 0)
            {
                name1 = "Joe";
            }
            else if(betterNo == 1)
            {
                name1 = "Bob";
            }
            else
            {
                name1 = "AI";
            }
            return name1;
        }
        public int getTotalAmount()
        {
            return total_amount;
        }

    }
}
