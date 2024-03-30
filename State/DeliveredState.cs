record DeliveredState : IOrderState
{
    public void Next(Order order)
    {
        Console.WriteLine("Order is Finished");
    }

    public void Previous(Order order)
    {
         order.State = new OnTheWayState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is DeliveredState");
    }
}