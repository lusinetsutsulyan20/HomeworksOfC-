namespace Part1
{
    public partial class GameClass{
        public string characterName;
        public int level;
    }
    internal class CourseEnrollment{
        static void Main(string[] args){
            GameClass G = new GameClass();
            G.characterName = "miBan";
            G.level = 2;
            G.ShowCharacterInfo();
        }
    }
}
