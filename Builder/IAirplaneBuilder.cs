//Builder
public abstract class IAirplaneBuilder
{
    protected Airplane airplane;
    public Airplane Airplane
    {
        get { return airplane; }
    }
 
    public abstract void SetCompany();
    public abstract void SetModel();
    public abstract void SetKnot();
    public abstract void SetIsWarrior();
}