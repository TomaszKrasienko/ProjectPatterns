namespace Visitor;

public class ConcreteComponentA : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }
    public string ExclusiveMethodOfConcrete()
    {
        return "A";
    }
}