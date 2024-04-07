// See https://aka.ms/new-console-template for more information
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

MyCollection collection = new MyCollection();

IEnumerator rator = collection.GetEnumerator();

while (rator.MoveNext())
{
    object obj = (int) rator.Current;
    Console.WriteLine(obj);
}


//foreach (var item in collection)
//{
//    Console.WriteLine(item);
//}


Console.WriteLine("Hello, World!");
Console.ReadLine();

class MyCollection : IEnumerable
{
    private int[] data = { 1, 2, 3, 4, 5 };
    public MyCollection()
    {
    }

    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(data);
    }
}

class MyEnumerator : IEnumerator
{
    private int[] data;
    private int position = -1;

    public MyEnumerator(int[] data)
    {
        this.data = data;
    }
    public object Current => data[position];

    public bool MoveNext()
    {
        position++;
        return position < data.Length;
    }

    public void Reset()
    {
        position = -1;
    }
}