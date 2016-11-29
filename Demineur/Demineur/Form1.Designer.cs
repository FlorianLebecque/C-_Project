namespace Demineur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Nud_Y = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Nud_X = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Panel();
            this.Nud_Size = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Nud_Size);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Nud_Y);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.Nud_X);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 179);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(12, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bomb left :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(103, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(203, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "100%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(4, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "1%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "% bombe";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(31, 104);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Taille :";
            // 
            // Nud_Y
            // 
            this.Nud_Y.BackColor = System.Drawing.Color.Black;
            this.Nud_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nud_Y.ForeColor = System.Drawing.Color.Green;
            this.Nud_Y.Location = new System.Drawing.Point(246, 49);
            this.Nud_Y.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Nud_Y.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nud_Y.Name = "Nud_Y";
            this.Nud_Y.Size = new System.Drawing.Size(75, 20);
            this.Nud_Y.TabIndex = 4;
            this.Nud_Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nud_Y.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.Green;
            this.checkBox1.Location = new System.Drawing.Point(165, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Rectangle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Nud_X
            // 
            this.Nud_X.BackColor = System.Drawing.Color.Black;
            this.Nud_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nud_X.ForeColor = System.Drawing.Color.Green;
            this.Nud_X.Location = new System.Drawing.Point(246, 23);
            this.Nud_X.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Nud_X.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nud_X.Name = "Nud_X";
            this.Nud_X.Size = new System.Drawing.Size(75, 20);
            this.Nud_X.TabIndex = 2;
            this.Nud_X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nud_X.ValueChanged += new System.EventHandler(this.Nud_X_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Area
            // 
            this.Area.AutoScroll = true;
            this.Area.BackColor = System.Drawing.Color.Black;
            this.Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Area.Location = new System.Drawing.Point(0, 179);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(491, 485);
            this.Area.TabIndex = 1;
            // 
            // Nud_Size
            // 
            this.Nud_Size.BackColor = System.Drawing.Color.Black;
            this.Nud_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nud_Size.ForeColor = System.Drawing.Color.Green;
            this.Nud_Size.Location = new System.Drawing.Point(56, 65);
            this.Nud_Size.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Nud_Size.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nud_Size.Name = "Nud_Size";
            this.Nud_Size.Size = new System.Drawing.Size(75, 20);
            this.Nud_Size.TabIndex = 16;
            this.Nud_Size.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.Nud_Size.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(109, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(491, 664);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FormFl Minesweeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nud_Y;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown Nud_X;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Area;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Nud_Size;
        private System.Windows.Forms.Label label3;
    }
}

