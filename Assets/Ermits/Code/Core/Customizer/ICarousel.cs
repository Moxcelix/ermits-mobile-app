using System.Collections.Generic;

namespace Core.Customizer
{
    public interface ICarousel
    {
        public List<IItem> Items { get; }

        public string Title { get; }

        public void Next();

        public void Prev();

        public int GetChoice();

        public void SetChoice(int choice);
    }

}