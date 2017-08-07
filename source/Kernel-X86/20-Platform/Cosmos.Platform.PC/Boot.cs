﻿using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.HAL;
using Cosmos.IL2CPU.API.Attribs;

namespace Cosmos.Platform.PC {
    static public class Boot {
        [BootEntry(20)]
        static private void Init() {
            var xMgr = new DeviceMgr();
            HAL.Globals.DeviceMgr = xMgr;

            var xProcessor = new Devices.Processor();

        }
    }
}
