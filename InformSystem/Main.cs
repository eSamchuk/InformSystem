using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ServiceProcess;
using System.Configuration;

namespace InformSystem
{
    public partial class Main : Form
    {
        SqlConnection sc;
        public bool terminate;
        public Main()
        {
            InitializeComponent();

            if (Environment.MachineName == "Samchuk".ToUpper())
            {
                sc = new SqlConnection(ConfigurationManager.ConnectionStrings["workConnection"].ConnectionString);
            }
            else if (Environment.MachineName == "RamielPC".ToUpper())
            {
                sc = new SqlConnection(ConfigurationManager.ConnectionStrings["homeConnection"].ConnectionString);

            }

            sc.Open();
            configureCustomGroupBoxes(false);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            sc.Close();
        }
        public void checkSqlService()
        {
            string myServiceName = "MSSQL$SQLEXPRESS"; 
            string status = null;

            ServiceController mySC = new ServiceController(myServiceName);

            try
            {
                status = mySC.Status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (mySC.Status.Equals(ServiceControllerStatus.Stopped) | mySC.Status.Equals(ServiceControllerStatus.Paused) | mySC.Status.Equals(ServiceControllerStatus.StopPending))
            {
                try
                {
                    mySC.Start();
                    mySC.WaitForStatus(ServiceControllerStatus.Running);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }

            }

            return;

        }
        public void configureCustomGroupBoxes(bool state)
        {
            foreach (var CGB in this.Controls.OfType<CustomGrpBox>().Where(n => n.Text != "Області"))
            {
                if (CGB.Text != "Розділи") CGB.Enabled = state;
            }

            if (oblSummCheck.Checked == false || agroCondCheck.Checked == false) regionsCGB.Enabled = false;
        }
        public void configureCheckBoxes(object patient)
        {
            foreach (var check in customGrpBox1.Controls.OfType<CheckBox>())
            {
                if (((CheckBox)patient).Name != check.Name)
                {
                    check.Checked = false;
                }
            }
            ((CheckBox)patient).BackColor = System.Drawing.SystemColors.ControlDark;
            variablesCombo.Items.Clear();
            seasonPeriodCombo.SelectedIndex = -1;
        }
        public void populateComboBox(ComboBox cmb, string sCommText)
        {
            cmb.Items.Clear();
            SqlCommand sComm = new SqlCommand(sCommText, sc);
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            
            sdr = sComm.ExecuteReader();

            while (sdr.Read())
            {
                try
                {
                    cmb.Items.Add(new ComboboxItem(sdr.GetString(1), sdr.GetInt32(0), sdr.GetInt32(2)));
                }
                catch
                {
                    cmb.Items.Add(new ComboboxItem(sdr.GetString(1), sdr.GetInt32(0), 0));
                }
            }

            sdr.Close();
        }
        public void populateComboBox(ComboBox cmb, int chapter)
        {
            cmb.Items.Clear();
            if (chapter < 4) chapter = 3;
            SqlCommand sComm = new SqlCommand($"SELECT SeasonName, SeasonID FROM Seasons WHERE Chapter = {chapter}", sc);
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = sComm.ExecuteReader();

            while (sdr.Read())
            {
                cmb.Items.Add(new ComboboxItem(sdr.GetString(0), sdr.GetInt32(1), 0));
            }

            sdr.Close();
        }
        private void checkBoxesChanged(object sender)
        {
            if (((CheckBox)sender).Checked == true)
            {
                configureCheckBoxes(sender);
                configureCustomGroupBoxes(true);

                populateComboBox(variablesCombo, $"SELECT VariableID, VariableName, VariableSeasonID FROM Variables WHERE VariableGroup = {(sender as CheckBox).TabIndex.ToString()}");


                if (((CheckBox)sender).Name == "agroCondCheck")
                {
                    regionsCGB.Text = "Культури";
                    regionsCGB.Enabled = true;
                    populateComboBox(regionsCombo, "SELECT * FROM AgroCultures");
                }
                else
                {
                    populateComboBox(regionsCombo, "SELECT * FROM Regions WHERE RegionID < 25");
                }
            }
            else
            {
                if (((CheckBox)sender).Name == "agroCondCheck")
                {
                    regionsCGB.Text = "Області";
                    regionsCGB.Enabled = false;
                }


                ((CheckBox)sender).BackColor = default(Color);
                ((CheckBox)sender).UseVisualStyleBackColor = true;
                variablesCombo.Items.Clear();
                seasonPeriodCombo.Items.Clear();
                regionsCombo.Items.Clear();

                configureCustomGroupBoxes(false);
            }
        }
        private void checksChanged(object sender, EventArgs e)
        {
            checkBoxesChanged(sender);
        }
        private void oblSummCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (oblSummCheck.Checked == true)
            {
                configureCheckBoxes(sender);
                configureCustomGroupBoxes(false);
                populateComboBox(regionsCombo, "SELECT * FROM Regions WHERE RegionID < 27");
                regionsCGB.Enabled = true;
            }
            else
            {
                oblSummCheck.BackColor = default(Color);
                oblSummCheck.UseVisualStyleBackColor = true;
                regionsCGB.Enabled = false;
            }
        }
        private void regionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeScaleCombo.SelectedIndex == 0 && (variablesCombo.SelectedIndex == 3 || variablesCombo.SelectedIndex == 4))
            {
                loadImage();
            }
            else if(oblSummCheck.Checked == true)
            {
                OblSummary oblSumm = new OblSummary(ref sc, (regionsCombo.SelectedItem as ComboboxItem).Value);
                oblSumm.ShowDialog();
            }
            else
            {
                populateComboBox(seasonPeriodCombo, $"SELECT SeasonID, SeasonName FROM Seasons WHERE Chapter = {(regionsCombo.SelectedIndex + 4).ToString()}");
                seasonPeriodCombo.SelectedIndex = -1;

                if (variablesCombo.SelectedIndex < 5)
                {
                    periodCGB.Enabled = true;
                    seasonPeriodCombo.SelectedIndex = 0;
                }
                else
                {
                    periodCGB.Enabled = false;
                    loadImage();
                }
            }
        }
        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void variablesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = (variablesCombo.SelectedItem as ComboboxItem).Season;

            if (agroCondCheck.Checked == false)
            {
                if (val != 0) populateComboBox(seasonPeriodCombo, $"SELECT SeasonID, SeasonName FROM Seasons WHERE SeasonID = {val}");
                else populateComboBox(seasonPeriodCombo, "SELECT SeasonID, SeasonName FROM Seasons WHERE SeasonID = 1 OR (SeasonID >= 4 AND SeasonID <= 7)");
                seasonPeriodCombo.SelectedIndex = 0;
            }
            else
            {
                if (timeScaleCombo.SelectedIndex == 0 && (variablesCombo.SelectedIndex == 3 || variablesCombo.SelectedIndex == 4))
                {
                    checkTwoCombosActive();
                }
                else
                {
                    if (variablesCombo.SelectedIndex < 5)
                    {
                        periodCGB.Enabled = true;
                        if (regionsCombo.SelectedIndex != -1) seasonPeriodCombo.SelectedIndex = 0;
                    }
                    else
                    {
                        periodCGB.Enabled = false;
                        seasonPeriodCombo.SelectedIndex = -1;
                        checkTwoCombosActive();
                    }
                }
                checkTwoCombosActive();
            }
          
        }
        private void seasonPeriodCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTwoCombosActive();
        }
        private void timeScaleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTwoCombosActive();
        }
        public void checkTwoCombosActive()
        {
            bool specialCondition = false;

            if (agroCondCheck.Checked == true && periodCGB.Enabled == false && regionsCombo.SelectedIndex != -1)
                specialCondition = true;


            if ((timeScaleCombo.SelectedIndex != -1 && seasonPeriodCombo.SelectedIndex != - 1 && variablesCombo.SelectedIndex != -1) || specialCondition)
            {
                if(!loadImage()) loadTable();
            }
        }
        public bool loadImage()
        {
            string sComm = null;

            if (seasonPeriodCombo.SelectedItem != null)
            {
                sComm = "SELECT ImageBinary FROM Images WHERE" +
                    $" ImageSeason = {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()}" +
                    $" AND ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)}" +
                    $" AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
            }
            else
            {
                sComm = "SELECT ImageBinary FROM Images WHERE " +
                    $" ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)}" +
                    $" AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
            }
            if (regionsCGB.Text == "Культури") sComm += $" AND ImageCulture = {(regionsCombo.SelectedIndex + 1).ToString()}";

            SqlCommand ss = new SqlCommand(sComm, sc);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(ss);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = dataSet.Tables[0].Rows[0]["ImageBinary"] as Byte[];
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
                pictureBox1.BringToFront();
                getDimension();
                return true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.inProgress;
                return false;
            }
        }
        public void loadTable()
        {
            bool exist;

            string tableName = null;

            if (regionsCGB.Text == "Культури")
            {
                if (variablesCombo.SelectedIndex < 5)
                { 
                   tableName = "Agro_Table_"
                   + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
                   + (seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString() + "_"
                   + (regionsCombo.SelectedIndex + 1).ToString() + "_"
                   + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
                }
                else
                {
                    tableName = "Agro_Table_"
                  + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
                  + (regionsCombo.SelectedIndex + 1).ToString() + "_"
                  + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
                }
            }
            else
            {
                tableName = "Table_"
                + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
                + (seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString() + "_"
                + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
            }

            isTableExists(tableName, out exist);

            if (exist)
            {
                SqlCommand sComm = new SqlCommand();
                sComm.Connection = sc;
                if (timeScaleCombo.Text.IndexOf("Проекції") == -1) sComm.CommandText = $"SELECT Regions.RegionName as 'Область', actualValue as 'Середнє за 1981-2010', changeSpeed as 'Швидкість зміни', pValue as 'Значимість' FROM Regions, {tableName} WHERE Regions.RegionID = {tableName}.RegionID";
                else sComm.CommandText = $"SELECT Regions.RegionName as Область, actualValue as 'Середнє 1981-2010', predictedValue as 'Прогнозоване значення', changeSpeed as 'Різниця', pValue as 'Значимість' FROM Regions, {tableName} WHERE Regions.RegionID = {tableName}.RegionID";
                SqlDataReader sReader;
                sReader = sComm.ExecuteReader();

                using (DataTable dt = new DataTable())
                {
                    dt.Load(sReader);
                    dataGridView2.DataSource = dt;
                }

                sReader.Close();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.Columns[0].Width = 110;
                dataGridView2.BringToFront();
                dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                getDimension();
            }
            else
            {
                pictureBox1.BringToFront();
                pictureBox1.Image = Properties.Resources.inProgress;
            }
        }
        public void loadSummaryTable()
        {
            dataGridView2.BringToFront();

            SqlDataReader sReader;
            SqlCommand sComm = new SqlCommand("SELECT VariableName as Параметр, ActualValue as 'Середнє за 1981-2010', ChangeSpeedActual as 'Швидкість зміни', ActualSignif as 'Значимість', PredictedValue as 'Проекція (2020-2050)', Diff as 'Різниця', PredictedSignif as 'Значимість ' " +
            "FROM RegionsExtreme, Regions, Variables " +
            "Where RegionsExtreme.RegionID = Regions.RegionID AND RegionsExtreme.VariableID = Variables.VariableID " +
            $"AND RegionsExtreme.RegionID = {(regionsCombo.SelectedItem as ComboboxItem).Value}", sc);

            sReader = sComm.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(sReader);
                dataGridView2.DataSource = dt;
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.BringToFront();
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            sReader.Close();
        }
        private void loadSeasonalTable()
        {
            dataGridView2.BringToFront();

            SqlDataReader sReader;
            SqlCommand sComm = new SqlCommand();

            sComm.CommandText = "SELECT VariableName, ActualValue, ChangeSpeedActual, ActualSignif, PredictedValue, Diff, PredictedSignif " +
            " FROM RegionsSeasonal, Regions, Seasons, Variables " +
            " Where RegionsSeasonal.RegionID = Regions.RegionID AND " +
            " RegionsSeasonal.SeasonID = Seasons.SeasonID AND " +
            " RegionsSeasonal.VariableID = Variables.VariableID AND " +
            $" RegionsSeasonal.RegionID = {(regionsCombo.SelectedItem as ComboboxItem).Value} AND " +
            $" RegionsSeasonal.SeasonID = {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value}";

            sComm.Connection = sc;

            sReader = sComm.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(sReader);
                dataGridView2.DataSource = dt;
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.BringToFront();
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            sReader.Close();
        }
        public void isTableExists(string tabl, out bool exist)
        {
            string myCommandText = $"SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tabl}'";

            SqlCommand myCommand = new SqlCommand(myCommandText, sc);
            SqlDataReader myReader = null;

            myReader = myCommand.ExecuteReader();
            if (myReader.HasRows == true) exist = true;
            else exist = false;

            myReader.Close();
        }
        public int rowCount(string table)
        {
            SqlDataReader sdr;
            SqlCommand sComm = new SqlCommand($"SELECT MAX(ImageID) FROM {table}", sc);
            int count = 0;
            sdr = sComm.ExecuteReader();
            sdr.Read();
            if (!sdr.IsDBNull(0)) count = sdr.GetInt32(0);
            else count = 0;
            sdr.Close();
            return count;
        }
        private void addAgroTable(string FileName)
        {
            int idx = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            string[] linn = File.ReadAllLines(FileName, Encoding.Default);
            string[] split;
            string param = null;
            string tableName = "Table_"
                + (timeScaleCombo.SelectedIndex).ToString() + "_"
                + (regionsCombo.SelectedIndex + 1).ToString() + "_"
                + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();


            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;
            sComm.CommandText = $"CREATE TABLE {tableName} (regionID int NOT NULL, Phase1a float NOT NULL, Phase1p float NOT NULL," +
                " Phase2a float NOT NULL,  Phase2p float NOT NULL, Phase3a float NOT NULL, Phase3p float NOT NULL," +
                " Phase4a float NOT NULL, Phase4p float NOT NULL, Phase5a float NOT NULL, Phase5p float NOT NULL," +
                " Phase6a float NOT NULL, Phase6p float NOT NULL, Phase7a float NOT NULL,  Phase7p float NOT NULL," +
                " PRIMARY KEY (regionID)," + " FOREIGN KEY (regionID) REFERENCES Regions(regionID))";

            sComm.ExecuteNonQuery();

            for (int i = 0; i < linn.Length; i++)
            {
                split = linn[i].Split(new String[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                idx = 0;
                da.InsertCommand = new SqlCommand($"INSERT INTO {tableName} VALUES(@regionID, @Phase1a, @Phase1p, @Phase2a, @Phase2p, @Phase3a, @Phase3p, @Phase4a, @Phase4p, @Phase5a, @Phase5p, @Phase6a, @Phase6p, @Phase7a, @Phase7p)", sc);
                da.InsertCommand.Parameters.Add("@regionID", SqlDbType.Int).Value = i + 1;

                for (int j = 1; j < 8; j++)
                {
                    param = $"Phase{j}a";
                    da.InsertCommand.Parameters.Add(param, SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                    param = $"Phase{j}p";
                    da.InsertCommand.Parameters.Add(param, SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);

                }

                da.InsertCommand.ExecuteNonQuery();

            }
        }
        private void getDimension()
        {
            string command = $"Select Dimensions.DimensionName From Dimensions Where Dimensions.DimensionID = (Select VariableDimensions.Dimension FROM VariableDimensions WHERE VariableDimensions.VariableID = {(variablesCombo.SelectedItem as ComboboxItem).Value} AND VariableDimensions.Period = { timeScaleCombo.SelectedIndex + 1})";

            SqlCommand sComm = new SqlCommand(command, sc);
            SqlDataReader sr = sComm.ExecuteReader();

            sr.Read();

            if (sr.HasRows)
            {
                label1.Text = $"Одиниці виміру: { sr.GetValue(0).ToString()}";
            }
            else
            {
                label1.Text = "Одиниці виміру: N/A";
            }
            label1.BringToFront();
            sr.Close();
        }
        private void addFactTable(string FileName)
        {
            int idx = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            string[] linn = File.ReadAllLines(FileName, Encoding.Default);
            string[] split;
            string tableName;

            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;


            if (regionsCGB.Text != "Культури")
            {
                tableName = "Table_"
                + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
                + (seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString() + "_"
                + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
            }
            else
            {
                tableName = "Agro_Table_"
               + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
               + (seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString() + "_"
               + (regionsCombo.SelectedItem as ComboboxItem).Value.ToString() + "_"
               + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
            }
       
            
            sComm.CommandText = $"CREATE TABLE {tableName} (regionID int NOT NULL, actualValue float NULL, changeSpeed float NULL," +
                " pValue float NULL PRIMARY KEY (regionID), FOREIGN KEY (regionID) REFERENCES Regions(regionID))";

            sComm.ExecuteNonQuery();

            for (int i = 0; i < linn.Length; i++)
            {
                split = linn[i].Split(new String[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                idx = 0;
                da.InsertCommand = new SqlCommand("INSERT INTO " + tableName + " VALUES(@regionID, @actualValue, @changeSpeed, @pValue)", sc);
                da.InsertCommand.Parameters.Add("@regionID", SqlDbType.Int).Value = i + 1;
                da.InsertCommand.Parameters.Add("@actualValue", SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                da.InsertCommand.Parameters.Add("@changeSpeed", SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                da.InsertCommand.Parameters.Add("@pValue", SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                da.InsertCommand.ExecuteNonQuery();
            }
        }
        private void updatePresenceTable(string scriptFileName)
        {
            var fileContent = File.ReadAllText(scriptFileName, Encoding.UTF8);

            SqlCommand cmd = new SqlCommand(fileContent, sc);
            cmd.ExecuteNonQuery();
        }
        private void addProjTable(string FileName)
        {
            int idx = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            string[] linn = File.ReadAllLines(FileName, Encoding.Default);
            string[] split;
            string tableName = null;

            


            if (regionsCGB.Text == "Культури")
            {
                if (variablesCombo.SelectedIndex >= 5)
                tableName = "Agro_Table_"
                + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
                + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
            }
                
            else
            {
                tableName = "Table_"
                + (timeScaleCombo.SelectedIndex + 1).ToString() + "_"
                + (seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString() + "_"
                + (variablesCombo.SelectedItem as ComboboxItem).Value.ToString();
            }

            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;
            sComm.CommandText = "CREATE TABLE " + tableName + " (regionID int NOT NULL, actualValue float NOT NULL, predictedValue float NOT NULL, changeSpeed float NOT NULL," +
                " pValue float NOT NULL PRIMARY KEY (regionID)," + " FOREIGN KEY (regionID) REFERENCES Regions(regionID))";

            sComm.ExecuteNonQuery();

            for (int i = 0; i < linn.Length; i++)
            {
                split = linn[i].Split(new String[] { "\t" }, StringSplitOptions.None);
                idx = 0;
                da.InsertCommand = new SqlCommand("INSERT INTO " + tableName + " VALUES(@regionID, @actualValue, @predictedValue, @changeSpeed, @pValue)", sc);
                da.InsertCommand.Parameters.Add("@regionID", SqlDbType.Int).Value = i + 1;
                da.InsertCommand.Parameters.Add("@actualValue", SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                da.InsertCommand.Parameters.Add("@predictedValue", SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                da.InsertCommand.Parameters.Add("@changeSpeed", SqlDbType.Float).Value = Convert.ToDouble(split[idx++]);
                da.InsertCommand.Parameters.Add("@pValue", SqlDbType.Float).Value = Convert.ToDouble(split[idx]);
                da.InsertCommand.ExecuteNonQuery();
            }
        }
        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info inf = new Info(sc);
            inf.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void додатиЗображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName, sCommText = null;
                int actualID = rowCount("Images") + 1;

                if (regionsCGB.Text == "Області")
                {
                    sCommText = $"INSERT INTO Images(ImageID, ImageSeason, ImagePeriod, ImageVariable, ImageBinary) SELECT {actualID}" +
                    $", {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()}" +
                    $", {(timeScaleCombo.SelectedIndex + 1)}" +
                    $", {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}" +
                    $", * FROM OPENROWSET(BULK N'{FileName}', SINGLE_BLOB) image";
                }
                else
                {
                    sCommText = $"INSERT INTO Images(ImageID, ImageSeason, ImagePeriod, ImageVariable, ImageCulture, ImageBinary) SELECT {actualID}" +
                   $", {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()}" +
                   $", {(timeScaleCombo.SelectedIndex + 1)}" +
                   $", {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}" +
                   $", {(regionsCombo.SelectedIndex + 1)}" +
                   $", * FROM OPENROWSET(BULK N'" + FileName + "', SINGLE_BLOB) image";
                }

                SqlCommand sComm = new SqlCommand(sCommText, sc);

                sComm.ExecuteNonQuery();
            }
        }
        private void замінитиЗображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName, sCommText = null;
                if (regionsCGB.Text == "Області")
                {
                    sCommText = $"UPDATE Images SET ImageBinary = BulkColumn from OPENROWSET(BULK '{ FileName }', Single_Blob) as ImageBinary WHERE ImageSeason = {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()} AND ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable = { (variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
                }
                else
                {
                    if (seasonPeriodCombo.SelectedItem != null)
                    {
                        sCommText = $"UPDATE Images SET ImageBinary = BulkColumn from OPENROWSET(BULK '{ FileName }', Single_Blob) as ImageBinary WHERE ImageSeason = {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()} AND ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
                    }
                    else
                    {
                        sCommText = $"UPDATE Images SET ImageBinary = BulkColumn from OPENROWSET(BULK '{ FileName }', Single_Blob) as ImageBinary WHERE ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
                    }
                }

                SqlCommand sComm = new SqlCommand(sCommText, sc);

                sComm.ExecuteNonQuery();
            }
        }
        private void видалитиЗображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = openFileDialog1.FileName, sCommText = null;

            if (regionsCGB.Text == "Області")
            {
                sCommText = $"DELETE FROM Images WHERE ImageSeason = {(seasonPeriodCombo.SelectedIndex + 1)} AND ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
            }
            else
            {
                sCommText = $"DELETE FROM Images WHERE ImageSeason = {(seasonPeriodCombo.SelectedIndex + 1)} AND ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable  LIKE '{(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}' AND ImageCulture = {(regionsCombo.SelectedIndex + 1)}";
            }

            SqlCommand sComm = new SqlCommand(sCommText, sc);

            sComm.ExecuteNonQuery();
        }
        private void дадатиТаблицюфактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;

                addFactTable(FileName);
            }

        }
        private void додатиТаблицюпроекціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                addProjTable(openFileDialog1.FileName);
            }
        }
        private void наявністьДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataPresence dP = new dataPresence(sc);
            dP.Show();
        }
        private void updateImageCheck()
        {
            string sText = null;

            if (seasonPeriodCombo.SelectedItem != null)
            {
                sText = $"Update Images SET checked = 1 WHERE ImageSeason = {(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()} AND ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
            }
            else
            {
                sText = $"Update Images SET checked = 1 WHERE ImagePeriod = {(timeScaleCombo.SelectedIndex + 1)} AND ImageVariable = {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
            }
            if (regionsCGB.Text == "Культури") sText += " AND ImageCulture = " + (regionsCombo.SelectedIndex + 1).ToString();

            SqlCommand sComm = new SqlCommand(sText, sc);
            sComm.CommandType = CommandType.Text;

            sComm.ExecuteNonQuery();

        }
        private void видалитиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = null;

            try
            {
                if (regionsCGB.Text != "Культури")
                {
                    tableName = $"Table_{(timeScaleCombo.SelectedIndex + 1).ToString()}_{(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()}_ {(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
                }
                else
                {
                    tableName = $"Agro_Table_{(timeScaleCombo.SelectedIndex + 1).ToString()}_{(seasonPeriodCombo.SelectedItem as ComboboxItem).Value.ToString()}_ {(regionsCombo.SelectedItem as ComboboxItem).Value.ToString()}_{(variablesCombo.SelectedItem as ComboboxItem).Value.ToString()}";
                }

                SqlCommand sComm = new SqlCommand();

                sComm.CommandText = "Drop Table " + tableName;
                sComm.Connection = sc;

                try
                {
                    sComm.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вказано недостатньо параметрів для видалення таблиці");
            }
        }
        private void додатиТаблицюекстримToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;

                AddExtremeTable(FileName);
            }
        }
        private void AddExtremeTable(string FileName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string[] linn = File.ReadAllLines(FileName, Encoding.Default);
            string[] split;

            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;

            sComm.CommandText = "DELETE FROM RegionsExtreme";
            sComm.ExecuteNonQuery();

            for (int i = 0; i < linn.Length; i++)
            {
                split = linn[i].Split(new String[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);

                sComm.CommandText = "Insert INTO RegionsExtreme VALUES (";

                switch (split.Length)
                {
                    case 2:
                        sComm.CommandText += split[0] + ", " + split[1] + ", NULL, NULL, NULL, NULL, NULL, NULL)";
                        break;

                    case 5:
                        sComm.CommandText += split[0] + ", " + split[1] + ", " + split[2] + ", " + split[3] + ", " + split[4] + ", NULL, NULL, NULL)";
                        break;

                    case 8:
                        sComm.CommandText += split[0] + ", " + split[1] + ", " + split[2] + ", " + split[3] + ", " + split[4] + ", "
                            + split[5] + ", " + split[6] + ", " + split[7] + ")";

                        break;
                }

                sComm.ExecuteNonQuery();
            }
        }
        private void AddSeasonTable(string FileName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string[] linn = File.ReadAllLines(FileName, Encoding.Default);
            string[] split;

            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;

            sComm.CommandText = "DELETE FROM RegionsSeasonal";
            sComm.ExecuteNonQuery();

            for (int i = 0; i < linn.Length; i++)
            {
                split = linn[i].Split(new String[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);

                sComm.CommandText = "Insert INTO RegionsSeasonal VALUES (";
                sComm.CommandText += $"{split[0]}, {split[1]}, {split[2]}, {split[3]}, {split[4]}, {split[5]}, {split[6]}, {split[7]}, {split[8]})";

                sComm.ExecuteNonQuery();
            }
        }
        private void AddAgroTable(string FileName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string[] linn = File.ReadAllLines(FileName, Encoding.Default);
            string[] split;

            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;

            sComm.CommandText = "DELETE FROM RegionsAgro";
            sComm.ExecuteNonQuery();

            for (int i = 0; i < linn.Length; i++)
            {
                split = linn[i].Split(new String[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);

                sComm.CommandText = "Insert INTO RegionsAgro VALUES (";
                sComm.CommandText += $"{split[0]},{split[1]}, {split[2]}, {split[3]}, {split[4]}, {split[5]}, {split[6]}, {split[7]}, {split[8]}, {split[9]})";

                sComm.ExecuteNonQuery();
            }
        }
        private void додатиТаблицюсезониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;
                AddSeasonTable(FileName);
            }
        }
        private void додатиТаблицюагроToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;
                AddAgroTable(FileName);
            }
        }

        //не використовується, але цікаво
        //private void regionsCombo_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index == -1)
        //        return;
        //    ComboBox combo = ((ComboBox)sender);
        //    using (SolidBrush brush = new SolidBrush(e.ForeColor))
        //    {
        //        Font font = e.Font;
        //        //if (/*Condition Specifying That Text Must Be Bold*/)
        //        font = new System.Drawing.Font(font, FontStyle.Bold);
        //        e.Graphics.DrawString(combo.Items[e.Index].ToString(), font, brush, e.Bounds);
        //    }
        //}

    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public int Season { get; set; }
        public ComboboxItem(string txt, int val, int seas)
        {
            Text = txt;
            Value = val;
            Season = seas;
        }
        public override string ToString()
        {
            return Text;
        }
    }
    public class CustomGrpBox : GroupBox
    {
        private string _Text = "";
        public CustomGrpBox()
        {
            base.Text = "";
        }
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("GroupBoxText")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush colorBrush = new SolidBrush(this.ForeColor);
            var backColor = new SolidBrush(this.BackColor);
            var size = TextRenderer.MeasureText(this.Text, this.Font);
            int left = (this.Width - size.Width) / 2;
            e.Graphics.FillRectangle(backColor, new Rectangle(left, 0, size.Width, size.Height));
            e.Graphics.DrawString(this.Text, this.Font, colorBrush, new PointF(left, 0));
        }
    }
}
