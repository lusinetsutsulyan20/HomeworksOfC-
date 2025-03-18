using System;
public class Program {
    public class Parent {
        public string name {get; private set;}
        public int age {get; private set;}
        public double salary {get; private set;}
        
        public Parent (string name, int age, double salary){
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public double GetSalary(){
            return salary;
        }
    }
    public class Child {
        public string name {get; private set;}
        public int age {get; private set;}
        public Parent father;
        public Parent mother;
        
        public Child (string name, int age, string fatherName, int fatherAge, double fatherSalary, string motherName, int motherAge, double motherSalary){
            this.name = name;
            this.age = age;
            father = new Parent (fatherName, fatherAge, fatherSalary);
            mother = new Parent (motherName, motherAge, motherSalary);
        }
        public double GetIncome (){
            return (mother.salary + father.salary);
        }
        public string ShowInfo(){
        return $"Name: {name}, Age: {age}, Mother's Name: {mother.name}, Father's Name: {father.name}";        }
    }
  
    // Ստեղծել Child-երի ստատիկ զանգված կազմված 10 տարրերից
    //    1. Տպել այն երեխաների ցուցակը, որոնց հոր և մոր տարիքը միասին չի գերազանցում 70-ը:
    //    2. Գտնել տարիքով ամենամեծ երեխայի հոր աշխատավարձը:
    //    3. Գտնել ամենամեծ ընտանեկան եկամուտ ունեցող երեխայի տվյալները:
    //    4. Զանգվածում տեղերով փոխել ամենաերիտասարդ և ամենամեծ երեխաների դիրքերը` տպելով ընդհանուր զանգվածը:
    
    static void Main() {
        Child[] childs = new Child[10];
        childs[0] = new Child ("Anna0", 2, "Aram0", 30, 100000, "Anush0", 25, 50000);
        childs[1] = new Child ("Anna1", 3, "Aram1", 31, 101000, "Anush1", 26, 51000);
        childs[2] = new Child ("Anna2", 4, "Aram2", 32, 102000, "Anush2", 27, 52000);
        childs[3] = new Child ("Anna3", 5, "Aram3", 33, 103000, "Anush3", 28, 53000);
        childs[4] = new Child ("Anna4", 6, "Aram4", 34, 104000, "Anush4", 29, 54000);
        childs[5] = new Child ("Anna5", 7, "Aram5", 35, 105000, "Anush5", 30, 55000);
        childs[6] = new Child ("Anna6", 8, "Aram6", 36, 106000, "Anush6", 31, 56000);
        childs[7] = new Child ("Anna7", 9, "Aram7", 37, 107000, "Anush7", 32, 57000);
        childs[8] = new Child ("Anna8", 10, "Aram8",38, 108000, "Anush8", 33, 58000);
        childs[9] = new Child ("Anna9", 11, "Aram9",39, 109000, "Anush9", 34, 59000);
        
        
        Console.WriteLine ("Childs whose parenths age is < 70");
        for (int i = 0; i < childs.Length; i++){
            int fatherMotherAge = childs[i].father.age + childs[i].mother.age;
            if (fatherMotherAge <= 70){
                Console.WriteLine (childs[i].ShowInfo());
            }
        }
        Console.WriteLine();
        
        int eldestChildAge = childs[0].age;
        int eldestChildIndex = 0;
        
        int youngestChildAge = childs[0].age;
        int youngestChildIndex = 0;
        
        double richedChildIncome = childs[0].GetIncome();   
        int richedChildIndex = 0;
        
        for (int i = 1; i < childs.Length; i++){
            if (childs[i].age > eldestChildAge){
                eldestChildAge = childs[i].age;
                eldestChildIndex = i;
            }
             if (childs[i].age < youngestChildAge){
                youngestChildAge = childs[i].age;
                youngestChildIndex = i;
            }
            if (childs[i].GetIncome() > richedChildIncome){
                richedChildIncome = childs[i].GetIncome();
                richedChildIndex = i;
            }
        }
        Console.WriteLine ("The eldest child's father's salary is: " + childs[eldestChildIndex].father.GetSalary());
        Console.WriteLine();
        Console.WriteLine ("The richest child's parents' income is: " + childs[richedChildIndex].GetIncome());
        Console.WriteLine();
        
        Child tmp = childs[eldestChildIndex];
        childs[eldestChildIndex] = childs[youngestChildIndex];
        childs[youngestChildIndex] = tmp;
        
        Console.WriteLine ("Is swapped youngest and eldest childs' indexes in array");
        
        for (int i = 0; i < childs.Length; i++){
            Console.WriteLine (childs[i].ShowInfo());
        }
        
    }
}
