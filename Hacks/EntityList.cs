using Barbudon.Euphoric;
using Barbudon.Euphoric.Objects;
using Barbudon.Hacks.Injection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Barbudon.Euphoric.Structs;

namespace Barbudon.Hacks
{
    public static class EntityList
    {
        public static Entity player;
        public static Entity[] List;
        public static ItemObjects[] ItemList;
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
                Thread.Sleep(1000);

                if (!Local.InGame) continue;
            
                string MapPath = string.Format(@"{0}\csgo\maps\{1}.bsp", 
                    Memory.process.Modules[0].FileName.Substring(0, Memory.process.Modules[0].FileName.Length - 9), Local.MapName);

                if (Local.InGame)
                {
                    if (Local.bspMap == null)
                    {
                        LoadMap(MapPath);
                    }
                    else if (Local.bspMap.FileName != MapPath)
                    {
                        LoadMap(MapPath);
                    }
                }
                
            }
        }

        public static void LoadMap(string MapPath)
        {
            if (File.Exists(MapPath) && Local.ActiveWeapon.WeaponID != -1)
            {
                Local.bspMap = new Euphoric.BspParsing.BSPFile(MapPath);
                ClientCMD.Exec(String.Format("clear; echo Map File {0} Loaded!", Local.MapName));
            }
        }

    }
}
