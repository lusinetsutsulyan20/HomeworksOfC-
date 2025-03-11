using System;
class Program {
    public class Person {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string FullName {get;}
        
        public Person (string firstname, string lastname){
            firstName = firstname;
            lastName = lastname;
            FullName = firstName + " " + lastName;
        }
        
    }
    static void Main() {
        Person P = new Person("anun", "azganun");
        
        Console.WriteLine(P.FullName);
        P.firstName = "changed";
        
        Console.WriteLine(P.FullName);
        
    }
}
