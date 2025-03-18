using System;
class HelloWorld {
    public class MyString {
        private char[] _string;
        public int Length {
            get {
                return _string.Length;
            }
        }
        public bool Empty {
            get {
                if (_string.Length != 0){
                    return false;
                }
                return true;
            }
        }
        public char this [int index]{
            get {
                if (index < 0 || index >= _string.Length){
                    Console.WriteLine ("Out of Length");
                    return '0';
                }
                return _string[index];
            }
        }
        // Constructors
        public MyString (){
            _string = null;
        }
        public MyString (char[] str){
            _string = new char[str.Length];
            for (int i = 0; i < str.Length; i++){
                _string[i] = str[i];
            }
        }
        public MyString (char ch, int len){
            char[] tmp = new char[len];
            for (int i = 0; i < len; i++){
                tmp[i] = ch;
            }
            _string = tmp;
        }
        public MyString (char[] str, int index, int len){
            _string = new char[str.Length];
            int count = 0;
            while (count < len){
                _string[index] = str[index];
                ++count;
                ++index;
            }
        }
        public MyString (MyString str, int index, int len){
            _string = new char[str.Length];
            int count = 0;
            while (count < len){
                _string[index] = str[index];
                ++count;
                ++index;
            }
        }
        //Methods
        //Compare method
        public static int Compare (MyString first, MyString second){
            if (first.Length > second.Length){
                return 1;
            } else if (first.Length < second.Length) {
                return -1;
            } else {
                for (int i = 0; i < first.Length; i++){
                    if (first[i] > second[i]){
                        return 1;
                    } else if (first[i] < second[i]){
                        return -1;
                    }
                }
                return 0;
            }
        }
        public static int Compare (MyString first, int fIndex, MyString second, int sIndex, int count){
            int index = 0;
            while (index < count){
                if (first[fIndex] > second[sIndex]){
                    return 1;
                } else if (first[fIndex] < second[sIndex]){
                    return -1;
                }
                ++fIndex;
                ++sIndex;
            }
            return 0;
        }
        
        // Compare EndsWith, StartsWith

        public static bool EndsWith (MyString cmp, MyString source){
            int tmpLength = cmp.Length;
            int index = 0;
            for (int i = tmpLength; i > 0; i--){
                if (cmp[index] != source[source.Length - tmpLength]){
                    return false;
                }
                ++index;
            }
            return true;
        }
        public static bool StartsWith (MyString cmp, MyString source){
            for (int i = 0; i < cmp.Length; i++){
                if (cmp[i] != source[i]){
                    return false;
                }
            }
            return true;
        }
        
        // operator ==, != override
        public static bool operator == (MyString first, MyString second){
            if (first.Length != second.Length){
                return false;
            }
            for (int i = 0; i < first.Length; i++){
                if (first[i] != second[i]){
                    return false;
                }
            }
            return true;
        }
        public static bool operator != (MyString first, MyString second){
            if (first.Length != second.Length){
                return true;
            }
            for (int i = 0; i < first.Length; i++){
                if (first[i] != second[i]){
                    return true;
                }
            }
            return false;
        }
        //Override of Equals and GetHashCode
        public override bool Equals (object obj){
            if (obj is MyString other){
                return this._string == other._string;
            }
            return false;
        }
        public override int GetHashCode(){
            int hash = 17;
            hash = hash * 23 + _string.GetHashCode();
            return hash;
        }
        // Join method and operator + override
        public static MyString Join (char ch, params MyString[] arr){
            int size = 0;
            for (int i = 0; i < arr.Length; i++){
                size += arr[i].Length;
            }
            size += arr.Length;
            --size;
            int index = 0;
            char[] result = new char[size];
            for (int i = 0; i < arr.Length; i++){
                for (int j = 0; j < arr[i].Length; j++){
                    result[index] = arr[i][j];
                }
                result [i + arr[i].Length] = ch;
            }
            MyString res = new MyString(result);
            return res;
        }
        public static MyString operator + (MyString first, MyString second){
            char[] result = new char [first.Length + second.Length];
            for (int i = 0; i < first.Length; i++){
                result[i] = first[i];
            }
            for (int i = 0, j = first.Length; i < second.Length; i++, j++){
                result[j] = second[i];
            }
            MyString res = new MyString(result);
            return res;
        }
    }
    static void Main() {
        Console.WriteLine("Hello World");
    }
}
