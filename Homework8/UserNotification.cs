using System;
class Program {
    public class User {
        private int userId;
        private string[] notification;
        
        public User(int id, string[] notes){
            userId = id;
            for (int i = 0; i < notes.Length; i++){
                notification[i] = notes[i];
            }
        }
    }
    
    public class Notifications{
        
        public Notifications (User[] u){
            
        }
    }
    
    
    
    
    static void Main() {
        
    }
} 
