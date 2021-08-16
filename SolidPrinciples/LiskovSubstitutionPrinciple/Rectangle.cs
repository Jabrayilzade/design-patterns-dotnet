namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
// ------ Liskov Substitution Principle -------
// The Liskov Substitution Principle (LSP) states that an instance of a child class must replace an instance of the
// parent class without affecting the results that we would get from an instance of the base class itself.
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        protected Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}