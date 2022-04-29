using System;
using System.IO;
using System.Threading.Tasks;

namespace s3Uploader
{
    public class LocalUploader : IUploader
    {
        public LocalUploader()
        {
        }

        public async Task Upload(string filePath, string keyName, string bucketName, string contentType)
        {
            await Task.Run(() => Console.WriteLine($"{filePath} , {keyName}, {bucketName}, {contentType}"));
            //keyName = "assetId/filename";
            // filePath = "/Users/ankit/Projects/s3Uploader/s3Uploader/assets";
            //string assetID = "12345";
            //string targetPath = $"/Users/ankit/Projects/s3Uploader/s3Uploader/{assetID}";
            //System.IO.Directory.CreateDirectory(targetPath);


            //string sourcePath = filePath;
            //string destinationPath = $"/Users/ankit/Projects/s3Uploader/s3Uploader/{assetID}"; ;


            //if (System.IO.Directory.Exists(sourcePath))
            //{

            //    //File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
            //    File.Copy(sourcePath, Path.Combine(backupDir, fName), true);



            //    string fileName;
            //    string destFile;
            //    string[] files = System.IO.Directory.GetFiles(sourcePath);

            //    foreach (string file in files)
            //    {
            //        // Use static Path methods to extract only the file name from the path.
            //        fileName = System.IO.Path.GetFileName(file);
            //        destFile = System.IO.Path.Combine(targetPath, fileName);
            //        System.IO.File.Copy(file, destFile, true);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Source path does not exist!");
            //}
        }
    }
}
