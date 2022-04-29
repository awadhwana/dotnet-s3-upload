using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Amazon;

using System.Net;

namespace s3Uploader
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Upload();

        }

        static void Upload()
        {
            //IUploader uploader;
            //uploader = new LocalUploader();
            //uploader.uploadAsync("", "", "", "");

            IUploader uploader;
            var newRegion = RegionEndpoint.GetBySystemName("ap-south-1");
            uploader = new AwsUploader("", "", newRegion);
            string bucketName = "upload-test-dotnet";
            string filePath = "/Users/ankit/Projects/s3Uploader/s3Uploader/assets/0.png";
            object assetID = "12345";
            string keyName = $"{assetID}/image.png";
            string contentType = "image/png";
            uploader.Upload(filePath, keyName, bucketName, contentType).Wait();
        }
    }
}
