﻿namespace Publisher.Components
{
    partial class UcHField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xTextBox1 = new Publisher.Components.XTextBox();
            this.xLabel1 = new Publisher.Components.XLabel();
            this.SuspendLayout();
            // 
            // xTextBox1
            // 
            this.xTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xTextBox1.Location = new System.Drawing.Point(62, 6);
            this.xTextBox1.Name = "xTextBox1";
            this.xTextBox1.Size = new System.Drawing.Size(193, 20);
            this.xTextBox1.TabIndex = 5;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.Location = new System.Drawing.Point(12, 9);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(44, 13);
            this.xLabel1.TabIndex = 4;
            this.xLabel1.Text = "xLabel1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xTextBox1);
            this.Controls.Add(this.xLabel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(268, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XTextBox xTextBox1;
        private XLabel xLabel1;
    }
}
