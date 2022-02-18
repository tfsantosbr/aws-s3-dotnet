using AWS.S3Storage.Api.ExternalServices.FileStorage.Models;

namespace AWS.S3Storage.Api.ExternalServices.FileStorage;

public interface IFileStorage
{
    Task UploadFileAsync(string bucketName, string fileName, string contentType, Stream fileStream);
    Task<FileStorageInfo?> GetFileInfoAsync(string bucket, string fileName);
    Task DownloadFileAsync(string bucketName, string fileName, Stream destination);
    Task RemoveFileAsync(string bucketName, string fileName);
}