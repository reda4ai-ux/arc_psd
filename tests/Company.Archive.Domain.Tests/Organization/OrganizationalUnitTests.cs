using Xunit;
using Company.Archive.Domain.Organization;

namespace Company.Archive.Domain.Tests.Organization;

public sealed class OrganizationalUnitTests
{
    [Fact]
    public void UnitCanStopAtSectorLevel()
    {
        var sector = new OrganizationalUnit("01", "قطاع نظم المعلومات", OrganizationalUnitType.Sector);

        Assert.Null(sector.ParentId);
        Assert.True(sector.IsActive);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    public void EmptyCodeIsRejected(string code)
    {
        Assert.Throws<ArgumentException>(() =>
            new OrganizationalUnit(code, "قطاع", OrganizationalUnitType.Sector));
    }
}
