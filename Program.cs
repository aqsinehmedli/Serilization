using Serialization.CarGallery;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
//void XmlWrite()
//{
//    List<Car> cars = new List<Car>()
//        {
//            new Car{Model="Priora",Marka= "Lada",Year = 2013},
//            new Car{Model="2107",Marka= "Lada",Year = 2011},
//            new Car{Model="2106",Marka= "Lada",Year = 1999},
//        };
//    List<Car> cars3 = new List<Car>()
//        {
//            new Car{Model="Mercedes",Marka= "Benz",Year = 2013},
//            new Car{Model="Ford",Marka= "Fushion",Year = 2011},
//        };
//    List<CarGallery> carGallery = new List<CarGallery>()
//    {
//        new CarGallery{Name = "Cars1",cars=cars},

//    };
//    using var writer = new XmlTextWriter("carGallery.xml", Encoding.Default);
//    writer.Formatting = Formatting.Indented;

//    writer.WriteStartDocument();
//    writer.WriteStartElement("carGallerys");
//    foreach (var carG in carGallery)
//    {

//        writer.WriteStartElement("carGalery");
//        writer.WriteStartElement("Car");

//        writer.WriteElementString(nameof(carG.Name), carG.Name);
//        foreach (var car1 in cars)
//        {
//            writer.WriteStartElement("Car");
//            writer.WriteElementString(nameof(car1.Marka), car1.Marka);
//            writer.WriteElementString(nameof(car1.Model), car1.Model);
//            writer.WriteElementString(nameof(car1.Year), car1.Year.ToString());
//            writer.WriteEndElement();

//        }
//    }

//    writer.WriteEndElement();
//    writer.WriteEndDocument();
////}

//void XmlRead()
//{
//    XmlDocument doc = new XmlDocument();
//    doc.Load("carGallery.xml");

//    var root = doc.DocumentElement;
//    foreach (XmlNode node in root.ChildNodes)
//    {
//        var carGallery = new CarGallery()
//        {
//            Name = node.SelectSingleNode(nameof(CarGallery.Name)).InnerText,
//        };
//        Console.WriteLine(carGallery);
//    }

//}
//XmlWrite();
////XmlRead();
///


List<Car> cars = new List<Car>()
{
    new Car{Id = 1,Model="Mercedes",Marka= "Benz",Year = 2013},
    new Car{Id = 2,Model="Ford",Marka= "Fushion",Year = 2011},
};
Car car1 = new Car(3, "Tayota", "Prado", 2012);
CarGallery carGallery = new CarGallery("MercedesShop", cars);

//foreach (Car car in cars3)
//{
//    Console.WriteLine(car);
//}

//carGallery.AddCar(car1);

carGallery.GetAllCar();