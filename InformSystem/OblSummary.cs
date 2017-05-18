using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem
{
    public partial class OblSummary : Form
    {
        private int oblIndex;
        public OblSummary(ref SqlConnection sc, int obl)
        {
            oblIndex = obl;
            InitializeComponent();

            loadTables(ref sc);
        }

        private void loadTables(ref SqlConnection sc)
        {
            loadExtreme(ref sc);
            loadSeasonal(ref sc);
            loadAgro(ref sc);
        }

        private void loadExtreme(ref SqlConnection sc)
        {
            SqlDataReader sReader;
            SqlCommand sComm = new SqlCommand("SELECT VariableName as Параметр, ActualValue as 'Середнє за 1981-2010', ChangeSpeedActual as 'Швидкість зміни', ActualSignif as 'Значимість', PredictedValue as 'Проекція (2021-2050)', Diff as 'Різниця', PredictedSignif as 'Значимість ' " +
            "FROM RegionsExtreme, Regions, Variables " +
            "Where RegionsExtreme.RegionID = Regions.RegionID AND RegionsExtreme.VariableID = Variables.VariableID " +
            "AND RegionsExtreme.RegionID = " + oblIndex, sc);

            sReader = sComm.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(sReader);
                extremeDGV.DataSource = dt;
            }

            extremeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            extremeDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            extremeDGV.BringToFront();
            extremeDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            extremeDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            sReader.Close();
        }

        private void loadSeasonal(ref SqlConnection sc)
        {
            SqlDataReader sReader;
            SqlCommand sComm = new SqlCommand();

            sComm.CommandText = "SELECT SeasonName as 'Сезон', VariableName as 'Параметр', ActualValue as 'Середнє за 1981-2010', ChangeSpeedActual  as 'Швидкість зміни', ActualSignif  as 'Значимість', PredictedValue  as 'Проекція (2021-2050)', Diff  as 'Різниця', PredictedSignif  as 'Значимість'" +
            " FROM RegionsSeasonal, Regions, Seasons, Variables " +
            " Where RegionsSeasonal.RegionID = Regions.RegionID AND " +
            " RegionsSeasonal.SeasonID = Seasons.SeasonID AND " +
            " RegionsSeasonal.VariableID = Variables.VariableID AND " +
            " RegionsSeasonal.RegionID = " + oblIndex;

            sComm.Connection = sc;

            sReader = sComm.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(sReader);
                SeasonDGV.DataSource = dt;
            }

            SeasonDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SeasonDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SeasonDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SeasonDGV.BringToFront();
            SeasonDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SeasonDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            sReader.Close();
        }

        private void loadAgro(ref SqlConnection sc)
        {
            SqlDataReader sReader;
            SqlCommand sComm = new SqlCommand();

            sComm.CommandText = "SELECT CultureName as 'Культура', SeasonName as 'Фаза', VariableName as 'Параметр', ActualValue as 'Середнє за 1981-2010', ChangeSpeedActual  as 'Швидкість зміни', ActualSignif  as 'Значимість', PredictedValue  as 'Проекція (2021-2050)', Diff  as 'Різниця', PredictedSignif  as 'Значимість'" +
            " FROM RegionsAgro, AgroCultures, Regions, Seasons, Variables " +
            " Where RegionsAgro.RegionID = Regions.RegionID AND " +
            " RegionsAgro.SeasonID = Seasons.SeasonID AND " +
            " RegionsAgro.VariableID = Variables.VariableID AND " +
            " RegionsAgro.SeasonID = Seasons.SeasonID AND " +
            " RegionsAgro.CultureID = AgroCultures.CultureID AND " +
            " RegionsAgro.RegionID = " + oblIndex;

            sComm.Connection = sc;

            sReader = sComm.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(sReader);
                agroDGV.DataSource = dt;
            }

            agroDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            agroDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            agroDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            agroDGV.BringToFront();
            agroDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            agroDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            sReader.Close();
        }


    }
}
