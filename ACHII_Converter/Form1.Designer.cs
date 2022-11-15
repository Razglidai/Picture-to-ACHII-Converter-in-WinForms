namespace ACHII_Converter
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectImage = new System.Windows.Forms.Button();
            this.CreateACHII_Art = new System.Windows.Forms.Button();
            this.ThisNegative = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(406, 65);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(150, 23);
            this.SelectImage.TabIndex = 2;
            this.SelectImage.Text = "Выберите картинку";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // CreateACHII_Art
            // 
            this.CreateACHII_Art.Location = new System.Drawing.Point(406, 157);
            this.CreateACHII_Art.Name = "CreateACHII_Art";
            this.CreateACHII_Art.Size = new System.Drawing.Size(150, 23);
            this.CreateACHII_Art.TabIndex = 3;
            this.CreateACHII_Art.Text = "Создать картинку";
            this.CreateACHII_Art.UseVisualStyleBackColor = true;
            this.CreateACHII_Art.Click += new System.EventHandler(this.CreateACHII_Art_Click);
            // 
            // ThisNegative
            // 
            this.ThisNegative.AutoSize = true;
            this.ThisNegative.Location = new System.Drawing.Point(225, 163);
            this.ThisNegative.Name = "ThisNegative";
            this.ThisNegative.Size = new System.Drawing.Size(159, 17);
            this.ThisNegative.TabIndex = 4;
            this.ThisNegative.Text = "Инвертировать градиент?";
            this.ThisNegative.UseVisualStyleBackColor = true;
            this.ThisNegative.CheckedChanged += new System.EventHandler(this.ThisNegative_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "300";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Разрешение картинки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grad
            // 
            this.Grad.Location = new System.Drawing.Point(225, 218);
            this.Grad.Name = "Grad";
            this.Grad.Size = new System.Drawing.Size(100, 20);
            this.Grad.TabIndex = 7;
            this.Grad.Text = "@$8W9H4l(r/:.";
            this.Grad.TextChanged += new System.EventHandler(this.Grad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ваш градиент(если поле пустое то он будет задан по умолчанию)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Путь к файлу";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Picture.txt";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ThisNegative);
            this.Controls.Add(this.CreateACHII_Art);
            this.Controls.Add(this.SelectImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Button CreateACHII_Art;
        private System.Windows.Forms.CheckBox ThisNegative;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

