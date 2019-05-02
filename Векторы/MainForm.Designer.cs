namespace Векторы
{
    partial class MainForm
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
            this.tBx1 = new System.Windows.Forms.TextBox();
            this.tBy1 = new System.Windows.Forms.TextBox();
            this.tBz1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBz2 = new System.Windows.Forms.TextBox();
            this.tBy2 = new System.Windows.Forms.TextBox();
            this.tBx2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBOperations = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBResult = new System.Windows.Forms.TextBox();
            this.btnRez = new System.Windows.Forms.Button();
            this.tBNum1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBx1
            // 
            this.tBx1.Location = new System.Drawing.Point(86, 17);
            this.tBx1.Name = "tBx1";
            this.tBx1.Size = new System.Drawing.Size(39, 20);
            this.tBx1.TabIndex = 0;
            // 
            // tBy1
            // 
            this.tBy1.Location = new System.Drawing.Point(150, 17);
            this.tBy1.Name = "tBy1";
            this.tBy1.Size = new System.Drawing.Size(39, 20);
            this.tBy1.TabIndex = 1;
            // 
            // tBz1
            // 
            this.tBz1.Location = new System.Drawing.Point(216, 17);
            this.tBz1.Name = "tBz1";
            this.tBz1.Size = new System.Drawing.Size(39, 20);
            this.tBz1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вектор А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вектор В";
            // 
            // tBz2
            // 
            this.tBz2.Location = new System.Drawing.Point(216, 63);
            this.tBz2.Name = "tBz2";
            this.tBz2.Size = new System.Drawing.Size(39, 20);
            this.tBz2.TabIndex = 6;
            // 
            // tBy2
            // 
            this.tBy2.Location = new System.Drawing.Point(150, 63);
            this.tBy2.Name = "tBy2";
            this.tBy2.Size = new System.Drawing.Size(39, 20);
            this.tBy2.TabIndex = 5;
            // 
            // tBx2
            // 
            this.tBx2.Location = new System.Drawing.Point(86, 63);
            this.tBx2.Name = "tBx2";
            this.tBx2.Size = new System.Drawing.Size(39, 20);
            this.tBx2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выбрать операцию";
            // 
            // cBOperations
            // 
            this.cBOperations.FormattingEnabled = true;
            this.cBOperations.Location = new System.Drawing.Point(6, 23);
            this.cBOperations.Name = "cBOperations";
            this.cBOperations.Size = new System.Drawing.Size(132, 21);
            this.cBOperations.TabIndex = 9;
            this.cBOperations.SelectedIndexChanged += new System.EventHandler(this.CBOperations_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBResult);
            this.groupBox1.Location = new System.Drawing.Point(15, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 83);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат";
            // 
            // tBResult
            // 
            this.tBResult.Location = new System.Drawing.Point(6, 19);
            this.tBResult.Multiline = true;
            this.tBResult.Name = "tBResult";
            this.tBResult.Size = new System.Drawing.Size(427, 58);
            this.tBResult.TabIndex = 0;
            // 
            // btnRez
            // 
            this.btnRez.Location = new System.Drawing.Point(171, 21);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(84, 23);
            this.btnRez.TabIndex = 11;
            this.btnRez.Text = "Вычислить";
            this.btnRez.UseVisualStyleBackColor = true;
            this.btnRez.Click += new System.EventHandler(this.BtnRez_Click);
            // 
            // tBNum1
            // 
            this.tBNum1.Location = new System.Drawing.Point(359, 17);
            this.tBNum1.Name = "tBNum1";
            this.tBNum1.Size = new System.Drawing.Size(55, 20);
            this.tBNum1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введите число";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(261, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBx1);
            this.panel1.Controls.Add(this.tBy1);
            this.panel1.Controls.Add(this.tBz1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBx2);
            this.panel1.Controls.Add(this.tBNum1);
            this.panel1.Controls.Add(this.tBy2);
            this.panel1.Controls.Add(this.tBz2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 102);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cBOperations);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnRez);
            this.panel2.Location = new System.Drawing.Point(15, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 58);
            this.panel2.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(343, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 282);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Операции над векторами";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBx1;
        private System.Windows.Forms.TextBox tBy1;
        private System.Windows.Forms.TextBox tBz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBz2;
        private System.Windows.Forms.TextBox tBy2;
        private System.Windows.Forms.TextBox tBx2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBOperations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBResult;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.TextBox tBNum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
    }
}

