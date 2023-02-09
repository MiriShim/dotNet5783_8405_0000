using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace DO;


/// <summary>
/// Structure for Product on sale resource
/// </summary>
public struct Product : INotifyPropertyChanged
{
    
    /// <summary>
    /// Unique ID of product
    /// </summary>
    public int Id { get; set; }

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

     public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(  String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString() => $@"
        {nameof(Id)}={Id}: {Name}, 
        {nameof(Category )} - {Category}
        {nameof(Price)}: {Price}
        {nameof(InStock )}: {InStock}
";

    public override bool Equals(object? obj)
    {
        if (obj == null) throw new EntityException();
        return ((Product)obj).Id.Equals(this.Id) ;
    }
    public DateTime LastUpdateAt { get; set; }
    public ProductStatus ProductStatus { get; set; }

}