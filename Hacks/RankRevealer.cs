using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barbudon.Euphoric;
using Barbudon.Euphoric.Config;
using Barbudon.Euphoric.Objects;
using Barbudon.Hacks.Injection;

namespace Barbudon.Hacks
{
    class Rank
    {
        public static void Start()
        {
            if (!Settings.userSettings.MiscSettings.RankRevealer) return;
            if (WinAPI.GetAsyncKeyState(0x9) <= 0 || (WinAPI.GetAsyncKeyState(0x9) & 0x8000) <= 0) return;
            RankRevealer.Show();
        }
    }
}
