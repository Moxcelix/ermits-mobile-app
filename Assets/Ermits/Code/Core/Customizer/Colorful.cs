namespace Core.Customizer
{
    public class Colorful
    {
        private readonly Colored[] _coloreds;

        public Colored[] Coloreds => _coloreds;

        public Colorful(int count)
        {
            _coloreds = new Colored[count];
        }
    }
}