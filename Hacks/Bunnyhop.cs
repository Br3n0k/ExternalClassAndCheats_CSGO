using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barbudon.Euphoric;
using Barbudon.Euphoric.Config;
using Barbudon.Euphoric.Objects;

namespace Barbudon.Hacks
{
    class Bunnyhop
    {
        public static void Start()
        {
            gvar.SHUTDOWN++;
            while (true)
            {
                if (gvar.isShuttingDown)
                {
                    gvar.SHUTDOWN--;
                    break;
                }
                Thread.Sleep(10);
                if (gvar.isMenu) continue;
                if (!Local.InGame) continue;
                if (!Settings.userSettings.MiscSettings.BunnyHop) continue;
                if ((WinAPI.GetAsyncKeyState(32) & 0x8000) <= 0) continue;
                if (Local.Flags != 257 && Local.Flags != 263) continue;
                Local.Jump();
            }
        }
    }
}
