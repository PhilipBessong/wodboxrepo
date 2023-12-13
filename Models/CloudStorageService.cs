using System.IO;
using Google.Apis.Storage.v1.Data; // Add this using directive
using Google.Cloud.Storage.V1;
using System.Threading.Tasks;
using wodapi.Models;

public class CloudStorageService : ICloudStorageService
{
    private readonly StorageClient _storageClient;

    public CloudStorageService()
    {
        // Initialize a storage client
        _storageClient = StorageClient.Create();
    }

    public async Task UploadVideoAsync(string bucketName, string objectName, string filePath)
    {
        using (var fileStream = File.OpenRead(filePath))
        {
            // Upload the video to Google Cloud Storage
            await _storageClient.UploadObjectAsync(bucketName, objectName, null, fileStream);
        }
    }

    public async Task<Stream> DownloadVideoAsync(string bucketName, string objectName)
    {
        // Download the video from Google Cloud Storage
        var downloadObject = await _storageClient.GetObjectAsync(bucketName, objectName);

        // Ensure that the downloadObject has a valid MediaDownloadLink
        if (string.IsNullOrEmpty(downloadObject.MediaLink))
        {
            // Handle the case where MediaLink is not available
            throw new InvalidOperationException("MediaLink is not available for the object.");
        }

        // Download the content using DownloadObject
        var downloadStream = new MemoryStream();
        await _storageClient.DownloadObjectAsync(bucketName, objectName, downloadStream);

        // Reset the stream position to the beginning
        downloadStream.Position = 0;

        return downloadStream;
    }





}
