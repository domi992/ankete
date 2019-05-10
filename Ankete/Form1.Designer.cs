namespace Test1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnkete = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridPitanja = new System.Windows.Forms.DataGridView();
            this.splitGraf = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridOdgovori = new System.Windows.Forms.DataGridView();
            this.tabPitanja = new System.Windows.Forms.TabPage();
            this.panPitanja = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBrisiPit = new System.Windows.Forms.Button();
            this.btnBrisiOdg = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.gridIzmjena = new System.Windows.Forms.DataGridView();
            this.lblPitanje = new System.Windows.Forms.Label();
            this.txPitanje = new System.Windows.Forms.TextBox();
            this.tabOAplikaciji = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAnkete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPitanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGraf)).BeginInit();
            this.splitGraf.Panel1.SuspendLayout();
            this.splitGraf.Panel2.SuspendLayout();
            this.splitGraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdgovori)).BeginInit();
            this.tabPitanja.SuspendLayout();
            this.panPitanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzmjena)).BeginInit();
            this.tabOAplikaciji.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(28, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 34);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Otvori ankete";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.btnIzlaz);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Location = new System.Drawing.Point(725, 6);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(95, 28);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 517);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnkete);
            this.tabControl1.Controls.Add(this.tabPitanja);
            this.tabControl1.Controls.Add(this.tabOAplikaciji);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnkete
            // 
            this.tabAnkete.Controls.Add(this.splitContainer1);
            this.tabAnkete.Location = new System.Drawing.Point(4, 22);
            this.tabAnkete.Name = "tabAnkete";
            this.tabAnkete.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnkete.Size = new System.Drawing.Size(833, 491);
            this.tabAnkete.TabIndex = 1;
            this.tabAnkete.Text = "Ankete";
            this.tabAnkete.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.splitContainer1.Panel1.Controls.Add(this.gridPitanja);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.splitGraf);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(827, 485);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridPitanja
            // 
            this.gridPitanja.AllowUserToAddRows = false;
            this.gridPitanja.AllowUserToDeleteRows = false;
            this.gridPitanja.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            this.gridPitanja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPitanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPitanja.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPitanja.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPitanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPitanja.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridPitanja.EnableHeadersVisualStyles = false;
            this.gridPitanja.Location = new System.Drawing.Point(10, 10);
            this.gridPitanja.Name = "gridPitanja";
            this.gridPitanja.ReadOnly = true;
            this.gridPitanja.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPitanja.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPitanja.RowTemplate.Height = 40;
            this.gridPitanja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPitanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPitanja.ShowCellErrors = false;
            this.gridPitanja.ShowCellToolTips = false;
            this.gridPitanja.ShowEditingIcon = false;
            this.gridPitanja.ShowRowErrors = false;
            this.gridPitanja.Size = new System.Drawing.Size(352, 465);
            this.gridPitanja.TabIndex = 0;
            this.gridPitanja.SelectionChanged += new System.EventHandler(this.gridPitanja_SelectionChanged);
            // 
            // splitGraf
            // 
            this.splitGraf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGraf.Location = new System.Drawing.Point(10, 10);
            this.splitGraf.Name = "splitGraf";
            this.splitGraf.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGraf.Panel1
            // 
            this.splitGraf.Panel1.Controls.Add(this.chart1);
            // 
            // splitGraf.Panel2
            // 
            this.splitGraf.Panel2.Controls.Add(this.gridOdgovori);
            this.splitGraf.Size = new System.Drawing.Size(431, 465);
            this.splitGraf.SplitterDistance = 318;
            this.splitGraf.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "RBR";
            series1.YValueMembers = "GLASOVI";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(431, 318);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Anketa";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "ChartTitle";
            this.chart1.Titles.Add(title1);
            // 
            // gridOdgovori
            // 
            this.gridOdgovori.AllowUserToAddRows = false;
            this.gridOdgovori.AllowUserToDeleteRows = false;
            this.gridOdgovori.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            this.gridOdgovori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridOdgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridOdgovori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOdgovori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridOdgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOdgovori.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOdgovori.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridOdgovori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOdgovori.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridOdgovori.EnableHeadersVisualStyles = false;
            this.gridOdgovori.Location = new System.Drawing.Point(0, 0);
            this.gridOdgovori.Name = "gridOdgovori";
            this.gridOdgovori.ReadOnly = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOdgovori.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridOdgovori.RowHeadersVisible = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOdgovori.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridOdgovori.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOdgovori.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridOdgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOdgovori.ShowCellErrors = false;
            this.gridOdgovori.ShowCellToolTips = false;
            this.gridOdgovori.ShowEditingIcon = false;
            this.gridOdgovori.ShowRowErrors = false;
            this.gridOdgovori.Size = new System.Drawing.Size(431, 143);
            this.gridOdgovori.TabIndex = 2;
            this.gridOdgovori.SelectionChanged += new System.EventHandler(this.gridOdgovori_SelectionChanged);
            // 
            // tabPitanja
            // 
            this.tabPitanja.BackColor = System.Drawing.Color.LightBlue;
            this.tabPitanja.Controls.Add(this.panPitanja);
            this.tabPitanja.Location = new System.Drawing.Point(4, 22);
            this.tabPitanja.Name = "tabPitanja";
            this.tabPitanja.Padding = new System.Windows.Forms.Padding(10);
            this.tabPitanja.Size = new System.Drawing.Size(833, 491);
            this.tabPitanja.TabIndex = 3;
            this.tabPitanja.Text = "Pitanja";
            this.tabPitanja.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // panPitanja
            // 
            this.panPitanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.panPitanja.Controls.Add(this.btnOdustani);
            this.panPitanja.Controls.Add(this.btnNovo);
            this.panPitanja.Controls.Add(this.btnBrisiPit);
            this.panPitanja.Controls.Add(this.btnBrisiOdg);
            this.panPitanja.Controls.Add(this.btnPrihvati);
            this.panPitanja.Controls.Add(this.gridIzmjena);
            this.panPitanja.Controls.Add(this.lblPitanje);
            this.panPitanja.Controls.Add(this.txPitanje);
            this.panPitanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPitanja.Enabled = false;
            this.panPitanja.Location = new System.Drawing.Point(10, 10);
            this.panPitanja.Name = "panPitanja";
            this.panPitanja.Size = new System.Drawing.Size(813, 471);
            this.panPitanja.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdustani.Location = new System.Drawing.Point(609, 414);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(116, 34);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani od izmjena";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Visible = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Location = new System.Drawing.Point(74, 414);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 34);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo pitanje";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnBrisiPit
            // 
            this.btnBrisiPit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisiPit.Location = new System.Drawing.Point(315, 414);
            this.btnBrisiPit.Name = "btnBrisiPit";
            this.btnBrisiPit.Size = new System.Drawing.Size(95, 34);
            this.btnBrisiPit.TabIndex = 6;
            this.btnBrisiPit.Text = "Obriši pitanje";
            this.btnBrisiPit.UseVisualStyleBackColor = true;
            this.btnBrisiPit.Click += new System.EventHandler(this.btnBrisiPit_Click);
            // 
            // btnBrisiOdg
            // 
            this.btnBrisiOdg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisiOdg.Location = new System.Drawing.Point(194, 414);
            this.btnBrisiOdg.Name = "btnBrisiOdg";
            this.btnBrisiOdg.Size = new System.Drawing.Size(95, 34);
            this.btnBrisiOdg.TabIndex = 5;
            this.btnBrisiOdg.Text = "Obriši odgovor";
            this.btnBrisiOdg.UseVisualStyleBackColor = true;
            this.btnBrisiOdg.Click += new System.EventHandler(this.btnBrisiOdg_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrihvati.Location = new System.Drawing.Point(498, 414);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(95, 34);
            this.btnPrihvati.TabIndex = 4;
            this.btnPrihvati.Text = "Spremi izmjene";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Visible = false;
            this.btnPrihvati.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridIzmjena
            // 
            this.gridIzmjena.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Bisque;
            this.gridIzmjena.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridIzmjena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridIzmjena.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridIzmjena.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzmjena.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridIzmjena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIzmjena.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridIzmjena.EnableHeadersVisualStyles = false;
            this.gridIzmjena.Location = new System.Drawing.Point(55, 103);
            this.gridIzmjena.MultiSelect = false;
            this.gridIzmjena.Name = "gridIzmjena";
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzmjena.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridIzmjena.RowHeadersVisible = false;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzmjena.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gridIzmjena.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzmjena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridIzmjena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridIzmjena.ShowCellErrors = false;
            this.gridIzmjena.ShowCellToolTips = false;
            this.gridIzmjena.ShowRowErrors = false;
            this.gridIzmjena.Size = new System.Drawing.Size(687, 295);
            this.gridIzmjena.TabIndex = 3;
            this.gridIzmjena.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIzmjena_CellValueChanged);
            this.gridIzmjena.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridIzmjena_UserAddedRow);
            // 
            // lblPitanje
            // 
            this.lblPitanje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPitanje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPitanje.Location = new System.Drawing.Point(52, 14);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Size = new System.Drawing.Size(690, 23);
            this.lblPitanje.TabIndex = 1;
            this.lblPitanje.Text = "P i t a n j e";
            this.lblPitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPitanje
            // 
            this.txPitanje.AcceptsReturn = true;
            this.txPitanje.AllowDrop = true;
            this.txPitanje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txPitanje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txPitanje.Location = new System.Drawing.Point(55, 48);
            this.txPitanje.Multiline = true;
            this.txPitanje.Name = "txPitanje";
            this.txPitanje.Size = new System.Drawing.Size(687, 45);
            this.txPitanje.TabIndex = 0;
            this.txPitanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txPitanje.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txPitanje_PreviewKeyDown);
            // 
            // tabOAplikaciji
            // 
            this.tabOAplikaciji.BackColor = System.Drawing.Color.Bisque;
            this.tabOAplikaciji.Controls.Add(this.panel5);
            this.tabOAplikaciji.Location = new System.Drawing.Point(4, 22);
            this.tabOAplikaciji.Name = "tabOAplikaciji";
            this.tabOAplikaciji.Padding = new System.Windows.Forms.Padding(10);
            this.tabOAplikaciji.Size = new System.Drawing.Size(833, 491);
            this.tabOAplikaciji.TabIndex = 4;
            this.tabOAplikaciji.Text = "O Aplikaciji";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(813, 471);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Ankete.Properties.Resources.About;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(234, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 599);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ankete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAnkete.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPitanja)).EndInit();
            this.splitGraf.Panel1.ResumeLayout(false);
            this.splitGraf.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGraf)).EndInit();
            this.splitGraf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdgovori)).EndInit();
            this.tabPitanja.ResumeLayout(false);
            this.panPitanja.ResumeLayout(false);
            this.panPitanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzmjena)).EndInit();
            this.tabOAplikaciji.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnkete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridPitanja;
        private System.Windows.Forms.SplitContainer splitGraf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView gridOdgovori;
        private System.Windows.Forms.TabPage tabPitanja;
        private System.Windows.Forms.TabPage tabOAplikaciji;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panPitanja;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.TextBox txPitanje;
        private System.Windows.Forms.DataGridView gridIzmjena;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnBrisiOdg;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBrisiPit;
        private System.Windows.Forms.Button btnOdustani;
    }
}

