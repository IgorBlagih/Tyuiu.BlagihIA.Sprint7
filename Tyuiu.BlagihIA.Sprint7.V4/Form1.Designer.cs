namespace Tyuiu.BlagihIA.Sprint7.V4
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
            groupBoxBook_BIA = new GroupBox();
            comboBoxBooks_BIA = new ComboBox();
            groupBox1 = new GroupBox();
            comboBoxAuthors_BIA = new ComboBox();
            buttonOpenFile_BIA = new Button();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            toolTip2 = new ToolTip(components);
            openFileDialogTask_BIA = new OpenFileDialog();
            panelLeft_BIA = new Panel();
            groupBoxInfo_BIA = new GroupBox();
            buttonAdd_BIA = new Button();
            textBoxCost_BIA = new TextBox();
            textBoxData_BIA = new TextBox();
            labelData = new Label();
            textBoxDes_BIA = new TextBox();
            labelDescribe = new Label();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            groupBoxName_BIA = new GroupBox();
            textBoxName_BIA = new TextBox();
            splitter1 = new Splitter();
            panelTop_BIA.SuspendLayout();
            groupBoxTop_BIA.SuspendLayout();
            groupBoxBook_BIA.SuspendLayout();
            groupBox1.SuspendLayout();
            panelLeft_BIA.SuspendLayout();
            groupBoxInfo_BIA.SuspendLayout();
            groupBoxName_BIA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BIA
            // 
            panelTop_BIA.Controls.Add(groupBoxTop_BIA);
            panelTop_BIA.Dock = DockStyle.Top;
            panelTop_BIA.Location = new Point(0, 0);
            panelTop_BIA.Name = "panelTop_BIA";
            panelTop_BIA.Size = new Size(1130, 142);
            panelTop_BIA.TabIndex = 1;
            // 
            // groupBoxTop_BIA
            // 
            groupBoxTop_BIA.Controls.Add(groupBoxBook_BIA);
            groupBoxTop_BIA.Controls.Add(groupBox1);
            groupBoxTop_BIA.Controls.Add(buttonOpenFile_BIA);
            groupBoxTop_BIA.Dock = DockStyle.Fill;
            groupBoxTop_BIA.Location = new Point(0, 0);
            groupBoxTop_BIA.Name = "groupBoxTop_BIA";
            groupBoxTop_BIA.Size = new Size(1130, 142);
            groupBoxTop_BIA.TabIndex = 0;
            groupBoxTop_BIA.TabStop = false;
            groupBoxTop_BIA.Text = "Поиск";
            // 
            // groupBoxBook_BIA
            // 
            groupBoxBook_BIA.Controls.Add(comboBoxBooks_BIA);
            groupBoxBook_BIA.Location = new Point(116, 68);
            groupBoxBook_BIA.Name = "groupBoxBook_BIA";
            groupBoxBook_BIA.Size = new Size(597, 50);
            groupBoxBook_BIA.TabIndex = 3;
            groupBoxBook_BIA.TabStop = false;
            groupBoxBook_BIA.Text = "Книги:";
            // 
            // comboBoxBooks_BIA
            // 
            comboBoxBooks_BIA.Enabled = false;
            comboBoxBooks_BIA.FormattingEnabled = true;
            comboBoxBooks_BIA.Location = new Point(6, 19);
            comboBoxBooks_BIA.Name = "comboBoxBooks_BIA";
            comboBoxBooks_BIA.Size = new Size(585, 23);
            comboBoxBooks_BIA.TabIndex = 0;
            comboBoxBooks_BIA.SelectedValueChanged += comboBoxBooks_BIA_SelectedValueChanged;
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
            comboBoxAuthors_BIA.Sorted = true;
            comboBoxAuthors_BIA.TabIndex = 0;
            comboBoxAuthors_BIA.SelectedValueChanged += comboBoxAuthors_BIA_SelectedValueChanged;
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
            // panelLeft_BIA
            // 
            panelLeft_BIA.Controls.Add(groupBoxInfo_BIA);
            panelLeft_BIA.Dock = DockStyle.Left;
            panelLeft_BIA.Location = new Point(0, 142);
            panelLeft_BIA.Name = "panelLeft_BIA";
            panelLeft_BIA.Size = new Size(482, 391);
            panelLeft_BIA.TabIndex = 2;
            // 
            // groupBoxInfo_BIA
            // 
            groupBoxInfo_BIA.Controls.Add(buttonAdd_BIA);
            groupBoxInfo_BIA.Controls.Add(textBoxCost_BIA);
            groupBoxInfo_BIA.Controls.Add(textBoxData_BIA);
            groupBoxInfo_BIA.Controls.Add(labelData);
            groupBoxInfo_BIA.Controls.Add(textBoxDes_BIA);
            groupBoxInfo_BIA.Controls.Add(labelDescribe);
            groupBoxInfo_BIA.Controls.Add(textBoxAuthor);
            groupBoxInfo_BIA.Controls.Add(labelAuthor);
            groupBoxInfo_BIA.Controls.Add(groupBoxName_BIA);
            groupBoxInfo_BIA.Dock = DockStyle.Fill;
            groupBoxInfo_BIA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInfo_BIA.Location = new Point(0, 0);
            groupBoxInfo_BIA.Name = "groupBoxInfo_BIA";
            groupBoxInfo_BIA.Size = new Size(482, 391);
            groupBoxInfo_BIA.TabIndex = 0;
            groupBoxInfo_BIA.TabStop = false;
            groupBoxInfo_BIA.Text = "Информация о книге";
            // 
            // buttonAdd_BIA
            // 
            buttonAdd_BIA.Location = new Point(315, 243);
            buttonAdd_BIA.Name = "buttonAdd_BIA";
            buttonAdd_BIA.Size = new Size(151, 60);
            buttonAdd_BIA.TabIndex = 9;
            buttonAdd_BIA.Text = "Добавить";
            buttonAdd_BIA.UseVisualStyleBackColor = true;
            // 
            // textBoxCost_BIA
            // 
            textBoxCost_BIA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCost_BIA.Location = new Point(338, 195);
            textBoxCost_BIA.Multiline = true;
            textBoxCost_BIA.Name = "textBoxCost_BIA";
            textBoxCost_BIA.ReadOnly = true;
            textBoxCost_BIA.Size = new Size(128, 32);
            textBoxCost_BIA.TabIndex = 8;
            textBoxCost_BIA.Text = "а";
            textBoxCost_BIA.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxData_BIA
            // 
            textBoxData_BIA.Location = new Point(394, 104);
            textBoxData_BIA.Name = "textBoxData_BIA";
            textBoxData_BIA.ReadOnly = true;
            textBoxData_BIA.Size = new Size(72, 23);
            textBoxData_BIA.TabIndex = 7;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.BackColor = SystemColors.Control;
            labelData.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelData.ForeColor = SystemColors.GrayText;
            labelData.Location = new Point(307, 105);
            labelData.Name = "labelData";
            labelData.Size = new Size(81, 17);
            labelData.TabIndex = 6;
            labelData.Text = "Год издания";
            labelData.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDes_BIA
            // 
            textBoxDes_BIA.Location = new Point(17, 105);
            textBoxDes_BIA.Multiline = true;
            textBoxDes_BIA.Name = "textBoxDes_BIA";
            textBoxDes_BIA.ReadOnly = true;
            textBoxDes_BIA.Size = new Size(235, 281);
            textBoxDes_BIA.TabIndex = 5;
            // 
            // labelDescribe
            // 
            labelDescribe.AutoSize = true;
            labelDescribe.BackColor = SystemColors.Control;
            labelDescribe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDescribe.ForeColor = SystemColors.GrayText;
            labelDescribe.Location = new Point(12, 85);
            labelDescribe.Name = "labelDescribe";
            labelDescribe.Size = new Size(66, 17);
            labelDescribe.TabIndex = 4;
            labelDescribe.Text = "Описание";
            labelDescribe.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.BorderStyle = BorderStyle.None;
            textBoxAuthor.Location = new Point(230, 44);
            textBoxAuthor.Multiline = true;
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.ReadOnly = true;
            textBoxAuthor.Size = new Size(236, 54);
            textBoxAuthor.TabIndex = 3;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.BackColor = SystemColors.Control;
            labelAuthor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuthor.ForeColor = SystemColors.GrayText;
            labelAuthor.Location = new Point(180, 44);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(44, 17);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Автор";
            labelAuthor.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBoxName_BIA
            // 
            groupBoxName_BIA.Controls.Add(textBoxName_BIA);
            groupBoxName_BIA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxName_BIA.Location = new Point(11, 35);
            groupBoxName_BIA.Name = "groupBoxName_BIA";
            groupBoxName_BIA.Size = new Size(163, 47);
            groupBoxName_BIA.TabIndex = 0;
            groupBoxName_BIA.TabStop = false;
            groupBoxName_BIA.Text = "Название книги";
            // 
            // textBoxName_BIA
            // 
            textBoxName_BIA.BorderStyle = BorderStyle.None;
            textBoxName_BIA.Location = new Point(6, 22);
            textBoxName_BIA.Name = "textBoxName_BIA";
            textBoxName_BIA.ReadOnly = true;
            textBoxName_BIA.Size = new Size(144, 16);
            textBoxName_BIA.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(482, 142);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 391);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 533);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_BIA);
            Controls.Add(panelTop_BIA);
            Name = "Form1";
            Text = "Form1";
            panelTop_BIA.ResumeLayout(false);
            groupBoxTop_BIA.ResumeLayout(false);
            groupBoxBook_BIA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelLeft_BIA.ResumeLayout(false);
            groupBoxInfo_BIA.ResumeLayout(false);
            groupBoxInfo_BIA.PerformLayout();
            groupBoxName_BIA.ResumeLayout(false);
            groupBoxName_BIA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BIA;
        private GroupBox groupBoxTop_BIA;
        private GroupBox groupBoxBook_BIA;
        private ComboBox comboBoxBooks_BIA;
        private GroupBox groupBox1;
        private ComboBox comboBoxAuthors_BIA;
        private Button buttonOpenFile_BIA;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTip2;
        private OpenFileDialog openFileDialogTask_BIA;
        private Panel panelLeft_BIA;
        private GroupBox groupBoxInfo_BIA;
        private Splitter splitter1;
        private GroupBox groupBoxName_BIA;
        private TextBox textBoxAuthor;
        private Label labelAuthor;
        private TextBox textBoxName_BIA;
        private TextBox textBoxDes_BIA;
        private Label labelDescribe;
        private Button buttonAdd_BIA;
        private TextBox textBoxCost_BIA;
        private TextBox textBoxData_BIA;
        private Label labelData;
    }
}
