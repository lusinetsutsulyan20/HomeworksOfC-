using System;
class Program {
    public class Students {
        private string[] subjects = new string[5];
        private double[] grades = new double[5];
        
        public double this [string name]{
            get{
                for (int i = 0; i < subjects.Length; i++){
                    if (this.subjects[i] == name){
                        return this.grades[i];
                    }
                }
                return -1;
            }
            set {
                for (int i = 0; i < subjects.Length; i++){
                    if (subjects[i] == name){
                        this.grades[i] = value;
                    }
                }
            }
        }
        
        public Students (string[] a, double[] b){
            for (int i = 0; i < a.Length; i++){
                subjects[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++){
                grades[i] = b[i];
            }
        }
    }
    
    static void Main() {
        string[] array = {"a", "b", "c", "d", "e"};
        double[] grades = {1.1, 2.2, 3.3, 4.4};
        Students S = new Students(array, grades);
        
        Console.WriteLine(S["math"]);
        S["e"] = 5.5;
        Console.WriteLine(S["e"]);
    }
}
