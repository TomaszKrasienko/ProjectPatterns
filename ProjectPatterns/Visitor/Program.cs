// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Visitor;

List<IComponent> components = new List<IComponent>()
{
    new ConcreteComponentA(),
    new ConcreteComponentB() 
};
var visitor1 = new ConcreteVisitor1();
Console.WriteLine("The client works with all visitors via the base Visitor interface");
Client.ClientCode(components, visitor1);

Console.WriteLine();

var visitor2 = new ConcreteVisitor2();
Console.WriteLine("The client works with all visitors via the base Visitor interface");
Client.ClientCode(components, visitor2);