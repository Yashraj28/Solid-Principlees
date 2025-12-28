namespace SOLID_Principle.OCP;

public class ReportService
{
    public void ReportType(IReportFormat reportFormat, string msg)
    {
        reportFormat.Format(msg);
    }
    
}

public class Xml : IReportFormat
{
    public void Format(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class Pdf : IReportFormat
{
    public void Format(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class Excel : IReportFormat
{
    public void Format(string msg)
    {
        Console.WriteLine(msg);
    }
}