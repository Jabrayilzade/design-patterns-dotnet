namespace SolidPrinciples.OpenClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == _color;
        }
    }
}