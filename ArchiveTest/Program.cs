using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchivePrgm.Logics.KindOfFormats;


namespace ArchiveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArchiveStrategy arch = new ArchiveStrategy("pr", "1", "2", new RARArchive());
            arch.ArchiveFile();
            Console.ReadKey();

            arch._iarchive = new ZIPArchive();
            arch.ArchiveFile();

            Console.WriteLine("The END !!!");
            Console.ReadKey();
        }
    }
}
