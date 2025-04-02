// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

namespace Program;
public class Program
{
    public struct Words
    {
        public string Original {get; init;}
        public string Translated {get; init;}

        public Words (string original, string translated)
        {
            Original = original;
            Translated = translated;
        }
    }
    public abstract class Translator
    {   
        protected Words[] words;
        public string this[string val]
        {
            get 
            {
                for (int i = 0; i < words.Length; ++i)
                {
                    return words[i].Original;
                };
                return " ";
            }
        }
        public abstract string Translate(string org);
        public Translator (int size)
        {
            words = new Words[size];
        }
    }
    public class Russian : Translator
    {
    
        public Russian () : base (10)
        {
            words[0] = new Words("apple", "яблоко");
            words[1] = new Words("banana", "банан");
            words[2] = new Words("orange", "апельсин");
            words[3] = new Words("mango", "манго");
            words[4] = new Words("pineapple", "ананас");
            words[5] = new Words("grape", "виноград");
            words[6] = new Words("strawberry", "клубника");
            words[7] = new Words("cherry", "вишня");
            words[8] = new Words("watermelon", "арбуз");
            words[9] = new Words("peach", "персик");
        }

        public override string Translate(string org)
        {
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i].Original == org)
                    {
                        return words[i].Translated;
                    }
            }
            return " ";
        }
    }
    
    public class Spanish : Translator
    {
         public Spanish() : base(10)
    {
        words[0] = new Words("apple", "manzana");
        words[1] = new Words("banana", "plátano");
        words[2] = new Words("orange", "naranja");
        words[3] = new Words("mango", "mango");
        words[4] = new Words("pineapple", "piña");
        words[5] = new Words("grape", "uva");
        words[6] = new Words("strawberry", "fresa");
        words[7] = new Words("cherry", "cereza");
        words[8] = new Words("watermelon", "sandía");
        words[9] = new Words("peach", "durazno");
    }
        public override string Translate(string org)
        {
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i].Original == org)
                    {
                        return words[i].Translated;
                    }
            }
            return " ";
        }
    }
    
    public class French : Translator
    {
        public French() : base(10) 
    {
        words[0] = new Words("apple", "pomme");
        words[1] = new Words("banana", "banane");
        words[2] = new Words("orange", "orange");
        words[3] = new Words("mango", "mangue");
        words[4] = new Words("pineapple", "ananas");
        words[5] = new Words("grape", "raisin");
        words[6] = new Words("strawberry", "fraise");
        words[7] = new Words("cherry", "cerise");
        words[8] = new Words("watermelon", "pastèque");
        words[9] = new Words("peach", "pêche");
    }
        public override string Translate(string org)
        {
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i].Original == org)
                    {
                        return words[i].Translated;
                    }
            }
            return " ";
        }
    }

    public static void Main()
    {
        Translator[] words = new Translator[3];
        words[0] = new Spanish();
        words[1] = new French();
        words[2] = new Russian();
        
        foreach(Translator t in words){
            Console.WriteLine(t.Translate("apple"));
        }
    }
}
