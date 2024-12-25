using Project.V1.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;

        public static string[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            string[,] data = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = line[j];
                }
            }
            return data;
        }

        private void buttonOpenFile_KAA_Click(object sender, EventArgs e)
        {
            openFileDialogInputFile_KAA.ShowDialog();
            openFilePath = openFileDialogInputFile_KAA.FileName;

            string[,] data = new string[rows, cols];

            data = LoadFromFileData(openFilePath);

            dataGridViewInputData_KAA.ColumnCount = cols;
            dataGridViewInputData_KAA.RowCount = rows + 1;
            dataGridViewOutputData_KAA.ColumnCount = cols;
            dataGridViewOutputData_KAA.RowCount = rows + 1;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewInputData_KAA.Columns[i].Width = 190;
                dataGridViewOutputData_KAA.Columns[i].Width = 190;
            }

            dataGridViewInputData_KAA.Rows[0].Cells[0].Value = "���. ����� ����������";
            dataGridViewInputData_KAA.Rows[0].Cells[1].Value = "����� ����������";
            dataGridViewInputData_KAA.Rows[0].Cells[2].Value = "���� ����������";
            dataGridViewInputData_KAA.Rows[0].Cells[3].Value = "�������� ���������, �.�.";
            dataGridViewInputData_KAA.Rows[0].Height = 50;

            int r = 1;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    dataGridViewInputData_KAA.Rows[r].Cells[j].Value = data[i, j];

                }
                r++;
            }
            buttonSaveFile_KAA.Enabled = true;
            buttonSortColor_KAA.Enabled = true;
            buttonSortBrand_KAA.Enabled = true;
            buttonChartCreate_KAA.Enabled = true;
            buttonAverageStatCreateDataGridView_KAA.Enabled = true;
            buttonSearchByNumber_KAA.Enabled = true;
        }

        private void buttonSaveFile_KAA_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveResult_KAA.FileName = "file.csv";
            saveFileDialogSaveResult_KAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogSaveResult_KAA.ShowDialog();


            string path = saveFileDialogSaveResult_KAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            try
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (dataGridViewOutputData_KAA.Rows[i].Cells[j].Value.ToString() == "") break;
                        if (j != cols - 1)
                        {
                            str += dataGridViewOutputData_KAA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewOutputData_KAA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {

            }
        }

        private void buttonSortColor_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, cols];
            data = LoadFromFileData(openFilePath);

            dataGridViewOutputData_KAA.Rows.Clear();
            dataGridViewOutputData_KAA.ColumnCount = cols;
            dataGridViewOutputData_KAA.RowCount = rows + 1;
            dataGridViewOutputData_KAA.Rows[0].Cells[0].Value = "���. ����� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[1].Value = "����� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[2].Value = "���� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[3].Value = "�������� ���������, �.�.";
            dataGridViewOutputData_KAA.Rows[0].Height = 50;
            dataGridViewOutputData_KAA.Rows[0].Height = 50;

            int r = 1;
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "�����")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "����������")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "�������")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "��������")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "���������")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "�����")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "����������")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 2] == "������")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
        }

        private void buttonSortBrand_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, cols];
            data = LoadFromFileData(openFilePath);

            dataGridViewOutputData_KAA.Rows.Clear();
            dataGridViewOutputData_KAA.ColumnCount = cols;
            dataGridViewOutputData_KAA.RowCount = rows + 1;
            dataGridViewOutputData_KAA.Rows[0].Cells[0].Value = "���. ����� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[1].Value = "����� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[2].Value = "���� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[3].Value = "�������� ���������, �.�.";
            dataGridViewOutputData_KAA.Rows[0].Height = 50;

            int r = 1;
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 1] == "Audi")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 1] == "BMW")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 1] == "Lada")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 1] == "Porshe")
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
        }

        private void buttonChartCreate_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, cols];

            data = LoadFromFileData(openFilePath);

            this.chartStats_KAA.ChartAreas[0].AxisX.Title = "����� ����������";
            this.chartStats_KAA.ChartAreas[0].AxisY.Title = "��. �������� ���������";

            double avgPwrAudi = 0;
            int AudiCount = 0;
            double avgPwrPorshe = 0;
            int PorsheCount = 0;
            double avgPwrBMW = 0;
            int BMWCount = 0;
            double avgPwrLada = 0;
            int LadaCount = 0;

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 1] == "Audi")
                {
                    avgPwrAudi += Convert.ToInt32(data[i, 3]);
                    AudiCount++;
                }
                if (data[i, 1] == "BMW")
                {
                    avgPwrBMW += Convert.ToInt32(data[i, 3]);
                    BMWCount++;
                }
                if (data[i, 1] == "Lada")
                {
                    avgPwrLada += Convert.ToInt32(data[i, 3]);
                    LadaCount++;
                }
                if (data[i, 1] == "Porshe")
                {
                    avgPwrPorshe += Convert.ToInt32(data[i, 3]);
                    PorsheCount++;
                }
            }

            avgPwrAudi = Math.Round(avgPwrAudi / AudiCount, 2);
            avgPwrBMW = Math.Round(avgPwrBMW / BMWCount, 2);
            avgPwrLada = Math.Round(avgPwrLada / LadaCount, 2);
            avgPwrPorshe = Math.Round(avgPwrPorshe / PorsheCount, 2);

            this.chartStats_KAA.Series.Add("Audi");
            this.chartStats_KAA.Series.Add("BMW");
            this.chartStats_KAA.Series.Add("Lada");
            this.chartStats_KAA.Series.Add("Porshe");


            foreach (Series series in this.chartStats_KAA.Series)
            {
                series.ChartType = SeriesChartType.Column;
            }

            this.chartStats_KAA.Series["Audi"].Points.AddXY(0, avgPwrAudi);
            this.chartStats_KAA.Series["BMW"].Points.AddXY(1, avgPwrBMW);
            this.chartStats_KAA.Series["Lada"].Points.AddXY(2, avgPwrLada);
            this.chartStats_KAA.Series["Porshe"].Points.AddXY(3, avgPwrPorshe);
        }

        private void buttonAverageStatCreateDataGridView_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, cols];
            data = LoadFromFileData(openFilePath);

            dataGridViewStats_KAA.ColumnCount = 2;
            dataGridViewStats_KAA.RowCount = 6;

            dataGridViewStats_KAA.Rows[0].Cells[0].Value = "����� ���-�� �����";
            dataGridViewStats_KAA.Rows[1].Cells[0].Value = "������������� ���� �����";
            dataGridViewStats_KAA.Rows[2].Cells[0].Value = "������������� ����� �����";
            dataGridViewStats_KAA.Rows[3].Cells[0].Value = "������� �������� ���������";
            dataGridViewStats_KAA.Rows[4].Cells[0].Value = "������������ �������� ���������";
            dataGridViewStats_KAA.Rows[5].Cells[0].Value = "����������� �������� ���������";
            dataGridViewStats_KAA.Columns[0].Width = 300;
            dataGridViewStats_KAA.Columns[1].Width = 100;
            dataGridViewStats_KAA.Rows[0].Cells[1].Value = dataGridViewInputData_KAA.Rows.Count - 1;
            int Red = 0;
            int Blue = 0;
            int White = 0;
            int Black = 0;
            int Violet = 0;
            int Brown = 0;
            int Orange = 0;
            int Metal = 0;
            int Audi = 0;
            int BMW = 0;
            int Lada = 0;
            int Porshe = 0;
            double AvgPower = 0;
            int maxPower = 0;
            int minPower = 1000;
            for (int i = 0; i < rows; i++)
            {
                switch (data[i, 2])
                {
                    case "�������":
                        Red++; break;
                    case "�����":
                        Blue++; break;
                    case "�����":
                        White++; break;
                    case "������":
                        Black++; break;
                    case "��������":
                        Metal++; break;
                    case "���������":
                        Orange++; break;
                    case "����������":
                        Violet++; break;
                    case "����������":
                        Brown++; break;
                }
                switch (data[i, 1])
                {
                    case "Audi":
                        Audi++; break;
                    case "BMW":
                        BMW++; break;
                    case "Lada":
                        Lada++; break;
                    case "Porshe":
                        Porshe++; break;
                }
                AvgPower += Convert.ToInt32(data[i, 3]);
                if (Convert.ToInt32(data[i, 3]) >= maxPower)
                {
                    maxPower = Convert.ToInt32(data[i, 3]);
                }
                if (Convert.ToInt32(data[i, 3]) <= minPower)
                {
                    minPower = Convert.ToInt32(data[i, 3]);
                }
            }
            AvgPower = Math.Round(AvgPower / (dataGridViewInputData_KAA.Rows.Count - 1), 2);
            string Color;
            int maxcolor = Math.Max(Red, Math.Max(
                Blue, Math.Max(
                    White, Math.Max(
                        Black, Math.Max(
                            Metal, Math.Max(Orange, Math.Max(Violet, Brown)))))));

            if (maxcolor == Red) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "�������";
            if (maxcolor == Blue) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "�����";
            if (maxcolor == White) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "�����";
            if (maxcolor == Black) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "������";
            if (maxcolor == Metal) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "��������";
            if (maxcolor == Orange) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "���������";
            if (maxcolor == Violet) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "����������";
            if (maxcolor == Brown) dataGridViewStats_KAA.Rows[1].Cells[1].Value = "����������";

            int maxBrand = Math.Max(Audi, Math.Max(
                                                    BMW, Math.Max(Lada, Porshe)));
            if (maxBrand == Audi) dataGridViewStats_KAA.Rows[2].Cells[1].Value = "Audi";
            if (maxBrand == BMW) dataGridViewStats_KAA.Rows[2].Cells[1].Value = "BMW";
            if (maxBrand == Lada) dataGridViewStats_KAA.Rows[2].Cells[1].Value = "Lada";
            if (maxBrand == Porshe) dataGridViewStats_KAA.Rows[2].Cells[1].Value = "Porshe";
            dataGridViewStats_KAA.Rows[3].Cells[1].Value = Convert.ToString(AvgPower);
            dataGridViewStats_KAA.Rows[4].Cells[1].Value = Convert.ToString(maxPower);
            dataGridViewStats_KAA.Rows[5].Cells[1].Value = Convert.ToString(minPower);
        }

        private void buttonSearchByNumber_KAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, cols];

            data = LoadFromFileData(openFilePath);
            int r = 1;
            dataGridViewOutputData_KAA.Rows.Clear();
            dataGridViewOutputData_KAA.ColumnCount = cols;
            dataGridViewOutputData_KAA.RowCount = rows + 1;
            dataGridViewOutputData_KAA.Rows[0].Cells[0].Value = "���. ����� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[1].Value = "����� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[2].Value = "���� ����������";
            dataGridViewOutputData_KAA.Rows[0].Cells[3].Value = "�������� ���������, �.�.";
            dataGridViewOutputData_KAA.Rows[0].Height = 50;

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 0] == textBoxSearch_KAA.Text)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewOutputData_KAA.Rows[r].Cells[j].Value = data[i, j];
                    }
                    r++;
                }
            }
            if (r == 1)
            {
                MessageBox.Show("����� ������ ������� ��� ������ � ����� ������� ��� � ��������������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
