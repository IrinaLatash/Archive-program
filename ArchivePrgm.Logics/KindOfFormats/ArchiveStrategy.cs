using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivePrgm.Logics.KindOfFormats
{
    public class ArchiveStrategy
    {
        public IArchive _iarchive { get; set; }

        protected string _FileOutName, _BaseDir, _FileInName;
        public ArchiveStrategy(string FileOutName, string BaseDir, string FileInName, IArchive iarchive)
        {
            this._FileOutName = FileOutName; this._BaseDir = BaseDir; this._FileInName = FileInName; this._iarchive = iarchive;
        }

        public void ArchiveFile()
        {
            _iarchive.ArchiveFile();
        }
    }
}
