namespace TemplateMethod;

public class Client
{
    public static void ClientCode(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}