using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer {
    class Rename {

        private readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        /// <summary>
        /// Add and prepare new files for the listview
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public ListViewItem[] AddNewFiles(string[] files) {

            List<ListViewItem> items = new List<ListViewItem>();
            foreach (string file in files) {
                Tuple<string, string> nameAndExt = GetFileNameAndExt(file);
                items.Add(new ListViewItem(new[] { file, nameAndExt.Item1, nameAndExt.Item2, nameAndExt.Item1, nameAndExt.Item2, GetFileSize(file), GetFileCreationTime(file), GetFileLastAccessTime(file), GetFileLastWriteTime(file) }));
            }
            return items.ToArray();
        }


        /// <summary>
        /// Rename all files from listview
        /// </summary>
        /// <param name="items"></param>
        public void RenameFiles(ListView.ListViewItemCollection items) {

            // Process listview items
            List<ToRename> toRenames = new List<ToRename>();
            if (items.Count > 0) {
                for (int c = 0; c < items.Count; c++) {
                    string pathFrom = items[c].SubItems[0].Text;
                    string directoryFrom = Path.GetDirectoryName(pathFrom);
                    // If 2 or more files are the same (full path) (rename only one)
                    if (toRenames.Find(tr => (tr.PathFrom == pathFrom)) == null) {
                        toRenames.Add(new ToRename(pathFrom, Path.Combine(directoryFrom, $"{items[c].SubItems[3].Text}{items[c].SubItems[4].Text}")));
                    }
                }
            }

            // Rename file
            foreach(ToRename ToRename in toRenames) {
                try {
                    if (File.Exists(ToRename.PathFrom)) {
                        if (!File.Exists(ToRename.PathTo)) {
                            File.Move(ToRename.PathFrom, ToRename.PathTo);
                        } else {

                            // Check if change the extention (uppercase, lowercase)
                            if (Path.GetExtension(ToRename.PathFrom) != Path.GetExtension(ToRename.PathTo)) {
                                string radomFile = Path.GetRandomFileName();
                                File.Move(ToRename.PathFrom, radomFile);
                                File.Move(radomFile, ToRename.PathTo);
                            }
                        }
                    }
                } catch { }
            }
        }

        #region New files name and extension

        /// <summary>
        /// Replace file name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replace"></param>
        /// <param name="with"></param>
        /// <returns></returns>
        public string GetReplace(string name, string replace, string with) {
            try {
                return name.Replace(replace, with);
            } catch (ArgumentException) {
                return name;
            }
        }

        /// <summary>
        /// Remove char from file name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fromFisrt"></param>
        /// <param name="fromLast"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public string GetRemove(string name, int fromFisrt, int fromLast, int from, int to) {

            if (fromFisrt <= name.Length) {
                name = fromFisrt > 0 ? name.Substring(fromFisrt) : name;
            }

            if (name.Length - fromLast >= 0) {
                name = fromLast > 0 ? name.Substring(0, name.Length - fromLast) : name;
            }
            if (to > name.Length) {
                to = name.Length;
            }

            if (from < name.Length) {
                name = (from | to) != 0 ? name.Remove(from, (to - from)) : name;
            } else {
                return name;
            }

            return name;
        }

        /// <summary>
        /// Add char to file name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prefix"></param>
        /// <param name="sufix"></param>
        /// <param name="insert"></param>
        /// <param name="at"></param>
        /// <returns></returns>
        public string GetAdd(string name, string prefix, string sufix, string insert, int at) {
            name = string.Format("{0}" + name + "{1}", prefix, sufix);

            // Check if we pass the max file name length
            if (at <= name.Length) {
                name = name.Insert(at, insert);
            } else {

                // Get the new position and remove the last char
                int x = at - name.Length;
                if (insert.Length - x >= 0) {
                    insert = insert.Remove(insert.Length - x);
                    name = name.Insert(at - x, insert);
                }
            }

            return name;

        }

        /// <summary>
        /// Modify file name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="action"></param>
        /// <param name="rename"></param>
        /// <returns></returns>
        public string GetName(string name, string action, string rename = "") {
            if (action == "Remove") {
                return String.Empty;
            } else if (action == "Rename") {
                return rename;
            } else if (action == "Reverse") {
                if (name == null) return String.Empty;
                char[] array = name.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            } else if (action == "First to upper") {
                return char.ToUpper(name[0]) + name.Substring(1);
            } else if (action == "First to lower") {
                return char.ToLower(name[0]) + name.Substring(1);
            } else if (action == "To upper") {
                return name.ToUpper();
            } else if (action == "To lower") {
                return name.ToLower();
            }
            return name;
        }


        /// <summary>
        /// Modify file extension
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="action"></param>
        /// <param name="rename"></param>
        /// <returns></returns>
        public string GetExt(string extension, string action, string rename = "") {
            if (action == "Remove") {
                return String.Empty;
            } else if (action == "Rename") {
                return $".{rename}";
            } else if (action == "To upper") {
                return extension.ToUpper();
            } else if (action == "To lower") {
                return extension.ToLower();
            }
            return extension;
        }
        #endregion

        #region Get file proprieties

        /// <summary>
        /// Get file name and extension
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private Tuple<string, string> GetFileNameAndExt(string filePath) {
            return Tuple.Create(Path.GetFileNameWithoutExtension(filePath), Path.GetExtension(filePath));
        }

        /// <summary>
        /// Get file creation timestamps
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string GetFileCreationTime(string file) {
            return File.GetCreationTime(file).ToString("dd-MM-yyyy HH:mm:ss");
        }

        /// <summary>
        /// Get file last access timestamps
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string GetFileLastAccessTime(string file) {
            return File.GetLastAccessTime(file).ToString("dd-MM-yyyy HH:mm:ss");
        }

        /// <summary>
        /// Get file last write timestamps
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string GetFileLastWriteTime(string file) {
            return File.GetLastWriteTime(file).ToString("dd-MM-yyyy HH:mm:ss");
        }

        /// <summary>
        /// Get file size
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        private string GetFileSize(string filePath, int decimalPlaces = 0) {
            FileInfo file = new FileInfo(filePath);
            if (file.Length < 0) {
                throw new ArgumentException("Bytes should not be negative", "value");
            }
            var mag = (int)Math.Max(0, Math.Log(file.Length, 1024));
            var adjustedSize = Math.Round(file.Length / Math.Pow(1024, mag), decimalPlaces);
            return String.Format("{0} {1}", adjustedSize, SizeSuffixes[mag]);
        }
        #endregion
    }

    public class ToRename{

        private string pathFrom = String.Empty;
        private string pathTo = string.Empty;

        public ToRename(string pathFrom, string pathTo) {
            this.pathFrom = pathFrom;
            this.pathTo = pathTo;
        }

        public string PathFrom { get => pathFrom;}
        public string PathTo { get => pathTo;}
    }
}
