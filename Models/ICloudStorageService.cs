namespace wodapi.Models
{
    public interface ICloudStorageService
    {
        Task UploadVideoAsync(string bucketName, string objectName, string filePath);
        Task<Stream> DownloadVideoAsync(string bucketName, string objectName);
    }
}
