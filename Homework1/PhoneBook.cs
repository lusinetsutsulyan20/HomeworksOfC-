namespace Program
{
    public class Contact
    {
        public string? name;
        public string? phoneNumber;
        public string? email;

        public Contact(string n, string phone, string mail)
        {
            name = n;
            phoneNumber = phone;
            email = mail;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name is - {name}");
            Console.WriteLine($"Phone number is - {phoneNumber}");
            Console.WriteLine($"Email is - {email}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact[] C = new Contact[3] { new Contact("", "", ""), new Contact("", "", ""), new Contact("", "", "") };


            //Contact[] C = new Contact[3];

            for (int i = 0; i < C.Length; i++)
            {

                string? name = Console.ReadLine() ?? "";
                string? phone = Console.ReadLine() ?? "";
                string? mail = Console.ReadLine() ?? "";
                C[i] = new Contact(name, phone, mail);
            }

            for (int i = 0; i < C.Length; i++)
            {
                C[i].DisplayInfo();
            }

            string searchName = Console.ReadLine() ?? "";
            for (int i = 0; i < C.Length; i++)
            {
                if (C[i].name == searchName)
                {
                    C[i].DisplayInfo();
                }
            }

        }
    }


}
