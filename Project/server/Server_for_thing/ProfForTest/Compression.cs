using Ionic.Zip;
using System.Text;
//using Server_for_thing;
using System.IO;
namespace ProfForTest
{
    public class Compression
    {

        public Compression ()
        {

        }
        public static void CompressionFolder(string folder, string name)
        {
            try
            {
                string path = folder + @"\" + name + ".zip";
                if (File.Exists(path))
                    File.Delete(path);
                Listing test = new Listing();
                test.CreateCollection(folder);
                if (test.Count() < 1)
                    File.AppendAllText(folder + @"\emptytext.sys", "Папка с бэкапами пуста");
                System.Threading.Thread.Sleep(1000);
                using (ZipFile zip = new ZipFile())
                {
                    zip.AlternateEncoding = Encoding.UTF8;
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level0;
                    zip.AddDirectory(@folder);
                    zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
                    zip.Save(@path);
                }
            }
            catch { }
        }
        //разархивация архива в нужную папку. Передается целиком путь к архиву, и целиком путь разархивации
        public static void DeCompressionFolder(string name, string folder)
        {
            using (ZipFile zip1 = ZipFile.Read(name))
            {
                foreach (ZipEntry e in zip1)
                {
                    e.Extract(folder, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }

        //Архивация выделенных файлов/папок
        //public static void CompressCollection(Listing collection, string folder, string name)
        //{
        //    string path = folder + @"\" + name + ".zip";
        //    using (ZipFile zip = new ZipFile())
        //    {
        //        zip.AlternateEncoding = Encoding.UTF8;
        //        zip.AlternateEncodingUsage = ZipOption.AsNecessary;

        //        zip.AddFiles(collection.setfilesCollection(),"");
        //        foreach(string files in collection.setfolderCollection())
        //        {
        //            zip.AddDirectory(files, Path.GetFileName(files));
        //        }

        //        zip.Save(@path);
        //    }
        //}
    }
}