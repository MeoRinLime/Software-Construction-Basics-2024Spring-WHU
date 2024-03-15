//链表结点
public class Node<T>
{
    public Node<T>? Next { get; set; }
    public T? Data { get; set; }

    public Node(T data)
    {
        Next = null;
        Data = data;
    }
}

//泛型链表类
public class GenericList<T>
{
    private Node<T>? head;
    private Node<T>? tail;

    public GenericList()
    {
        head = tail = null;
    }

    public Node<T>? Head
    {
        get => head;
    }

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }

    public void ForEach(Action<T> action)
    {
        Node<T>? current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(9);
        list.Add(8);
        list.Add(7);

        // 打印链表元素
        list.ForEach(item => Console.WriteLine(item));

        // 求最大值
        int max = int.MinValue;
        list.ForEach(item => { if (item > max) max = item; });
        Console.WriteLine($"Max value: {max}");

        // 求最小值
        int min = int.MaxValue;
        list.ForEach(item => { if (item < min) min = item; });
        Console.WriteLine($"Min value: {min}");

        // 求和
        int sum = 0;
        list.ForEach(item => sum += item);
        Console.WriteLine($"Sum: {sum}");
    }
}