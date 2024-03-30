/*

Yeni Sipariş
İşleniyor
Gönderimde
Teslim Edildi

*/

///State 
Order productOrder = new Order();
productOrder.PrintStatus();


productOrder.NextState();
productOrder.PrintStatus();

productOrder.NextState();
productOrder.PrintStatus();

productOrder.NextState();
productOrder.PrintStatus();

productOrder.NextState();
productOrder.PrintStatus();

///Builder

IArabaBuilder araba = new ToyotaConcreteBuilder();
ArabaUret uret = new ArabaUret();
uret.Uret(araba);
Console.WriteLine(araba.Araba.ToString());
 