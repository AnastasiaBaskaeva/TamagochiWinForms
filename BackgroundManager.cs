using System.Collections.Generic;
using System.Drawing;

namespace kursach
{
    public static class BackgroundManager
    {
        private static readonly List<Image> _backgrounds = new List<Image>
        {
            Properties.Resources.Background0,
            Properties.Resources.Background1,
            Properties.Resources.Background2,
            Properties.Resources.Background3,
            Properties.Resources.Background4
            // Добавляйте новые фоны здесь
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
}