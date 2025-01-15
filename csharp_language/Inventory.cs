namespace csharp_language;

public class Inventory
{
    private string _name;
    private HashSet<Item> _items = [];

    public Inventory(string name)
    {
        _name = name;
    }

    public bool AddItem(Item item)
    {
        return _items.Add(item);
    }

    public bool RemoveItem(Item item)
    {
        return _items.Remove(item);
    }
}

//use to GET HashSet items using a test obj with the same ID to match the Contains criteria (could also just use a list of items)
public static class HashSetExtensions
{
    public static T? TryGetValue<T>(this HashSet<T> set, T value) where T : class
    {
        return set.TryGetValue(value, out var found) ? found : null;
    }
    
    public static bool TryGetValue<T>(this HashSet<T?> set, T? value, out T? found) where T : class
    {
        found = null;
        if (!set.Contains(value)) return false;

        // Iterate to find the exact instance
        foreach (var item in set)
        {
            if (item.Equals(value))
            {
                found = item;
                return true;
            }
        }
        return false;
    }
}