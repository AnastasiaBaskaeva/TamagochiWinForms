using System;
using System.Drawing;
using System.Windows.Forms;

namespace kursach
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            btnContinue.Enabled = Properties.Settings.Default.Life; // проверка сохранений

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Point menuLocation = this.Location;

            this.Hide();
            using (tamagochi gameForm = new tamagochi())
            {
                gameForm.StartPosition = FormStartPosition.Manual;
                gameForm.Location = menuLocation;
                gameForm.ShowDialog();
            }
            this.Show();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = menuLocation;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            DialogResult result = (MessageBox.Show("Начать новую игру? Текущий прогресс будет потерян.",
                                           "Новая игра",
                                           MessageBoxButtons.YesNo));

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                this.Hide();
                using (tamagochi gameForm = new tamagochi())
                {
                    gameForm.StartPosition = FormStartPosition.Manual;
                    gameForm.Location = this.Location;
                    gameForm.ShowDialog();
                }
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SoundManager.Dispose();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SoundManager.Initialize();
        }
    }
}
