namespace SolidPrinciples.OpenClosedPrinciple
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Size == _size;
        }
    }
}