using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreamTunesServerSide
{
    public struct ID3Reader
    {
        public static List<Song> ReadTags(string[] filepaths){
            //Song mp3File = new Song();

            //parse file name

            List<Song> songs = new List<Song>();
            string webpath;

            foreach (string filepath in filepaths)
            {
                
                string fileName = filepath.Substring(filepath.LastIndexOf(@"\") + 1);

                //parse file path
                string filePath = filepath.Substring(0, filepath.LastIndexOf(@"\") + 1);

                //filepath.

                //create shell instance
                Shell32.Shell shell = new Shell32.Shell();
                //set the namespace to file path
                Shell32.Folder folder = shell.NameSpace(filePath);
                //get ahandle to the file
                Shell32.FolderItem folderItem = folder.ParseName(fileName);
                //did we get a handle ?
                if (folderItem != null)
                {
                    webpath = filepath.Substring(filepath.LastIndexOf("StreamTunes") + 11);
                    //folder.
                    songs.Add(new Song(webpath, artist: folder.GetDetailsOf(folderItem,13), album: folder.GetDetailsOf(folderItem, 14),
                        name: folder.GetDetailsOf(folderItem, 21)));

                }
                //clean ip
                folderItem = null;
                folder = null;
                shell = null;
                //return mp3File instance

            }
            

          
            return songs;
        }
    }
}
