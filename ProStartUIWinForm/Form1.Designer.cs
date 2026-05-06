namespace ProStartUIWinForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();

            // -- Add Activity tab controls
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtpActivity = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.tabControlInner = new System.Windows.Forms.TabControl();
            this.tabFitness = new System.Windows.Forms.TabPage();
            this.tabEntertainment = new System.Windows.Forms.TabPage();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSaveFitness = new System.Windows.Forms.Button();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.btnSaveEntertainment = new System.Windows.Forms.Button();

            // -- Search tab controls
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.rdoBefore = new System.Windows.Forms.RadioButton();
            this.rdoOn = new System.Windows.Forms.RadioButton();
            this.rdoAfter = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabControlInner.SuspendLayout();
            this.tabFitness.SuspendLayout();
            this.tabEntertainment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvResults).BeginInit();
            this.SuspendLayout();

            // ── tabControl1 ───────────────────────────────────
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Size = new System.Drawing.Size(620, 480);
            this.tabControl1.TabIndex = 0;

            // ── tabAdd ────────────────────────────────────────
            this.tabAdd.Text = "Add Activity";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(12);
            this.tabAdd.Controls.Add(this.lblDateTime);
            this.tabAdd.Controls.Add(this.dtpActivity);
            this.tabAdd.Controls.Add(this.lblTitle);
            this.tabAdd.Controls.Add(this.txtTitle);
            this.tabAdd.Controls.Add(this.lblCost);
            this.tabAdd.Controls.Add(this.txtCost);
            this.tabAdd.Controls.Add(this.tabControlInner);

            // lblDateTime
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.Location = new System.Drawing.Point(20, 24);
            this.lblDateTime.Size = new System.Drawing.Size(100, 24);
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // dtpActivity
            this.dtpActivity.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActivity.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpActivity.ShowUpDown = false;
            this.dtpActivity.Location = new System.Drawing.Point(130, 24);
            this.dtpActivity.Size = new System.Drawing.Size(440, 24);

            // lblTitle
            this.lblTitle.Text = "Title";
            this.lblTitle.Location = new System.Drawing.Point(20, 62);
            this.lblTitle.Size = new System.Drawing.Size(100, 24);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(130, 62);
            this.txtTitle.Size = new System.Drawing.Size(440, 24);

            // lblCost
            this.lblCost.Text = "Cost";
            this.lblCost.Location = new System.Drawing.Point(20, 100);
            this.lblCost.Size = new System.Drawing.Size(100, 24);
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // txtCost
            this.txtCost.Location = new System.Drawing.Point(130, 100);
            this.txtCost.Size = new System.Drawing.Size(440, 24);

            // ── tabControlInner ───────────────────────────────
            this.tabControlInner.Controls.Add(this.tabFitness);
            this.tabControlInner.Controls.Add(this.tabEntertainment);
            this.tabControlInner.Location = new System.Drawing.Point(20, 140);
            this.tabControlInner.Size = new System.Drawing.Size(560, 260);
            this.tabControlInner.TabIndex = 10;

            // tabFitness
            this.tabFitness.Text = "Fitness";
            this.tabFitness.Padding = new System.Windows.Forms.Padding(10);
            this.tabFitness.Controls.Add(this.lblLocation);
            this.tabFitness.Controls.Add(this.txtLocation);
            this.tabFitness.Controls.Add(this.btnSaveFitness);

            // lblLocation
            this.lblLocation.Text = "Location";
            this.lblLocation.Location = new System.Drawing.Point(14, 16);
            this.lblLocation.Size = new System.Drawing.Size(80, 20);

            // txtLocation
            this.txtLocation.Location = new System.Drawing.Point(14, 40);
            this.txtLocation.Size = new System.Drawing.Size(510, 24);

            // btnSaveFitness
            this.btnSaveFitness.Text = "Save Fitness Activity";
            this.btnSaveFitness.Location = new System.Drawing.Point(14, 80);
            this.btnSaveFitness.Size = new System.Drawing.Size(510, 30);
            this.btnSaveFitness.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnSaveFitness.FlatStyle = System.Windows.Forms.FlatStyle.System;

            // tabEntertainment
            this.tabEntertainment.Text = "Entertainment";
            this.tabEntertainment.Padding = new System.Windows.Forms.Padding(10);
            this.tabEntertainment.Controls.Add(this.lblVenue);
            this.tabEntertainment.Controls.Add(this.txtVenue);
            this.tabEntertainment.Controls.Add(this.btnSaveEntertainment);

            // lblVenue
            this.lblVenue.Text = "Venue";
            this.lblVenue.Location = new System.Drawing.Point(14, 16);
            this.lblVenue.Size = new System.Drawing.Size(80, 20);

            // txtVenue
            this.txtVenue.Location = new System.Drawing.Point(14, 40);
            this.txtVenue.Size = new System.Drawing.Size(510, 24);

            // btnSaveEntertainment
            this.btnSaveEntertainment.Text = "Save Entertainment Activity";
            this.btnSaveEntertainment.Location = new System.Drawing.Point(14, 80);
            this.btnSaveEntertainment.Size = new System.Drawing.Size(510, 30);
            this.btnSaveEntertainment.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnSaveEntertainment.FlatStyle = System.Windows.Forms.FlatStyle.System;

            // ── tabSearch ─────────────────────────────────────
            this.tabSearch.Text = "Search Activities";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(12);
            this.tabSearch.Controls.Add(this.lblSearchDate);
            this.tabSearch.Controls.Add(this.dtpSearch);
            this.tabSearch.Controls.Add(this.lblSearchCriteria);
            this.tabSearch.Controls.Add(this.rdoBefore);
            this.tabSearch.Controls.Add(this.rdoOn);
            this.tabSearch.Controls.Add(this.rdoAfter);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.btnDisplayAll);
            this.tabSearch.Controls.Add(this.dgvResults);

            // lblSearchDate
            this.lblSearchDate.Text = "Search Date";
            this.lblSearchDate.Location = new System.Drawing.Point(20, 24);
            this.lblSearchDate.Size = new System.Drawing.Size(100, 24);
            this.lblSearchDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // dtpSearch
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearch.Location = new System.Drawing.Point(130, 24);
            this.dtpSearch.Size = new System.Drawing.Size(440, 24);

            // lblSearchCriteria
            this.lblSearchCriteria.Text = "Search Criteria";
            this.lblSearchCriteria.Location = new System.Drawing.Point(20, 62);
            this.lblSearchCriteria.Size = new System.Drawing.Size(100, 24);
            this.lblSearchCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // rdoBefore
            this.rdoBefore.Text = "Before";
            this.rdoBefore.Location = new System.Drawing.Point(130, 62);
            this.rdoBefore.Size = new System.Drawing.Size(80, 24);

            // rdoOn
            this.rdoOn.Text = "On";
            this.rdoOn.Location = new System.Drawing.Point(220, 62);
            this.rdoOn.Size = new System.Drawing.Size(60, 24);
            this.rdoOn.Checked = true;

            // rdoAfter
            this.rdoAfter.Text = "After";
            this.rdoAfter.Location = new System.Drawing.Point(290, 62);
            this.rdoAfter.Size = new System.Drawing.Size(70, 24);

            // btnSearch
            this.btnSearch.Text = "Search Activities";
            this.btnSearch.Location = new System.Drawing.Point(20, 100);
            this.btnSearch.Size = new System.Drawing.Size(560, 30);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;

            // btnDisplayAll
            this.btnDisplayAll.Text = "Display All Activities";
            this.btnDisplayAll.Location = new System.Drawing.Point(20, 140);
            this.btnDisplayAll.Size = new System.Drawing.Size(560, 30);
            this.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.System;

            // dgvResults
            this.dgvResults.Location = new System.Drawing.Point(20, 184);
            this.dgvResults.Size = new System.Drawing.Size(560, 210);
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.ReadOnly = true;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.Columns.AddRange(this.colDateTime, this.colTitle, this.colCost);

            // colDateTime
            this.colDateTime.HeaderText = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.FillWeight = 35;

            // colTitle
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.FillWeight = 45;

            // colCost
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.FillWeight = 20;

            // ── Form ──────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.Text = "Activity Tracker";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabControlInner.ResumeLayout(false);
            this.tabFitness.ResumeLayout(false);
            this.tabFitness.PerformLayout();
            this.tabEntertainment.ResumeLayout(false);
            this.tabEntertainment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvResults).EndInit();
            this.ResumeLayout(false);
        }

        // ── Field declarations ─────────────────────────────────
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtpActivity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TabControl tabControlInner;
        private System.Windows.Forms.TabPage tabFitness;
        private System.Windows.Forms.TabPage tabEntertainment;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSaveFitness;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Button btnSaveEntertainment;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.RadioButton rdoBefore;
        private System.Windows.Forms.RadioButton rdoOn;
        private System.Windows.Forms.RadioButton rdoAfter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
    }
}