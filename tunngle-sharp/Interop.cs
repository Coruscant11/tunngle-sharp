using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace tunngle_sharp
{
    public class Interop
    {
        public const string DllName = "Launcher.dll";
        
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern int Init(string company, string project);


    }
}
