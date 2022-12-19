namespace Visitor;

public interface IVisitor
{
    void VisitConcreteComponentA(ConcreteComponentA concreteComponentA);
    void VisitConcreteComponentB(ConcreteComponentB concreteComponentB);
}