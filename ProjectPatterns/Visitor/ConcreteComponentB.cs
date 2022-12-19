namespace Visitor;

public class ConcreteComponentB : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentB(this);
    }

    public string ExclusiveMethodOfConcreteB()
    {
        return "B";
    }
}