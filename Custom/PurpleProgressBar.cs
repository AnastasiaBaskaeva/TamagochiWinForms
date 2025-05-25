using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace kursach
{
    public class PurpleProgressBar : ProgressBar
    {
        public PurpleProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(1, 20); // Запрещаем нулевую ширину
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Проверяем допустимые размеры
            if (this.Width <= 0 || this.Height <= 0)
                return;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Фон
            using (var bgBrush = new SolidBrush(Color.FromArgb(240, 240, 250)))
                e.Graphics.FillRectangle(bgBrush, rect);

            // Прогресс (только если есть значение)
            if (this.Value > 0 && this.Maximum > 0)
            {
                // Гарантируем минимальную ширину = 1 пиксель
                int progressWidth = Math.Max(1, (int)(rect.Width * ((double)this.Value / this.Maximum)));

                Rectangle progressRect = new Rectangle(0, 0, progressWidth, rect.Height);

                // Проверяем, что прямоугольник прогресса валиден
                if (progressRect.Width > 0 && progressRect.Height > 0)
                {
                    using (var progressBrush = new LinearGradientBrush(
                        progressRect,
                        Color.FromArgb(150, 100, 200),
                        Color.FromArgb(180, 140, 220),
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(progressBrush, progressRect);
                    }
                }
            }

            // Рамка
            using (var borderPen = new Pen(Color.FromArgb(100, 50, 150), 1))
                e.Graphics.DrawRectangle(borderPen, 0, 0, rect.Width - 1, rect.Height - 1);
        }
    }
}