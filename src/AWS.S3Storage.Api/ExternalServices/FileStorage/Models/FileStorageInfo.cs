namespace AWS.S3Storage.Api.ExternalServices.FileStorage.Models;

public class FileStorageInfo
{
    public string Id { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public string Name { get; set; } = null!;
    public ulong? Size { get; set; }
}