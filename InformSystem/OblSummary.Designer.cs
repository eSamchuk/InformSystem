namespace InformSystem
{
    partial class OblSummary
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
            this.extremeDGV = new System.Windows.Forms.DataGridView();
            this.extremeGB = new System.Windows.Forms.GroupBox();
            this.seasonGB = new System.Windows.Forms.GroupBox();
            this.SeasonDGV = new System.Windows.Forms.DataGridView();
            this.agroGB = new System.Windows.Forms.GroupBox();
            this.agroDGV = new System.Windows.Forms.DataGridView();
            this.cultureCombo = new System.Windows.Forms.ComboBox();
            this.phaseCombo = new System.Windows.Forms.ComboBox();
            this.seasonCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.extremeDGV)).BeginInit();
            this.extremeGB.SuspendLayout();
            this.seasonGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeasonDGV)).BeginInit();
            this.agroGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agroDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // extremeDGV
            // 
            this.extremeDGV.AllowUserToAddRows = false;
            this.extremeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extremeDGV.Location = new System.Drawing.Point(6, 19);
            this.extremeDGV.Name = "extremeDGV";
            this.extremeDGV.Size = new System.Drawing.Size(922, 192);
            this.extremeDGV.TabIndex = 0;
            // 
            // extremeGB
            // 
            this.extremeGB.Controls.Add(this.extremeDGV);
            this.extremeGB.Location = new System.Drawing.Point(12, 3);
            this.extremeGB.Name = "extremeGB";
            this.extremeGB.Size = new System.Drawing.Size(934, 217);
            this.extremeGB.TabIndex = 1;
            this.extremeGB.TabStop = false;
            this.extremeGB.Text = "Екстремальні параметри";
            // 
            // seasonGB
            // 
            this.seasonGB.Controls.Add(this.SeasonDGV);
            this.seasonGB.Location = new System.Drawing.Point(12, 223);
            this.seasonGB.Name = "seasonGB";
            this.seasonGB.Size = new System.Drawing.Size(934, 218);
            this.seasonGB.TabIndex = 1;
            this.seasonGB.TabStop = false;
            this.seasonGB.Text = "Сезонні параметри";
            // 
            // SeasonDGV
            // 
            this.SeasonDGV.AllowUserToAddRows = false;
            this.SeasonDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeasonDGV.Location = new System.Drawing.Point(6, 19);
            this.SeasonDGV.Name = "SeasonDGV";
            this.SeasonDGV.Size = new System.Drawing.Size(922, 193);
            this.SeasonDGV.TabIndex = 0;
            // 
            // agroGB
            // 
            this.agroGB.Controls.Add(this.agroDGV);
            this.agroGB.Location = new System.Drawing.Point(12, 445);
            this.agroGB.Name = "agroGB";
            this.agroGB.Size = new System.Drawing.Size(934, 203);
            this.agroGB.TabIndex = 1;
            this.agroGB.TabStop = false;
            this.agroGB.Text = "Агрометеорологічні параметри";
            // 
            // agroDGV
            // 
            this.agroDGV.AllowUserToAddRows = false;
            this.agroDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agroDGV.Location = new System.Drawing.Point(6, 19);
            this.agroDGV.Name = "agroDGV";
            this.agroDGV.Size = new System.Drawing.Size(922, 178);
            this.agroDGV.TabIndex = 0;
            // 
            // cultureCombo
            // 
            this.cultureCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cultureCombo.FormattingEnabled = true;
            this.cultureCombo.Location = new System.Drawing.Point(7, 19);
            this.cultureCombo.Name = "cultureCombo";
            this.cultureCombo.Size = new System.Drawing.Size(121, 21);
            this.cultureCombo.TabIndex = 2;
            // 
            // phaseCombo
            // 
            this.phaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phaseCombo.FormattingEnabled = true;
            this.phaseCombo.Location = new System.Drawing.Point(6, 19);
            this.phaseCombo.Name = "phaseCombo";
            this.phaseCombo.Size = new System.Drawing.Size(122, 21);
            this.phaseCombo.TabIndex = 2;
            // 
            // seasonCombo
            // 
            this.seasonCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonCombo.FormattingEnabled = true;
            this.seasonCombo.Location = new System.Drawing.Point(7, 19);
            this.seasonCombo.Name = "seasonCombo";
            this.seasonCombo.Size = new System.Drawing.Size(121, 21);
            this.seasonCombo.TabIndex = 2;
            // 
            // OblSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 652);
            this.Controls.Add(this.agroGB);
            this.Controls.Add(this.seasonGB);
            this.Controls.Add(this.extremeGB);
            this.Name = "OblSummary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Підсумок по області";
            ((System.ComponentModel.ISupportInitialize)(this.extremeDGV)).EndInit();
            this.extremeGB.ResumeLayout(false);
            this.seasonGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeasonDGV)).EndInit();
            this.agroGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agroDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView extremeDGV;
        private System.Windows.Forms.ComboBox cultureCombo;
        private System.Windows.Forms.ComboBox phaseCombo;
        private System.Windows.Forms.ComboBox seasonCombo;
        private System.Windows.Forms.GroupBox extremeGB;
        private System.Windows.Forms.GroupBox seasonGB;
        private System.Windows.Forms.DataGridView SeasonDGV;
        private System.Windows.Forms.GroupBox agroGB;
        private System.Windows.Forms.DataGridView agroDGV;
    }
}