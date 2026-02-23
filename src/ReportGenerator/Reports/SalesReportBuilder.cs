namespace ReportGenerator.Reports;

public class SalesReportBuilder : IReportBuilder
{
    private readonly Report _report = new();

    public IReport Build() => _report;

    public IReportBuilder IncludePageNumbers()
    {
        _report.IncludePageNumbers = true;
        return this;
    }

    public IReportBuilder IncludeSummary()
    {
        _report.IncludeSummary = true;
        return this;
    }

    public IReportBuilder IncludeTotals()
    {
        _report.IncludeTotals = true;
        return this;
    }

    public IReportBuilder WithChartType(string chartType)
    {
        _report.ChartType = chartType;
        return this;
    }

    public IReportBuilder WithColumn(string column)
    {
        _report.AddColumn(column);
        return this;
    }

    public IReportBuilder WithCompanyLogo(string companyLogo)
    {
        _report.CompanyLogo = companyLogo;
        return this;
    }

    public IReportBuilder WithEndDate(DateTime endDate)
    {
        _report.EndDate = endDate;
        return this;
    }

    public IReportBuilder WithFilter(string filter)
    {
        _report.AddFilter(filter);
        return this;
    }

    public IReportBuilder WithFooter(string footerText)
    {
        _report.FooterText = footerText;
        return this;
    }

    public IReportBuilder WithFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public IReportBuilder GroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public IReportBuilder WithHeader(string headerText)
    {
        _report.HeaderText = headerText;
        return this;
    }

    public IReportBuilder WithOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public IReportBuilder WithPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public IReportBuilder OrderBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public IReportBuilder WithStartDate(DateTime startDate)
    {
        _report.StartDate = startDate;
        return this;
    }

    public IReportBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public IReportBuilder WithWaterMark(string waterMark)
    {
        _report.WaterMark = waterMark;
        return this;
    }
}
