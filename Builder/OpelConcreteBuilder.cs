//ConcreteBuilder Class
public class OpelConcreteBuilder : IArabaBuilder
{
    public OpelConcreteBuilder()
    {
        araba = new Araba();
    }
    public override void SetKM() => araba.KM = 100;
    public override void SetMarka() => araba.Marka = "Opel";
    public override void SetModel() => araba.Model = "Astra";
    public override void SetVites() => araba.Vites = true;
}
//ConcreteBuilder Class
public class ToyotaConcreteBuilder : IArabaBuilder
{
    public ToyotaConcreteBuilder()
    {
        araba = new Araba();
    }
    public override void SetKM() => araba.KM = 150;
    public override void SetMarka() => araba.Marka = "Toyota";
    public override void SetModel() => araba.Model = "Corolla";
    public override void SetVites() => araba.Vites = true;
}
//ConcreteBuilder Class
public class BMWConcreteBuilder : IArabaBuilder
{
    public BMWConcreteBuilder()
    {
        araba = new Araba();
    }
    public override void SetKM() => araba.KM = 25;
    public override void SetMarka() => araba.Marka = "BMW";
    public override void SetModel() => araba.Model = "X Bilmem Kaç";
    public override void SetVites() => araba.Vites = true;
}