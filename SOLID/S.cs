// public class Report
// {
//     public string Title { get; set; }
//     public string Content { get; set; }
//     public void SaveToFile(string path)
//     {
//         System.IO.File.WriteAllText(path, Content);
//     }
//     public void Print()
//     {
//         Console.WriteLine($"--- {Title} ---\n{Content}");
//     }
// }

// Այստեղ խաղտվում է SOLID-ի S սկզբունքը, պետք է ստեղծել նոր class,
// որը պատասխանատու կլինի SaveToFile անելու համար և ևս մեկը Print անլու համար։


public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }
}
public class ReportSaverInFile
{
    public void SaveToFile(Report report, string path)
    {
        System.IO.File.WriteAllText(path, report.Content);
    }
}
public class ReportPrinter
{
    public void Print(Report report)
    {
        Console.WriteLine($"--- {report.Title} ---\n{report.Content}");
    }
}
