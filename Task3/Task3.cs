using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_spaces
{
    public partial class Task3 : Form
    {

        string selectedFileName = "";
        List<double[,]> HSVValues;
        Bitmap srcImage, resImage;
        int HTrack, STrack, VTrack;

        List<double[,]> GetHSV(Image source)
        {

            Bitmap sourceBitmap = new Bitmap(source);


            double[,] HBitmap = new double[sourceBitmap.Width, sourceBitmap.Height];
            double[,] SBitmap = new double[sourceBitmap.Width, sourceBitmap.Height];
            double[,] VBitmap = new double[sourceBitmap.Width, sourceBitmap.Height];

            for (int x = 0; x < sourceBitmap.Width; x++)
            {
                for (int y = 0; y < sourceBitmap.Height; y++)
                {
                    Color color = sourceBitmap.GetPixel(x, y);

                    double cMin = Math.Min(color.R, Math.Min(color.G, color.B));
                    double cMax = Math.Max(color.R, Math.Max(color.G, color.B));

                    // Пиксели результирующих картинок R,G,B
                    if (cMax == cMin)
                    {
                        HBitmap[x, y] = 0;
                    }
                    else
                    {
                        if (cMax == color.R)
                        {
                            HBitmap[x, y] = 60 * (color.G - color.B) / (cMax - cMin);
                            if (color.G < color.B)
                                HBitmap[x, y] += 360;
                        }
                        else if (cMax == color.G)
                        {
                            HBitmap[x, y] = 60 * (color.B - color.R) / (cMax - cMin) + 120;
                        }
                        else if (cMax == color.B)
                        {
                            HBitmap[x, y] = 60 * (color.R - color.G) / (cMax - cMin) + 240;
                        }
                    }
                    

                    
                    if (cMax == 0)
                    {
                        SBitmap[x, y] = 0;
                    }
                    else
                    {
                        SBitmap[x, y] = 1 - cMin/cMax;
                    }
                    
                    VBitmap[x, y] = cMax / 255;
                    

                }
            }

            sourceBitmap.Dispose();

            return new List<double[,]> { HBitmap, SBitmap, VBitmap };
        }

        Bitmap GetRGB(List<double[,]> HSVValues)
        {
            double[,] HBitmap = HSVValues[0];
            double[,] SBitmap = HSVValues[1];
            double[,] VBitmap = HSVValues[2];
            int width = HBitmap.GetLength(0);
            int height = HBitmap.GetLength(1);

            Bitmap resBitmap = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int H = (int)HBitmap[x, y];
                    int Hi = (int)Math.Floor(HBitmap[x, y] / 60) % 6;
                    int Vmin = (int)Math.Floor((1 - SBitmap[x, y]) * VBitmap[x, y] * 100);
                    int V = (int)Math.Floor(100 * VBitmap[x, y]);
                    int a = (V - Vmin) * (H % 60) / 60;
                    int Vinc = Vmin + a;
                    int Vdec = V - a;
                    int R = 0, G = 0, B = 0;
                    switch (Hi)
                    {
                        case 0:
                            R = V;
                            G = Vinc;
                            B = Vmin;
                            break;
                        case 1:
                            R = Vdec;
                            G = V;
                            B = Vmin;
                            break;
                        case 2:
                            R = Vmin;
                            G = V;
                            B = Vinc;
                            break;
                        case 3:
                            R = Vmin;
                            G = Vdec;
                            B = V;
                            break;
                        case 4:
                            R = Vinc;
                            G = Vmin;
                            B = V;
                            break;
                        case 5:
                            R = V;
                            G = Vmin;
                            B = Vdec;
                            break;
                    }
                    R = (int)(R * 255.0 / 100);
                    G = (int)(G * 255.0 / 100);
                    B = (int)(B * 255.0 / 100);
                    resBitmap.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            return resBitmap;
        }

        void setTrackBars(List<double[,]> HSVValues)
        {
            double[,] HBitmap = HSVValues[0];
            double[,] SBitmap = HSVValues[1];
            double[,] VBitmap = HSVValues[2];

            int pxCount = HSVValues[0].Length;
            double medianH = 0, medianS = 0, medianV = 0;

            int width = HBitmap.GetLength(0);
            int height = HBitmap.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    medianH += HBitmap[x, y];
                    medianS += SBitmap[x, y];
                    medianV += VBitmap[x, y];
                }
            }

            HTrack = (int)(medianH / pxCount);
            STrack = (int)(medianS / pxCount * 100);
            VTrack = (int)(medianV / pxCount * 100);

            hueTrackBar.Value = HTrack;
            saturationTrackBar.Value = STrack;
            valueTrackBar.Value = VTrack;
        }

        private void sourcePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (selectedFileName != "")
            {
                e.Graphics.DrawImage(srcImage, 0, 0);
            }
            
        }

        private void resultPictureBox_Paint(object sender, PaintEventArgs e)
        {

            if (selectedFileName != "")
            {
                Bitmap i = new Bitmap(new Bitmap(selectedFileName), resultPictureBox.Size);
                e.Graphics.DrawImage(resImage, 0, 0);
            }

        }


        public Task3()
        {
            InitializeComponent();
            sourcePictureBox.Paint += sourcePictureBox_Paint;
            resultPictureBox.Paint += resultPictureBox_Paint;
        }

        private void modifyResult()
        {
            int deltaH = hueTrackBar.Value - HTrack;
            double deltaS = (saturationTrackBar.Value - STrack)/100.0;
            double deltaV = (valueTrackBar.Value - VTrack) / 100.0;

            int width = HSVValues[0].GetLength(0);
            int height = HSVValues[0].GetLength(1);

            List<double[,]> hsv = new List<double[,]>
            {
                new double[width, height],
                new double[width, height],
                new double[width, height]
            };

            Bitmap res = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    hsv[0][x, y] = (360 + HSVValues[0][x, y] + deltaH) % 360;
                }
            }


            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double S = HSVValues[1][x, y] + deltaS;
                    if (S < 0) S = 0;
                    else if (S > 1) S = 1;
                    hsv[1][x, y] = S;
                }
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double V = HSVValues[2][x, y] + deltaV;
                    if (V < 0) V = 0;
                    else if (V > 1) V = 1;
                    hsv[2][x, y] = V;
                }
            }
            
            resImage = GetRGB(hsv);
            resultPictureBox.Refresh();
        }

        private void hueTrackBar_Scroll(object sender, EventArgs e)
        {
            modifyResult();
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            resImage.Save("Result.bmp");
        }

        private void saturationTrackBar_Scroll(object sender, EventArgs e)
        {
            modifyResult();
        }

        private void valueTrackBar_Scroll(object sender, EventArgs e)
        {
            modifyResult();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                selectedFileName = openFileDialog1.FileName;
            }

            Console.WriteLine(result); // <-- For debugging use.
            Console.WriteLine(selectedFileName);
            
            srcImage = new Bitmap(new Bitmap(selectedFileName), sourcePictureBox.Size);
            resImage = new Bitmap(new Bitmap(selectedFileName), sourcePictureBox.Size);
            HSVValues = GetHSV(srcImage);
            setTrackBars(HSVValues);

            sourcePictureBox.Refresh();
            resultPictureBox.Refresh();
        }
    }
}
