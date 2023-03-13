// source: https://www.youtube.com/watch?v=4XSSC6uPFNA

using System.Diagnostics;

var cts = new CancellationTokenSource();

//var silverQueue = new Queue<string>();
//var goldQueue = new Queue<string>();
//var platinQueue = new Queue<string>();

//silverQueue.Enqueue("Benjamin");
//platinQueue.Enqueue("Sandro");
//goldQueue.Enqueue("Lia");
//goldQueue.Enqueue("Corinne");
//platinQueue.Enqueue("Noemie");
//silverQueue.Enqueue("Micheal");

//while (!cts.IsCancellationRequested)
//{
//    await Task.Delay(1000);

//    if (platinQueue.Count > 0)
//    {
//        var platinItem = platinQueue.Dequeue();
//        Console.WriteLine($"Platin: {platinItem}");
//        continue;
//    }

//    if (goldQueue.Count > 0)
//    {
//        var goldItem = goldQueue.Dequeue();
//        Console.WriteLine($"Gold: {goldItem}");
//        continue;
//    }

//    if (silverQueue.Count > 0)
//    {
//        var silverItem = silverQueue.Dequeue();
//        Console.WriteLine($"Silver: {silverItem}");
//        continue;
//    }   
//}

var queue = new PriorityQueue<User, (Status, long)>(StatusComparer.Instance);

// timestamp for order
queue.Enqueue(new User("Benjamin"), (Status.Silver, Stopwatch.GetTimestamp()));
queue.Enqueue(new User("Sandro"), (Status.Platin, Stopwatch.GetTimestamp()));
queue.Enqueue(new User("Lia"), (Status.Gold, Stopwatch.GetTimestamp()));
queue.Enqueue(new User("Corinne"), (Status.Gold, Stopwatch.GetTimestamp()));
queue.Enqueue(new User("Noemie"), (Status.Platin, Stopwatch.GetTimestamp()));
queue.Enqueue(new User("Micheal"), (Status.Silver, Stopwatch.GetTimestamp()));

while (!cts.IsCancellationRequested)
{
    await Task.Delay(500);

    if (queue.Count > 0)
    {
        var item = queue.Dequeue();
        Console.WriteLine($"Item: {item.Name}");
    }
}

enum Status
{
    Silver,
    Gold,
    Platin
}

record User(string Name);

// singleton
class StatusComparer : IComparer<(Status, long)>
{
    public static StatusComparer Instance { get; } = new StatusComparer();

    private StatusComparer() { }

    public int Compare((Status, long) x, (Status, long) y)
    {
        if (x.Item1 == y.Item1)
            return x.CompareTo(y);

        return y.CompareTo(x);
    }
}