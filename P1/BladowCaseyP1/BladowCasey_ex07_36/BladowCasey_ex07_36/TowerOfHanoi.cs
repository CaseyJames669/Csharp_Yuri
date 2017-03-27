using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladowCasey_ex07_36
{
    public class TowerOfHanoi
    {
        static string msg = string.Empty;
        public static string Tower(int disks, int peg1, int peg3, int peg2)
        {
            if (disks ==1)
            {
                msg += string.Format("{0} --> {1}\n", peg1, peg3);
                return msg;
            }

            // move (disks-1) disks from peg1 to peg2 recursively
            Tower(disks - 1, peg1, peg2, peg3);

            //move the last disk from peg1 to peg3
            msg += string.Format("{0} --> {1}\n", peg1, peg3);

            //move (disks-1) disks from peg2 to peg3 recursively
            Tower(disks - 1, peg2, peg3, peg1);

            return msg;
        }
    }
}
