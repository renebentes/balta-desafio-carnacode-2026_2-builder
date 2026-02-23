using ReportGenerator.Reports;

Console.WriteLine("=== Sistema de Relatórios ===");

var monthlySalesReport = new SalesReportBuilder()
    .WithTitle("Vendas Mensais")
    .WithFormat("PDF")
    .WithStartDate(new DateTime(2024, 1, 1))
    .WithEndDate(new DateTime(2024, 1, 31))
    .WithHeader("Relatório de Vendas")
    .WithFooter("Confidencial")
    .WithChartType("Bar")
    .WithColumn("Produto")
    .WithColumn("Quantidade")
    .WithColumn("Valor")
    .WithFilter("Status=Ativo")
    .OrderBy("Valor")
    .GroupBy("Categoria")
    .IncludeTotals()
    .WithOrientation("Portrait")
    .WithPageSize("A4")
    .IncludePageNumbers()
    .WithCompanyLogo("logo.png")
    .WithWaterMark("Confidencial")
    .Build();

monthlySalesReport.Generate();

var quarterlySalesReport = new SalesReportBuilder()
    .WithTitle("Relatório Trimestral")
    .WithFormat("Excel")
    .WithStartDate(new DateTime(2024, 1, 1))
    .WithEndDate(new DateTime(2024, 3, 31))
    .WithHeader("Relatório de Vendas")
    .WithFooter("Confidencial")
    .WithColumn("Produto")
    .WithColumn("Quantidade")
    .WithColumn("Valor")
    .WithChartType("Pie")
    .IncludeTotals()
    .WithOrientation("Landscape")
    .WithPageSize("A4")
    .Build();

quarterlySalesReport.Generate();

var annualSalesReport = new SalesReportBuilder()
    .WithTitle("Vendas Anuais")
    .WithFormat("PDF")
    .WithStartDate(new DateTime(2024, 1, 1))
    .WithEndDate(new DateTime(2024, 12, 31))
    .WithColumn("Vendedor")
    .WithColumn("Região")
    .WithColumn("Total")
    .WithChartType("Line")
    .GroupBy("Região")
    .IncludeTotals()
    .Build();

annualSalesReport.Generate();
