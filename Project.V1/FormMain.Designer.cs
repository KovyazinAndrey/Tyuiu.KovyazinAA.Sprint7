namespace Project.V1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PanelTools_KAA = new Panel();
            ToolsPanel_KAA = new GroupBox();
            buttonHelp_KAA = new Button();
            groupBoxSearchByNumber_KAA = new GroupBox();
            textBoxSearch_KAA = new TextBox();
            buttonSearchByNumber_KAA = new Button();
            groupBoxStats_KAA = new GroupBox();
            buttonAverageStatCreateDataGridView_KAA = new Button();
            buttonChartCreate_KAA = new Button();
            groupBoxSort_KAA = new GroupBox();
            buttonSortBrand_KAA = new Button();
            buttonSortColor_KAA = new Button();
            buttonSaveFile_KAA = new Button();
            buttonOpenFile_KAA = new Button();
            panelDataGridInput_KAA = new Panel();
            dataGridViewInputData_KAA = new DataGridView();
            splitterBetweenDataGridInputAndOutput_KAA = new Splitter();
            panelDataGridOutput_KAA = new Panel();
            dataGridViewOutputData_KAA = new DataGridView();
            splitterBetweenDataGrinOutputAndStats_KAA = new Splitter();
            panelStats_KAA = new Panel();
            chartStats_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewStats_KAA = new DataGridView();
            openFileDialogInputFile_KAA = new OpenFileDialog();
            saveFileDialogSaveResult_KAA = new SaveFileDialog();
            toolTip_KAA = new ToolTip(components);
            splitterBetweenChartStatsAndDataGridViewStats_KAA = new Splitter();
            panelDataGridStats_KAA = new Panel();
            PanelTools_KAA.SuspendLayout();
            ToolsPanel_KAA.SuspendLayout();
            groupBoxSearchByNumber_KAA.SuspendLayout();
            groupBoxStats_KAA.SuspendLayout();
            groupBoxSort_KAA.SuspendLayout();
            panelDataGridInput_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputData_KAA).BeginInit();
            panelDataGridOutput_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData_KAA).BeginInit();
            panelStats_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStats_KAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_KAA).BeginInit();
            panelDataGridStats_KAA.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTools_KAA
            // 
            PanelTools_KAA.Controls.Add(ToolsPanel_KAA);
            PanelTools_KAA.Dock = DockStyle.Top;
            PanelTools_KAA.Location = new Point(0, 0);
            PanelTools_KAA.Name = "PanelTools_KAA";
            PanelTools_KAA.Size = new Size(1582, 148);
            PanelTools_KAA.TabIndex = 0;
            // 
            // ToolsPanel_KAA
            // 
            ToolsPanel_KAA.Controls.Add(buttonHelp_KAA);
            ToolsPanel_KAA.Controls.Add(groupBoxSearchByNumber_KAA);
            ToolsPanel_KAA.Controls.Add(groupBoxStats_KAA);
            ToolsPanel_KAA.Controls.Add(groupBoxSort_KAA);
            ToolsPanel_KAA.Controls.Add(buttonSaveFile_KAA);
            ToolsPanel_KAA.Controls.Add(buttonOpenFile_KAA);
            ToolsPanel_KAA.Dock = DockStyle.Fill;
            ToolsPanel_KAA.Location = new Point(0, 0);
            ToolsPanel_KAA.Name = "ToolsPanel_KAA";
            ToolsPanel_KAA.Size = new Size(1582, 148);
            ToolsPanel_KAA.TabIndex = 0;
            ToolsPanel_KAA.TabStop = false;
            ToolsPanel_KAA.Text = "Панель инструментов";
            // 
            // buttonHelp_KAA
            // 
            buttonHelp_KAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAA.Cursor = Cursors.Hand;
            buttonHelp_KAA.Image = (Image)resources.GetObject("buttonHelp_KAA.Image");
            buttonHelp_KAA.Location = new Point(1454, 26);
            buttonHelp_KAA.Name = "buttonHelp_KAA";
            buttonHelp_KAA.Size = new Size(122, 110);
            buttonHelp_KAA.TabIndex = 5;
            toolTip_KAA.SetToolTip(buttonHelp_KAA, "О программе");
            buttonHelp_KAA.UseVisualStyleBackColor = true;
            buttonHelp_KAA.Click += buttonHelp_KAA_Click;
            // 
            // groupBoxSearchByNumber_KAA
            // 
            groupBoxSearchByNumber_KAA.Controls.Add(textBoxSearch_KAA);
            groupBoxSearchByNumber_KAA.Controls.Add(buttonSearchByNumber_KAA);
            groupBoxSearchByNumber_KAA.Location = new Point(745, 32);
            groupBoxSearchByNumber_KAA.Name = "groupBoxSearchByNumber_KAA";
            groupBoxSearchByNumber_KAA.Size = new Size(395, 116);
            groupBoxSearchByNumber_KAA.TabIndex = 4;
            groupBoxSearchByNumber_KAA.TabStop = false;
            groupBoxSearchByNumber_KAA.Text = "Поиск";
            // 
            // textBoxSearch_KAA
            // 
            textBoxSearch_KAA.Location = new Point(163, 55);
            textBoxSearch_KAA.Name = "textBoxSearch_KAA";
            textBoxSearch_KAA.Size = new Size(226, 27);
            textBoxSearch_KAA.TabIndex = 1;
            // 
            // buttonSearchByNumber_KAA
            // 
            buttonSearchByNumber_KAA.BackgroundImage = (Image)resources.GetObject("buttonSearchByNumber_KAA.BackgroundImage");
            buttonSearchByNumber_KAA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearchByNumber_KAA.Cursor = Cursors.Hand;
            buttonSearchByNumber_KAA.Enabled = false;
            buttonSearchByNumber_KAA.Location = new Point(6, 26);
            buttonSearchByNumber_KAA.Name = "buttonSearchByNumber_KAA";
            buttonSearchByNumber_KAA.Size = new Size(151, 84);
            buttonSearchByNumber_KAA.TabIndex = 0;
            toolTip_KAA.SetToolTip(buttonSearchByNumber_KAA, "Поиск по Гос. номеру автомобиля");
            buttonSearchByNumber_KAA.UseVisualStyleBackColor = true;
            buttonSearchByNumber_KAA.Click += buttonSearchByNumber_KAA_Click;
            // 
            // groupBoxStats_KAA
            // 
            groupBoxStats_KAA.Controls.Add(buttonAverageStatCreateDataGridView_KAA);
            groupBoxStats_KAA.Controls.Add(buttonChartCreate_KAA);
            groupBoxStats_KAA.Location = new Point(524, 26);
            groupBoxStats_KAA.Name = "groupBoxStats_KAA";
            groupBoxStats_KAA.Size = new Size(215, 116);
            groupBoxStats_KAA.TabIndex = 3;
            groupBoxStats_KAA.TabStop = false;
            groupBoxStats_KAA.Text = "Статистика";
            // 
            // buttonAverageStatCreateDataGridView_KAA
            // 
            buttonAverageStatCreateDataGridView_KAA.BackgroundImage = (Image)resources.GetObject("buttonAverageStatCreateDataGridView_KAA.BackgroundImage");
            buttonAverageStatCreateDataGridView_KAA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAverageStatCreateDataGridView_KAA.Cursor = Cursors.Hand;
            buttonAverageStatCreateDataGridView_KAA.Enabled = false;
            buttonAverageStatCreateDataGridView_KAA.Location = new Point(106, 26);
            buttonAverageStatCreateDataGridView_KAA.Name = "buttonAverageStatCreateDataGridView_KAA";
            buttonAverageStatCreateDataGridView_KAA.Size = new Size(100, 84);
            buttonAverageStatCreateDataGridView_KAA.TabIndex = 1;
            toolTip_KAA.SetToolTip(buttonAverageStatCreateDataGridView_KAA, "Различная статискика");
            buttonAverageStatCreateDataGridView_KAA.UseVisualStyleBackColor = true;
            buttonAverageStatCreateDataGridView_KAA.Click += buttonAverageStatCreateDataGridView_KAA_Click;
            // 
            // buttonChartCreate_KAA
            // 
            buttonChartCreate_KAA.BackgroundImage = (Image)resources.GetObject("buttonChartCreate_KAA.BackgroundImage");
            buttonChartCreate_KAA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonChartCreate_KAA.Cursor = Cursors.Hand;
            buttonChartCreate_KAA.Enabled = false;
            buttonChartCreate_KAA.Location = new Point(6, 26);
            buttonChartCreate_KAA.Name = "buttonChartCreate_KAA";
            buttonChartCreate_KAA.Size = new Size(94, 84);
            buttonChartCreate_KAA.TabIndex = 0;
            toolTip_KAA.SetToolTip(buttonChartCreate_KAA, "Показать график ");
            buttonChartCreate_KAA.UseVisualStyleBackColor = true;
            buttonChartCreate_KAA.Click += buttonChartCreate_KAA_Click;
            // 
            // groupBoxSort_KAA
            // 
            groupBoxSort_KAA.Controls.Add(buttonSortBrand_KAA);
            groupBoxSort_KAA.Controls.Add(buttonSortColor_KAA);
            groupBoxSort_KAA.Location = new Point(308, 26);
            groupBoxSort_KAA.Name = "groupBoxSort_KAA";
            groupBoxSort_KAA.Size = new Size(210, 116);
            groupBoxSort_KAA.TabIndex = 2;
            groupBoxSort_KAA.TabStop = false;
            groupBoxSort_KAA.Text = "Сортировка";
            // 
            // buttonSortBrand_KAA
            // 
            buttonSortBrand_KAA.BackgroundImage = (Image)resources.GetObject("buttonSortBrand_KAA.BackgroundImage");
            buttonSortBrand_KAA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSortBrand_KAA.Cursor = Cursors.Hand;
            buttonSortBrand_KAA.Enabled = false;
            buttonSortBrand_KAA.Location = new Point(106, 26);
            buttonSortBrand_KAA.Name = "buttonSortBrand_KAA";
            buttonSortBrand_KAA.Size = new Size(94, 84);
            buttonSortBrand_KAA.TabIndex = 1;
            toolTip_KAA.SetToolTip(buttonSortBrand_KAA, "Сортировка таблицы по марке");
            buttonSortBrand_KAA.UseVisualStyleBackColor = true;
            buttonSortBrand_KAA.Click += buttonSortBrand_KAA_Click;
            // 
            // buttonSortColor_KAA
            // 
            buttonSortColor_KAA.BackgroundImage = (Image)resources.GetObject("buttonSortColor_KAA.BackgroundImage");
            buttonSortColor_KAA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSortColor_KAA.Cursor = Cursors.Hand;
            buttonSortColor_KAA.Enabled = false;
            buttonSortColor_KAA.Location = new Point(6, 26);
            buttonSortColor_KAA.Name = "buttonSortColor_KAA";
            buttonSortColor_KAA.Size = new Size(94, 84);
            buttonSortColor_KAA.TabIndex = 0;
            toolTip_KAA.SetToolTip(buttonSortColor_KAA, "Сортировка таблицы по цвету");
            buttonSortColor_KAA.UseVisualStyleBackColor = true;
            buttonSortColor_KAA.Click += buttonSortColor_KAA_Click;
            // 
            // buttonSaveFile_KAA
            // 
            buttonSaveFile_KAA.Cursor = Cursors.Hand;
            buttonSaveFile_KAA.Enabled = false;
            buttonSaveFile_KAA.Image = (Image)resources.GetObject("buttonSaveFile_KAA.Image");
            buttonSaveFile_KAA.Location = new Point(159, 26);
            buttonSaveFile_KAA.Name = "buttonSaveFile_KAA";
            buttonSaveFile_KAA.Size = new Size(143, 116);
            buttonSaveFile_KAA.TabIndex = 1;
            toolTip_KAA.SetToolTip(buttonSaveFile_KAA, "Сохранить в файл");
            buttonSaveFile_KAA.UseVisualStyleBackColor = true;
            buttonSaveFile_KAA.Click += buttonSaveFile_KAA_Click;
            // 
            // buttonOpenFile_KAA
            // 
            buttonOpenFile_KAA.Cursor = Cursors.Hand;
            buttonOpenFile_KAA.Image = (Image)resources.GetObject("buttonOpenFile_KAA.Image");
            buttonOpenFile_KAA.Location = new Point(12, 26);
            buttonOpenFile_KAA.Name = "buttonOpenFile_KAA";
            buttonOpenFile_KAA.Size = new Size(141, 116);
            buttonOpenFile_KAA.TabIndex = 0;
            toolTip_KAA.SetToolTip(buttonOpenFile_KAA, "Открыть файл");
            buttonOpenFile_KAA.UseVisualStyleBackColor = true;
            buttonOpenFile_KAA.Click += buttonOpenFile_KAA_Click;
            // 
            // panelDataGridInput_KAA
            // 
            panelDataGridInput_KAA.Controls.Add(dataGridViewInputData_KAA);
            panelDataGridInput_KAA.Dock = DockStyle.Left;
            panelDataGridInput_KAA.Location = new Point(0, 148);
            panelDataGridInput_KAA.Name = "panelDataGridInput_KAA";
            panelDataGridInput_KAA.Size = new Size(600, 505);
            panelDataGridInput_KAA.TabIndex = 1;
            // 
            // dataGridViewInputData_KAA
            // 
            dataGridViewInputData_KAA.AllowUserToAddRows = false;
            dataGridViewInputData_KAA.AllowUserToDeleteRows = false;
            dataGridViewInputData_KAA.AllowUserToResizeColumns = false;
            dataGridViewInputData_KAA.AllowUserToResizeRows = false;
            dataGridViewInputData_KAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInputData_KAA.Dock = DockStyle.Fill;
            dataGridViewInputData_KAA.Location = new Point(0, 0);
            dataGridViewInputData_KAA.Name = "dataGridViewInputData_KAA";
            dataGridViewInputData_KAA.ReadOnly = true;
            dataGridViewInputData_KAA.RowHeadersWidth = 51;
            dataGridViewInputData_KAA.Size = new Size(600, 505);
            dataGridViewInputData_KAA.TabIndex = 0;
            // 
            // splitterBetweenDataGridInputAndOutput_KAA
            // 
            splitterBetweenDataGridInputAndOutput_KAA.Location = new Point(600, 148);
            splitterBetweenDataGridInputAndOutput_KAA.Name = "splitterBetweenDataGridInputAndOutput_KAA";
            splitterBetweenDataGridInputAndOutput_KAA.Size = new Size(4, 505);
            splitterBetweenDataGridInputAndOutput_KAA.TabIndex = 2;
            splitterBetweenDataGridInputAndOutput_KAA.TabStop = false;
            // 
            // panelDataGridOutput_KAA
            // 
            panelDataGridOutput_KAA.Controls.Add(dataGridViewOutputData_KAA);
            panelDataGridOutput_KAA.Dock = DockStyle.Left;
            panelDataGridOutput_KAA.Location = new Point(604, 148);
            panelDataGridOutput_KAA.Name = "panelDataGridOutput_KAA";
            panelDataGridOutput_KAA.Size = new Size(600, 505);
            panelDataGridOutput_KAA.TabIndex = 3;
            // 
            // dataGridViewOutputData_KAA
            // 
            dataGridViewOutputData_KAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutputData_KAA.Dock = DockStyle.Fill;
            dataGridViewOutputData_KAA.Location = new Point(0, 0);
            dataGridViewOutputData_KAA.Name = "dataGridViewOutputData_KAA";
            dataGridViewOutputData_KAA.RowHeadersWidth = 51;
            dataGridViewOutputData_KAA.Size = new Size(600, 505);
            dataGridViewOutputData_KAA.TabIndex = 0;
            // 
            // splitterBetweenDataGrinOutputAndStats_KAA
            // 
            splitterBetweenDataGrinOutputAndStats_KAA.Location = new Point(1204, 148);
            splitterBetweenDataGrinOutputAndStats_KAA.Name = "splitterBetweenDataGrinOutputAndStats_KAA";
            splitterBetweenDataGrinOutputAndStats_KAA.Size = new Size(4, 505);
            splitterBetweenDataGrinOutputAndStats_KAA.TabIndex = 4;
            splitterBetweenDataGrinOutputAndStats_KAA.TabStop = false;
            // 
            // panelStats_KAA
            // 
            panelStats_KAA.Controls.Add(chartStats_KAA);
            panelStats_KAA.Dock = DockStyle.Top;
            panelStats_KAA.Location = new Point(1208, 148);
            panelStats_KAA.Name = "panelStats_KAA";
            panelStats_KAA.Size = new Size(374, 254);
            panelStats_KAA.TabIndex = 5;
            // 
            // chartStats_KAA
            // 
            chartArea3.Name = "ChartArea1";
            chartStats_KAA.ChartAreas.Add(chartArea3);
            chartStats_KAA.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartStats_KAA.Legends.Add(legend3);
            chartStats_KAA.Location = new Point(0, 0);
            chartStats_KAA.Name = "chartStats_KAA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartStats_KAA.Series.Add(series3);
            chartStats_KAA.Size = new Size(374, 254);
            chartStats_KAA.TabIndex = 0;
            chartStats_KAA.Text = "chart1";
            // 
            // dataGridViewStats_KAA
            // 
            dataGridViewStats_KAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats_KAA.Dock = DockStyle.Fill;
            dataGridViewStats_KAA.Location = new Point(0, 0);
            dataGridViewStats_KAA.Name = "dataGridViewStats_KAA";
            dataGridViewStats_KAA.RowHeadersWidth = 51;
            dataGridViewStats_KAA.Size = new Size(374, 247);
            dataGridViewStats_KAA.TabIndex = 1;
            // 
            // openFileDialogInputFile_KAA
            // 
            openFileDialogInputFile_KAA.FileName = "openFileDialog1";
            // 
            // splitterBetweenChartStatsAndDataGridViewStats_KAA
            // 
            splitterBetweenChartStatsAndDataGridViewStats_KAA.Dock = DockStyle.Top;
            splitterBetweenChartStatsAndDataGridViewStats_KAA.Location = new Point(1208, 402);
            splitterBetweenChartStatsAndDataGridViewStats_KAA.Name = "splitterBetweenChartStatsAndDataGridViewStats_KAA";
            splitterBetweenChartStatsAndDataGridViewStats_KAA.Size = new Size(374, 4);
            splitterBetweenChartStatsAndDataGridViewStats_KAA.TabIndex = 6;
            splitterBetweenChartStatsAndDataGridViewStats_KAA.TabStop = false;
            // 
            // panelDataGridStats_KAA
            // 
            panelDataGridStats_KAA.Controls.Add(dataGridViewStats_KAA);
            panelDataGridStats_KAA.Dock = DockStyle.Fill;
            panelDataGridStats_KAA.Location = new Point(1208, 406);
            panelDataGridStats_KAA.Name = "panelDataGridStats_KAA";
            panelDataGridStats_KAA.Size = new Size(374, 247);
            panelDataGridStats_KAA.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 653);
            Controls.Add(panelDataGridStats_KAA);
            Controls.Add(splitterBetweenChartStatsAndDataGridViewStats_KAA);
            Controls.Add(panelStats_KAA);
            Controls.Add(splitterBetweenDataGrinOutputAndStats_KAA);
            Controls.Add(panelDataGridOutput_KAA);
            Controls.Add(splitterBetweenDataGridInputAndOutput_KAA);
            Controls.Add(panelDataGridInput_KAA);
            Controls.Add(PanelTools_KAA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторемонтные мастерские";
            WindowState = FormWindowState.Maximized;
            PanelTools_KAA.ResumeLayout(false);
            ToolsPanel_KAA.ResumeLayout(false);
            groupBoxSearchByNumber_KAA.ResumeLayout(false);
            groupBoxSearchByNumber_KAA.PerformLayout();
            groupBoxStats_KAA.ResumeLayout(false);
            groupBoxSort_KAA.ResumeLayout(false);
            panelDataGridInput_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputData_KAA).EndInit();
            panelDataGridOutput_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData_KAA).EndInit();
            panelStats_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStats_KAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_KAA).EndInit();
            panelDataGridStats_KAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTools_KAA;
        private GroupBox ToolsPanel_KAA;
        private Button buttonSaveFile_KAA;
        private Button buttonOpenFile_KAA;
        private GroupBox groupBoxSort_KAA;
        private Button buttonSortBrand_KAA;
        private Button buttonSortColor_KAA;
        private GroupBox groupBoxSearchByNumber_KAA;
        private Button buttonSearchByNumber_KAA;
        private GroupBox groupBoxStats_KAA;
        private Button buttonAverageStatCreateDataGridView_KAA;
        private Button buttonChartCreate_KAA;
        private Button buttonHelp_KAA;
        private Panel panelDataGridInput_KAA;
        private Splitter splitterBetweenDataGridInputAndOutput_KAA;
        private Panel panelDataGridOutput_KAA;
        private Splitter splitterBetweenDataGrinOutputAndStats_KAA;
        private Panel panelStats_KAA;
        private DataGridView dataGridViewInputData_KAA;
        private DataGridView dataGridViewOutputData_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_KAA;
        private DataGridView dataGridViewStats_KAA;
        private OpenFileDialog openFileDialogInputFile_KAA;
        private SaveFileDialog saveFileDialogSaveResult_KAA;
        private ToolTip toolTip_KAA;
        private Splitter splitterBetweenChartStatsAndDataGridViewStats_KAA;
        private Panel panelDataGridStats_KAA;
        private TextBox textBoxSearch_KAA;
    }
}
