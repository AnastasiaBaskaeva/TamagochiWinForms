using System.Drawing;
using System.Windows.Forms;

public class PurpleButton : Button
{
    private readonly Color normalColor = Color.Transparent;
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

        // Для кнопки "В меню" можно добавить особые настройки
        if (this.Text == "←")
        {
            this.FlatAppearance.BorderSize = 2;
            this.Font = new Font("Wingdings", 12, FontStyle.Bold);
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Дополнительная отрисовка (если нужна)
        if (this.Focused && this.ShowFocusCues)
        {
            var rect = new Rectangle(1, 1, this.Width - 3, this.Height - 3);
            ControlPaint.DrawFocusRectangle(pevent.Graphics, rect);
        }
    }
}