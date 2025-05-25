using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class tamagochi : Form
    {
        int sleep = 0;
        int life = 1;
        public tamagochi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размера
            this.ControlBox = false;
            pictureBox.Image = imageList1.Images[0]; //начальный спрайт

        }

        private void btnFeed_Click(object sender, EventArgs e) //кормить
        {
            if (life != 0)
            {
                //sleep = 0;
                pictureBox.Image = imageList1.Images[1];
                if (progressHungry.Value > progressHungry.Minimum + 200)
                    progressHungry.Value -= 200;
                else progressHungry.Value = 0;
            }

        }

        private void btnSleep_Click(object sender, EventArgs e) //спать
        {
            if (life != 0)
            {
                pictureBox.Image = imageList1.Images[3];
                sleep = 1;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e) //играть
        {
            if (life != 0)
            {
                sleep = 0;

                pictureBox.Image = imageList1.Images[5];
                if (progressHappiness.Value < progressHappiness.Maximum - 200)
                {
                    progressHappiness.Value += 200;
                    if (progressTired.Value < progressTired.Maximum - 200) progressTired.Value += 150;

                }
                else progressHappiness.Value = progressHappiness.Maximum;
            }
        }

        private void btnWakeUp_Click(object sender, EventArgs e) //разбудить
        {
            if (life != 0)
            {
                pictureBox.Image = imageList1.Images[0];
                sleep = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressHungry.Value < progressHungry.Maximum)
                progressHungry.Value++; //голод++
            if (sleep == 1) //состояние сон
            {
                if (progressTired.Value > progressTired.Minimum + 10)
                {
                    progressTired.Value -= 10;

                }
                else
                {
                    progressTired.Value = progressTired.Minimum; //просыпается сам когда усталость на нуле
                    pictureBox.Image = imageList1.Images[0];
                    sleep = 0;//состояние проснулся
                }
            }
            else
            {
                if (progressTired.Value < progressTired.Maximum)
                    progressTired.Value++;//усталость накапливаем
            }
            if (progressHappiness.Value > progressHappiness.Minimum)   //реализация смерти
                progressHappiness.Value--; //счастье--
            if (progressHungry.Value == progressHungry.Maximum && sleep == 0)
                pictureBox.Image = imageList1.Images[8];
            if (progressTired.Value == progressTired.Maximum && sleep == 0)
                pictureBox.Image = imageList1.Images[4];
            if (progressHappiness.Value == progressHappiness.Minimum && sleep == 0)
                pictureBox.Image = imageList1.Images[2];
            if (progressHungry.Value == progressHungry.Maximum && progressTired.Value == progressTired.Maximum && progressHappiness.Value == progressHappiness.Minimum)
            {
                life = 0;
                pictureBox.Image = imageList1.Images[9];
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sleep == 0 && progressHungry.Value != progressHungry.Maximum && progressTired.Value != progressTired.Maximum && progressHappiness.Value != progressHappiness.Minimum && life != 0)
                pictureBox.Image = imageList1.Images[0]; //меняет спрайт на нейтральный после того как покормили/поиграли
        }


        private void tamagochi_Load(object sender, EventArgs e)
        {
            // Загружаем сохраненные значения
            progressHungry.Value = Properties.Settings.Default.Hunger;
            progressTired.Value = Properties.Settings.Default.Tired;
            progressHappiness.Value = Properties.Settings.Default.Happiness;
            sleep = Properties.Settings.Default.IsSleeping ? 1 : 0;
            life = Properties.Settings.Default.Life ? 1 : 0;

            // Восстанавливаем визуальное состояние
            if (Properties.Settings.Default.IsSleeping)
                pictureBox.Image = imageList1.Images[3];
            else if (!Properties.Settings.Default.Life)
                pictureBox.Image = imageList1.Images[9];
            else pictureBox.Image = imageList1.Images[0];
        }

        private void tamagochi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем текущее состояние
            Properties.Settings.Default.Hunger = progressHungry.Value;
            Properties.Settings.Default.Tired = progressTired.Value;
            Properties.Settings.Default.Happiness = progressHappiness.Value;
            Properties.Settings.Default.IsSleeping = sleep == 1;
            Properties.Settings.Default.Life = life == 1;

            // Обязательно вызываем Save()
            Properties.Settings.Default.Save();
        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
