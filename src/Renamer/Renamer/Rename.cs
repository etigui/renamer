using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer {
    class Rename {

        private ListViewItem items = null;
        private readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public ListViewItem Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }





        private Tuple<string, string> GetFileNameAndExt(string filePath) {
            return Tuple.Create(Path.GetFileNameWithoutExtension(filePath), Path.GetExtension(filePath));
        }

              
        private string GetFileSize(string filePath, int decimalPlaces = 0) {
            FileInfo file = new FileInfo(filePath);
            if (file.Length < 0) {
                throw new ArgumentException("Bytes should not be negative", "value");
            }
            var mag = (int)Math.Max(0, Math.Log(file.Length, 1024));
            var adjustedSize = Math.Round(file.Length / Math.Pow(1024, mag), decimalPlaces);
            return String.Format("{0} {1}", adjustedSize, SizeSuffixes[mag]);
        }
    }
}
