namespace TaskItem
{
    public class TaskItem{
        public string description;
        public bool iscompleted;

        public TaskItem(string desc){
            description = desc;
            iscompleted = false;
        }
        public void MarkComplete(){
            iscompleted = true;
        }
        public void MarklnComplete(){
            iscompleted = false;
        }
    }

    internal class BookLibrary{
        static void Main(string[] args){
            TaskItem[] T = new TaskItem[3];
            
            for (int i = 0; i < T.Length; i++){
                string desc = Console.ReadLine() ?? "";
                T[i] = new TaskItem(desc);
            }
            T[1].MarkComplete();
            T[3].MarkComplete();
        }
    }
}