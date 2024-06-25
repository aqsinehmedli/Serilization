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
    public override string ToString() =>
        $"{Name} - {cars}";
    public void AddCar(Car car)
    {

            var jsonString = JsonConvert.SerializeObject(car, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("carNewtonSoftJson.json", jsonString);

        

    }


}
