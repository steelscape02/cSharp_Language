namespace csharp_language;

public class Item
{
    private readonly int _id;
    private string _name;
    private int _quantity;

    public Item(int id,string name,int quantity)
    {
        _id = id;
        _name = name;
        _quantity = quantity;
    }
    
    
    //Contains override for object comparison based only on ID
    public bool Equals(Item? other)
    {
        if (other == null) return false;
        return _id == other._id;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Item);
    }

    public override int GetHashCode()
    {
        return _id.GetHashCode();
    }
}