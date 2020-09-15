using System;
using System.Drawing;
using System.Windows.Forms;

namespace color_spaces
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        
        private void HandleButtonClick(object sender, EventArgs eventArgs)
        {
            var imageDialog = new OpenFileDialog
            {
                Title = "Выберите картинку",
                Filter = "Image Files(*.PNG;*.JPG;)|*.PNG;*.JPG;",
                InitialDirectory = @"C:\"
            };

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                var chosenImage = Image.FromFile(imageDialog.FileName);
                originalImage.Image = chosenImage;
                var grayscaleConverter = new GrayscaleConverter(chosenImage as Bitmap);
                grayscaleConverter.ConvertToGrayscale();
                PalImage.Image = grayscaleConverter.GetPalBitmap();
                HdTvImage.Image = grayscaleConverter.GetHdTvBitmap();
                diffImage.Image = grayscaleConverter.GetDiffBitmap();
                palChart.Series[0].Points.DataBindY(grayscaleConverter.GetPalIntensity());
                hdtvChart.Series[0].Points.DataBindY(grayscaleConverter.GetHdTvIntensity());
            }
        }

    }
}
