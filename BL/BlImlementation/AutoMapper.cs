using AutoMapper;
namespace BlImlementation;

public class BLAutoMapper
{
    //Ignore()
    //??
    //isn't it possible to put there default values???
    public static  MapperConfiguration OredrMappingConfiguration = new MapperConfiguration(cnf =>
    cnf.CreateMap<BO.Order, DO.Order>()
    .ForMember(b => b.ID, option => option.MapFrom(d => d.id))
    .ForMember(b => b.ShipDate, option => option.MapFrom(d => d.DeleveryDate))
    .ReverseMap()
    .ForMember(b => b.id, option => option.MapFrom(d => d.ID))
    .ForMember(b => b.DeleveryDate, option => option.MapFrom(d => d.ShipDate))
    .ForMember(b => b.TotalPrice, option => option.Ignore())
    );

    public static  MapperConfiguration OredrItemMappingConfiguration = new MapperConfiguration(cnf =>
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


    public static MapperConfiguration ProductMappingConfiguration = new MapperConfiguration(cnf =>
    cnf.CreateMap<BO.Product, DO.Product>()
     .ReverseMap()   
    );

    
}
