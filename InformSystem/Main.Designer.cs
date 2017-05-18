namespace InformSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сУБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиЗображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиЗображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замінитиЗображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.дадатиТаблицюфактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиТаблицюпроекціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиТаблицюсезониToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиТаблицюагроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиТаблицюекстримToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.наявністьДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.timeScaleCGB = new InformSystem.CustomGrpBox();
            this.timeScaleCombo = new System.Windows.Forms.ComboBox();
            this.periodCGB = new InformSystem.CustomGrpBox();
            this.seasonPeriodCombo = new System.Windows.Forms.ComboBox();
            this.regionsCGB = new InformSystem.CustomGrpBox();
            this.regionsCombo = new System.Windows.Forms.ComboBox();
            this.variablesCGB = new InformSystem.CustomGrpBox();
            this.variablesCombo = new System.Windows.Forms.ComboBox();
            this.customGrpBox1 = new InformSystem.CustomGrpBox();
            this.oblSummCheck = new System.Windows.Forms.CheckBox();
            this.specClimatIndicesCheck = new System.Windows.Forms.CheckBox();
            this.termoCheck = new System.Windows.Forms.CheckBox();
            this.humidityCheck = new System.Windows.Forms.CheckBox();
            this.agroCondCheck = new System.Windows.Forms.CheckBox();
            this.windCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.timeScaleCGB.SuspendLayout();
            this.periodCGB.SuspendLayout();
            this.regionsCGB.SuspendLayout();
            this.variablesCGB.SuspendLayout();
            this.customGrpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(26, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 562);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Параметр";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Фактичне значення";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 263;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Прогнозоване значення";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Різниця";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Значимість";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідкаToolStripMenuItem,
            this.сУБДToolStripMenuItem,
            this.вийтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.довідкаToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            this.довідкаToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // сУБДToolStripMenuItem
            // 
            this.сУБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиЗображенняToolStripMenuItem,
            this.видалитиЗображенняToolStripMenuItem,
            this.замінитиЗображенняToolStripMenuItem,
            this.toolStripMenuItem1,
            this.дадатиТаблицюфактToolStripMenuItem,
            this.додатиТаблицюпроекціяToolStripMenuItem,
            this.додатиТаблицюсезониToolStripMenuItem,
            this.додатиТаблицюагроToolStripMenuItem,
            this.додатиТаблицюекстримToolStripMenuItem,
            this.видалитиТаблицюToolStripMenuItem,
            this.toolStripMenuItem2,
            this.наявністьДанихToolStripMenuItem});
            this.сУБДToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.сУБДToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.сУБДToolStripMenuItem.Name = "сУБДToolStripMenuItem";
            this.сУБДToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.сУБДToolStripMenuItem.Text = "СУБД";
            // 
            // додатиЗображенняToolStripMenuItem
            // 
            this.додатиЗображенняToolStripMenuItem.Name = "додатиЗображенняToolStripMenuItem";
            this.додатиЗображенняToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.додатиЗображенняToolStripMenuItem.Text = "Додати зображення";
            this.додатиЗображенняToolStripMenuItem.Click += new System.EventHandler(this.додатиЗображенняToolStripMenuItem_Click);
            // 
            // видалитиЗображенняToolStripMenuItem
            // 
            this.видалитиЗображенняToolStripMenuItem.Name = "видалитиЗображенняToolStripMenuItem";
            this.видалитиЗображенняToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.видалитиЗображенняToolStripMenuItem.Text = "Видалити зображення";
            this.видалитиЗображенняToolStripMenuItem.Click += new System.EventHandler(this.видалитиЗображенняToolStripMenuItem_Click);
            // 
            // замінитиЗображенняToolStripMenuItem
            // 
            this.замінитиЗображенняToolStripMenuItem.Name = "замінитиЗображенняToolStripMenuItem";
            this.замінитиЗображенняToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.замінитиЗображенняToolStripMenuItem.Text = "Замінити зображення";
            this.замінитиЗображенняToolStripMenuItem.Click += new System.EventHandler(this.замінитиЗображенняToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // дадатиТаблицюфактToolStripMenuItem
            // 
            this.дадатиТаблицюфактToolStripMenuItem.Name = "дадатиТаблицюфактToolStripMenuItem";
            this.дадатиТаблицюфактToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.дадатиТаблицюфактToolStripMenuItem.Text = "Дадати таблицю (факт)";
            this.дадатиТаблицюфактToolStripMenuItem.Click += new System.EventHandler(this.дадатиТаблицюфактToolStripMenuItem_Click);
            // 
            // додатиТаблицюпроекціяToolStripMenuItem
            // 
            this.додатиТаблицюпроекціяToolStripMenuItem.Name = "додатиТаблицюпроекціяToolStripMenuItem";
            this.додатиТаблицюпроекціяToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.додатиТаблицюпроекціяToolStripMenuItem.Text = "Додати таблицю (проекція)";
            this.додатиТаблицюпроекціяToolStripMenuItem.Click += new System.EventHandler(this.додатиТаблицюпроекціяToolStripMenuItem_Click);
            // 
            // додатиТаблицюсезониToolStripMenuItem
            // 
            this.додатиТаблицюсезониToolStripMenuItem.Name = "додатиТаблицюсезониToolStripMenuItem";
            this.додатиТаблицюсезониToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.додатиТаблицюсезониToolStripMenuItem.Text = "Додати таблицю (сезони)";
            this.додатиТаблицюсезониToolStripMenuItem.Click += new System.EventHandler(this.додатиТаблицюсезониToolStripMenuItem_Click);
            // 
            // додатиТаблицюагроToolStripMenuItem
            // 
            this.додатиТаблицюагроToolStripMenuItem.Name = "додатиТаблицюагроToolStripMenuItem";
            this.додатиТаблицюагроToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.додатиТаблицюагроToolStripMenuItem.Text = "Додати таблицю (агро)";
            this.додатиТаблицюагроToolStripMenuItem.Click += new System.EventHandler(this.додатиТаблицюагроToolStripMenuItem_Click);
            // 
            // додатиТаблицюекстримToolStripMenuItem
            // 
            this.додатиТаблицюекстримToolStripMenuItem.Name = "додатиТаблицюекстримToolStripMenuItem";
            this.додатиТаблицюекстримToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.додатиТаблицюекстримToolStripMenuItem.Text = "Додати таблицю (екстрим)";
            this.додатиТаблицюекстримToolStripMenuItem.Click += new System.EventHandler(this.додатиТаблицюекстримToolStripMenuItem_Click);
            // 
            // видалитиТаблицюToolStripMenuItem
            // 
            this.видалитиТаблицюToolStripMenuItem.Name = "видалитиТаблицюToolStripMenuItem";
            this.видалитиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.видалитиТаблицюToolStripMenuItem.Text = "Видалити таблицю";
            this.видалитиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.видалитиТаблицюToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(249, 6);
            // 
            // наявністьДанихToolStripMenuItem
            // 
            this.наявністьДанихToolStripMenuItem.Name = "наявністьДанихToolStripMenuItem";
            this.наявністьДанихToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.наявністьДанихToolStripMenuItem.Text = "Наявність даних";
            this.наявністьДанихToolStripMenuItem.Click += new System.EventHandler(this.наявністьДанихToolStripMenuItem_Click);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Enabled = false;
            this.вийтиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.вийтиToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 562);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 122);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(902, 562);
            this.dataGridView2.TabIndex = 19;
            // 
            // timeScaleCGB
            // 
            this.timeScaleCGB.Controls.Add(this.timeScaleCombo);
            this.timeScaleCGB.Location = new System.Drawing.Point(25, 73);
            this.timeScaleCGB.Name = "timeScaleCGB";
            this.timeScaleCGB.Size = new System.Drawing.Size(235, 44);
            this.timeScaleCGB.TabIndex = 15;
            this.timeScaleCGB.TabStop = false;
            this.timeScaleCGB.Text = "Категорія";
            // 
            // timeScaleCombo
            // 
            this.timeScaleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeScaleCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeScaleCombo.FormattingEnabled = true;
            this.timeScaleCombo.Items.AddRange(new object[] {
            "Середнє значення за 1981-2010",
            "Швидкість зміни за 1981-2010",
            "Проекції (2021-2050)"});
            this.timeScaleCombo.Location = new System.Drawing.Point(6, 14);
            this.timeScaleCombo.Name = "timeScaleCombo";
            this.timeScaleCombo.Size = new System.Drawing.Size(221, 21);
            this.timeScaleCombo.TabIndex = 0;
            this.timeScaleCombo.SelectedIndexChanged += new System.EventHandler(this.timeScaleCombo_SelectedIndexChanged);
            // 
            // periodCGB
            // 
            this.periodCGB.Controls.Add(this.seasonPeriodCombo);
            this.periodCGB.Location = new System.Drawing.Point(557, 73);
            this.periodCGB.Name = "periodCGB";
            this.periodCGB.Size = new System.Drawing.Size(207, 44);
            this.periodCGB.TabIndex = 14;
            this.periodCGB.TabStop = false;
            this.periodCGB.Text = "Сезон";
            // 
            // seasonPeriodCombo
            // 
            this.seasonPeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonPeriodCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seasonPeriodCombo.FormattingEnabled = true;
            this.seasonPeriodCombo.Location = new System.Drawing.Point(8, 14);
            this.seasonPeriodCombo.Name = "seasonPeriodCombo";
            this.seasonPeriodCombo.Size = new System.Drawing.Size(193, 21);
            this.seasonPeriodCombo.TabIndex = 13;
            this.seasonPeriodCombo.SelectedIndexChanged += new System.EventHandler(this.seasonPeriodCombo_SelectedIndexChanged);
            // 
            // regionsCGB
            // 
            this.regionsCGB.Controls.Add(this.regionsCombo);
            this.regionsCGB.Enabled = false;
            this.regionsCGB.Location = new System.Drawing.Point(768, 73);
            this.regionsCGB.Name = "regionsCGB";
            this.regionsCGB.Size = new System.Drawing.Size(162, 44);
            this.regionsCGB.TabIndex = 12;
            this.regionsCGB.TabStop = false;
            this.regionsCGB.Text = "Області";
            // 
            // regionsCombo
            // 
            this.regionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionsCombo.FormattingEnabled = true;
            this.regionsCombo.Items.AddRange(new object[] {
            "Волинська",
            "Житомирська",
            "Рівненська",
            "Чернігівська",
            "Івано-Франківська",
            "Львівська",
            "Тернопільська",
            "Чернівецька",
            "Вінницька",
            "Київська",
            "Хмельницька",
            "Черкаська",
            "Полтавська",
            "Сумська",
            "Харківська",
            "Луганська",
            "Дніпропетровська",
            "Донецька",
            "Кіровоградська",
            "Запорізька",
            "Миколаївська",
            "Одеська",
            "Херсонська",
            "АР Крим"});
            this.regionsCombo.Location = new System.Drawing.Point(6, 13);
            this.regionsCombo.Name = "regionsCombo";
            this.regionsCombo.Size = new System.Drawing.Size(150, 21);
            this.regionsCombo.TabIndex = 10;
            this.regionsCombo.SelectedIndexChanged += new System.EventHandler(this.regionsCombo_SelectedIndexChanged);
            // 
            // variablesCGB
            // 
            this.variablesCGB.Controls.Add(this.variablesCombo);
            this.variablesCGB.Location = new System.Drawing.Point(263, 73);
            this.variablesCGB.Name = "variablesCGB";
            this.variablesCGB.Size = new System.Drawing.Size(288, 44);
            this.variablesCGB.TabIndex = 11;
            this.variablesCGB.TabStop = false;
            this.variablesCGB.Text = "Показники";
            // 
            // variablesCombo
            // 
            this.variablesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variablesCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variablesCombo.FormattingEnabled = true;
            this.variablesCombo.Location = new System.Drawing.Point(6, 14);
            this.variablesCombo.Name = "variablesCombo";
            this.variablesCombo.Size = new System.Drawing.Size(276, 21);
            this.variablesCombo.TabIndex = 4;
            this.variablesCombo.SelectedIndexChanged += new System.EventHandler(this.variablesCombo_SelectedIndexChanged);
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Controls.Add(this.oblSummCheck);
            this.customGrpBox1.Controls.Add(this.specClimatIndicesCheck);
            this.customGrpBox1.Controls.Add(this.termoCheck);
            this.customGrpBox1.Controls.Add(this.humidityCheck);
            this.customGrpBox1.Controls.Add(this.agroCondCheck);
            this.customGrpBox1.Controls.Add(this.windCheck);
            this.customGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.customGrpBox1.Location = new System.Drawing.Point(7, 27);
            this.customGrpBox1.Name = "customGrpBox1";
            this.customGrpBox1.Size = new System.Drawing.Size(933, 46);
            this.customGrpBox1.TabIndex = 9;
            this.customGrpBox1.TabStop = false;
            this.customGrpBox1.Text = "Розділи";
            // 
            // oblSummCheck
            // 
            this.oblSummCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.oblSummCheck.AutoSize = true;
            this.oblSummCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.oblSummCheck.Location = new System.Drawing.Point(795, 15);
            this.oblSummCheck.Name = "oblSummCheck";
            this.oblSummCheck.Size = new System.Drawing.Size(131, 23);
            this.oblSummCheck.TabIndex = 19;
            this.oblSummCheck.Text = "Підсумок по областям";
            this.oblSummCheck.UseVisualStyleBackColor = true;
            this.oblSummCheck.CheckedChanged += new System.EventHandler(this.oblSummCheck_CheckedChanged);
            // 
            // specClimatIndicesCheck
            // 
            this.specClimatIndicesCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.specClimatIndicesCheck.AutoSize = true;
            this.specClimatIndicesCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specClimatIndicesCheck.Location = new System.Drawing.Point(358, 15);
            this.specClimatIndicesCheck.Name = "specClimatIndicesCheck";
            this.specClimatIndicesCheck.Size = new System.Drawing.Size(147, 23);
            this.specClimatIndicesCheck.TabIndex = 3;
            this.specClimatIndicesCheck.Text = "Спеціалізовані показники";
            this.specClimatIndicesCheck.UseVisualStyleBackColor = true;
            this.specClimatIndicesCheck.CheckedChanged += new System.EventHandler(this.checksChanged);
            // 
            // termoCheck
            // 
            this.termoCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.termoCheck.AutoSize = true;
            this.termoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termoCheck.Location = new System.Drawing.Point(5, 15);
            this.termoCheck.Name = "termoCheck";
            this.termoCheck.Size = new System.Drawing.Size(133, 23);
            this.termoCheck.TabIndex = 0;
            this.termoCheck.Text = "Температурний режим";
            this.termoCheck.UseVisualStyleBackColor = true;
            this.termoCheck.CheckedChanged += new System.EventHandler(this.checksChanged);
            // 
            // humidityCheck
            // 
            this.humidityCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.humidityCheck.AutoSize = true;
            this.humidityCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidityCheck.Location = new System.Drawing.Point(139, 15);
            this.humidityCheck.Name = "humidityCheck";
            this.humidityCheck.Size = new System.Drawing.Size(117, 23);
            this.humidityCheck.TabIndex = 1;
            this.humidityCheck.Text = "Режим зволоження";
            this.humidityCheck.UseVisualStyleBackColor = true;
            this.humidityCheck.CheckedChanged += new System.EventHandler(this.checksChanged);
            // 
            // agroCondCheck
            // 
            this.agroCondCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.agroCondCheck.AutoSize = true;
            this.agroCondCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agroCondCheck.Location = new System.Drawing.Point(509, 15);
            this.agroCondCheck.Name = "agroCondCheck";
            this.agroCondCheck.Size = new System.Drawing.Size(282, 23);
            this.agroCondCheck.TabIndex = 4;
            this.agroCondCheck.Text = "Агрометеорологічні умови вирощування с/г культур";
            this.agroCondCheck.UseVisualStyleBackColor = true;
            this.agroCondCheck.CheckedChanged += new System.EventHandler(this.checksChanged);
            // 
            // windCheck
            // 
            this.windCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.windCheck.AutoSize = true;
            this.windCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windCheck.Location = new System.Drawing.Point(259, 15);
            this.windCheck.Name = "windCheck";
            this.windCheck.Size = new System.Drawing.Size(98, 23);
            this.windCheck.TabIndex = 2;
            this.windCheck.Text = "Вітровий режим";
            this.windCheck.UseVisualStyleBackColor = true;
            this.windCheck.CheckedChanged += new System.EventHandler(this.checksChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.timeScaleCGB);
            this.Controls.Add(this.periodCGB);
            this.Controls.Add(this.regionsCGB);
            this.Controls.Add(this.variablesCGB);
            this.Controls.Add(this.customGrpBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Інформаційна система";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.timeScaleCGB.ResumeLayout(false);
            this.periodCGB.ResumeLayout(false);
            this.regionsCGB.ResumeLayout(false);
            this.variablesCGB.ResumeLayout(false);
            this.customGrpBox1.ResumeLayout(false);
            this.customGrpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox variablesCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox humidityCheck;
        private System.Windows.Forms.CheckBox windCheck;
        private System.Windows.Forms.CheckBox specClimatIndicesCheck;
        private System.Windows.Forms.CheckBox agroCondCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.CheckBox termoCheck;
        private CustomGrpBox customGrpBox1;
        private System.Windows.Forms.ComboBox regionsCombo;
        private CustomGrpBox variablesCGB;
        private CustomGrpBox regionsCGB;
        private System.Windows.Forms.ComboBox seasonPeriodCombo;
        private CustomGrpBox periodCGB;
        private CustomGrpBox timeScaleCGB;
        private System.Windows.Forms.ComboBox timeScaleCombo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox oblSummCheck;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem сУБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиЗображенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиЗображенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замінитиЗображенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дадатиТаблицюфактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиТаблицюпроекціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наявністьДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиТаблицюToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem додатиТаблицюекстримToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиТаблицюсезониToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиТаблицюагроToolStripMenuItem;
    }
}

