using System;
class Program {
    public class BankAccount{
       public int accountNumber ;
       public int balance;
       public BankAccount(int a, int b){
            accountNumber = a;
            balance = b;
       }
       public override string ToString(){
           return ($"Account: {accountNumber}, Balance: {balance} USD");
       }
       public override bool Equals (object obj){
           if (obj is BankAccount other){
               return this.accountNumber == other.accountNumber;
           }
           return false;
       }
       public override int GetHashCode(){
           int hash = 17;
           hash = hash * 23 + accountNumber.GetHashCode();
           hash = hash * 23 + balance.GetHashCode();
           return hash;
       }
       public static BankAccount operator + (BankAccount obj, int count){
           obj.balance += count;
           return obj;
       }
       public static BankAccount operator  - (BankAccount obj, int count){
           if (obj.balance - count >= 0){
               obj.balance -= count;
               return obj;
           }
           Console.WriteLine("Not so maney");
           return obj;
       }
       public static bool operator < (BankAccount obj1, BankAccount obj2){
           return obj1.balance < obj2.balance;
       }
       public static bool operator > (BankAccount obj1, BankAccount obj2){
           return obj1.balance > obj2.balance;
       }
       public static bool operator <= (BankAccount obj1, BankAccount obj2){
           return obj1.balance <= obj2.balance;
       }
       public static bool operator >= (BankAccount obj1, BankAccount obj2){
           return obj1.balance >= obj2.balance;
       }
    }
    static void Main() {
        BankAccount B = new BankAccount(500, 500);
        B = B + 5;
        B = B + 200;
        B = B - 4;
        Console.WriteLine(B.ToString());
  }
}

