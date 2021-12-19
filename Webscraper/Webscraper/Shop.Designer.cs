namespace Webscraper
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCsv = new System.Windows.Forms.Button();
            this.dgvBol = new System.Windows.Forms.DataGridView();
            this.Artikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sterren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbGeen = new System.Windows.Forms.RadioButton();
            this.rbPrijs = new System.Windows.Forms.RadioButton();
            this.rbSterren = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.gbRadios = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBol)).BeginInit();
            this.gbRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(692, 33);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 31);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(15, 11);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(312, 56);
            this.lblTitel.TabIndex = 23;
            this.lblTitel.Text = "Bol.com artikelen";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 138);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 16);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Zoektext";
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(692, 153);
            this.btnCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(131, 31);
            this.btnCsv.TabIndex = 21;
            this.btnCsv.Text = "Exporteer";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // dgvBol
            // 
            this.dgvBol.AllowUserToAddRows = false;
            this.dgvBol.AllowUserToDeleteRows = false;
            this.dgvBol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikel,
            this.Prijs,
            this.Sterren,
            this.URL});
            this.dgvBol.Location = new System.Drawing.Point(25, 190);
            this.dgvBol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBol.Name = "dgvBol";
            this.dgvBol.ReadOnly = true;
            this.dgvBol.RowHeadersWidth = 51;
            this.dgvBol.RowTemplate.Height = 24;
            this.dgvBol.Size = new System.Drawing.Size(797, 374);
            this.dgvBol.TabIndex = 20;
            // 
            // Artikel
            // 
            this.Artikel.HeaderText = "Artikel";
            this.Artikel.MinimumWidth = 6;
            this.Artikel.Name = "Artikel";
            this.Artikel.ReadOnly = true;
            this.Artikel.Width = 125;
            // 
            // Prijs
            // 
            this.Prijs.HeaderText = "Prijs";
            this.Prijs.MinimumWidth = 6;
            this.Prijs.Name = "Prijs";
            this.Prijs.ReadOnly = true;
            this.Prijs.Width = 125;
            // 
            // Sterren
            // 
            this.Sterren.HeaderText = "Sterren";
            this.Sterren.MinimumWidth = 6;
            this.Sterren.Name = "Sterren";
            this.Sterren.ReadOnly = true;
            this.Sterren.Width = 125;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 125;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(25, 156);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 22);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(183, 153);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbGeen
            // 
            this.rbGeen.AutoSize = true;
            this.rbGeen.Checked = true;
            this.rbGeen.Location = new System.Drawing.Point(8, 17);
            this.rbGeen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGeen.Name = "rbGeen";
            this.rbGeen.Size = new System.Drawing.Size(116, 20);
            this.rbGeen.TabIndex = 25;
            this.rbGeen.TabStop = true;
            this.rbGeen.Text = "Geen sortering";
            this.rbGeen.UseVisualStyleBackColor = true;
            // 
            // rbPrijs
            // 
            this.rbPrijs.AutoSize = true;
            this.rbPrijs.Location = new System.Drawing.Point(8, 48);
            this.rbPrijs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPrijs.Name = "rbPrijs";
            this.rbPrijs.Size = new System.Drawing.Size(54, 20);
            this.rbPrijs.TabIndex = 26;
            this.rbPrijs.Text = "Prijs";
            this.rbPrijs.UseVisualStyleBackColor = true;
            // 
            // rbSterren
            // 
            this.rbSterren.AutoSize = true;
            this.rbSterren.Location = new System.Drawing.Point(8, 79);
            this.rbSterren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSterren.Name = "rbSterren";
            this.rbSterren.Size = new System.Drawing.Size(71, 20);
            this.rbSterren.TabIndex = 27;
            this.rbSterren.Text = "Sterren";
            this.rbSterren.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(497, 153);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(131, 31);
            this.btnSort.TabIndex = 28;
            this.btnSort.Text = "Sorteer";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // gbRadios
            // 
            this.gbRadios.BackColor = System.Drawing.Color.Transparent;
            this.gbRadios.Controls.Add(this.rbPrijs);
            this.gbRadios.Controls.Add(this.rbGeen);
            this.gbRadios.Controls.Add(this.rbSterren);
            this.gbRadios.Location = new System.Drawing.Point(336, 73);
            this.gbRadios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRadios.Name = "gbRadios";
            this.gbRadios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRadios.Size = new System.Drawing.Size(155, 111);
            this.gbRadios.TabIndex = 29;
            this.gbRadios.TabStop = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 610);
            this.ControlBox = false;
            this.Controls.Add(this.gbRadios);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.dgvBol);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBol)).EndInit();
            this.gbRadios.ResumeLayout(false);
            this.gbRadios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.DataGridView dgvBol;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sterren;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.RadioButton rbGeen;
        private System.Windows.Forms.RadioButton rbPrijs;
        private System.Windows.Forms.RadioButton rbSterren;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox gbRadios;
    }
}