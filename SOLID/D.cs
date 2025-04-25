// public class EmailService
// {
//     public void Send(string message)
//     {
//         Console.WriteLine("Sending Email: " + message);
//     }
// }
// public class Notification
// {
//     private EmailService emailService = new EmailService();
//     public void Alert(string message)
//     {
//         emailService.Send(message);
//     }
// }

// Այստեղ խպաղտվում է Dependency Inversion սկզբունքը, մի class-ը չպետք է կախված լինի մեկ այլ class-ից։


public interface IService
{
    public void Send(string message);
}
public class EmailService : IService
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}
public class Notification
{
    private IService service;
    public Notification (IService service)
    {
        this.service = service;
    }
    public void Alert(string message)
    {
        service.Send(message);
    }
}

public class Program
{
    public static void Main()
    {
        IService service = new EmailService();
        Notification notification = new Notification(service);
    }
}
