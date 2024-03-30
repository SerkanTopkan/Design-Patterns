record ProcessingState : IOrderState
{
    public void Previous(Order order)
    {
         order.State = new NewOrderState();
    }

    public void Next(Order order)
    {
        order.State = new OnTheWayState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is ProcessingState");
    }
}