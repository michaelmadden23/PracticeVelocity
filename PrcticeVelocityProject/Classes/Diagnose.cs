using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocityProject.Classes
{
    public class Diagnose : Events
    {
        public String[] StringsToPrint(int numberOfStrings)
        {
            String[] tempStrs = new String[numberOfStrings];

            for (int i = 1; i <= numberOfStrings; i++)
            {
                if (i % 2 == 0 && i % 7 == 0) tempStrs[i-1] = "Diagnose Patient";
                else if (i % 2 == 0) tempStrs[i-1] = "Diagnose";
                else if (i % 7 == 0) tempStrs[i-1] = "Patient";
                else tempStrs[i-1] = i.ToString();
            }

            return tempStrs;
        }
    }
}
