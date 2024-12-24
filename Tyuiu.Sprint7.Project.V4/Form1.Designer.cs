namespace Tyuiu.Sprint7.Project.V4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTop_BIA = new Panel();
            groupBoxTop_BIA = new GroupBox();
            groupBox2 = new GroupBox();
            comboBoxBooks_BIA = new ComboBox();
            groupBox1 = new GroupBox();
            comboBoxAuthors_BIA = new ComboBox();
            buttonOpenFile_BIA = new Button();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            toolTip2 = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            panelTop_BIA.SuspendLayout();
            groupBoxTop_BIA.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BIA
            // 
            panelTop_BIA.Controls.Add(groupBoxTop_BIA);
            panelTop_BIA.Dock = DockStyle.Top;
            panelTop_BIA.Location = new Point(0, 0);
            panelTop_BIA.Name = "panelTop_BIA";
            panelTop_BIA.Size = new Size(800, 142);
            panelTop_BIA.TabIndex = 0;
            // 
            // groupBoxTop_BIA
            // 
            groupBoxTop_BIA.Controls.Add(groupBox2);
            groupBoxTop_BIA.Controls.Add(groupBox1);
            groupBoxTop_BIA.Controls.Add(buttonOpenFile_BIA);
            groupBoxTop_BIA.Dock = DockStyle.Fill;
            groupBoxTop_BIA.Location = new Point(0, 0);
            groupBoxTop_BIA.Name = "groupBoxTop_BIA";
            groupBoxTop_BIA.Size = new Size(800, 142);
            groupBoxTop_BIA.TabIndex = 0;
            groupBoxTop_BIA.TabStop = false;
            groupBoxTop_BIA.Text = "Поиск";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxBooks_BIA);
            groupBox2.Location = new Point(116, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(597, 50);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Книги:";
            // 
            // comboBoxBooks_BIA
            // 
            comboBoxBooks_BIA.Enabled = false;
            comboBoxBooks_BIA.FormattingEnabled = true;
            comboBoxBooks_BIA.Location = new Point(6, 19);
            comboBoxBooks_BIA.Name = "comboBoxBooks_BIA";
            comboBoxBooks_BIA.Size = new Size(585, 23);
            comboBoxBooks_BIA.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxAuthors_BIA);
            groupBox1.Location = new Point(116, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 50);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Авторы:";
            // 
            // comboBoxAuthors_BIA
            // 
            comboBoxAuthors_BIA.FormattingEnabled = true;
            comboBoxAuthors_BIA.Location = new Point(6, 19);
            comboBoxAuthors_BIA.Name = "comboBoxAuthors_BIA";
            comboBoxAuthors_BIA.Size = new Size(585, 23);
            comboBoxAuthors_BIA.TabIndex = 0;
            // 
            // buttonOpenFile_BIA
            // 
            buttonOpenFile_BIA.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_BIA.FlatStyle = FlatStyle.Popup;
            buttonOpenFile_BIA.ForeColor = SystemColors.Control;
            buttonOpenFile_BIA.Image = (Image)resources.GetObject("buttonOpenFile_BIA.Image");
            buttonOpenFile_BIA.Location = new Point(12, 22);
            buttonOpenFile_BIA.Name = "buttonOpenFile_BIA";
            buttonOpenFile_BIA.Size = new Size(82, 67);
            buttonOpenFile_BIA.TabIndex = 1;
            toolTip1.SetToolTip(buttonOpenFile_BIA, "Выберете файл с библиотекой формата .csv\r\n");
            buttonOpenFile_BIA.UseVisualStyleBackColor = false;
            buttonOpenFile_BIA.Click += buttonOpenFile_BIA_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTop_BIA);
            Name = "Form1";
            Text = "Form1";
            panelTop_BIA.ResumeLayout(false);
            groupBoxTop_BIA.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BIA;
        private GroupBox groupBoxTop_BIA;
        private ComboBox comboBoxAuthors_BIA;
        private Button buttonOpenFile_BIA;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBoxBooks_BIA;
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTip2;
        private OpenFileDialog openFileDialogTask;
    }
}
