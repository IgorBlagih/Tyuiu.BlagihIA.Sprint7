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
                
                case "����� �����":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i,1] == "����� �����")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                                
                            }
                            
                        }
                    }
                    break;

                case "����� ���������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "����� ���������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "���� ��������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "���� ��������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "���� ��������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "���� ��������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "��� �������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "��� �������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "������ ��������":
                    comboBoxBooks_BIA.Items.Clear();    
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "������ ��������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "������ ���������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "������ ���������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "������� ������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "������� ������")
                            {
                                if (!comboBoxBooks_BIA.Items.Contains(authors[i, 0]))
                                {
                                    comboBoxBooks_BIA.Items.Add(authors[i, 0]);
                                }
                            }

                        }
                    }
                    break;

                case "����� �����������":
                    comboBoxBooks_BIA.Items.Clear();
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (authors[i, 1] == "����� �����������")
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
