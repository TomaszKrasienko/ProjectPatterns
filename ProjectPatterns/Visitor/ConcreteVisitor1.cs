using System.Runtime.CompilerServices;

namespace Visitor;

public class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteComponentA concreteComponentA)
    {
        Console.WriteLine(concreteComponentA.ExclusiveMethodOfConcrete() + "Concrete visitor 1");
    }

    public void VisitConcreteComponentB(ConcreteComponentB concreteComponentB)
    {
        Console.WriteLine(concreteComponentB.ExclusiveMethodOfConcreteB() + "Concrete visitor 1");
    }
}