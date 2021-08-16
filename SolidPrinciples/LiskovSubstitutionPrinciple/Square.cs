namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        public int Side
        {
            set => Width = Height = value;
        }
    }
}