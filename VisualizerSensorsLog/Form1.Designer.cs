namespace VisualizerSensorsLog
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browse_btn = new System.Windows.Forms.Button();
            this.path_txtBox = new System.Windows.Forms.TextBox();
            this.goParse_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(293, 24);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(75, 20);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Обзор...";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // path_txtBox
            // 
            this.path_txtBox.Location = new System.Drawing.Point(12, 24);
            this.path_txtBox.Name = "path_txtBox";
            this.path_txtBox.Size = new System.Drawing.Size(263, 20);
            this.path_txtBox.TabIndex = 1;
            // 
            // goParse_btn
            // 
            this.goParse_btn.Location = new System.Drawing.Point(648, 374);
            this.goParse_btn.Name = "goParse_btn";
            this.goParse_btn.Size = new System.Drawing.Size(75, 23);
            this.goParse_btn.TabIndex = 2;
            this.goParse_btn.Text = "Пуск";
            this.goParse_btn.UseVisualStyleBackColor = true;
            this.goParse_btn.Click += new System.EventHandler(this.goParse_btn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 97);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart1.Size = new System.Drawing.Size(614, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.goParse_btn);
            this.Controls.Add(this.path_txtBox);
            this.Controls.Add(this.browse_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.TextBox path_txtBox;
        private System.Windows.Forms.Button goParse_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

