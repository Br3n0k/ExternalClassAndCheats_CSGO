using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Barbudon.Euphoric.Structs;

namespace Barbudon.Euphoric.BspParsing
{
    [StructLayout(LayoutKind.Sequential)]
    public struct mvertex_t
    {
        public Vector3 m_Position;
    }
}
