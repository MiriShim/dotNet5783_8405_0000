// See https://aka.ms/new-console-template for more information
using BlApi;

using InputLibrary;

Console.ReadLine();


IBL bl = new BlImlementation.BL();

BO.Order order = new BO.Order() { Status =BO.OrderStatus.Recived,CastumerAdress="aaaaaaaa",CustomerEmail="dsdsdsd",CustomerName="Tamara"};
BO.Product  product = new BO.Product () {   Price=99.99,InStock=99,category=BO.Category.Nails ,Name="Geranume"};


bl.Product .Add(product  );

//Input.ReadInt("Input OK");

bl.Product .GetAll().ToList().ForEach(o=>Console.WriteLine(o));



