using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Collections.Generic;

namespace Chapter3.MemoryFile.MemFileLib
{
    public class VirtualFile
    {
        private string _memoryFileName;

        public VirtualFile(string memoryFileName)
        {
            _memoryFileName = memoryFileName;
        }

        public void WriteToMemory()
        {
            using (MemoryMappedFile mmf = MemoryMappedFile.CreateNew(_memoryFileName, 10000))
            {
                using (MemoryMappedViewStream mmvsm = mmf.CreateViewStream(0, 10000, MemoryMappedFileAccess.ReadWrite))
                {
                    StreamWriter sw = new StreamWriter(mmvsm);

                    for (int i=1; i<=100; i++)
                    {
                        sw.WriteLine($"Line {i} of the memory file");
                    }


                    StreamReader sr = new StreamReader(mmvsm);

                    while(!sr.EndOfStream)
                    {
                        var b = sr.ReadLine();
                    }
                }
            }
        }

        public List<string> ReadFromMemory()
        {
            var lines = new List<string>();

            using (MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen(_memoryFileName, 1000))
            {
                using (MemoryMappedViewAccessor mmvsm = mmf.CreateViewAccessor())
                {
                    byte[] bytes = new byte[50];

                    var a = mmvsm.ReadArray(0, bytes, 0, bytes.Length);
                    string text = System.Text.Encoding.UTF8.GetString(bytes).Trim('\0');


                }
            }

            return lines;
        }
    }
}
