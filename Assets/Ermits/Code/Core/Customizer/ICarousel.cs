using System.Collections.Generic;

namespace Core.Customizer
{
    public interface ICarousel
    {
        public List<IItem> Items { get; }

        public void Next();

        public void Prev();
    }

}