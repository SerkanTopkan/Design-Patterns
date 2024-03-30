public class Airplane
{
    public string Company { get; set; }
    public string Model { get; set; }
    public double Knot  { get; set; }
    public bool IsWarrior { get; set; }
    public override string ToString()
    {
        return $"{Company} marka, {Model} model, {Knot} hızın da bir Savaş kabiliyeti {IsWarrior} olan uçak   üretilmiştir.";
    }
}