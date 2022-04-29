using System.Threading.Tasks;

namespace s3Uploader
{
    public interface IUploader
    {
        Task Upload(string filePath, string keyName, string bucketName, string contentType);
    }
}
