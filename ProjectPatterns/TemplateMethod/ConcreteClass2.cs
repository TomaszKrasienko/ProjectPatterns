namespace TemplateMethod;

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass2 says: Implemented operation1");
    }

    protected override void RequiredOperation2()
    {       
        Console.WriteLine("ConcreteClass2 says: Implemented operation2");
    }

    protected override void Hook1()
    {
        Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
    }
}