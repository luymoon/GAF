using GAF.API.Models;

namespace GAF.API.Repositories.Interfaces;

public interface IReportRepository
{
    Task<Report> GetMonthlyReoportAsync(string userId, int month, int year);
    Task<IEnumerable<Report>> GetYearlyReportsAsync(string userId, int year);
    Task<Report> CreateOrUpdateMonthlyReportAsync(Report report);
}
