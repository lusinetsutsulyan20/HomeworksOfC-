namespace BankAccount
{
    public class Bank
    {
        public string accountNumber;
        public string holderNmae;
        public int balance;
        public Bank(string account, string name)
        {
            accountNumber = account;
            holderNmae = name;
            balance = 0;
        }
        public void Deposit(int count)
        {
            balance += count;
        }
        public void Withdraw(int count)
        {
            if (balance - count < 0)
            {
                Console.WriteLine("Insufficient fund");
            }
            else
            {
                balance -= count;
            }
        }
        public void Display()
        {
            Console.WriteLine(balance);
        }
    }
    internal class BankAccount
    {
        static void Main(string[] args)
        {
            Bank B1 = new Bank("12345", "Lusine");
            B1.Deposit(500);
            B1.Display();
            B1.Withdraw(200);
            B1.Display();
        }
    }
}