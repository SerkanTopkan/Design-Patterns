public interface IOrderState{

    void Next(Order order);

    void Previous (Order order);

    void PrintStatus();

}