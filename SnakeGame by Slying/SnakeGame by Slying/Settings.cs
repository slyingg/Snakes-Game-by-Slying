﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Classic_Snakes_Game_by_Slying

{
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string directions;
        public Settings()
        {
            Width = 17;
            Height = 17;
            directions = "left";
        }
    }
}