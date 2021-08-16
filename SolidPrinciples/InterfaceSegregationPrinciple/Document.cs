namespace SolidPrinciples.InterfaceSegregationPrinciple
{
// ----- Interface Segregation Principle    
// In the field of software engineering, the interface-segregation principle (ISP) states that no client should be
// forced to depend on methods it does not use.
    public interface IScanner
    {
        void Scan(Document document);
    }

    public interface IPrinter
    {
        void Print(Document document);
    }

    public interface IFax
    {
        void Fax(Document document);
    }

    public interface IMultiFunctionDevice : IScanner, IPrinter, IFax
    {
    }

    public interface IOlFashionedMachine : IScanner, IPrinter
    {
    }

    public class Document
    {
    }
}