// Գրել Memoize մեթոդը, որն իբրև պարամետր ստանում է Func<T, T> և վերադարձնում Func<T,T> -ի memoize արված տարբերակը
// Օրինակ՝
// Func<int,int> factorial = (int p) => {...};
// var memoFact = Memoize(factorial);
// //memoFact-ն այլևս իրականացնում է ֆակտորիալի հաշվարկը memoizing-ով

namespace MyProg
{
    public class Program
    {
        public delegate void Action<T> ();
        public static void Main()
        {
            Func<int,int> factorial = x => {  
                int p = 1;
                for (int i = 2; i <= x; ++i)
                {
                    p *= i;
                }
                return p;
            };
            var memoFact = Memoize(factorial);
            Console.WriteLine(memoFact(5));
        }

        public static Func<T, T>  Memoize<T> (Func<T, T> func)
        {
            Dictionary<T, T> memo = new();
        
                return x => {
                    if (memo.ContainsKey(x))
                    {
                        return memo[x];
                    }
                    
                    var result  = func(x);
                    memo[x] = result;
                    return result;
                };
        }
    }
}
