using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocityProject.Enums
{
    public class EventOptions
    {
        enum Events { Register, Diagnose }

        public static List<String> getEvents()
        {
            return new List<String>() {Events.Register.ToString(), Events.Diagnose.ToString()};
        }
    }
}
