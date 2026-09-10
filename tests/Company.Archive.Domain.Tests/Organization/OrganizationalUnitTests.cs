using Company.Archive.Domain.Organization;

namespace Company.Archive.Domain.Tests.Organization;

public sealed class OrganizationalUnitTests
{
    [Fact]
    public void Unit_can_stop_at_sector_level()
    {
        var sector = new OrganizationalUnit("01", "قطاع نظم المعلومات", OrganizationalUnitType.Sector);

        Assert.Null(sector.ParentId);
        Assert.True(sector.IsActive);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void Empty_code_is_rejected(string code)
    {
        Assert.Throws<ArgumentException>(() =>
            new OrganizationalUnit(code, "قطاع", OrganizationalUnitType.Sector));
    }
}
