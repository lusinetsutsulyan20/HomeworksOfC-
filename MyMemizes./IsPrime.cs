// Գրել ManagedCache ֆունկցիան, որը վերադարձնում է Tuple՝ երկու դելեգատներից
//  (Func<int,bool> IsPrime, Action ClearCache):
// Առաջինը ստուգում է՝ արդյո՞ք տվյալ թիվը պարզ է թե չէ:  Երկրորդը դատարկում է Cache-ի համար պահված Dictionary-ն
// Օրինակ՝
// var fn = ManagedCache();
// cw(fn.IsPrime(13)); // վերադարձնում է True
// cw(fn.IsPrime(13)); // տպում է "from cache" արտահայտությունը, վերադարձնում TRUE

namespace MyProg
{
    public class Program
    {
        public static void Main()
        {
            var fn = ManagedCache();
            Console.WriteLine(fn.IsPrime(13)); // վերադարձնում է True
            Console.WriteLine(fn.IsPrime(13)); // տպում է "from cache" արտահայտությունը, վերադարձնում TRUE
        }
        public static (Func<int,bool> IsPrime, Action ClearCache) ManagedCache()
        {
            Dictionary<int, bool> cache = new Dictionary<int, bool>();
            bool IsPrime (int n)
            {   
                if (cache.ContainsKey(n))
                {
                    Console.Write("From cache:   ");
                    return cache[n];
                }

                if (n <= 1) 
                {
                    cache.Add(n, false);
                    return false;
                }
                if (n == 2 || n == 3) 
                {
                    cache.Add(n, true);
                    return true;
                }
                if (n % 2 == 0 || n % 3 == 0)
                {
                    cache.Add(n, false);
                    return false;
                }

                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                        cache.Add(n, false);
                        return false;
                }
                cache.Add(n, true);
                return true;
            }
            void ClearCache ()
            {
                cache.Clear();
            }

            return (IsPrime, ClearCache);
        }
        
    }

}
