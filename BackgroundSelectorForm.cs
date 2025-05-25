using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class BackgroundSelectorForm : Form
    {
        private int _currentIndex = 0;
        private readonly List<Image> _backgrounds;

        public Image SelectedBackground => _backgrounds[_currentIndex];

        public BackgroundSelectorForm()
        {
            InitializeComponent();
            this.ControlBox = false;

            // Загрузка фонов
            _backgrounds = new List<Image>
        {
            Properties.Resources.Background0,
            Properties.Resources.Background1,
            Properties.Resources.Background2
        };
            _currentIndex = Properties.Settings.Default.Background;
            UpdatePreview();

            // Обработчики событий
            btnPrev.Click += (s, e) => {
                _currentIndex = (_currentIndex - 1 + _backgrounds.Count) % _backgrounds.Count;
                UpdatePreview();
            };

            btnNext.Click += (s, e) => {
                _currentIndex = (_currentIndex + 1) % _backgrounds.Count;
                UpdatePreview();
            };

            btnApply.Click += (s, e) => {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

        private void UpdatePreview()
        {
            picPreview.Image = _backgrounds[_currentIndex];
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Background = _currentIndex;
            Properties.Settings.Default.Save(); // Важно: не забываем сохранять!
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
