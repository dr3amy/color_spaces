using System;
using System.Drawing;
using System.Windows.Forms;

namespace color_spaces
{
    partial class Task1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.HdTvImage = new System.Windows.Forms.PictureBox();
            this.PalImage = new System.Windows.Forms.PictureBox();
            this.choseImageButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HdTvImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(35, 37);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(547, 325);
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // LumaImage
            // 
            this.HdTvImage.Location = new System.Drawing.Point(35, 381);
            this.HdTvImage.Name = "HdTvImage";
            this.HdTvImage.Size = new System.Drawing.Size(547, 325);
            this.HdTvImage.TabIndex = 1;
            this.HdTvImage.TabStop = false;
            // 
            // ColorimetricImage
            // 
            this.PalImage.Location = new System.Drawing.Point(781, 373);
            this.PalImage.Name = "PalImage";
            this.PalImage.Size = new System.Drawing.Size(547, 325);
            this.PalImage.TabIndex = 2;
            this.PalImage.TabStop = false;
            // 
            // choseImageButton
            // 
            this.choseImageButton.Location = new System.Drawing.Point(35, 13);
            this.choseImageButton.Name = "choseImageButton";
            this.choseImageButton.Size = new System.Drawing.Size(105, 23);
            this.choseImageButton.TabIndex = 3;
            this.choseImageButton.Text = "Выберите картинку";
            this.choseImageButton.UseVisualStyleBackColor = true;
            this.choseImageButton.Click += this.handleButtonClick;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(53, 728);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(511, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(800, 728);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(511, 300);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Origignal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 713);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "HD TV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PAL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 1061);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.choseImageButton);
            this.Controls.Add(this.PalImage);
            this.Controls.Add(this.HdTvImage);
            this.Controls.Add(this.originalImage);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HdTvImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox HdTvImage;
        private System.Windows.Forms.PictureBox PalImage;
        private System.Windows.Forms.Button choseImageButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;

        private void handleButtonClick(object sender, EventArgs eventArgs)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Title = "Выберите картинку";
            imageDialog.Filter = "Image Files(*.PNG;*.JPG;)|*.PNG;*.JPG;";
            imageDialog.InitialDirectory = @"C:\";

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                Image chosenImage = Image.FromFile(imageDialog.FileName);
                this.originalImage.Image = chosenImage;
                GrayscaleConverter grayscaleConverter = new GrayscaleConverter(chosenImage as Bitmap);
                grayscaleConverter.ConvertToGrayscale();
                this.PalImage.Image = grayscaleConverter.GetPalBitmap();
                this.HdTvImage.Image = grayscaleConverter.GetHdTvBitmap();
                this.chart1.Series[0].Points.DataBindY(grayscaleConverter.GetPalIntensity());
                this.chart2.Series[0].Points.DataBindY(grayscaleConverter.GetHdTvIntensity());
            }
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}

