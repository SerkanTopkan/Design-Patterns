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

IAirplaneBuilder boingBuilder = new BoingConcreteBuilder();
AirplaneBuild build = new AirplaneBuild();
build.Build(boingBuilder);
Console.WriteLine(boingBuilder.Airplane.ToString());
 