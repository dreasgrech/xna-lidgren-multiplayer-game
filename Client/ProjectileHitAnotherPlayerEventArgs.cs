﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class ProjectileHitPlayerEventArgs:EventArgs
    {
        public RemotePlayer OtherPlayer { get; set; }
        public ProjectileHitPlayerEventArgs(RemotePlayer otherPlayer)
        {
            OtherPlayer = otherPlayer;
        }
    }
}
