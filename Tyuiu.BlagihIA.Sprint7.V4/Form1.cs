using Tyuiu.BlagihIA.Sprint6.Task7.V24;
using Tyuiu.BlagihIA.Sprint7.V4.Lib;
namespace Tyuiu.BlagihIA.Sprint7.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int colums;
        static int sum = 0;
        int index;

        //Class1 ds = new Class1();




        private void buttonOpenFile_BIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BIA.ShowDialog();
            openFilePath = openFileDialogTask_BIA.FileName;


            string[,] authors = Class1.LoadFromFileData(openFilePath);
            rows = authors.GetLength(0);
            colums = authors.GetLength(1);
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= 1; j++)
                {

                    if (!comboBoxAuthors_BIA.Items.Contains(authors[i, j]))
                    {
                        comboBoxAuthors_BIA.Items.Add(authors[i, j]);
                    }
                }
            }

            comboBoxBooks_BIA.Enabled = true;



        }

        private void comboBoxAuthors_BIA_SelectedValueChanged(object sender, EventArgs e)
        {

            string[,] authors = Class1.LoadFromFileData(openFilePath);
            rows = authors.GetLength(0);
            colums = authors.GetLength(1);

            switch (Convert.ToString(comboBoxAuthors_BIA.SelectedItem))
            {

                case "Антон Чехов":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Антон Чехов")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }

                            }

                        }
                    }
                    break;

                case "Борис Пастернак":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Борис Пастернак")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Иван Гончаров":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Иван Гончаров")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Иван Тургенев":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Иван Тургенев")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Лев Толстой":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Лев Толстой")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Михаил Булгаков":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Михаил Булгаков")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Михаил Лермонтов":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Михаил Лермонтов")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Николай Гоголь":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Николай Гоголь")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "Федор Достоевский":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "Федор Достоевский")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;
            }
        }



        private void comboBoxBooks_BIA_SelectedValueChanged(object sender, EventArgs e)
        {
            groupBoxCart_BIA.Visible = true;
            groupBoxInfo_BIA.Visible = true;
            string[,] book = Class1.LoadFromFileData(openFilePath);
            rows = book.GetLength(0);
            colums = book.GetLength(1);
            string word = Convert.ToString(comboBoxBooks_BIA.SelectedItem);
            if (word != null)
            {
                textBoxName_BIA.Clear();
                textBoxCost_BIA.Clear();
                textBoxData_BIA.Clear();
                textBoxDes_BIA.Clear();
                textBoxName_BIA.AppendText(word);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= 1; j++)
                {

                    if (word == book[i, 0])
                    {
                        textBoxAuthor_BIA.AppendText(book[i, 1]);
                        textBoxData_BIA.AppendText(book[i, 2]);
                        textBoxDes_BIA.AppendText(book[i, 4]);

                        textBoxCost_BIA.AppendText(book[i, 3] + " RUB");


                    }


                }
            }




            dataGridViewCart_BIA.RowCount = rows;




        }

        private void buttonAdd_BIA_Click(object sender, EventArgs e)
        {
            int count = 0;

            string[,] book = Class1.LoadFromFileData(openFilePath);
            rows = book.GetLength(0);
            colums = book.GetLength(1);

            string word = Convert.ToString(comboBoxBooks_BIA.SelectedItem);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (word == book[i, 0])
                    {
                        for (int c = 0; c < rows; c++)
                        {

                            if (dataGridViewCart_BIA.Rows[c].Cells[0].Value == null)
                            {
                                textBoxSum_BIA.Clear();
                                dataGridViewCart_BIA.Rows[c].Cells[0].Value = word;
                                dataGridViewCart_BIA.Rows[c].Cells[1].Value = book[i, 3] + " RUB";
                                count++;

                                sum += Convert.ToInt32(book[i, 3]);
                                textBoxSum_BIA.AppendText(Convert.ToString(sum + " RUB"));
                            }
                            if (count == 1)
                            {
                                break;
                            }
                        }

                        buttonSave_BIA.Enabled = true;

                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            string[,] book = Class1.LoadFromFileData(openFilePath);
            rows = book.GetLength(0);
            colums = book.GetLength(1);



            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {

                    for (int c = rows - 1; c > 0; c--)
                    {

                        if (dataGridViewCart_BIA.Rows[c].Cells[0].Value != null)
                        {
                            textBoxSum_BIA.Clear();
                            count++;
                            dataGridViewCart_BIA.Rows[c].Cells[0].Value = null;
                            dataGridViewCart_BIA.Rows[c].Cells[1].Value = null;
                            sum -= Convert.ToInt32(book[i, 3]);
                            textBoxSum_BIA.AppendText(Convert.ToString(sum + " RUB"));
                        }
                        if (count == 1)
                        {
                            break;
                        }
                    }




                }
            }

        }

        private void buttonSave_BIA_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileProjectV4.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool exist = fileinfo.Exists;
            if (exist)
            {
                File.Delete(path);
            }

            int rows = dataGridViewCart_BIA.RowCount;
            int cols = dataGridViewCart_BIA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewCart_BIA.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewCart_BIA.Rows[i].Cells[j].Value;

                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_BIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
