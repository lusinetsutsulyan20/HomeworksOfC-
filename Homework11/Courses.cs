// Ստեղծել, Course, Group, Module կլասները

// Course - ինֆորմացիա է պարունակում դասընթացի մասին (անուն,  ամսավճար, մոդուլներ)
// Module - ինֆորմացիա է պարունակում դասընթացի առանձին կտորի մասին (վերնագիր, տևողություն)
// Group - Ներկայացնում է խմբի տվյլաները (անուն, ուսանողների քանակ, կուրս)

// Course կլասից ժառանգվում են Web, Game, AI  կլասները,
// ընդ որում Web-ը ունի նաև type դաշտ, որը կարող է լինել frontend, backend, fullstack
// Game-ը ունի engine դաշտ, որը կարող է լինել unity, unreal:

// Course,Module և Group, Course կապը has a է, իսկ Course=>Web,Game,Ai -ը is a:

using System;
public class Program 
{
    public class Module 
    {
        private string title {get; set;}
        private int timeInMinutes {get; set;}
        public Module (string title, int time)
        {
            this.title = title;
            timeInMinutes = time;
        }
    }
    public class Course 
    {
        protected string name {get; set;}
        protected double payment {get; set;}
        protected Module[] moduls;

        public Course (string name, double payment, Module[] moduls)
        {
            this.name = name;
            this.payment = payment;
            this.moduls = moduls;
        }
        public Course (string name, double payment, int size){
            this.name = name;
            this.payment = payment;
            moduls = new Module[size];
        }
    }
    public class Group 
    {
        private string name {get; set;}
        private int count {get; set;}
        private Course course;
        
        public Group (string name, int count, Course course){
            this.name = name;
            this.count = count;
            this.course = course;
        }
        public Group (string name, int count, string courseName, double payment, int cuont){
            this.name = name;
            this.count = count;
            course = new Course (courseName, payment, count);
        }
        public string ShowInfo() 
        {
            return $"Group name is {name}, students count is {count}";
        }
    }
    
    public class Web : Course   
    {
        private string type;
        public string Type
        {
            get
            {
                return type;    
            } 
            set
            {
                if ((value == "frontend") || (value == "backend") || (value == "fullstack"))
                {
                    type = value;
                } 
                else 
                {
                    Console.WriteLine ("Invalid input"); 
                    return;   
                }
            }
        }
        public Web (string name, double payment, string type, Module[] moduls) : base (name, payment, moduls) => this.type = type;
        public Web (string name, double payment, string type, int count) : base (name, payment, count)
        {
            this.type = type;
        }
            
    }
    public class Game : Course 
    {
        private string engine;
        public string Engine
        {   
            get
            {
                return engine;    
            } 
            set
            {
                if ((value == "unity") || (value == "unreal"))
                {
                    engine = value;
                } 
                else 
                {
                    Console.WriteLine ("Invalid input");    
                }
            }
        }
        public Game (string name, double payment, string engine, Module[] moduls) : base (name, payment, moduls) => this.engine = engine;
        public Game (string name, double payment, string engine, int count) : base (name, payment, count) => this.engine = engine;
    }
    public class AI : Course 
    {
        public AI (string name, double payment, Module[] moduls) : base (name, payment, moduls){ }
        public AI (string name, double payment, int count) : base (name, payment, count){ }
    }
    
    
    static void Main() {
        Course[] courses = new Course[]
        {
            new Web("Frontend Development", 500000, "frontend", new Module[] 
            { 
                new Module("HTML & CSS", 2), new Module("JavaScript", 3) 
            }),
                new Web("Fullstack Development", 60000, "fullstack", new Module[] 
            { 
                new Module("Node.js", 4), new Module("React", 5) 
            }),
            new AI("Machine Learning", 80000, new Module[] 
            { 
                new Module("Python for AI", 6), new Module("Deep Learning", 8) 
            }),
            new Game("Game Development", 72000, "Unity", new Module[] 
            {    
                new Module("C# for Unity", 5), new Module("Physics in Games", 4) 
            }),
            new Game("Game Dev Advanced", 42000, "Unreal", new Module[] 
            { 
                new Module("Blueprints", 6), new Module("C++ for Unreal", 7) 
            }) 
        };  
            
        Group[] groups = new Group[]
        {
            new Group("Frontend Group 1", 15, courses[0]),   // Frontend Development
            new Group("Fullstack Group 1", 12, courses[1]),  // Fullstack Development
            new Group("AI Group 1", 10, courses[2]),         // Machine Learning
            new Group("Game Dev Group 1", 20, courses[3]),   // Unity Game Development
            new Group("Game Dev Group 2", 18, courses[4])     // Unreal Game Development
        }; 
        for (int i = 0; i < groups.Length; i++) 
        {
            Console.WriteLine (groups[i].ShowInfo());
        } 
    }
}
