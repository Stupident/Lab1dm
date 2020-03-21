namespace lab1dm
{
    partial class ForZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForZ));
            this.pictureF = new System.Windows.Forms.PictureBox();
            this.setsBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.setYBox = new System.Windows.Forms.TextBox();
            this.setXBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.setZBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureF)).BeginInit();
            this.setsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureF
            // 
            this.pictureF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureF.Image = ((System.Drawing.Image)(resources.GetObject("pictureF.Image")));
            this.pictureF.Location = new System.Drawing.Point(32, 13);
            this.pictureF.Margin = new System.Windows.Forms.Padding(4);
            this.pictureF.Name = "pictureF";
            this.pictureF.Size = new System.Drawing.Size(358, 84);
            this.pictureF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureF.TabIndex = 38;
            this.pictureF.TabStop = false;
            // 
            // setsBox
            // 
            this.setsBox.Controls.Add(this.label10);
            this.setsBox.Controls.Add(this.label11);
            this.setsBox.Controls.Add(this.setYBox);
            this.setsBox.Controls.Add(this.setXBox);
            this.setsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.setsBox.ForeColor = System.Drawing.SystemColors.Window;
            this.setsBox.Location = new System.Drawing.Point(12, 113);
            this.setsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setsBox.Name = "setsBox";
            this.setsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setsBox.Size = new System.Drawing.Size(399, 181);
            this.setsBox.TabIndex = 39;
            this.setsBox.TabStop = false;
            this.setsBox.Text = "Sets";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(20, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Set Y = not set A:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(20, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Set X = not set B:";
            // 
            // setYBox
            // 
            this.setYBox.Location = new System.Drawing.Point(24, 127);
            this.setYBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setYBox.Name = "setYBox";
            this.setYBox.Size = new System.Drawing.Size(346, 26);
            this.setYBox.TabIndex = 1;
            // 
            // setXBox
            // 
            this.setXBox.Location = new System.Drawing.Point(24, 59);
            this.setXBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setXBox.Name = "setXBox";
            this.setXBox.Size = new System.Drawing.Size(346, 26);
            this.setXBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Set Z:";
            // 
            // setZBox
            // 
            this.setZBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setZBox.Location = new System.Drawing.Point(27, 349);
            this.setZBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setZBox.Name = "setZBox";
            this.setZBox.Size = new System.Drawing.Size(367, 26);
            this.setZBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(160, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 40);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "Save result";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcButton.Location = new System.Drawing.Point(27, 399);
            this.calcButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 40);
            this.calcButton.TabIndex = 41;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goBack.Location = new System.Drawing.Point(294, 399);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 40);
            this.goBack.TabIndex = 40;
            this.goBack.Text = "Go back";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            // 
            // ForZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(424, 464);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.setsBox);
            this.Controls.Add(this.setZBox);
            this.Controls.Add(this.pictureF);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "De_Mka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureF)).EndInit();
            this.setsBox.ResumeLayout(false);
            this.setsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureF;
        private System.Windows.Forms.GroupBox setsBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox setYBox;
        private System.Windows.Forms.TextBox setXBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox setZBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}