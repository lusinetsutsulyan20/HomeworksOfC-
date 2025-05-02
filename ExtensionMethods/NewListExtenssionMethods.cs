// 3. List<T>-ի համար ընդլալնել Filter մեթոդը, որը Func<T,bool> դելեգատի միջոցով վերադարձնում է ֆունկցիային բավարարող տարրերը.
// Օրինակ՝
// List<Student> students = new List<Student>(){...};
// var temp = students.Filter(a => a.age > 20);

// 4. List<T>-ի համար ընդլալնել Map մեթոդը, որը Func<T,T> դելեգատի միջոցով վերադարձնում է նոր List , որի ամեն տարր փոխված է
// Օրինակ՝
// List<int> list = new List<int>(){1,2,3,4,5,6};
// var temp = list.Map(a => a+1);
// c.w(temp[2])) //4


// 5. List<T>-ի համար ընդլալնել Every մեթոդը, որը Func<T,bool> դելեգատի միջոցով վերադարձնում է  true,  եթե բոլոր տարրերը բավարարում են նշված դելեգատին
// Օրինակ՝
// List<int> list = new List<int>(){1,2,3,4,5,6};
// cw(list.Every(a => a > 0)) //True

// 6. List<T>-ի համար ընդլալնել Some մեթոդը, որը Func<T,bool> դելեգատի միջոցով վերադարձնում է  true,  եթե գոնե մեկ տարր կա, որը բավարարում է նշված դելեգատին
// Օրինակ՝
// List<int> list = new List<int>(){1,2,3,4,5,6};
// cw(list.Some(a => a < 0)) //False (edited) 



namespace MyNewListExtensionNamespace
{
    public static class Extensions 
    {
        public static bool Some<T> (this List<T> _array, Func<T, bool> fn)
        {
            List<T> tmp = new();
            foreach (var item in _array)
            {
                if (fn(item))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool Every<T> (this List<T> _array, Func<T, bool> fn)
        {
            List<T> tmp = new();
            foreach (var item in _array)
            {
                if (!fn(item))
                {
                    return false;
                }
            }

            return true;
        }
         public static List<T> Map<T> (this List<T> _array, Func<T, T> fn)
        {
            List<T> tmp = new();
            foreach (var item in _array)
            {
                tmp.Add(fn(item));
            }

            return tmp;   
        }
        public static List<T> Filter<T> (this List<T> _array, Func<T, bool> fn)
        {
            List<T> tmp = new();
            foreach (var item in _array)
            {
                if (fn(item))
                {
                    tmp.Add(item);
                }
            }

            return tmp;
        } 
    }
}
