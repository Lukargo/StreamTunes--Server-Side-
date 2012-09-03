using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreamTunesServerSide
{
    public class Song
    {
        readonly string fileName;
        public string FileName { get { return fileName; } }

        readonly string artist;
        public string Artist { get { return artist; } }

        readonly string album;
        public string Album { get { return album; } }

        readonly string name;
        public string Name { get { return name; } }

        public Song(string fileName, string artist, string album, string name)
        {
            this.fileName = fileName;
            this.artist = artist;
            this.album = album;
            this.name = name;
        }
    }
}
