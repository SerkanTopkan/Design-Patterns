//Director Class
public class AirplaneBuild
{
    public void Build(IAirplaneBuilder airplane)
    {
        airplane.SetKnot();
        airplane.SetCompany();
        airplane.SetModel();
        airplane.SetKnot();
    }
}