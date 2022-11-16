namespace Strategy;

public class Context
{
    private IStrategy _strategy;

    public Context() { }
    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void DoSomeBusinessLogic()
    {
        Console.WriteLine("Context: Sorting data using the strategy");
        var result = _strategy.DoAlgorithm(new List<string> {"a", "b", "c", "d", "e"});
        string resultStr = String.Empty;
        foreach (var item in result as List<string>)
        {
            resultStr += item + ", ";
        }
        Console.WriteLine(resultStr);
    }
}