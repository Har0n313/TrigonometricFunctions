using System.Text;

public class FileExporter
{
    public static void ExportToFile(List<(double x, double y)> values, string filename)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var (x, y) in values)
        {
            sb.AppendLine($"{x}\t{y}");
        }
        File.WriteAllText(filename, sb.ToString());
    }
}