using System.Collections.Generic;
using System.Drawing;

public static class BackgroundManager
    {
        private static readonly List<Image> _backgrounds = new List<Image>
        {
            kursach.Properties.Resources.Background0,
            kursach.Properties.Resources.Background1,
            kursach.Properties.Resources.Background2,
            kursach.Properties.Resources.Background3,
            kursach.Properties.Resources.Background4
        };

        public static int BackgroundsCount => _backgrounds.Count;

        public static Image GetBackground(int index)
        {
            if (index >= 0 && index < _backgrounds.Count)
                return _backgrounds[index];
            return _backgrounds[0]; // Возвращаем фон по умолчанию
        }

        public static List<Image> GetAllBackgrounds() => new List<Image>(_backgrounds);
    
}