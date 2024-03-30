record NewOrderState : IOrderState
{
    public void Previous(Order order)
    {
        Console.WriteLine("This is the initial state");
    }

    public void Next(Order order)
    {
        order.State = new ProcessingState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is NewOrderState");
    }
}