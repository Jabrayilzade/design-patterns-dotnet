namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class MultiFunctionDevice : IMultiFunctionDevice
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;
        private readonly IFax _fax;

        public MultiFunctionDevice(IPrinter printer, IScanner scanner, IFax fax)
        {
            _printer = printer;
            _scanner = scanner;
            _fax = fax;
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Fax(Document document)
        {
            _fax.Fax(document);
        }
    }
}