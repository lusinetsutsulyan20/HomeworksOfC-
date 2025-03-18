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
    public class Course 
    {
        private string name {get; set;}
        private double psyment {get; set;}
        private Module[] moduls;
    }
    public class Group 
    {
        private string name {get; set;}
        private int count {get; set;}
        private Course course;
    }
    public class Module 
    {
        private string title {get; set;}
        private int timeInMinutes {get; set;}
    }
    
    public class Web : Course 
    {
        private string type 
        {
            get
            {
                return type;    
            } 
            set
            {
                if ((value == "frontend") || (value == "backend") || (value == "backend"))
                {
                    type = value;
                } 
                else 
                {
                    Console.WriteLine ("Invalid input");    
                }
            }}
    }
    public class Game : Course 
    {
        private string engine
        {   
            get
            {
                return type;    
            } 
            set
            {
                if ((value == "unity") || (value == "unreal"))
                {
                    type = value;
                } 
                else 
                {
                    Console.WriteLine ("Invalid input");    
                }
            }}
    }
    public class AI : Course 
    {
        
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
            new Group("Game Dev Group 2", 18, courses[4])    // Unreal Game Development
        };   
    }
}
