﻿namespace Color_Thermostat_GUI_GraysonBeam
{
    partial class ColorsForm
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
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.TemperatureResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TemperatureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownLabel = new System.Windows.Forms.Label();
            this.TemperatureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.Location = new System.Drawing.Point(304, 7);
            this.TemperatureTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.Size = new System.Drawing.Size(51, 22);
            this.TemperatureTextBox.TabIndex = 0;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TemperatureLabel.Location = new System.Drawing.Point(16, 11);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(244, 20);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Enter a temperture value. 1-100";
            // 
            // TemperatureResultRichTextBox
            // 
            this.TemperatureResultRichTextBox.Location = new System.Drawing.Point(59, 97);
            this.TemperatureResultRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemperatureResultRichTextBox.Name = "TemperatureResultRichTextBox";
            this.TemperatureResultRichTextBox.Size = new System.Drawing.Size(335, 228);
            this.TemperatureResultRichTextBox.TabIndex = 2;
            this.TemperatureResultRichTextBox.Text = "";
            // 
            // TemperatureNumericUpDown
            // 
            this.TemperatureNumericUpDown.Location = new System.Drawing.Point(276, 42);
            this.TemperatureNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemperatureNumericUpDown.Name = "TemperatureNumericUpDown";
            this.TemperatureNumericUpDown.Size = new System.Drawing.Size(52, 22);
            this.TemperatureNumericUpDown.TabIndex = 3;
            this.TemperatureNumericUpDown.ValueChanged += new System.EventHandler(this.TemperatureNumericUpDown_ValueChanged);
            // 
            // NumericUpDownLabel
            // 
            this.NumericUpDownLabel.AutoSize = true;
            this.NumericUpDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumericUpDownLabel.Location = new System.Drawing.Point(131, 42);
            this.NumericUpDownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumericUpDownLabel.Name = "NumericUpDownLabel";
            this.NumericUpDownLabel.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownLabel.TabIndex = 4;
            this.NumericUpDownLabel.Text = "+ or - 1 degree\r\n";
            // 
            // TemperatureButton
            // 
            this.TemperatureButton.Location = new System.Drawing.Point(364, 5);
            this.TemperatureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemperatureButton.Name = "TemperatureButton";
            this.TemperatureButton.Size = new System.Drawing.Size(69, 28);
            this.TemperatureButton.TabIndex = 5;
            this.TemperatureButton.Text = "Go";
            this.TemperatureButton.UseVisualStyleBackColor = true;
            this.TemperatureButton.Click += new System.EventHandler(this.TemperatureButton_Click);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 363);
            this.Controls.Add(this.TemperatureButton);
            this.Controls.Add(this.NumericUpDownLabel);
            this.Controls.Add(this.TemperatureNumericUpDown);
            this.Controls.Add(this.TemperatureResultRichTextBox);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.TemperatureTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ColorsForm";
            this.Text = "Thermostat Temperture Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.RichTextBox TemperatureResultRichTextBox;
        private System.Windows.Forms.NumericUpDown TemperatureNumericUpDown;
        private System.Windows.Forms.Label NumericUpDownLabel;
        private System.Windows.Forms.Button TemperatureButton;
    }
}

