namespace Speed_Meter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aGaugeUp = new System.Windows.Forms.AGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUploadSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldownload = new System.Windows.Forms.Label();
            this.aGaugeDown = new System.Windows.Forms.AGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAgueUp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgueDown = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aGaugeUp
            // 
            this.aGaugeUp.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeUp.BaseArcRadius = 80;
            this.aGaugeUp.BaseArcStart = 135;
            this.aGaugeUp.BaseArcSweep = 270;
            this.aGaugeUp.BaseArcWidth = 2;
            this.aGaugeUp.Center = new System.Drawing.Point(100, 100);
            this.aGaugeUp.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.aGaugeUp.Location = new System.Drawing.Point(12, 86);
            this.aGaugeUp.MaxValue = 1000F;
            this.aGaugeUp.MinValue = 0F;
            this.aGaugeUp.Name = "aGaugeUp";
            this.aGaugeUp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGaugeUp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGaugeUp.NeedleRadius = 80;
            this.aGaugeUp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeUp.NeedleWidth = 2;
            this.aGaugeUp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeUp.ScaleLinesInterInnerRadius = 73;
            this.aGaugeUp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeUp.ScaleLinesInterWidth = 1;
            this.aGaugeUp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeUp.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeUp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeUp.ScaleLinesMajorStepValue = 100F;
            this.aGaugeUp.ScaleLinesMajorWidth = 2;
            this.aGaugeUp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeUp.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeUp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeUp.ScaleLinesMinorTicks = 9;
            this.aGaugeUp.ScaleLinesMinorWidth = 1;
            this.aGaugeUp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeUp.ScaleNumbersFormat = null;
            this.aGaugeUp.ScaleNumbersRadius = 95;
            this.aGaugeUp.ScaleNumbersRotation = 0;
            this.aGaugeUp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeUp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeUp.Size = new System.Drawing.Size(206, 184);
            this.aGaugeUp.TabIndex = 0;
            this.aGaugeUp.Text = "aGauge1";
            this.aGaugeUp.Value = 0F;
            this.aGaugeUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Up :";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // lblUploadSpeed
            // 
            this.lblUploadSpeed.AutoSize = true;
            this.lblUploadSpeed.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadSpeed.Location = new System.Drawing.Point(31, 11);
            this.lblUploadSpeed.Name = "lblUploadSpeed";
            this.lblUploadSpeed.Size = new System.Drawing.Size(45, 20);
            this.lblUploadSpeed.TabIndex = 2;
            this.lblUploadSpeed.Text = "label2";
            this.lblUploadSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Down :";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // lbldownload
            // 
            this.lbldownload.AutoSize = true;
            this.lbldownload.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldownload.Location = new System.Drawing.Point(138, 11);
            this.lbldownload.Name = "lbldownload";
            this.lbldownload.Size = new System.Drawing.Size(45, 20);
            this.lbldownload.TabIndex = 4;
            this.lbldownload.Text = "label4";
            this.lbldownload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // aGaugeDown
            // 
            this.aGaugeDown.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeDown.BaseArcRadius = 80;
            this.aGaugeDown.BaseArcStart = 135;
            this.aGaugeDown.BaseArcSweep = 270;
            this.aGaugeDown.BaseArcWidth = 2;
            this.aGaugeDown.Center = new System.Drawing.Point(100, 100);
            this.aGaugeDown.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.aGaugeDown.Location = new System.Drawing.Point(258, 86);
            this.aGaugeDown.MaxValue = 1000F;
            this.aGaugeDown.MinValue = 0F;
            this.aGaugeDown.Name = "aGaugeDown";
            this.aGaugeDown.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGaugeDown.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGaugeDown.NeedleRadius = 80;
            this.aGaugeDown.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeDown.NeedleWidth = 2;
            this.aGaugeDown.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeDown.ScaleLinesInterInnerRadius = 73;
            this.aGaugeDown.ScaleLinesInterOuterRadius = 80;
            this.aGaugeDown.ScaleLinesInterWidth = 1;
            this.aGaugeDown.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeDown.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeDown.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeDown.ScaleLinesMajorStepValue = 100F;
            this.aGaugeDown.ScaleLinesMajorWidth = 2;
            this.aGaugeDown.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeDown.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeDown.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeDown.ScaleLinesMinorTicks = 9;
            this.aGaugeDown.ScaleLinesMinorWidth = 1;
            this.aGaugeDown.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeDown.ScaleNumbersFormat = null;
            this.aGaugeDown.ScaleNumbersRadius = 95;
            this.aGaugeDown.ScaleNumbersRotation = 0;
            this.aGaugeDown.ScaleNumbersStartScaleLine = 0;
            this.aGaugeDown.ScaleNumbersStepScaleLines = 1;
            this.aGaugeDown.Size = new System.Drawing.Size(206, 184);
            this.aGaugeDown.TabIndex = 0;
            this.aGaugeDown.Text = "aGauge1";
            this.aGaugeDown.Value = 0F;
            this.aGaugeDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(69, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Up :";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // lblAgueUp
            // 
            this.lblAgueUp.AutoSize = true;
            this.lblAgueUp.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblAgueUp.Location = new System.Drawing.Point(103, 275);
            this.lblAgueUp.Name = "lblAgueUp";
            this.lblAgueUp.Size = new System.Drawing.Size(45, 20);
            this.lblAgueUp.TabIndex = 2;
            this.lblAgueUp.Text = "label2";
            this.lblAgueUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.Location = new System.Drawing.Point(305, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Down :";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // lblAgueDown
            // 
            this.lblAgueDown.AutoSize = true;
            this.lblAgueDown.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblAgueDown.Location = new System.Drawing.Point(352, 275);
            this.lblAgueDown.Name = "lblAgueDown";
            this.lblAgueDown.Size = new System.Drawing.Size(45, 20);
            this.lblAgueDown.TabIndex = 4;
            this.lblAgueDown.Text = "label4";
            this.lblAgueDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FromMoveWithouse);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Maximize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(468, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAgueDown);
            this.Controls.Add(this.lbldownload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAgueUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUploadSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aGaugeDown);
            this.Controls.Add(this.aGaugeUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Internet Speed Meter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.AGauge aGaugeUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUploadSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldownload;
        private System.Windows.Forms.AGauge aGaugeDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgueUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAgueDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

