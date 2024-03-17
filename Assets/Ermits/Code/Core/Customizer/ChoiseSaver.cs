namespace Core.Customizer
{
    public static class ChoiseSaver
    {
        public static string Save(ICarousel rootCarousel)
        {
            string result = string.Empty;

            result += rootCarousel.GetChoice().ToString();

            foreach (var item in rootCarousel.Items[rootCarousel.GetChoice()].Carousels) 
            {
                result += " " + item.GetChoice().ToString();
            }

            return result;
        }

        public static void Load(ICarousel rootCarousel, string file)
        {
            var literals = file.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

            void LoadByLiteral(string literal, ICarousel carousel)
            {
                int index = int.Parse(literal);

                carousel.SetChoice(index);
            }

            LoadByLiteral(literals[0], rootCarousel);

            for (int i = 1; i < literals.Length; i++)
            {
                LoadByLiteral(literals[i], rootCarousel.Items[rootCarousel.GetChoice()].Carousels[i - 1]);
            }
        }
    }
}