namespace ReportGenerator.Reports;

public sealed class Report : IReport
{
    private readonly IList<string> _columns = [];

    private readonly IList<string> _filters = [];

    public string ChartType { get; set; } = string.Empty;
    public string CompanyLogo { get; set; } = string.Empty;

    public DateTime EndDate { get; set; }

    public string FooterText { get; set; } = string.Empty;

    public string Format { get; set; } = string.Empty;

    public string GroupBy { get; set; } = string.Empty;

    public string HeaderText { get; set; } = string.Empty;

    public bool IncludeCharts => !string.IsNullOrWhiteSpace(ChartType);

    public bool IncludeFooter => !string.IsNullOrWhiteSpace(FooterText);

    public bool IncludeHeader => !string.IsNullOrWhiteSpace(HeaderText);

    public bool IncludePageNumbers { get; set; }

    public bool IncludeSummary { get; set; }
    public bool IncludeTotals { get; set; }
    public string Orientation { get; set; } = string.Empty;
    public string PageSize { get; set; } = string.Empty;
    public string SortBy { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public string Title { get; set; } = string.Empty;
    public string WaterMark { get; set; } = string.Empty;

    public void AddColumn(string column) => _columns.Add(column);

    public void AddFilter(string filter) => _filters.Add(filter);

    public void Generate()
    {
        Console.WriteLine($"\n=== Gerando Relatório: {Title} ===");
        Console.WriteLine($"Formato: {Format}");
        Console.WriteLine($"Período: {StartDate:dd/MM/yyyy} a {EndDate:dd/MM/yyyy}");

        if (IncludeHeader)
        {
            Console.WriteLine($"Cabeçalho: {HeaderText}");
        }

        if (IncludeCharts)
        {
            Console.WriteLine($"Gráfico: {ChartType}");
        }

        Console.WriteLine($"Colunas: {string.Join(", ", _columns)}");

        if (_filters.Count > 0)
        {
            Console.WriteLine($"Filtros: {string.Join(", ", _filters)}");
        }

        if (!string.IsNullOrEmpty(GroupBy))
        {
            Console.WriteLine($"Agrupado por: {GroupBy}");
        }

        if (IncludeFooter)
        {
            Console.WriteLine($"Rodapé: {FooterText}");
        }

        Console.WriteLine("Relatório gerado com sucesso!");
    }
}
