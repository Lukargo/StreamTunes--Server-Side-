using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamTunesServerSide
{
    static class StreamTunes
    {

        readonly static string[] songPathList;
        public static string[] SongPathList { get { return songPathList; }}
        
        static StreamTunes()
        {
            songPathList = Directory.GetFiles(@"C:\StreamTunes\", "*.mp3", SearchOption.AllDirectories);
        }

    }
}
