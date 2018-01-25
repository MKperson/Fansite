using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class TriviaLogic
    {
        private string q1, q2, q3, q4, q5;
        
        public TriviaLogic()
        {
            q1 = null;
            q2 = null;
            q3 = null;
            q4 = null;
            q4 = null;
        }
        public TriviaLogic(string Q1, string Q2, string Q3, string Q4, string Q5)
        {
            
            q1 = Q1;
            q2 = Q2;
            q3 = Q3;
            q4 = Q4;
            q5 = Q5;

        }
        public int Test()
        {
            int num = 0;
            if (q1 == "a")
            {
                
                num++;
            }
            if (q2 == "c")
            {
               
                num++;
            }
            if (q3 == "a")
            {
                
                num++;
            }
            if (q4 == "d")
            {
                
                num++;
            }
            if (q5 == "a")
            {
                
                num++;
            }
            
            return num;
        }

    }
}

