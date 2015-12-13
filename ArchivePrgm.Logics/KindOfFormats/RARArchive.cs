using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivePrgm.Logics.KindOfFormats
{
    public class RARArchive : IArchive
    {
        public void ArchiveFile()
        {
            Console.WriteLine("This's rar archive. We did an rar-archive file");
        }

        public void UnArchiveFile()
        {
            Console.WriteLine("This's rar archive. We did an unrar-archive file");
        }        
    }
}
