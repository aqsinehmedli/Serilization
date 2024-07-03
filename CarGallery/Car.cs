namespace Serialization.CarGallery;

public class Car
{

    public int Id { get; set; }
    public string Model { get; set; }
    public string Marka { get; set; }
    public int Year { get; set; }
    public Car(int id, string model, string marka, int year)
    {
        Id = id;
        Model = model;
        Marka = marka;
        Year = year;
    }
    public Car()
    {
        
    }
    public override string ToString() =>
        $"{Id} - {Model} - {Marka} - {Year}";

}
