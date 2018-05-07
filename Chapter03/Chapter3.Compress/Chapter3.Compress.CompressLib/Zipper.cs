using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;

namespace Chapter3.Compress.CompressLib
{
    public class Zipper
    {
        private string _destinationPath;

        public Zipper(string destinationPath)
        {
            _destinationPath = destinationPath;
        }
        public void CompressFile(string zipPath)
        {
            //File.SetAttributes(_destinationPath, FileAttributes.Normal);
            ZipFile.CreateFromDirectory(zipPath, _destinationPath);
        }

        public List<string> ListArchive(string zipFile)
        {
            var fileList = new List<string>();

            using (ZipArchive archive = ZipFile.OpenRead(zipFile))
            {
                foreach(var entry in archive.Entries)
                {
                    fileList.Add(entry.Name);
                }
            }

            return fileList;
        }
    }
}
