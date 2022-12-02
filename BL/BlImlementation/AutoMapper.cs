using AutoMapper;
namespace BlImlementation;

public class BLAutoMapper
{
    //Ignore()??
    //isn't it possible to put there default values???
    public MapperConfiguration OredrMappingConfiguration = new MapperConfiguration(cnf =>
    cnf.CreateMap<BO.Order, DO.Order>()
    .ForMember(b => b.ID, option => option.MapFrom(d => d.id))
    .ForMember(b => b.ShipDate, option => option.MapFrom(d => d.ShipDate))
    .ForMember(b => b.ShipDate, option => option.MapFrom(d => d.DeleveryDate))
    .ReverseMap()
    .ForMember(b => b.id, option => option.MapFrom(d => d.ID))
    .ForMember(b => b.ShipDate, option => option.MapFrom(d => d.ShipDate))
    .ForMember(b => b.DeleveryDate, option => option.MapFrom(d => d.ShipDate))
    .ForMember(b => b.Status, option => option.Ignore())
    .ForMember(b => b.PaymentDate, option => option.Ignore())
    .ForMember(b => b.Items, option => option.Ignore())
    .ForMember(b => b.TotalPrice, option => option.Ignore())
    );

    public MapperConfiguration OredrItemMappingConfiguration = new MapperConfiguration(cnf =>
    cnf.CreateMap<BO.OrderItem, DO.OrderItem>()
    .ForMember(b => b.ProductID, option => option.MapFrom(d => d.productId))
    .ForMember(b => b.Amount, option => option.MapFrom(d => d.amount))
    .ForMember(b => b.Price, option => option.MapFrom(d => d.price))
    .ForMember(b => b.OrderID, option => option.Ignore())
    .ReverseMap()
    .ForMember(b => b.productId, option => option.MapFrom(d => d.ProductID))
    .ForMember(b => b.amount, option => option.MapFrom(d => d.Amount))
    .ForMember(b => b.price, option => option.MapFrom(d => d.Price))
    );


    public MapperConfiguration ProductMappingConfiguration = new MapperConfiguration(cnf =>
    cnf.CreateMap<BO.Product, DO.Product>()
    .ForMember(b => b.ID, option => option.MapFrom(d => d.id))
    .ForMember(b => b.Name, option => option.MapFrom(d => d.name))
    .ForMember(b => b.Category, option => option.MapFrom(d => d.category))
    .ForMember(b => b.Price, option => option.MapFrom(d => d.price))
    .ForMember(b => b.InStock, option => option.MapFrom(d => d.inStock))
     .ReverseMap()
    .ForMember(b => b.id, option => option.MapFrom(d => d.ID))
    .ForMember(b => b.name, option => option.MapFrom(d => d.Name))
    .ForMember(b => b.category, option => option.MapFrom(d => d.Category))
    .ForMember(b => b.price, option => option.MapFrom(d => d.Price))
    .ForMember(b => b.inStock, option => option.MapFrom(d => d.InStock))
    );

    
}
