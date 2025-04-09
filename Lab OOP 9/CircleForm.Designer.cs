namespace Lab_OOP_9
{
    partial class CircleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleForm));
            this.btnCalculateCircumference = new System.Windows.Forms.Button();
            this.btnCheckPoint = new System.Windows.Forms.Button();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateCircumference
            // 
            this.btnCalculateCircumference.BackColor = System.Drawing.Color.DarkRed;
            this.btnCalculateCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateCircumference.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculateCircumference.Location = new System.Drawing.Point(12, 369);
            this.btnCalculateCircumference.Name = "btnCalculateCircumference";
            this.btnCalculateCircumference.Size = new System.Drawing.Size(160, 30);
            this.btnCalculateCircumference.TabIndex = 24;
            this.btnCalculateCircumference.Text = "Довжина";
            this.btnCalculateCircumference.UseVisualStyleBackColor = false;
            this.btnCalculateCircumference.Click += new System.EventHandler(this.btnCalculateCircumference_Click);
            // 
            // btnCheckPoint
            // 
            this.btnCheckPoint.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckPoint.Location = new System.Drawing.Point(178, 341);
            this.btnCheckPoint.Name = "btnCheckPoint";
            this.btnCheckPoint.Size = new System.Drawing.Size(146, 58);
            this.btnCheckPoint.TabIndex = 25;
            this.btnCheckPoint.Text = "Перевірити точку";
            this.btnCheckPoint.UseVisualStyleBackColor = false;
            this.btnCheckPoint.Click += new System.EventHandler(this.btnCheckPoint_Click);
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.BackColor = System.Drawing.Color.DarkRed;
            this.btnCalculateArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculateArea.Location = new System.Drawing.Point(11, 340);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(160, 30);
            this.btnCalculateArea.TabIndex = 23;
            this.btnCalculateArea.Text = "Площа";
            this.btnCalculateArea.UseVisualStyleBackColor = false;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "X";
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Controls.Add(this.txtResult);
            this.panelCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelCanvas.Location = new System.Drawing.Point(12, 56);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(312, 279);
            this.panelCanvas.TabIndex = 26;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.DarkRed;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Location = new System.Drawing.Point(-1, 257);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(313, 24);
            this.txtResult.TabIndex = 30;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.Color.DarkRed;
            this.txtRadius.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRadius.Location = new System.Drawing.Point(224, 28);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 22;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // txtY
            // 
            this.txtY.BackColor = System.Drawing.Color.DarkRed;
            this.txtY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtY.Location = new System.Drawing.Point(118, 28);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 21;
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.DarkRed;
            this.txtX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtX.Location = new System.Drawing.Point(12, 28);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 20;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab_OOP_9.Properties.Resources.Dog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 401);
            this.Controls.Add(this.btnCalculateCircumference);
            this.Controls.Add(this.btnCheckPoint);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CircleForm";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.CircleForm_Load);
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateCircumference;
        private System.Windows.Forms.Button btnCheckPoint;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

