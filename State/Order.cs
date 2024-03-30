public class Order {


    public IOrderState State { get; set; }

    public Order()
    {
        State = new NewOrderState();
    }

    public void NextState(){
        State.Next(this);

    }

    public void PreviousState(){State.Previous(this);}

    public void PrintStatus(){

        State.PrintStatus();
    }
}
