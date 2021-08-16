using System;

namespace SolidPrinciples.OpenClosedPrinciple
{
    public class MixSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _size;
        private readonly ISpecification<T> _color;

        public MixSpecification(ISpecification<T> size, ISpecification<T> color)
        {
            _size = size ?? throw new ArgumentNullException();
            _color = color ?? throw new ArgumentNullException();
        }

        public bool IsSatisfied(T t)
        {
            return _color.IsSatisfied(t) && _size.IsSatisfied(t);
        }
    }
}