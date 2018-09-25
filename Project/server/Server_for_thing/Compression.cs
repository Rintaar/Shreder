using System;

public class Compression
{

    private void CompressionFolder(string folder, string name)
    {
        string path = folder + @"\" + name + ".zip";
        using (ZipFile zip = new ZipFile())
        {
            zip.AlternateEncoding = Encoding.UTF8;
            zip.AlternateEncodingUsage = ZipOption.AsNecessary;
            zip.AddDirectory(@folder);
            zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
            zip.Save(@path);
        }
    }
    private void DeCompressionFolder(string name, string folder)
    {
        using (ZipFile zip1 = ZipFile.Read(name))
        {
            foreach (ZipEntry e in zip1)
            {
                e.Extract(folder, ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}