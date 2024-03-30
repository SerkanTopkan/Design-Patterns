record OnTheWayState : IOrderState
{
    public void Next(Order order)
    {
        order.State = new DeliveredState();
    }

    public void Previous(Order order)
    {
       order.State = new ProcessingState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is OnTheWayState");
    }
}