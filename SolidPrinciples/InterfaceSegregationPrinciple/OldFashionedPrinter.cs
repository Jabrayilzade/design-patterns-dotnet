namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IOlFashionedMachine
    {
        private readonly IScanner _scanner;
        private readonly IPrinter _printer;

        public OldFashionedPrinter(IScanner scanner, IPrinter printer)
        {
            _scanner = scanner;
            _printer = printer;
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        } // decorator
    }
}