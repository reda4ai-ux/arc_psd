namespace Company.Archive.Application.Abstractions;

public interface IFileStorageService
{
    Task<StoredFile> SaveAsync(Stream content, FileStorageRequest request, CancellationToken cancellationToken);
    Task<Stream> OpenReadAsync(string storageKey, CancellationToken cancellationToken);
    Task<bool> ExistsAsync(string storageKey, CancellationToken cancellationToken);
}

public sealed record FileStorageRequest(string OriginalFileName, string ContentType, long MaximumBytes);
public sealed record StoredFile(string StorageKey, long SizeBytes, string Sha256, string ContentType);
