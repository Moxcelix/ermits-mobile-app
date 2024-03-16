using System.Collections.Generic;

namespace Core.Customizer
{
    public interface IItem
    {
        public List<ICarousel> Carousels { get; } 
    }
}