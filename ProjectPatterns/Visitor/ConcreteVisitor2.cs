namespace Visitor;

public class ConcreteVisitor2 : IVisitor 
{ 
    public void VisitConcreteComponentA(ConcreteComponentA concreteComponentA) 
    { 
        Console.WriteLine(concreteComponentA.ExclusiveMethodOfConcrete() + "Concrete visitor 2");
    }
    public void VisitConcreteComponentB(ConcreteComponentB concreteComponentB)
    { 
        Console.WriteLine(concreteComponentB.ExclusiveMethodOfConcreteB() + "Concrete visitor 2");
    }
}
