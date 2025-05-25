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

        public Image SelectedBackground => BackgroundManager.GetBackground(_currentIndex);

        public BackgroundSelectorForm()
        {
            InitializeComponent();
            this.ControlBox = false;

            _currentIndex = Properties.Settings.Default.Background;
            UpdatePreview();

            btnPrev.Click += (s, e) => {
                _currentIndex = (_currentIndex - 1 + BackgroundManager.BackgroundsCount) % BackgroundManager.BackgroundsCount;
                UpdatePreview();
            };

            btnNext.Click += (s, e) => {
                _currentIndex = (_currentIndex + 1) % BackgroundManager.BackgroundsCount;
                UpdatePreview();
            };
        }

        private void UpdatePreview()
        {
            picPreview.Image = SelectedBackground;
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
