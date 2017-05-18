namespace InformSystem
{
    partial class dataPresence
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.customGrpBox1 = new InformSystem.CustomGrpBox();
            this.timeScaleCombo = new System.Windows.Forms.ComboBox();
            this.customGrpBox2 = new InformSystem.CustomGrpBox();
            this.cultureCombo = new System.Windows.Forms.ComboBox();
            this.timeScaleCGB = new InformSystem.CustomGrpBox();
            this.variableTypeCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customGrpBox1.SuspendLayout();
            this.customGrpBox2.SuspendLayout();
            this.timeScaleCGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 419);
            this.dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(754, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 18;
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Controls.Add(this.timeScaleCombo);
            this.customGrpBox1.Location = new System.Drawing.Point(12, 12);
            this.customGrpBox1.Name = "customGrpBox1";
            this.customGrpBox1.Size = new System.Drawing.Size(235, 44);
            this.customGrpBox1.TabIndex = 16;
            this.customGrpBox1.TabStop = false;
            this.customGrpBox1.Text = "Розділ";
            // 
            // timeScaleCombo
            // 
            this.timeScaleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeScaleCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeScaleCombo.FormattingEnabled = true;
            this.timeScaleCombo.Items.AddRange(new object[] {
            "Середнє значення за 1981-2010",
            "Швидкість зміни за 1981-2010",
            "Проекції"});
            this.timeScaleCombo.Location = new System.Drawing.Point(6, 14);
            this.timeScaleCombo.Name = "timeScaleCombo";
            this.timeScaleCombo.Size = new System.Drawing.Size(221, 21);
            this.timeScaleCombo.TabIndex = 0;
            this.timeScaleCombo.SelectedIndexChanged += new System.EventHandler(this.timeScaleCombo_SelectedIndexChanged);
            // 
            // customGrpBox2
            // 
            this.customGrpBox2.Controls.Add(this.cultureCombo);
            this.customGrpBox2.Location = new System.Drawing.Point(494, 12);
            this.customGrpBox2.Name = "customGrpBox2";
            this.customGrpBox2.Size = new System.Drawing.Size(235, 44);
            this.customGrpBox2.TabIndex = 16;
            this.customGrpBox2.TabStop = false;
            this.customGrpBox2.Text = "Культури";
            // 
            // cultureCombo
            // 
            this.cultureCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cultureCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cultureCombo.FormattingEnabled = true;
            this.cultureCombo.Items.AddRange(new object[] {
            "Озима пшениця",
            "Кукурудза",
            "Ячмінь"});
            this.cultureCombo.Location = new System.Drawing.Point(6, 14);
            this.cultureCombo.Name = "cultureCombo";
            this.cultureCombo.Size = new System.Drawing.Size(221, 21);
            this.cultureCombo.TabIndex = 0;
            this.cultureCombo.SelectedIndexChanged += new System.EventHandler(this.cultureCombo_SelectedIndexChanged);
            // 
            // timeScaleCGB
            // 
            this.timeScaleCGB.Controls.Add(this.variableTypeCombo);
            this.timeScaleCGB.Location = new System.Drawing.Point(253, 12);
            this.timeScaleCGB.Name = "timeScaleCGB";
            this.timeScaleCGB.Size = new System.Drawing.Size(235, 44);
            this.timeScaleCGB.TabIndex = 16;
            this.timeScaleCGB.TabStop = false;
            this.timeScaleCGB.Text = "Категорія";
            // 
            // variableTypeCombo
            // 
            this.variableTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variableTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variableTypeCombo.FormattingEnabled = true;
            this.variableTypeCombo.Items.AddRange(new object[] {
            "Загальні параметри",
            "Агрометеорологічні умови"});
            this.variableTypeCombo.Location = new System.Drawing.Point(6, 14);
            this.variableTypeCombo.Name = "variableTypeCombo";
            this.variableTypeCombo.Size = new System.Drawing.Size(221, 21);
            this.variableTypeCombo.TabIndex = 0;
            this.variableTypeCombo.SelectedIndexChanged += new System.EventHandler(this.variableTypeCombo_SelectedIndexChanged);
            // 
            // dataPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customGrpBox1);
            this.Controls.Add(this.customGrpBox2);
            this.Controls.Add(this.timeScaleCGB);
            this.MaximizeBox = false;
            this.Name = "dataPresence";
            this.Text = "Наявність даних";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customGrpBox1.ResumeLayout(false);
            this.customGrpBox2.ResumeLayout(false);
            this.timeScaleCGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrpBox timeScaleCGB;
        private System.Windows.Forms.ComboBox variableTypeCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomGrpBox customGrpBox1;
        private System.Windows.Forms.ComboBox timeScaleCombo;
        private CustomGrpBox customGrpBox2;
        private System.Windows.Forms.ComboBox cultureCombo;
        private System.Windows.Forms.Label label1;
    }
}