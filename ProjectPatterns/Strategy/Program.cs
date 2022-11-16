using Strategy;

var context = new Context();
Console.WriteLine("Client: strategy is set to normal sort");
context.SetStrategy(new ConcreteStrategyA());
context.DoSomeBusinessLogic();
Console.WriteLine("Client: strategy is set to reverse sort");
context.SetStrategy(new ConcreteStrategyB());
context.DoSomeBusinessLogic();
