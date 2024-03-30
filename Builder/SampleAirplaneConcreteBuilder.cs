//ConcreteBuilder Class
public class BoingConcreteBuilder : IAirplaneBuilder
{
    public BoingConcreteBuilder()
    {
        airplane = new Airplane();
    }
    public override void SetKnot() => airplane.Knot = 2;
    public override void SetCompany() => airplane.Company = "Boing";
    public override void SetModel() => airplane.Model = "757";
    public override void SetIsWarrior() => airplane.IsWarrior = false;
}
//ConcreteBuilder Class
public class F16ConcreteBuilder : IAirplaneBuilder
{
    public F16ConcreteBuilder()
    {
        airplane = new Airplane();
    }
   public override void SetKnot() => airplane.Knot = 2;
    public override void SetCompany() => airplane.Company = "General Dynamics";
    public override void SetModel() => airplane.Model = "F16";
    public override void SetIsWarrior() => airplane.IsWarrior = true;
}
