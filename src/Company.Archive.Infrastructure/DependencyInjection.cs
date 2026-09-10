using Microsoft.Extensions.DependencyInjection;

namespace Company.Archive.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddArchiveInfrastructure(this IServiceCollection services)
    {
        // Oracle, HR directory, Identity persistence, and file storage adapters
        // are added after their Phase 1 proofs of concept are accepted.
        return services;
    }
}
