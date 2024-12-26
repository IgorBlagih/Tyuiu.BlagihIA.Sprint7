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

        private void comboBoxAuthors_BIA_TextChanged(object sender, EventArgs e)
        {

            comboBoxAuthors_BIA.DataSource = comboBoxAuthors_BIA.Items;
            comboBoxAuthors_BIA.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxAuthors_BIA.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }
        
        private void comboBoxBooks_BIA_SelectedValueChanged(object sender, EventArgs e)
        {
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


        }
    }
}
