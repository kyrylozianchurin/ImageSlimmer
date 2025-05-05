using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;

namespace ImageEditorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSlider trackBarScale;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxWatermark;
        private MaterialSkin.Controls.MaterialButton btnLoad;
        private MaterialSkin.Controls.MaterialButton btnApply;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialComboBox comboBoxPosition;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel labelScale;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.trackBarScale = new MaterialSkin.Controls.MaterialSlider();
            this.textBoxWatermark = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLoad = new MaterialSkin.Controls.MaterialButton();
            this.btnApply = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label100 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.labelScale = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarScale
            // 
            this.trackBarScale.Depth = 0;
            this.trackBarScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBarScale.Location = new System.Drawing.Point(94, 403);
            this.trackBarScale.Margin = new System.Windows.Forms.Padding(10, 13, 13, 13);
            this.trackBarScale.MouseState = MaterialSkin.MouseState.HOVER;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Padding = new System.Windows.Forms.Padding(15);
            this.trackBarScale.RangeMin = 1;
            this.trackBarScale.ShowText = false;
            this.trackBarScale.ShowValue = false;
            this.trackBarScale.Size = new System.Drawing.Size(444, 40);
            this.trackBarScale.TabIndex = 1;
            this.trackBarScale.Text = "1";
            this.trackBarScale.Value = 80;
            this.trackBarScale.Click += new System.EventHandler(this.trackBarScale_Scroll);
            this.trackBarScale.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBarScale_MouseMove);
            // 
            // textBoxWatermark
            // 
            this.textBoxWatermark.AnimateReadOnly = false;
            this.textBoxWatermark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxWatermark.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxWatermark.Depth = 0;
            this.textBoxWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxWatermark.HideSelection = true;
            this.textBoxWatermark.Hint = "Watermark text";
            this.textBoxWatermark.LeadingIcon = null;
            this.textBoxWatermark.Location = new System.Drawing.Point(121, 515);
            this.textBoxWatermark.MaxLength = 32767;
            this.textBoxWatermark.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxWatermark.Name = "textBoxWatermark";
            this.textBoxWatermark.PasswordChar = '\0';
            this.textBoxWatermark.PrefixSuffixText = null;
            this.textBoxWatermark.ReadOnly = false;
            this.textBoxWatermark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxWatermark.SelectedText = "";
            this.textBoxWatermark.SelectionLength = 0;
            this.textBoxWatermark.SelectionStart = 0;
            this.textBoxWatermark.ShortcutsEnabled = true;
            this.textBoxWatermark.Size = new System.Drawing.Size(155, 48);
            this.textBoxWatermark.TabIndex = 3;
            this.textBoxWatermark.TabStop = false;
            this.textBoxWatermark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxWatermark.TrailingIcon = null;
            this.textBoxWatermark.UseSystemPasswordChar = false;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = false;
            this.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoad.Depth = 0;
            this.btnLoad.HighEmphasis = true;
            this.btnLoad.Icon = null;
            this.btnLoad.Location = new System.Drawing.Point(220, 357);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoad.Size = new System.Drawing.Size(200, 36);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "LOAD IMAGE";
            this.btnLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoad.UseAccentColor = false;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = false;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApply.Depth = 0;
            this.btnApply.HighEmphasis = true;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(173, 581);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApply.Size = new System.Drawing.Size(300, 36);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "APPLY CHANGES";
            this.btnApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApply.UseAccentColor = false;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(480, 630);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.AutoResize = false;
            this.comboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxPosition.Depth = 0;
            this.comboBoxPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxPosition.DropDownHeight = 174;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.DropDownWidth = 121;
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Hint = "Position";
            this.comboBoxPosition.IntegralHeight = false;
            this.comboBoxPosition.ItemHeight = 43;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Top-Left",
            "Top-Right",
            "Bottom-Left",
            "Bottom-Right",
            "Center"});
            this.comboBoxPosition.Location = new System.Drawing.Point(338, 514);
            this.comboBoxPosition.MaxDropDownItems = 4;
            this.comboBoxPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(200, 49);
            this.comboBoxPosition.StartIndex = 0;
            this.comboBoxPosition.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(261, 483);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "WATERMARK";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label100.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label100.Location = new System.Drawing.Point(297, 456);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(41, 19);
            this.label100.TabIndex = 10;
            this.label100.Text = "80%";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_1.Location = new System.Drawing.Point(63, 413);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(18, 19);
            this.label_1.TabIndex = 11;
            this.label_1.Text = "1";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Depth = 0;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelScale.Location = new System.Drawing.Point(280, 150);
            this.labelScale.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(100, 23);
            this.labelScale.TabIndex = 0;
            this.labelScale.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(554, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 76);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(592, 269);
            this.materialCard1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 680);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.trackBarScale);
            this.Controls.Add(this.textBoxWatermark);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(620, 680);
            this.MinimumSize = new System.Drawing.Size(620, 680);
            this.Name = "Form1";
            this.Text = "Image Slimmer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label label100;
        private Label label_1;
        private Label label2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
