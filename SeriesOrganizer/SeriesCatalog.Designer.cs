
namespace SeriesOrganizer
{
    partial class SeriesCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesCatalog));
            this.listViewSeries = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnTotalSeasons = new System.Windows.Forms.ColumnHeader();
            this.columnGenre = new System.Windows.Forms.ColumnHeader();
            this.columnCurrentSeason = new System.Windows.Forms.ColumnHeader();
            this.columnCurrentEpisode = new System.Windows.Forms.ColumnHeader();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTotalSeasons = new System.Windows.Forms.TextBox();
            this.textBoxCurrentSeason = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelTotalSeasons = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.LabelCurrentSeason = new System.Windows.Forms.Label();
            this.LabelCurrentEpisode = new System.Windows.Forms.Label();
            this.textBoxCurrentEpisode = new System.Windows.Forms.TextBox();
            this.ButtonAddSerie = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelMySerie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSeries
            // 
            this.listViewSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnTotalSeasons,
            this.columnGenre,
            this.columnCurrentSeason,
            this.columnCurrentEpisode});
            this.listViewSeries.FullRowSelect = true;
            this.listViewSeries.GridLines = true;
            this.listViewSeries.HideSelection = false;
            this.listViewSeries.Location = new System.Drawing.Point(378, 164);
            this.listViewSeries.MultiSelect = false;
            this.listViewSeries.Name = "listViewSeries";
            this.listViewSeries.Size = new System.Drawing.Size(550, 516);
            this.listViewSeries.TabIndex = 0;
            this.listViewSeries.UseCompatibleStateImageBehavior = false;
            this.listViewSeries.View = System.Windows.Forms.View.Details;
            this.listViewSeries.SelectedIndexChanged += new System.EventHandler(this.ListViewSeriesSelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnTotalSeasons
            // 
            this.columnTotalSeasons.Text = "Total Seasons";
            this.columnTotalSeasons.Width = 100;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Genre";
            this.columnGenre.Width = 100;
            // 
            // columnCurrentSeason
            // 
            this.columnCurrentSeason.Text = "Current Season";
            this.columnCurrentSeason.Width = 100;
            // 
            // columnCurrentEpisode
            // 
            this.columnCurrentEpisode.Text = "Current Episode";
            this.columnCurrentEpisode.Width = 95;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(24, 200);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(234, 16);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxTotalSeasons
            // 
            this.textBoxTotalSeasons.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxTotalSeasons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalSeasons.Location = new System.Drawing.Point(24, 284);
            this.textBoxTotalSeasons.Name = "textBoxTotalSeasons";
            this.textBoxTotalSeasons.Size = new System.Drawing.Size(234, 16);
            this.textBoxTotalSeasons.TabIndex = 2;
            // 
            // textBoxCurrentSeason
            // 
            this.textBoxCurrentSeason.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxCurrentSeason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentSeason.Location = new System.Drawing.Point(24, 441);
            this.textBoxCurrentSeason.Name = "textBoxCurrentSeason";
            this.textBoxCurrentSeason.Size = new System.Drawing.Size(234, 16);
            this.textBoxCurrentSeason.TabIndex = 4;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelName.ForeColor = System.Drawing.Color.Blue;
            this.LabelName.Location = new System.Drawing.Point(24, 157);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(70, 33);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name";
            // 
            // LabelTotalSeasons
            // 
            this.LabelTotalSeasons.AutoSize = true;
            this.LabelTotalSeasons.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTotalSeasons.ForeColor = System.Drawing.Color.Blue;
            this.LabelTotalSeasons.Location = new System.Drawing.Point(24, 235);
            this.LabelTotalSeasons.Name = "LabelTotalSeasons";
            this.LabelTotalSeasons.Size = new System.Drawing.Size(145, 33);
            this.LabelTotalSeasons.TabIndex = 6;
            this.LabelTotalSeasons.Text = "Total Seasons";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGenre.ForeColor = System.Drawing.Color.Blue;
            this.labelGenre.Location = new System.Drawing.Point(24, 322);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(73, 33);
            this.labelGenre.TabIndex = 7;
            this.labelGenre.Text = "Genre";
            // 
            // LabelCurrentSeason
            // 
            this.LabelCurrentSeason.AutoSize = true;
            this.LabelCurrentSeason.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCurrentSeason.ForeColor = System.Drawing.Color.Blue;
            this.LabelCurrentSeason.Location = new System.Drawing.Point(24, 398);
            this.LabelCurrentSeason.Name = "LabelCurrentSeason";
            this.LabelCurrentSeason.Size = new System.Drawing.Size(165, 33);
            this.LabelCurrentSeason.TabIndex = 8;
            this.LabelCurrentSeason.Text = "Current Season";
            // 
            // LabelCurrentEpisode
            // 
            this.LabelCurrentEpisode.AutoSize = true;
            this.LabelCurrentEpisode.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCurrentEpisode.ForeColor = System.Drawing.Color.Blue;
            this.LabelCurrentEpisode.Location = new System.Drawing.Point(24, 477);
            this.LabelCurrentEpisode.Name = "LabelCurrentEpisode";
            this.LabelCurrentEpisode.Size = new System.Drawing.Size(172, 33);
            this.LabelCurrentEpisode.TabIndex = 10;
            this.LabelCurrentEpisode.Text = "Current Episode";
            // 
            // textBoxCurrentEpisode
            // 
            this.textBoxCurrentEpisode.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxCurrentEpisode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentEpisode.Location = new System.Drawing.Point(24, 520);
            this.textBoxCurrentEpisode.Name = "textBoxCurrentEpisode";
            this.textBoxCurrentEpisode.Size = new System.Drawing.Size(234, 16);
            this.textBoxCurrentEpisode.TabIndex = 9;
            // 
            // ButtonAddSerie
            // 
            this.ButtonAddSerie.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonAddSerie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonAddSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddSerie.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSerie.ForeColor = System.Drawing.Color.White;
            this.ButtonAddSerie.Location = new System.Drawing.Point(24, 565);
            this.ButtonAddSerie.Name = "ButtonAddSerie";
            this.ButtonAddSerie.Size = new System.Drawing.Size(108, 38);
            this.ButtonAddSerie.TabIndex = 11;
            this.ButtonAddSerie.Text = "ADD";
            this.ButtonAddSerie.UseVisualStyleBackColor = false;
            this.ButtonAddSerie.Click += new System.EventHandler(this.ButtonAddSerieClick);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(177, 565);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(118, 38);
            this.ButtonUpdate.TabIndex = 12;
            this.ButtonUpdate.Text = "UPDATE";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(92, 642);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(120, 38);
            this.ButtonDelete.TabIndex = 13;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(631, 126);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(24, 27);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 14;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.PictureBoxSearchClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(24, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(24, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(24, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(24, 542);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(24, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 1);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(379, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 22;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Location = new System.Drawing.Point(378, 130);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(234, 16);
            this.textBoxSearch.TabIndex = 21;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Documentary",
            "Fantasy",
            "Musical",
            "Romance",
            "Science Fiction",
            "Terror",
            "Thriller",
            "Tragedy",
            "Western"});
            this.comboBoxGenre.Location = new System.Drawing.Point(24, 358);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(234, 23);
            this.comboBoxGenre.TabIndex = 23;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Shrikhand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonClose.ForeColor = System.Drawing.Color.LightCyan;
            this.ButtonClose.Location = new System.Drawing.Point(918, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(40, 36);
            this.ButtonClose.TabIndex = 24;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.labelMySerie);
            this.panel7.Controls.Add(this.ButtonClose);
            this.panel7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(958, 104);
            this.panel7.TabIndex = 25;
            // 
            // labelMySerie
            // 
            this.labelMySerie.AutoSize = true;
            this.labelMySerie.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelMySerie.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMySerie.ForeColor = System.Drawing.Color.LightCyan;
            this.labelMySerie.Location = new System.Drawing.Point(24, 18);
            this.labelMySerie.Name = "labelMySerie";
            this.labelMySerie.Size = new System.Drawing.Size(206, 58);
            this.labelMySerie.TabIndex = 25;
            this.labelMySerie.Text = "My Series";
            // 
            // SeriesCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(956, 709);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonAddSerie);
            this.Controls.Add(this.LabelCurrentEpisode);
            this.Controls.Add(this.textBoxCurrentEpisode);
            this.Controls.Add(this.LabelCurrentSeason);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.LabelTotalSeasons);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.textBoxCurrentSeason);
            this.Controls.Add(this.textBoxTotalSeasons);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewSeries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeriesCatalog";
            this.Text = "Catalog";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSeries;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTotalSeasons;
        private System.Windows.Forms.TextBox textBoxCurrentSeason;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelTotalSeasons;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label LabelCurrentSeason;
        private System.Windows.Forms.Label LabelCurrentEpisode;
        private System.Windows.Forms.TextBox textBoxCurrentEpisode;
        private System.Windows.Forms.Button ButtonAddSerie;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnTotalSeasons;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnCurrentSeason;
        private System.Windows.Forms.ColumnHeader columnCurrentEpisode;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelMySerie;
    }
}

