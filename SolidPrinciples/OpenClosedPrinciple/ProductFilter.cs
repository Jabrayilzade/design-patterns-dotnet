using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.OpenClosedPrinciple
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
        {
            return products.Where(specification.IsSatisfied);
        }
    }
}