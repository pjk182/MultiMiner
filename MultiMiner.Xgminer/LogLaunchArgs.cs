﻿using System;

namespace MultiMiner.Xgminer
{
    public class LogLaunchArgs : EventArgs
    {
        public DateTime DateTime { get; set; }
        public string ExecutablePath { get; set; }
        public string Arguments { get; set; }
    }
}