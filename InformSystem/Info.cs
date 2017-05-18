using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InformSystem
{
    public partial class Info : Form
    {
        SqlConnection sc;


        public Info(SqlConnection sc)
        {
            this.sc = sc;
            InitializeComponent();
            LoadPValue();
            populateTextBox();
        }

        private void LoadPValue()
        {
            int row = 0;

            SqlCommand sComm = new SqlCommand("SELECT pValue, procent, textInfo FROM pValueInfo", sc);
            SqlDataReader sReader;
            sReader = sComm.ExecuteReader();

            while (sReader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = sReader.GetString(0);
                dataGridView1.Rows[row].Cells[1].Value = sReader.GetString(1);
                dataGridView1.Rows[row++].Cells[2].Value = sReader.GetString(2);
                dataGridView1.ReadOnly = true;
            }

            dataGridView1.EndEdit();
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);

        }
        private void populateTextBox()
        {
            textBox1.Text = "1. Відтінки червоного кольору ілюструють збільшення показника.\r\n" +
                "2. Відтінки синього кольору ілюструють зменшення показника.\r\n" +
                "3. Інтенсивність кольору зростає при збільшені статистичної ймовірності.\r\n" +
                "4. Білий колір свідчить про відсутність змін чи інформації";
        }




    }
}
