﻿using System.Collections.Generic;
using System.Diagnostics;

namespace HumanAim
{
    internal static class HumanAim
    {
        public static string GameName { get { return "Counter-Strike Global Offensive"; } }
        public static string ProcessName { get { return "csgo"; } }
        public static bool IsAttached { get; set; }
        public static Process Process { get; set; }
        public static ProcessModule ClientDll { get; set; }
        public static ProcessModule EngineDll { get; set; }
        public static MemorySystem.MemoryScanner Memory { get; set; }
        public static MemorySystem.SignatureScanner SigScanner { get; set; }
        public static Dictionary<string, int> NetVars { get; set; }
    }
}