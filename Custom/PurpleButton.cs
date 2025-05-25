using System.Drawing;
using System.Windows.Forms;

public class PurpleButton : Button
{
    private readonly Color normalColor = Color.FromArgb(221, 160, 221);
    private readonly Color hoverColor = Color.FromArgb(255, 200, 220);
    private readonly Color textColor = Color.FromArgb(128, 0, 128);
    private readonly Color borderColor = Color.FromArgb(150, 100, 200);

    public PurpleButton()
    {
        // Базовые настройки
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 1;
        this.ForeColor = textColor;
        this.BackColor = normalColor;
        this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        this.Cursor = Cursors.Hand;

        // Настройки рамки
        this.FlatAppearance.BorderColor = borderColor;

        // Обработчики событий
        this.MouseEnter += (s, e) => this.BackColor = hoverColor;
        this.MouseLeave += (s, e) => this.BackColor = normalColor;

        this.Click += (s, e) => SoundManager.PlayButtonClick();
    }

}