using System.Collections;

namespace DesignPatterns.Iterator;

// Concrete Collections provide one or several methods for retrieving fresh
// iterator instances, compatible with the collection class.
class WordsCollection : IteratorAggregate
{
    List<string> _collection = new();

    bool _direction = false;

    public void ReverseDirection() =>  _direction = !_direction;

    public List<string> getItems() => _collection;

    public void AddItem(string item) => _collection.Add(item);

    public override IEnumerator GetEnumerator() => new AlphabeticalOrderIterator(this, _direction);
}
