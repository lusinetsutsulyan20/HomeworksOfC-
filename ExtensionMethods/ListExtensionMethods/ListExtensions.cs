// List<T>ի համար ընդլայնել
// void Shuffle() - պատահականության սկզբունքով խառնել բոլոր տարրերի դիրքերը
// void Reverse() - շրջել List-ը
// List<T> Slice(int start, int end) - կտրում և վերադարձնում է start-ից end հատվածի տարրերը:
// T At(int index) - վերադարձնում է index-րդ տարրը.  եթե index<0, հաշվարկը հակառակ կողմից իրականացնել

namespace MyListExtensionNamespace
{
public static class Extensions 
{
    public static void MyShuffle<T> (this List<T> _array)
    {
        Random random = new Random();
        int n = _array.Count;
        while (n > 1)
        {
            --n;
            int k = random.Next(n + 1);
            (_array[k], _array[n]) = (_array[n], _array[k]);
        }
    }
    public static void MyReverse<T> (this List<T> _array)
    {
        for (int i = 0; i < (_array.Count / 2); i++)
        {
            T tmp = _array[i];
            _array[i] = _array[_array.Count - i - 1];
            _array[_array.Count - i - 1] = tmp;
        }
    }

    public static List<T>  MySlice <T> (this List<T> _array, int start, int length)
    {
        if (start < 0 || start >= _array.Count)
        {
            throw new IndexOutOfRangeException("Start index is out of range.");
        }
        if (length < 0 || start + length > _array.Count)
        {
            throw new IndexOutOfRangeException("The length exceeds the available elements.");
        }
        
        List<T> tmp = new List<T>();
        int index = 0;

        for (int i = start; i < start + length; i++)
        {
            tmp.Add(_array[i]);
        }
        return tmp;
    }

    public static T MyAt<T> (this List<T> _array, int index)
    {
        if (index >= _array.Count || index < -_array.Count)
        {
            throw new IndexOutOfRangeException("Start index is invalid.");
        }

        if (index >= 0)
        {
            return _array[index]; 
        }
        else
        {
            return _array[_array.Count + index];
        }
    }

}
}
