namespace Tutorial11
{
    partial class Form1
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
            this.openButton = new System.Windows.Forms.Button();
            this.pauseButton1 = new System.Windows.Forms.Button();
            this.compareButton = new System.Windows.Forms.Button();
            this.customWaveViewer2 = new Tutorial11.CustomWaveViewer();
            this.customWaveViewer1 = new Tutorial11.CustomWaveViewer();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(97, 1);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(125, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open Audio File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pauseButton1
            // 
            this.pauseButton1.Location = new System.Drawing.Point(245, 1);
            this.pauseButton1.Name = "pauseButton1";
            this.pauseButton1.Size = new System.Drawing.Size(75, 23);
            this.pauseButton1.TabIndex = 3;
            this.pauseButton1.Text = "Play/Pause";
            this.pauseButton1.UseVisualStyleBackColor = true;
            this.pauseButton1.Click += new System.EventHandler(this.pauseButton1_Click);
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(97, 98);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(125, 23);
            this.compareButton.TabIndex = 4;
            this.compareButton.Text = "File To Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // customWaveViewer2
            // 
            this.customWaveViewer2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.customWaveViewer2.Location = new System.Drawing.Point(0, 124);
            this.customWaveViewer2.Name = "customWaveViewer2";
            this.customWaveViewer2.PenColor = System.Drawing.Color.DodgerBlue;
            this.customWaveViewer2.PenWidth = 1F;
            this.customWaveViewer2.SamplesPerPixel = 128;
            this.customWaveViewer2.Size = new System.Drawing.Size(438, 68);
            this.customWaveViewer2.StartPosition = ((long)(0));
            this.customWaveViewer2.TabIndex = 6;
            this.customWaveViewer2.WaveStream = null;
            // 
            // customWaveViewer1
            // 
            this.customWaveViewer1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.customWaveViewer1.Location = new System.Drawing.Point(0, 27);
            this.customWaveViewer1.Name = "customWaveViewer1";
            this.customWaveViewer1.PenColor = System.Drawing.Color.DodgerBlue;
            this.customWaveViewer1.PenWidth = 1F;
            this.customWaveViewer1.SamplesPerPixel = 128;
            this.customWaveViewer1.Size = new System.Drawing.Size(438, 68);
            this.customWaveViewer1.StartPosition = ((long)(0));
            this.customWaveViewer1.TabIndex = 1;
            this.customWaveViewer1.WaveStream = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 211);
            this.Controls.Add(this.customWaveViewer2);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.pauseButton1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.customWaveViewer1);
            this.Name = "Form1";
            this.Text = "Tutorial 11";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomWaveViewer customWaveViewer1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button pauseButton1;
        private System.Windows.Forms.Button compareButton;
        private CustomWaveViewer customWaveViewer2;
    }
}

