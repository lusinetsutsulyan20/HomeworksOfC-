using System;
class Program {
    public class Person {
        public string firstName {get; set;}
        public string lastName {get; set;}
        
        private string _fullName;
        public string FullName {
            get{
                if (_fullName == null){
                    Console.WriteLine ("We have not FullName");
                }
                return _fullName;
            }
        }
    
        public Person (string firstname, string lastname){
            firstName = firstname;
            lastName = lastname;
            _fullName = $"{firstName} {lastName}";
        }
        
    }
    static void Main() {
        Person P = new Person("anun", "azganun");
        Console.WriteLine(P.FullName);
        
        P.firstName = "changed";
        Console.WriteLine(P.FullName);
    }
}
