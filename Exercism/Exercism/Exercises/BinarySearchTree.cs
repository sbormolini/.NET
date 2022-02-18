using System.Collections;

namespace Exercism;

public class BinarySearchTree : IEnumerable<int>
{
    public int Value { get; private set; }
    public BinarySearchTree Left { get; private set; }
    public BinarySearchTree Right { get; private set; }

    public BinarySearchTree(int value) => Value = value;

    public BinarySearchTree(IEnumerable<int> values)
    {
        Value = values.First();
        foreach (var value in values.Skip(1))
            Add(value);
    }

    public BinarySearchTree Add(int value)
    {
        if (value <= Value)
            Left = Left?.Add(value) ?? new BinarySearchTree(value);
        else
            Right = Right?.Add(value) ?? new BinarySearchTree(value);

        return this;
    }

    public IEnumerator<int> GetEnumerator()
    {
        if (Left is not null)
            foreach (var leftValue in Left)
                yield return leftValue;

        yield return Value;

        if (Right is not null)
            foreach (var rightValue in Right)
                yield return rightValue;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}