using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivePrgm.Logics.KindOfFormats
{
    public class ZIPArchive : IArchive
    {
        public void ArchiveFile()
        {
            Console.WriteLine("This's zip archive. We did an zip-archive file");
        }

        public void UnArchiveFile()
        {
            Console.WriteLine("This's zip archive. We did an unzip-archive file");
        }
    }
}
