using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbudon.Euphoric
{
    public static class Checks
    {
        public static bool Upd(this int value)
        {
            if (value != gvar.RefreshID)
            {
                value = gvar.RefreshID;
                return true;
            }
            return false;
        }
    }
}
