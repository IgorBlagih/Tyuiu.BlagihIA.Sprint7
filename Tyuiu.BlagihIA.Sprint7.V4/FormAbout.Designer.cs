namespace Tyuiu.BlagihIA.Sprint6.Task7.V24
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_BIA = new Button();
            pictureBoxMe_BIA = new PictureBox();
            textBoxInfo_BIA = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_BIA).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_BIA
            // 
            buttonOK_BIA.BackColor = SystemColors.GradientActiveCaption;
            buttonOK_BIA.Location = new Point(327, 125);
            buttonOK_BIA.Name = "buttonOK_BIA";
            buttonOK_BIA.Size = new Size(60, 32);
            buttonOK_BIA.TabIndex = 5;
            buttonOK_BIA.Text = "ОК";
            buttonOK_BIA.UseVisualStyleBackColor = false;
            buttonOK_BIA.Click += button1_Click;
            // 
            // pictureBoxMe_BIA
            // 
            pictureBoxMe_BIA.Image = (Image)resources.GetObject("pictureBoxMe_BIA.Image");
            pictureBoxMe_BIA.Location = new Point(3, 12);
            pictureBoxMe_BIA.Name = "pictureBoxMe_BIA";
            pictureBoxMe_BIA.Size = new Size(113, 107);
            pictureBoxMe_BIA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMe_BIA.TabIndex = 4;
            pictureBoxMe_BIA.TabStop = false;
            // 
            // textBoxInfo_BIA
            // 
            textBoxInfo_BIA.BackColor = SystemColors.Control;
            textBoxInfo_BIA.BorderStyle = BorderStyle.None;
            textBoxInfo_BIA.Location = new Point(122, 12);
            textBoxInfo_BIA.Multiline = true;
            textBoxInfo_BIA.Name = "textBoxInfo_BIA";
            textBoxInfo_BIA.ReadOnly = true;
            textBoxInfo_BIA.Size = new Size(272, 107);
            textBoxInfo_BIA.TabIndex = 3;
            textBoxInfo_BIA.TabStop = false;
            textBoxInfo_BIA.Text = "Разработчик: Благих И.А\r\nгруппа ИИПб-24-2\r\n\r\nПрограмма разработана в рамках изучения С#\r\n\r\nВнутреннее имя: Tyuiu.BlagihIA.Sptrint6.Project.V4\r\n";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 200);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(313, 239);
            textBox1.TabIndex = 6;
            textBox1.TabStop = false;
            textBox1.Text = "Программа предоставляет возможность просмотра библиотеки формата *csv с возможностью добавлениякниг в список желаний, с последующим сохранением.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 7;
            label1.Text = "Краткое сведение о программе";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 298);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonOK_BIA);
            Controls.Add(pictureBoxMe_BIA);
            Controls.Add(textBoxInfo_BIA);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_BIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_BIA;
        private PictureBox pictureBoxMe_BIA;
        private TextBox textBoxInfo_BIA;
        private TextBox textBox1;
        private Label label1;
    }
}