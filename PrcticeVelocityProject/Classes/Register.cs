using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocityProject.Classes
{
    public class Register : Events
    {
        public String[] StringsToPrint(int numberOfStrings)
        {
            String[] tempStrs = new String[numberOfStrings];

            for (int i = 1; i <= numberOfStrings; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) tempStrs[i-1] = "Register Patient";
                else if (i % 3 == 0) tempStrs[i-1] = "Register";
                else if (i % 5 == 0) tempStrs[i-1] = "Patient";
                else tempStrs[i-1] = i.ToString();
            }

            return tempStrs;
        }
    }
}
