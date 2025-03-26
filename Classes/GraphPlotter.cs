using System.Windows.Forms.DataVisualization.Charting;

public class GraphPlotter
{
    public static void PlotGraph(Chart chart, List<(double x, double y)> values, string functionName)
    {
        chart.Series.Clear();
        var series = new Series
        {
            Name = functionName,
            ChartType = SeriesChartType.Line
        };
        foreach (var (x, y) in values)
        {
            series.Points.AddXY(x, y);
        }
        chart.Series.Add(series);
    }
}
