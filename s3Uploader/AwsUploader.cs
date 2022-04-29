using System;
using System.IO;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace s3Uploader
{
    public class AwsUploader : IUploader
    {
        private readonly IAmazonS3 client;

        public AwsUploader(string ak, string sk, RegionEndpoint region)
        {

            client = new AmazonS3Client(ak, sk, region);
        }

        public async Task Upload(string filePath, string keyName, string bucketName, string contentType)
        {
            Console.WriteLine("AwsUploader ...");

            // Confirm that the file exists on the local computer.
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Couldn't find {filePath}. Try again.\n");
                return;
            }

            try
            {
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName,
                    FilePath = filePath,
                    ContentType = contentType
                };


                PutObjectResponse response = await client.PutObjectAsync(request);

                Console.WriteLine($"Successfully uploaded {keyName} from {filePath} to {bucketName}.\n");

            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine(
                        "Error encountered ***. Message:'{0}' when writing an object"
                        , e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    "Unknown encountered on server. Message:'{0}' when writing an object"
                    , e.Message);
            }

        }

        public static implicit operator AwsUploader(LocalUploader v)
        {
            throw new NotImplementedException();
        }
    }
}
