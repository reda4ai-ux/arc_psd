namespace Company.Archive.Application.Abstractions;

public interface IEmployeeDirectoryService
{
    Task<EmployeeDirectoryEntry?> FindByCodeAsync(string employeeCode, CancellationToken cancellationToken);
}

public sealed record EmployeeDirectoryEntry(
    string EmployeeCode,
    string? EmployeeName,
    string EmployeeTypeCode,
    string? EmployeeTypeName,
    string JobCode,
    string? JobName,
    string? SectorCode,
    string? SectorName,
    string? GeneralManagementCode,
    string? GeneralManagementName,
    string? DepartmentCode,
    string? DepartmentName,
    DateTime? EmploymentEndDate,
    string? EmploymentEndCode,
    string? EmploymentEndName);
