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
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using NationalInstruments.NetworkVariable;
using System.Threading;

namespace OPC_Client_DB_Logging_0
{
    public partial class UiForm : Form
    {
        string value, quality, type, value2, quality2, type2;

        private string connectionString =
        ConfigurationManager.ConnectionStrings
        ["ScadaDatabase"].ConnectionString;

        private NetworkVariableReader<double> _reader;
        private const string NetworkVariableLocation = @"\\localhost\SCADA\PV";
        private NetworkVariableReader<double> _reader2;
        private const string NetworkVariableLocation2 = @"\\localhost\SCADA\MV";

        

        public UiForm()
        {
            InitializeComponent();
            txtConStringDB.Text = connectionString;
            cmbLogInterval.Text = "1000";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetData();
            ConnectOPC();
            ReadOPC();
            _reader.Disconnect();
            _reader2.Disconnect();
        }

        private void ConnectOPC() //OPC connection
        {
            txtConStrOPC.Text = NetworkVariableLocation;
            _reader = new NetworkVariableReader<double>(NetworkVariableLocation);
            _reader.Connect();
            txtConStrOPC.AppendText("    And    " + NetworkVariableLocation);
            _reader2 = new NetworkVariableReader<double>(NetworkVariableLocation2);
            _reader2.Connect();
            lblStatusOPC.Text = _reader.ConnectionStatus.ToString();

            if (lblStatusOPC.Text == "Connected")
            {
                lblStatusOPC.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatusOPC.Text = "Not Connected";
                lblStatusOPC.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void GetData() //Gets data from the database
        {
            int tagId = cmbTagId.SelectedIndex + 1;
            List<Database> dbData = new List<Database>();
            Database db = new Database();
            dbData = db.GetValue(connectionString, chrtSensorData, tagId);
            dgvSensorLog.DataSource = dbData;
        }

        private void ReadOPC()
        {
            NetworkVariableData<double> opcdata = null;
            NetworkVariableData<double> opcdata2 = null;
            try
            {
                opcdata = _reader.ReadData();
                opcdata2 = _reader2.ReadData();
                value = opcdata.GetValue().ToString();
                value2 = opcdata2.GetValue().ToString();
                quality = opcdata.Quality.ToString();
                quality2 = opcdata2.Quality.ToString();
                type = opcdata.GetType().ToString();
                type2 = opcdata2.GetType().ToString();
                txtReadValuePV.Text = value;
                txtReadQualityPV.Text = quality;
                txtReadTypePV.Text = type;
                txtReadValueMV.Text = value2;
                txtReadQualityMV.Text = quality2;
                txtReadTypeMV.Text = type2;
                double opcdatadoub = opcdata.GetValue();
                double opcdatadoub2 = opcdata2.GetValue();
                waveformGraph1.PlotYAppend(opcdatadoub);
                waveformGraph2.PlotYAppend(opcdatadoub2);

            }
            catch (Exception e)
            {
                MessageBox.Show("The read has timed out.", "Timeout" + e);
                return;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Database db = new Database();
            db.InsertValue(connectionString, value, quality, lblStatusDB, 1);

            Database db2 = new Database();
            db2.InsertValue(connectionString, value2, quality2, lblStatusDB, 2);

            timer2.Interval = Convert.ToInt32(cmbLogInterval.Text);
        }

        int count = 0;
        private void btnLog_Click(object sender, EventArgs e)
        {
            switch (count % 2) //Even number check if sampling should stop start when sampling button is pressed
            {
                case 0:
                    timer2.Interval = Convert.ToInt32(cmbLogInterval.Text);
                    timer2.Start();
                    btnLog.Text = "Stop Logging";
                    break;
             default:
                    timer2.Stop();
                    btnLog.Text = "Start Logging";
                    break;
            }
            count++;
            timer2.Interval = Convert.ToInt32(cmbLogInterval.Text);
            timer2.Start();
        }
    }


    public class Database
    {
        public DateTime TimeStamp { get; set; }
        public double TagId { get; set; }
        public double Value { get; set; }
        public string Status { get; set; }
        public string Quality { get; set; }

        private int GridlinesOffset = 0;

        public static Semaphore _pool;

        public Database()
        {
            _pool = new Semaphore(0, 3);
            _pool.Release(3);
        }

        private void InitChart(Chart chrtSensorData)
        {
            chrtSensorData.Series.Clear();
            chrtSensorData.Series.Add("Temp Celsius");
            chrtSensorData.Series["Temp Celsius"].ChartType =
                SeriesChartType.Line;
            chrtSensorData.ResetAutoValues();
            chrtSensorData.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -GridlinesOffset; //https://stackoverflow.com/questions/31667086/how-to-move-x-axis-grids-on-chart-whenever-a-data-is-added-on-the-chart
            GridlinesOffset++;
            GridlinesOffset %= (int)chrtSensorData.ChartAreas[0].AxisX.MajorGrid.Interval; // Calculate next offset.
            Axis yaxis = chrtSensorData.ChartAreas[0].AxisY;
            yaxis.Minimum = 15;
            chrtSensorData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd.MM HH:mm:ss";
        }

        public List<Database> GetValue(string connectionString, Chart chrtSensorData, int tagId)
        {
            InitChart(chrtSensorData);

            try
            {
                List<Database> tempList = new List<Database>();
                SqlConnection con = new SqlConnection(connectionString);
                string selectSQL = "select TagId, Value, Timestamp, Status, Quality from TAGDATA where TagId = " + tagId + "ORDER BY Timestamp DESC";
                con.Open();
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Database db = new Database();
                        db.TimeStamp = Convert.ToDateTime(dr["Timestamp"]);
                        db.TagId = Convert.ToDouble(dr["TagId"]);
                        db.Value = Convert.ToDouble(dr["Value"]);
                        db.Status = dr["Status"].ToString();
                        db.Quality = dr["Quality"].ToString();
                        tempList.Add(db);
                        //if (chrtSensorData.Series["Temp Celsius"].Points.Count() > 10) //
                        //    chrtSensorData.Series["Temp Celsius"].Points.RemoveAt(0); //removes points in chart if more than 10 is shown, moving chart
                        chrtSensorData.Series["Temp Celsius"].Points.AddXY
                        (db.TimeStamp, db.Value);
                    }
                }
                con.Close();
                return tempList;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The connection has timed out.", "Timeout");
                throw;
            }
        }

        public void InsertValue(string connectionString, string value, string quality, Label lblStatus, int num)
        {
            _pool.WaitOne();
            try
            {
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Connected";
                SqlConnection con2 = new SqlConnection(connectionString);
                string cmdSQL = "InsertData";
                con2.Open();
                SqlCommand cmd = new SqlCommand(cmdSQL, con2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TagId", SqlDbType.Int).Value = num;
                cmd.Parameters.AddWithValue("@Value", SqlDbType.Float).Value = Convert.ToDouble(value);
                cmd.Parameters.AddWithValue("@Quality", SqlDbType.Char).Value = quality;
                cmd.ExecuteNonQuery();
                con2.Close();
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The connection has timed out.", "Timeout");
                throw;
            }
            _pool.Release();
        }
    }
}
