namespace Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Beze = new System.Windows.Forms.RadioButton();
            this.Bucket2 = new System.Windows.Forms.RadioButton();
            this.Bucket = new System.Windows.Forms.RadioButton();
            this.CirclePen = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Pen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(214, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(46, 670);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 23);
            this.Clean.TabIndex = 1;
            this.Clean.Text = "Отчистка";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Толщина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цвет";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 547);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Beze);
            this.groupBox1.Controls.Add(this.Bucket2);
            this.groupBox1.Controls.Add(this.Bucket);
            this.groupBox1.Controls.Add(this.CirclePen);
            this.groupBox1.Controls.Add(this.Circle);
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Controls.Add(this.Pen);
            this.groupBox1.Location = new System.Drawing.Point(8, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 335);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "кисти";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "рисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Beze
            // 
            this.Beze.AutoSize = true;
            this.Beze.Location = new System.Drawing.Point(4, 197);
            this.Beze.Name = "Beze";
            this.Beze.Size = new System.Drawing.Size(96, 17);
            this.Beze.TabIndex = 7;
            this.Beze.TabStop = true;
            this.Beze.Text = "Кривая Безье";
            this.Beze.UseVisualStyleBackColor = true;
            // 
            // Bucket2
            // 
            this.Bucket2.AutoSize = true;
            this.Bucket2.Location = new System.Drawing.Point(4, 173);
            this.Bucket2.Name = "Bucket2";
            this.Bucket2.Size = new System.Drawing.Size(100, 17);
            this.Bucket2.TabIndex = 6;
            this.Bucket2.TabStop = true;
            this.Bucket2.Text = "Супер заливка";
            this.Bucket2.UseVisualStyleBackColor = true;
            // 
            // Bucket
            // 
            this.Bucket.AutoSize = true;
            this.Bucket.Location = new System.Drawing.Point(4, 149);
            this.Bucket.Name = "Bucket";
            this.Bucket.Size = new System.Drawing.Size(68, 17);
            this.Bucket.TabIndex = 5;
            this.Bucket.TabStop = true;
            this.Bucket.Text = "Заливка";
            this.Bucket.UseVisualStyleBackColor = true;
            this.Bucket.Visible = false;
            // 
            // CirclePen
            // 
            this.CirclePen.AutoSize = true;
            this.CirclePen.Location = new System.Drawing.Point(5, 79);
            this.CirclePen.Name = "CirclePen";
            this.CirclePen.Size = new System.Drawing.Size(138, 17);
            this.CirclePen.TabIndex = 4;
            this.CirclePen.TabStop = true;
            this.CirclePen.Text = "кисть из окружностей";
            this.CirclePen.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(4, 125);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(85, 17);
            this.Circle.TabIndex = 3;
            this.Circle.TabStop = true;
            this.Circle.Text = "окружность";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.Circle_CheckedChanged);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(4, 102);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(66, 17);
            this.Line.TabIndex = 2;
            this.Line.TabStop = true;
            this.Line.Text = "отрезок";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Pen
            // 
            this.Pen.AutoSize = true;
            this.Pen.Location = new System.Drawing.Point(5, 55);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(76, 17);
            this.Pen.TabIndex = 1;
            this.Pen.TabStop = true;
            this.Pen.Text = "Карандаш";
            this.Pen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Pen;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton CirclePen;
        private System.Windows.Forms.RadioButton Bucket;
        private System.Windows.Forms.RadioButton Bucket2;
        private System.Windows.Forms.RadioButton Beze;
        private System.Windows.Forms.Button button1;
    }
}

