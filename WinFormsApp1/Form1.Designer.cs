using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSentance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSentance
            // 
            this.txtSentance.Location = new System.Drawing.Point(12, 12);
            this.txtSentance.Name = "txtSentance";
            this.txtSentance.Size = new System.Drawing.Size(255, 23);
            this.txtSentance.TabIndex = 0;
            //
            // 
            //
            chart = new Chart();
            chart.Size = new Size(300, 300);
            chart.ChartAreas.Add(new ChartArea());
            chart.Location = new Point(35, 100);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предложение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSentance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart chart;
        private TextBox txtSentance;
        private Label label1;
        private Button button1;
    }
}