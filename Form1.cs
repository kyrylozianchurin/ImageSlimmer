using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ImageEditorApp
{
    public partial class Form1 : MaterialForm // Main form of the application, inherits from MaterialForm.2
    {
        private List<Image> loadedImages = new List<Image>(); // List to store loaded images
        private int currentImageIndex = 0; // Index of the currently displayed image

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            var primary = Color.FromArgb(100, 104, 221);
            var accent = Color.FromArgb(255, 193, 7);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;  // Initialize MaterialSkin theme and color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue900,
                Accent.Blue700,
                TextShade.WHITE);
            comboBoxPosition.SelectedIndex = 0;  // Set default selection for watermark position
        }
        private void btnLoad_Click(object sender, EventArgs e)  // Load button click handler
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK) // Clear previously loaded images
                {
                    loadedImages.Clear();
                    foreach (string fileName in ofd.FileNames)
                    {
                        loadedImages.Add(Image.FromFile(fileName));
                    }
                    currentImageIndex = 0;
                    ShowImage();  // Display the first image
                }
            }
        }

        private void ShowImage()  // Displays the currently selected image in the PictureBox
        {
            if (loadedImages.Count > 0)
            {
                pictureBox1.Image = new Bitmap(loadedImages[currentImageIndex]);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)  // Apply button click handler
        {
            if (loadedImages.Count == 0)
                return;

            Image originalImage = loadedImages[currentImageIndex];
            int scale = trackBarScale.Value;
            string watermark = textBoxWatermark.Text;
            string position = comboBoxPosition.SelectedItem.ToString();

            int newWidth = originalImage.Width * scale / 100; // Calculate new dimensions
            int newHeight = originalImage.Height * scale / 100;

            Bitmap resized = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic; //  Scaling
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);

                if (!string.IsNullOrWhiteSpace(watermark))
                {
                    Font font = new Font("Arial", 40);
                    Brush brush = new SolidBrush(Color.FromArgb(128, Color.Red));
                    SizeF textSize = g.MeasureString(watermark, font); 
                    PointF location = position switch  // Determine watermark position
                    {
                        "Top-Left" => new PointF(10, 10),
                        "Top-Right" => new PointF(newWidth - textSize.Width - 10, 10),
                        "Bottom-Left" => new PointF(10, newHeight - textSize.Height - 10),
                        "Bottom-Right" => new PointF(newWidth - textSize.Width - 10, newHeight - textSize.Height - 10),
                        "Center" => new PointF((newWidth - textSize.Width) / 2, (newHeight - textSize.Height) / 2),
                        _ => new PointF(10, newHeight - textSize.Height - 10)
                    };
                    g.DrawString(watermark, font, brush, location);  // Draw watermark text on image
                }
            }

            pictureBox1.Image = resized;  // Display the edited image
        }

        private void btnSave_Click(object sender, EventArgs e)   // Save button click handler
        {
            if (pictureBox1.Image == null)
                return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName); // Save current image to selected path
                }
            }
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)  // TrackBar scroll handler – updates label with scale value and changes color
        {
            labelScale.Text = $"{trackBarScale.Value}%";

            if (trackBarScale.Value == 100)
            {
                labelScale.ForeColor = MaterialSkinManager.Instance.TextHighEmphasisColor;
            }
            else
            {
                labelScale.ForeColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e) // Form load event – sets colors for trackbar and picture box
        {
            trackBarScale.BackColor = MaterialSkinManager.Instance.BackgroundColor;
            pictureBox1.BackColor = SystemColors.Window;
        }

        private void trackBarScale_MouseMove(object sender, MouseEventArgs e) // Show current scale on mouse move over the trackbar
        {
            label100.Text = $"{trackBarScale.Value}%";
        }

        
    }
}

