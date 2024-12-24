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
        Class1 ds = new Class1();

        


        private void buttonOpenFile_BIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BIA.ShowDialog();
            openFilePath = openFileDialogTask_BIA.FileName;

            string[,] authors = LoadFromFileData(openFilePath);

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
            
            string[,] authors = LoadFromFileData(openFilePath);

            string word = Convert.ToString(comboBoxAuthors_BIA.SelectedItem;
            switch (word)
            {
                
                case "Антон Чехов":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i,1] == "Антон Чехов")
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
    }
}
