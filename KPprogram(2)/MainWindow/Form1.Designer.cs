namespace MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Current_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.One_LB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Five_LB = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Three_LB = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.For_LB = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Two_LB = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.LogStudent_TB = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Manual_B = new System.Windows.Forms.Button();
            this.Manual_RB = new System.Windows.Forms.RadioButton();
            this.Auto_RB = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_NUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.Stat_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stat_B = new System.Windows.Forms.Button();
            this.Timer_T = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NUD)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Current_TB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кабинет";
            // 
            // Current_TB
            // 
            this.Current_TB.Location = new System.Drawing.Point(9, 42);
            this.Current_TB.Name = "Current_TB";
            this.Current_TB.ReadOnly = true;
            this.Current_TB.Size = new System.Drawing.Size(237, 20);
            this.Current_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.One_LB);
            this.groupBox2.Location = new System.Drawing.Point(18, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Получение допуска к сессии";
            // 
            // One_LB
            // 
            this.One_LB.FormattingEnabled = true;
            this.One_LB.Location = new System.Drawing.Point(6, 41);
            this.One_LB.Name = "One_LB";
            this.One_LB.Size = new System.Drawing.Size(150, 251);
            this.One_LB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Five_LB);
            this.groupBox3.Location = new System.Drawing.Point(718, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Получение «бегунка» для пересдачи экзамена";
            // 
            // Five_LB
            // 
            this.Five_LB.FormattingEnabled = true;
            this.Five_LB.Location = new System.Drawing.Point(6, 41);
            this.Five_LB.Name = "Five_LB";
            this.Five_LB.Size = new System.Drawing.Size(150, 251);
            this.Five_LB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Three_LB);
            this.groupBox4.Location = new System.Drawing.Point(368, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 298);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Получение квитанции на оплату пересдачи экзамена";
            // 
            // Three_LB
            // 
            this.Three_LB.FormattingEnabled = true;
            this.Three_LB.Location = new System.Drawing.Point(6, 41);
            this.Three_LB.Name = "Three_LB";
            this.Three_LB.Size = new System.Drawing.Size(150, 251);
            this.Three_LB.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.For_LB);
            this.groupBox5.Location = new System.Drawing.Point(543, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 298);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Возврат «бегунка» с оценкой";
            // 
            // For_LB
            // 
            this.For_LB.FormattingEnabled = true;
            this.For_LB.Location = new System.Drawing.Point(6, 41);
            this.For_LB.Name = "For_LB";
            this.For_LB.Size = new System.Drawing.Size(150, 251);
            this.For_LB.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Two_LB);
            this.groupBox6.Location = new System.Drawing.Point(193, 126);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(169, 298);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Закрытие сессии";
            // 
            // Two_LB
            // 
            this.Two_LB.FormattingEnabled = true;
            this.Two_LB.Location = new System.Drawing.Point(6, 41);
            this.Two_LB.Name = "Two_LB";
            this.Two_LB.Size = new System.Drawing.Size(150, 251);
            this.Two_LB.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.LogStudent_TB);
            this.groupBox7.Location = new System.Drawing.Point(18, 430);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(519, 156);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Действия, выполненные на последнем шаге";
            // 
            // LogStudent_TB
            // 
            this.LogStudent_TB.Location = new System.Drawing.Point(9, 19);
            this.LogStudent_TB.Multiline = true;
            this.LogStudent_TB.Name = "LogStudent_TB";
            this.LogStudent_TB.ReadOnly = true;
            this.LogStudent_TB.Size = new System.Drawing.Size(504, 131);
            this.LogStudent_TB.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Manual_B);
            this.groupBox8.Controls.Add(this.Manual_RB);
            this.groupBox8.Controls.Add(this.Auto_RB);
            this.groupBox8.Location = new System.Drawing.Point(907, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(362, 76);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Управление";
            // 
            // Manual_B
            // 
            this.Manual_B.Location = new System.Drawing.Point(194, 26);
            this.Manual_B.Name = "Manual_B";
            this.Manual_B.Size = new System.Drawing.Size(162, 36);
            this.Manual_B.TabIndex = 2;
            this.Manual_B.Text = "В&ыполнить шаг";
            this.Manual_B.UseVisualStyleBackColor = true;
            this.Manual_B.Click += new System.EventHandler(this.Manual_B_Click);
            // 
            // Manual_RB
            // 
            this.Manual_RB.AutoSize = true;
            this.Manual_RB.Checked = true;
            this.Manual_RB.Location = new System.Drawing.Point(6, 47);
            this.Manual_RB.Name = "Manual_RB";
            this.Manual_RB.Size = new System.Drawing.Size(67, 17);
            this.Manual_RB.TabIndex = 1;
            this.Manual_RB.TabStop = true;
            this.Manual_RB.Text = "Вруч&ную";
            this.Manual_RB.UseVisualStyleBackColor = true;
            this.Manual_RB.CheckedChanged += new System.EventHandler(this.Manual_RB_CheckedChanged);
            // 
            // Auto_RB
            // 
            this.Auto_RB.AutoSize = true;
            this.Auto_RB.Location = new System.Drawing.Point(6, 24);
            this.Auto_RB.Name = "Auto_RB";
            this.Auto_RB.Size = new System.Drawing.Size(103, 17);
            this.Auto_RB.TabIndex = 0;
            this.Auto_RB.TabStop = true;
            this.Auto_RB.Text = "Автома&тически";
            this.Auto_RB.UseVisualStyleBackColor = true;
            this.Auto_RB.CheckedChanged += new System.EventHandler(this.Auto_RB_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Count_NUD);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.Input_NUD);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Location = new System.Drawing.Point(907, 95);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(362, 87);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Новые студенты";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(194, 55);
            this.Count_NUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Count_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(162, 20);
            this.Count_NUD.TabIndex = 10;
            this.Count_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_NUD.ValueChanged += new System.EventHandler(this.Count_NUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "К&оличество от 1 до";
            // 
            // Input_NUD
            // 
            this.Input_NUD.Location = new System.Drawing.Point(194, 29);
            this.Input_NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Input_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Input_NUD.Name = "Input_NUD";
            this.Input_NUD.Size = new System.Drawing.Size(162, 20);
            this.Input_NUD.TabIndex = 1;
            this.Input_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Input_NUD.ValueChanged += new System.EventHandler(this.Input_NUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вероятность появлен&ия 1 из";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Stat_TB);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.Stat_B);
            this.groupBox10.Location = new System.Drawing.Point(907, 188);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(361, 331);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Отчет";
            // 
            // Stat_TB
            // 
            this.Stat_TB.Location = new System.Drawing.Point(9, 83);
            this.Stat_TB.Multiline = true;
            this.Stat_TB.Name = "Stat_TB";
            this.Stat_TB.ReadOnly = true;
            this.Stat_TB.Size = new System.Drawing.Size(347, 242);
            this.Stat_TB.TabIndex = 2;
            this.Stat_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Результаты ра&боты";
            // 
            // Stat_B
            // 
            this.Stat_B.Location = new System.Drawing.Point(9, 21);
            this.Stat_B.Name = "Stat_B";
            this.Stat_B.Size = new System.Drawing.Size(347, 34);
            this.Stat_B.TabIndex = 0;
            this.Stat_B.Text = "&Группировка по типам операций";
            this.Stat_B.UseVisualStyleBackColor = true;
            this.Stat_B.Click += new System.EventHandler(this.Stat_B_Click);
            // 
            // Timer_T
            // 
            this.Timer_T.Tick += new System.EventHandler(this.Timer_T_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 598);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Дирекция";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NUD)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Current_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox One_LB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Five_LB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox Three_LB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox For_LB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox Two_LB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button Manual_B;
        private System.Windows.Forms.RadioButton Manual_RB;
        private System.Windows.Forms.RadioButton Auto_RB;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Input_NUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Stat_B;
        private System.Windows.Forms.TextBox LogStudent_TB;
        private System.Windows.Forms.TextBox Stat_TB;
        private System.Windows.Forms.Timer Timer_T;
    }
}

