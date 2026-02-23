namespace ReportGenerator.Reports;

public interface IReportBuilder
{
    IReport Build();
    IReportBuilder IncludePageNumbers();
    IReportBuilder IncludeSummary();
    IReportBuilder IncludeTotals();
    IReportBuilder WithChartType(string chartType);
    IReportBuilder WithColumn(string column);
    IReportBuilder WithCompanyLogo(string companyLogo);
    IReportBuilder WithEndDate(DateTime endDate);
    IReportBuilder WithFilter(string filter);
    IReportBuilder WithFooter(string footerText);
    IReportBuilder WithFormat(string format);
    IReportBuilder GroupBy(string groupBy);
    IReportBuilder WithHeader(string headerText);
    IReportBuilder WithOrientation(string orientation);
    IReportBuilder WithPageSize(string pageSize);
    IReportBuilder OrderBy(string sortBy);
    IReportBuilder WithStartDate(DateTime startDate);
    IReportBuilder WithTitle(string title);
    IReportBuilder WithWaterMark(string waterMark);
}
