using System;
class VectorOverloaded {
    public class Vector {
        public int x;
        public int y;
        public int z;
        public Vector (int x, int y, int z){
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString(){
            return $"(X: {x}, Y: {y}, Z: {z})";
        }
        public static Vector operator + (Vector vec1, Vector vec2){
            Vector vec = new Vector(0, 0, 0);
            vec.x = vec1.x + vec2.x;
            vec.y = vec1.y + vec2.y;
            vec.z = vec1.z + vec2.z;
            return vec;
        }
        public static Vector operator - (Vector vec1, Vector vec2){
            Vector vec = new Vector(0, 0, 0);
            vec.x = vec1.x - vec2.x;
            vec.y = vec1.y - vec2.y;
            vec.z = vec1.z - vec2.z;
            return vec;
        }
        public static int operator * (Vector vec1, Vector vec2){
            int res = 0;
            res += vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;
            return res;
        }
        public static bool operator == (Vector vec1, Vector vec2){
            return vec1.x == vec2.x && vec1.y == vec2.y && vec1.z == vec2.z;
        }
        public static bool operator != (Vector vec1, Vector vec2){
            return vec1.x != vec2.x && vec1.y != vec2.y && vec1.z != vec2.z;
        }
        public override bool Equals (object obj){
           if (obj is Vector other){
               return this.x == other.x && this.y == other.y && this.z == other.z;
           }
           return false;
        }
        public override int GetHashCode(){
           int hash = 17;
           hash = hash * 23 + x.GetHashCode();
           hash = hash * 23 + y.GetHashCode();
           hash = hash * 23 + z.GetHashCode();
           return hash;
        }
        public static bool operator true (Vector vec){
            return vec.x != 0 && vec.y != 0 && vec.z != 0;
        }
        public static bool operator false (Vector vec){
            return vec.x == 0 && vec.y == 0 && vec.z == 0;
        }
        public static bool operator < (Vector vec1, Vector vec2){
            return vec1.x < vec2.x && vec1.y < vec2.y && vec1.z < vec2.z;
        }
        public static bool operator > (Vector vec1, Vector vec2){
            return vec1.x > vec2.x && vec1.y > vec2.y && vec1.z > vec2.z;
        }
         public static bool operator <= (Vector vec1, Vector vec2){
            return vec1.x <= vec2.x && vec1.y <= vec2.y && vec1.z <= vec2.z;
        }
        public static bool operator >= (Vector vec1, Vector vec2){
            return vec1.x >= vec2.x && vec1.y >= vec2.y && vec1.z >= vec2.z;
        }
    }
  static void Main() {
      Vector vec1 = new Vector(1, 1, 1);
      Vector vec2 = new Vector(2, 2, 2);
      Vector vec3 = vec1 + vec2;
      Console.WriteLine(vec3.ToString());
  }
}
