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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(618, 582);
            button1.Name = "button1";
            button1.Size = new Size(345, 55);
            button1.TabIndex = 1;
            button1.Text = "배경색　변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1772697609226;
            pictureBox1.Location = new Point(95, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(467, 70);
            label2.Name = "label2";
            label2.Size = new Size(172, 65);
            label2.TabIndex = 3;
            label2.Text = "최지민";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(467, 144);
            label1.Name = "label1";
            label1.Size = new Size(434, 45);
            label1.TabIndex = 4;
            label1.Text = "컴퓨터학부 컴퓨터sw 2학년";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.DarkOrchid;
            label3.Location = new Point(467, 246);
            label3.Name = "label3";
            label3.Size = new Size(364, 45);
            label3.TabIndex = 5;
            label3.Text = "cjimin996@gmail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(467, 201);
            label4.Name = "label4";
            label4.Size = new Size(172, 45);
            label4.TabIndex = 6;
            label4.Text = "25017088";
            // 
            // button2
            // 
            button2.Font = new Font("굴림", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(471, 314);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 7;
            button2.Text = "github";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.LightSalmon;
            button3.Location = new Point(95, 531);
            button3.Name = "button3";
            button3.Size = new Size(345, 59);
            button3.TabIndex = 8;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 649);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}
