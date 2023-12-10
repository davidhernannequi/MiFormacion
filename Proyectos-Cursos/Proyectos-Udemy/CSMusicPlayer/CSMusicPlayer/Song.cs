﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMusicPlayer
{
    internal class Song
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public Song() { }

        public Song(string name, string path) 
        {
            Name = name;
            Path = path;
        }
    }
}
