using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019VisualProgramingProject
{
    class Calculator
    {
        public int CalOut(int money)
        {
            int outsum = 0;
            if(money < 10000)
            {
                for (int day = 0; day < 7; day++)
                {
                    outsum += day * money * 5;
                }
            }
            else if(money < 50000)
            {
                for (int day = 0; day < 7; day++)
                {
                    outsum += day * money * 2;
                }
            }
            else if(money < 100000)
            {
                for (int day = 0; day < 7; day++)
                {
                    outsum += day * money;
                }
            }
            else
            {
                for (int day = 0; day < 7; day++)
                {
                    outsum += day * money / 2;
                }
            }
            return outsum;
        }
    }
}
