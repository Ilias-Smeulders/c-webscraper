namespace Webscraper
{
    partial class yt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yt));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCsv = new System.Windows.Forms.Button();
            this.dgvYT = new System.Windows.Forms.DataGridView();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Views = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(511, 33);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 25);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(3, 15);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(326, 46);
            this.lblTitel.TabIndex = 16;
            this.lblTitel.Text = "Youtube video\'s vinden";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 118);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Zoektext";
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(511, 130);
            this.btnCsv.Margin = new System.Windows.Forms.Padding(2);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(98, 25);
            this.btnCsv.TabIndex = 12;
            this.btnCsv.Text = "Exporteer";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // dgvYT
            // 
            this.dgvYT.AllowUserToAddRows = false;
            this.dgvYT.AllowUserToDeleteRows = false;
            this.dgvYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titel,
            this.Uploader,
            this.Views,
            this.URL});
            this.dgvYT.Location = new System.Drawing.Point(11, 160);
            this.dgvYT.Margin = new System.Windows.Forms.Padding(2);
            this.dgvYT.Name = "dgvYT";
            this.dgvYT.ReadOnly = true;
            this.dgvYT.RowHeadersWidth = 51;
            this.dgvYT.RowTemplate.Height = 24;
            this.dgvYT.Size = new System.Drawing.Size(598, 304);
            this.dgvYT.TabIndex = 11;
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
            // Uploader
            // 
            this.Uploader.HeaderText = "Uploader";
            this.Uploader.Name = "Uploader";
            this.Uploader.ReadOnly = true;
            // 
            // Views
            // 
            this.Views.HeaderText = "Views";
            this.Views.Name = "Views";
            this.Views.ReadOnly = true;
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
            this.txtSearch.Location = new System.Drawing.Point(11, 133);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(115, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(129, 130);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // yt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.dgvYT);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.DataGridView dgvYT;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Views;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
    }
}