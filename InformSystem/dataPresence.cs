using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InformSystem
{
    public partial class dataPresence : Form
    {
        SqlConnection sc;

        public dataPresence(SqlConnection sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void timeScaleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeScaleCombo.SelectedIndex != -1 && variableTypeCombo.SelectedIndex != -1)
            {
                loadPresenceCheck(timeScaleCombo.SelectedIndex);
            }
        }

        private void loadPresenceCheck(int selIndex)
        {
            string tableName = null, sCommText = null;
            int culture = 0, phase = 1;

            SqlCommand sComm = new SqlCommand();
            sComm.Connection = sc;

            SqlDataReader sReader;
           // sc.Open();

            if (variableTypeCombo.Text == "Агрометеорологічні умови")
            {
                tableName = "agroPresence";

                culture = cultureCombo.SelectedIndex + 1;



                sComm.CommandText = "SELECT Seasons.SeasonName FROM Seasons WHERE Seasons.Chapter = " + (culture + 3).ToString();

                sReader = sComm.ExecuteReader();

                sCommText = "Select Variables.VariableName as 'Параметр' ";

                while (sReader.Read())
                {
                    sCommText += ", Phase" + (phase++).ToString() + " as '" + sReader.GetString(0) + "' ";
                }

                sCommText += " from " + tableName + ", Variables WHERE Variables.VariableID = " + tableName + ".Variable AND Period = " + (selIndex + 1).ToString() + " AND Culture = " + (cultureCombo.SelectedIndex + 1).ToString();
                sReader.Close();
            }
            else
            {
                tableName = "regularPresence";
                sCommText = "Select Variables.VariableName as 'Параметр',Year as 'Рік', Winter as 'Зима', Spring as 'Весна', Summer as 'Літо', Autumn as 'Осінь', Cold as 'Холодний період', Warm as 'Теплий період' " +
                " from " + tableName + ", Variables WHERE Variables.VariableID = " + tableName + ".Variable AND Period = " + (selIndex + 1).ToString() + " ORDER BY VariableID ASC";
            }


            sComm.CommandText = sCommText;
            Clipboard.SetText(sCommText);
            sReader = sComm.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(sReader);
                dataGridView1.DataSource = dt;
            }

            configureDataGridView();

          //  sc.Close();


        }


        public void configureDataGridView()
        {
            int allCount = 0, presentCount = 0, absentCount = 0;
            string value = null;
            dataGridView1.AutoResizeColumns();
            for (int i = 1; i < dataGridView1.Columns.Count; dataGridView1.Columns[i++].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill) ;
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                {
                    value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    if (value != "-         ")
                    {
                       
                        allCount++;
                        if (value == "Нема      ")
                        {
                            absentCount++;
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            presentCount++;
                        }
                    }
                    else dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                }
            }

            label1.Text = "Наявні - " + presentCount.ToString() + ",\nвідсутні - " + absentCount.ToString() + ",\nвсього - " + allCount.ToString(); 

            dataGridView1.ReadOnly = true;
        }

        private void variableTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variableTypeCombo.SelectedIndex == 1)
            {
                cultureCombo.SelectedIndex = 0;
            }
            else cultureCombo.SelectedIndex = -1;

            if (timeScaleCombo.SelectedIndex != -1 && variableTypeCombo.SelectedIndex != -1)
            {
                loadPresenceCheck(timeScaleCombo.SelectedIndex);
            }
        }

        private void cultureCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeScaleCombo.SelectedIndex != -1 && variableTypeCombo.SelectedIndex != -1) {
                loadPresenceCheck(timeScaleCombo.SelectedIndex); }
        }
    }
}
