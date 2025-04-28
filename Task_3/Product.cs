namespace Task_3;
public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    
    public override string ToString()
    {
        return $"{Name}";
    }
}