using Company.Archive.Domain.Common;

namespace Company.Archive.Domain.Organization;

public sealed class OrganizationalUnit : Entity
{
    private OrganizationalUnit() { }

    public OrganizationalUnit(string code, string nameArabic, OrganizationalUnitType type, long? parentId = null)
    {
        Code = Require(code, nameof(code), 32);
        NameArabic = Require(nameArabic, nameof(nameArabic), 200);
        Type = type;
        ParentId = parentId;
        IsActive = true;
    }

    public string Code { get; private set; } = string.Empty;
    public string NameArabic { get; private set; } = string.Empty;
    public OrganizationalUnitType Type { get; private set; }
    public long? ParentId { get; private set; }
    public bool IsActive { get; private set; }

    public void Deactivate() => IsActive = false;

    private static string Require(string value, string parameterName, int maximumLength)
    {
        var normalized = value?.Trim() ?? string.Empty;
        if (normalized.Length is 0 || normalized.Length > maximumLength)
            throw new ArgumentException($"Value must contain 1 to {maximumLength} characters.", parameterName);
        return normalized;
    }
}

public enum OrganizationalUnitType
{
    Sector = 1,
    GeneralManagement = 2,
    Department = 3
}
