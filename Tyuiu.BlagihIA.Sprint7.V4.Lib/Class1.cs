namespace Tyuiu.BlagihIA.Sprint7.V4.Lib
{
    public class Class1
    {
        public static string[,] LoadFromFileData(string filepath)
        {
            int rows;
            int colums;
            string fileData = File.ReadAllText(filepath);

            fileData = fileData.Replace("\n", "\r");

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            rows = lines.Length;
            colums = lines[0].Split(';').Length;
            string[,] list = new string[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] lines_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {

                    list[i, j] = lines_r[j];
                }
            }

            return list;



        }
    }
}
