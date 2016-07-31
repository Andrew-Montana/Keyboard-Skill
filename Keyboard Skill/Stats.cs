using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Skill
{
    class Stats
    {
        public int Total = 0;
        public int Good = 0;
        public int Bad = 0;
        public int Accuracy = 0;

        public void Update(bool isKeyRight)
        {   Total++;
        if (isKeyRight)
            Good++;
        else
            Bad++;

        Accuracy = 100 * Good / (Good + Bad);
        }
    }
}
