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
            this.palChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hdtvChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diffImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.HdTvImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.PalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.palChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.hdtvChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.diffImage)).BeginInit();
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
            // HdTvImage
            // 
            this.HdTvImage.Location = new System.Drawing.Point(35, 381);
            this.HdTvImage.Name = "HdTvImage";
            this.HdTvImage.Size = new System.Drawing.Size(547, 325);
            this.HdTvImage.TabIndex = 1;
            this.HdTvImage.TabStop = false;
            // 
            // PalImage
            // 
            this.PalImage.Location = new System.Drawing.Point(781, 381);
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
            this.choseImageButton.Click += this.HandleButtonClick;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.palChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.palChart.Legends.Add(legend1);
            this.palChart.Location = new System.Drawing.Point(53, 728);
            this.palChart.Name = "palChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.palChart.Series.Add(series1);
            this.palChart.Size = new System.Drawing.Size(511, 300);
            this.palChart.TabIndex = 4;
            this.palChart.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.hdtvChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.hdtvChart.Legends.Add(legend2);
            this.hdtvChart.Location = new System.Drawing.Point(800, 728);
            this.hdtvChart.Name = "hdtvChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.hdtvChart.Series.Add(series2);
            this.hdtvChart.Size = new System.Drawing.Size(511, 300);
            this.hdtvChart.TabIndex = 5;
            this.hdtvChart.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 713);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "HD TV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PAL";
            // 
            // pictureBox1
            // 
            this.diffImage.Location = new System.Drawing.Point(781, 37);
            this.diffImage.Name = "diffImage";
            this.diffImage.Size = new System.Drawing.Size(547, 325);
            this.diffImage.TabIndex = 9;
            this.diffImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Diff";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 1061);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diffImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hdtvChart);
            this.Controls.Add(this.palChart);
            this.Controls.Add(this.choseImageButton);
            this.Controls.Add(this.PalImage);
            this.Controls.Add(this.HdTvImage);
            this.Controls.Add(this.originalImage);
            this.Name = "Task1";
            this.Text = "Grayscale";
            ((System.ComponentModel.ISupportInitialize) (this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.HdTvImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.PalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.palChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.hdtvChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.diffImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox HdTvImage;
        private System.Windows.Forms.PictureBox PalImage;
        private System.Windows.Forms.PictureBox diffImage;
        private System.Windows.Forms.Button choseImageButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart palChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart hdtvChart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

