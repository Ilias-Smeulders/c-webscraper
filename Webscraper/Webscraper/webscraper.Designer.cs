namespace Webscraper
{
    partial class webScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(webScraper));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bedrijf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnCsv = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.txtWaar = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(184, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 164);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titel,
            this.Bedrijf,
            this.Locatie,
            this.URL});
            this.dgvJobs.Location = new System.Drawing.Point(26, 192);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(797, 374);
            this.dgvJobs.TabIndex = 2;
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.MinimumWidth = 6;
            this.Titel.Name = "Titel";
            this.Titel.ReadOnly = true;
            this.Titel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Titel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Titel.Width = 125;
            // 
            // Bedrijf
            // 
            this.Bedrijf.HeaderText = "Bedrijf";
            this.Bedrijf.MinimumWidth = 6;
            this.Bedrijf.Name = "Bedrijf";
            this.Bedrijf.ReadOnly = true;
            this.Bedrijf.Width = 125;
            // 
            // Locatie
            // 
            this.Locatie.HeaderText = "Locatie";
            this.Locatie.MinimumWidth = 6;
            this.Locatie.Name = "Locatie";
            this.Locatie.ReadOnly = true;
            this.Locatie.Width = 125;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 125;
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(693, 155);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(130, 31);
            this.btnCsv.TabIndex = 3;
            this.btnCsv.Text = "Exporteer";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(27, 142);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Zoektext";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(27, 98);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(58, 16);
            this.lblLocatie.TabIndex = 5;
            this.lblLocatie.Text = "Locatie?";
            // 
            // txtWaar
            // 
            this.txtWaar.Location = new System.Drawing.Point(26, 117);
            this.txtWaar.Name = "txtWaar";
            this.txtWaar.Size = new System.Drawing.Size(152, 22);
            this.txtWaar.TabIndex = 6;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(16, 13);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(527, 56);
            this.lblTitel.TabIndex = 7;
            this.lblTitel.Text = "Makkelijk een lijst jobs vinden";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(693, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 31);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // webScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 578);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtWaar);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "webScraper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webscraper";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bedrijf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locatie;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.TextBox txtWaar;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnBack;
    }
}

