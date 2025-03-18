// Ստեղծել, Course, Group, Module կլասները

// Course - ինֆորմացիա է պարունակում դասընթացի մասին (անուն,  ամսավճար, մոդուլներ)
// Module - ինֆորմացիա է պարունակում դասընթացի առանձին կտորի մասին (վերնագիր, տևողություն)
// Group - Ներկայացնում է խմբի տվյլաները (անուն, ուսանողների քանակ, կուրս)

// Course կլասից ժառանգվում են Web, Game, AI  կլասները,
// ընդ որում Web-ը ունի նաև type դաշտ, որը կարող է լինել frontend, backend, fullstack
// Game-ը ունի engine դաշտ, որը կարող է լինել unity, unreal:

// Course,Module և Group, Course կապը has a է, իսկ Course=>Web,Game,Ai -ը is a:

using System;
public class Program {
    public class Course {
        string name {}
        double psyment;
        
    }
    public class Group {
        
    }
    public class Module {
        string title;
        int timeInMinutes;
    }
    
    
    static void Main() {
        
    }
}
