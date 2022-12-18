using System.Diagnostics.CodeAnalysis;

namespace DO;


/// <summary>
/// Structure for Product on sale resource
/// </summary>
public struct Product
{
    
    /// <summary>
    /// Unique ID of product
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Descriptive name of product
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Current sell price of product
    /// </summary>
    public int Price { get; set; }

    /// <summary>
    /// Category of product in the sotre product list
    /// </summary>
    public Category? Category { get; set; }

    /// <summary>
    /// How many items of product are in stock for sale
    /// </summary>
    public int? InStock { get; set; }

    public override string ToString() => $@"
        {nameof(ID)}={ID}: {Name}, 
        {nameof(Category )} - {Category}
        {nameof(Price)}: {Price}
        {nameof(InStock )}: {InStock}
";

    public override bool Equals(object? obj)
    {
        if (obj == null) throw new EntityException();
        return (obj as Product?).Value.ID .Equals(this.ID) ;
    }
}