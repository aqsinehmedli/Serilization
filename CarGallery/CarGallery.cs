using Newtonsoft.Json;
using System.Text;
namespace Serialization.CarGallery;

public class CarGallery
{
    public string Name { get; set; }
    public List<Car> cars { get; set; }

    public CarGallery()
    {
        
    }

    public CarGallery(string name, List<Car> cars)
    {
        Name = name;
        this.cars = cars;
    }

    public override string ToString()
    {
        return $"CarGallery Name: {Name}, Cars: {string.Join(", ", cars)}";
    }
    public void AddCar(Car car)
    {

        List<Car> cars = new List<Car>();


        var stringData = File.ReadAllText("carNewtonSoftJson.json");
        cars = JsonConvert.DeserializeObject<List<Car>>(stringData) ?? new List<Car>();

        cars.Add(car);
        //foreach (var item in cars)
        //{
        //    Console.WriteLine(car);
        //}
        var jsonString = JsonConvert.SerializeObject(car, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("carNewtonSoftJson.json", jsonString);
    }


    public void RemoveCar(Car car)
    {
        List<Car> cars = new List<Car>();


        var stringData = File.ReadAllText("carNewtonSoftJson.json");
        cars = JsonConvert.DeserializeObject<List<Car>>(stringData) ?? new List<Car>();

        cars.Remove(car);
        //foreach (var item in cars)
        //{
        //    Console.WriteLine(car);
        //}
        var jsonString = JsonConvert.SerializeObject(car, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("carNewtonSoftJson.json", jsonString);
    }
    public void GetAllCar()
    {
        foreach (Car item in cars)
        {
            Console.WriteLine(item);
        }
    }
}
