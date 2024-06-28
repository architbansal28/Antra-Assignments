namespace Assignment_04_Generics;

public class MyList<T>
{
    private List<T> _elements = new List<T>();

    public int Count => _elements.Count;

    public void Add(T element)
    {
        _elements.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(index));
        T element = _elements[index];
        _elements.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        return _elements.Contains(element);
    }

    public void Clear()
    {
        _elements.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(index));
        _elements.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(index));
        _elements.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= _elements.Count)
            throw new ArgumentOutOfRangeException(nameof(index));
        return _elements[index];
    }
}