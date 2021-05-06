
namespace OPC_Client_DB_Logging_0
{
    partial class UiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTagId = new System.Windows.Forms.ComboBox();
            this.dgvSensorLog = new System.Windows.Forms.DataGridView();
            this.chrtSensorData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReadTypeMV = new System.Windows.Forms.TextBox();
            this.txtReadQualityMV = new System.Windows.Forms.TextBox();
            this.txtReadValueMV = new System.Windows.Forms.TextBox();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReadTypePV = new System.Windows.Forms.TextBox();
            this.txtReadQualityPV = new System.Windows.Forms.TextBox();
            this.txtReadValuePV = new System.Windows.Forms.TextBox();
            this.lblStatusOPC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConStrOPC = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLogInterval = new System.Windows.Forms.ComboBox();
            this.lblStatusDB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConStringDB = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.waveformGraph2 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSensorData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTagId);
            this.groupBox1.Controls.Add(this.dgvSensorLog);
            this.groupBox1.Controls.Add(this.chrtSensorData);
            this.groupBox1.Location = new System.Drawing.Point(705, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Log";
            // 
            // cmbTagId
            // 
            this.cmbTagId.FormattingEnabled = true;
            this.cmbTagId.Items.AddRange(new object[] {
            "TagId 1",
            "TagId 2"});
            this.cmbTagId.Location = new System.Drawing.Point(6, 19);
            this.cmbTagId.Name = "cmbTagId";
            this.cmbTagId.Size = new System.Drawing.Size(121, 21);
            this.cmbTagId.TabIndex = 2;
            this.cmbTagId.Text = "Select Tag";
            // 
            // dgvSensorLog
            // 
            this.dgvSensorLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensorLog.Location = new System.Drawing.Point(6, 333);
            this.dgvSensorLog.Name = "dgvSensorLog";
            this.dgvSensorLog.Size = new System.Drawing.Size(666, 195);
            this.dgvSensorLog.TabIndex = 2;
            // 
            // chrtSensorData
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtSensorData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtSensorData.Legends.Add(legend3);
            this.chrtSensorData.Location = new System.Drawing.Point(6, 48);
            this.chrtSensorData.Name = "chrtSensorData";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrtSensorData.Series.Add(series3);
            this.chrtSensorData.Size = new System.Drawing.Size(666, 279);
            this.chrtSensorData.TabIndex = 1;
            this.chrtSensorData.Text = "chart2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waveformGraph2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtReadTypeMV);
            this.groupBox2.Controls.Add(this.txtReadQualityMV);
            this.groupBox2.Controls.Add(this.txtReadValueMV);
            this.groupBox2.Controls.Add(this.waveformGraph1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtReadTypePV);
            this.groupBox2.Controls.Add(this.txtReadQualityPV);
            this.groupBox2.Controls.Add(this.txtReadValuePV);
            this.groupBox2.Controls.Add(this.lblStatusOPC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtConStrOPC);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPC Connection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "MV TAG TYPE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "MV QUALITY:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "MV VALUE:";
            // 
            // txtReadTypeMV
            // 
            this.txtReadTypeMV.Location = new System.Drawing.Point(91, 295);
            this.txtReadTypeMV.Multiline = true;
            this.txtReadTypeMV.Name = "txtReadTypeMV";
            this.txtReadTypeMV.ReadOnly = true;
            this.txtReadTypeMV.Size = new System.Drawing.Size(133, 53);
            this.txtReadTypeMV.TabIndex = 12;
            // 
            // txtReadQualityMV
            // 
            this.txtReadQualityMV.Location = new System.Drawing.Point(91, 263);
            this.txtReadQualityMV.Name = "txtReadQualityMV";
            this.txtReadQualityMV.ReadOnly = true;
            this.txtReadQualityMV.Size = new System.Drawing.Size(133, 20);
            this.txtReadQualityMV.TabIndex = 11;
            // 
            // txtReadValueMV
            // 
            this.txtReadValueMV.Location = new System.Drawing.Point(91, 231);
            this.txtReadValueMV.Name = "txtReadValueMV";
            this.txtReadValueMV.ReadOnly = true;
            this.txtReadValueMV.Size = new System.Drawing.Size(133, 20);
            this.txtReadValueMV.TabIndex = 10;
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(240, 99);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(432, 117);
            this.waveformGraph1.TabIndex = 9;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PV TAG TYPE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PV QUALITY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PV VALUE:";
            // 
            // txtReadTypePV
            // 
            this.txtReadTypePV.Location = new System.Drawing.Point(91, 163);
            this.txtReadTypePV.Multiline = true;
            this.txtReadTypePV.Name = "txtReadTypePV";
            this.txtReadTypePV.ReadOnly = true;
            this.txtReadTypePV.Size = new System.Drawing.Size(133, 53);
            this.txtReadTypePV.TabIndex = 5;
            // 
            // txtReadQualityPV
            // 
            this.txtReadQualityPV.Location = new System.Drawing.Point(91, 131);
            this.txtReadQualityPV.Name = "txtReadQualityPV";
            this.txtReadQualityPV.ReadOnly = true;
            this.txtReadQualityPV.Size = new System.Drawing.Size(133, 20);
            this.txtReadQualityPV.TabIndex = 4;
            // 
            // txtReadValuePV
            // 
            this.txtReadValuePV.Location = new System.Drawing.Point(91, 99);
            this.txtReadValuePV.Name = "txtReadValuePV";
            this.txtReadValuePV.ReadOnly = true;
            this.txtReadValuePV.Size = new System.Drawing.Size(133, 20);
            this.txtReadValuePV.TabIndex = 3;
            // 
            // lblStatusOPC
            // 
            this.lblStatusOPC.AutoSize = true;
            this.lblStatusOPC.Location = new System.Drawing.Point(6, 75);
            this.lblStatusOPC.Name = "lblStatusOPC";
            this.lblStatusOPC.Size = new System.Drawing.Size(79, 13);
            this.lblStatusOPC.TabIndex = 2;
            this.lblStatusOPC.Text = "Not Connected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // txtConStrOPC
            // 
            this.txtConStrOPC.Location = new System.Drawing.Point(6, 52);
            this.txtConStrOPC.Name = "txtConStrOPC";
            this.txtConStrOPC.Size = new System.Drawing.Size(666, 20);
            this.txtConStrOPC.TabIndex = 0;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(9, 93);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(133, 39);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Start Logging";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbLogInterval);
            this.groupBox3.Controls.Add(this.lblStatusDB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnLog);
            this.groupBox3.Controls.Add(this.txtConStringDB);
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "LOGGING TIME milliseconds:";
            // 
            // cmbLogInterval
            // 
            this.cmbLogInterval.FormattingEnabled = true;
            this.cmbLogInterval.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "2000"});
            this.cmbLogInterval.Location = new System.Drawing.Point(159, 137);
            this.cmbLogInterval.Name = "cmbLogInterval";
            this.cmbLogInterval.Size = new System.Drawing.Size(82, 21);
            this.cmbLogInterval.TabIndex = 11;
            // 
            // lblStatusDB
            // 
            this.lblStatusDB.AutoSize = true;
            this.lblStatusDB.Location = new System.Drawing.Point(6, 73);
            this.lblStatusDB.Name = "lblStatusDB";
            this.lblStatusDB.Size = new System.Drawing.Size(79, 13);
            this.lblStatusDB.TabIndex = 4;
            this.lblStatusDB.Text = "Not Connected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connection String:";
            // 
            // txtConStringDB
            // 
            this.txtConStringDB.Location = new System.Drawing.Point(6, 50);
            this.txtConStringDB.Name = "txtConStringDB";
            this.txtConStringDB.Size = new System.Drawing.Size(666, 20);
            this.txtConStringDB.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // waveformGraph2
            // 
            this.waveformGraph2.Location = new System.Drawing.Point(240, 231);
            this.waveformGraph2.Name = "waveformGraph2";
            this.waveformGraph2.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph2.Size = new System.Drawing.Size(432, 117);
            this.waveformGraph2.TabIndex = 16;
            this.waveformGraph2.UseColorGenerator = true;
            this.waveformGraph2.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph2.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            // 
            // UiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 559);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UiForm";
            this.Text = "OPC Read and DB Logging";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSensorData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSensorData;
        private System.Windows.Forms.DataGridView dgvSensorLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConStrOPC;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbTagId;
        private System.Windows.Forms.Label lblStatusOPC;
        private System.Windows.Forms.TextBox txtReadValuePV;
        private System.Windows.Forms.TextBox txtReadQualityPV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReadTypePV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConStringDB;
        private System.Windows.Forms.Label lblStatusDB;
        private System.Windows.Forms.Timer timer2;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLogInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReadTypeMV;
        private System.Windows.Forms.TextBox txtReadQualityMV;
        private System.Windows.Forms.TextBox txtReadValueMV;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph2;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
    }
}

