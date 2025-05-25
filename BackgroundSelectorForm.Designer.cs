using System.Drawing;
using System.Windows.Forms;

namespace kursach
{
    partial class BackgroundSelectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundSelectorForm));
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.imageListBackgrounds = new System.Windows.Forms.ImageList(this.components);
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new PurpleButton();
            this.btnNext = new PurpleButton();
            this.btnPrev = new PurpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Image = global::kursach.Properties.Resources.Background1;
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(703, 387);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // imageListBackgrounds
            // 
            this.imageListBackgrounds.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBackgrounds.ImageStream")));
            this.imageListBackgrounds.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBackgrounds.Images.SetKeyName(0, "room0.png");
            this.imageListBackgrounds.Images.SetKeyName(1, "room1.png");
            this.imageListBackgrounds.Images.SetKeyName(2, "room2.png");
            // 
            // panel
            // 
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.panel.Controls.Add(this.btnApply, 1, 0);
            this.panel.Controls.Add(this.btnNext, 2, 0);
            this.panel.Controls.Add(this.btnPrev, 0, 0);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 387);
            this.panel.Name = "panel";
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel.Size = new System.Drawing.Size(703, 50);
            this.panel.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnApply.Location = new System.Drawing.Point(332, 7);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(39, 35);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "✓";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnNext.Location = new System.Drawing.Point(520, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "→";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnPrev.Location = new System.Drawing.Point(145, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrev.Size = new System.Drawing.Size(38, 35);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "←";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // BackgroundSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(703, 437);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.panel);
            this.Name = "BackgroundSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tamagochi";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ImageList imageListBackgrounds;
        private PurpleButton btnNext;
        private PurpleButton btnPrev;
        private PurpleButton btnApply;
        private TableLayoutPanel panel;
    }
}