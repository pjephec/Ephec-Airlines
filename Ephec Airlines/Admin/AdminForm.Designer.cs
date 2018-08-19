namespace Admin
{
    partial class AdminForm
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
            this.tabsAdmin = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lblPrixGeneralDetails = new System.Windows.Forms.Label();
            this.lblVolsGeneralDetails = new System.Windows.Forms.Label();
            this.cmbTranchePrix = new System.Windows.Forms.ComboBox();
            this.txtVolsInput = new System.Windows.Forms.TextBox();
            this.btnFiltreVols = new System.Windows.Forms.Button();
            this.dataGridViewPrix = new System.Windows.Forms.DataGridView();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblVols = new System.Windows.Forms.Label();
            this.dataGridViewVols = new System.Windows.Forms.DataGridView();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.dataGridViewCA = new System.Windows.Forms.DataGridView();
            this.dataGridViewPassagers = new System.Windows.Forms.DataGridView();
            this.lblCADetails = new System.Windows.Forms.Label();
            this.lblPassagersVol = new System.Windows.Forms.Label();
            this.txtCAVol = new System.Windows.Forms.TextBox();
            this.txtNbPlacesRestantes = new System.Windows.Forms.TextBox();
            this.txtOccupationVol = new System.Windows.Forms.TextBox();
            this.txtNbPassagers = new System.Windows.Forms.TextBox();
            this.cmbDateVol = new System.Windows.Forms.ComboBox();
            this.cmbVolDetails = new System.Windows.Forms.ComboBox();
            this.lblCAVol = new System.Windows.Forms.Label();
            this.lblPlacesRestantes = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblNbPassagers = new System.Windows.Forms.Label();
            this.lblDateVolDetails = new System.Windows.Forms.Label();
            this.lblVolDetails = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabsAdmin.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVols)).BeginInit();
            this.tabDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassagers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsAdmin
            // 
            this.tabsAdmin.Controls.Add(this.tabGeneral);
            this.tabsAdmin.Controls.Add(this.tabDetails);
            this.tabsAdmin.Location = new System.Drawing.Point(13, 13);
            this.tabsAdmin.Multiline = true;
            this.tabsAdmin.Name = "tabsAdmin";
            this.tabsAdmin.SelectedIndex = 0;
            this.tabsAdmin.Size = new System.Drawing.Size(933, 601);
            this.tabsAdmin.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneral.Controls.Add(this.lblPrixGeneralDetails);
            this.tabGeneral.Controls.Add(this.lblVolsGeneralDetails);
            this.tabGeneral.Controls.Add(this.cmbTranchePrix);
            this.tabGeneral.Controls.Add(this.txtVolsInput);
            this.tabGeneral.Controls.Add(this.btnFiltreVols);
            this.tabGeneral.Controls.Add(this.dataGridViewPrix);
            this.tabGeneral.Controls.Add(this.lblPrix);
            this.tabGeneral.Controls.Add(this.lblVols);
            this.tabGeneral.Controls.Add(this.dataGridViewVols);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(925, 575);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Général";
            // 
            // lblPrixGeneralDetails
            // 
            this.lblPrixGeneralDetails.AutoSize = true;
            this.lblPrixGeneralDetails.Location = new System.Drawing.Point(287, 296);
            this.lblPrixGeneralDetails.Name = "lblPrixGeneralDetails";
            this.lblPrixGeneralDetails.Size = new System.Drawing.Size(160, 13);
            this.lblPrixGeneralDetails.TabIndex = 8;
            this.lblPrixGeneralDetails.Text = "(Afficher les tranches et leur prix)";
            // 
            // lblVolsGeneralDetails
            // 
            this.lblVolsGeneralDetails.AutoSize = true;
            this.lblVolsGeneralDetails.Location = new System.Drawing.Point(389, 23);
            this.lblVolsGeneralDetails.Name = "lblVolsGeneralDetails";
            this.lblVolsGeneralDetails.Size = new System.Drawing.Size(110, 13);
            this.lblVolsGeneralDetails.TabIndex = 7;
            this.lblVolsGeneralDetails.Text = "(Afficher tous les vols)";
            // 
            // cmbTranchePrix
            // 
            this.cmbTranchePrix.FormattingEnabled = true;
            this.cmbTranchePrix.Location = new System.Drawing.Point(119, 293);
            this.cmbTranchePrix.Name = "cmbTranchePrix";
            this.cmbTranchePrix.Size = new System.Drawing.Size(145, 21);
            this.cmbTranchePrix.TabIndex = 6;
            // 
            // txtVolsInput
            // 
            this.txtVolsInput.Location = new System.Drawing.Point(119, 20);
            this.txtVolsInput.Name = "txtVolsInput";
            this.txtVolsInput.Size = new System.Drawing.Size(145, 20);
            this.txtVolsInput.TabIndex = 5;
            // 
            // btnFiltreVols
            // 
            this.btnFiltreVols.Location = new System.Drawing.Point(290, 18);
            this.btnFiltreVols.Name = "btnFiltreVols";
            this.btnFiltreVols.Size = new System.Drawing.Size(75, 23);
            this.btnFiltreVols.TabIndex = 4;
            this.btnFiltreVols.Text = "Filtrer";
            this.btnFiltreVols.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrix
            // 
            this.dataGridViewPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrix.Location = new System.Drawing.Point(50, 328);
            this.dataGridViewPrix.Name = "dataGridViewPrix";
            this.dataGridViewPrix.Size = new System.Drawing.Size(817, 217);
            this.dataGridViewPrix.TabIndex = 3;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(49, 291);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(46, 24);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix";
            // 
            // lblVols
            // 
            this.lblVols.AutoSize = true;
            this.lblVols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVols.Location = new System.Drawing.Point(49, 18);
            this.lblVols.Name = "lblVols";
            this.lblVols.Size = new System.Drawing.Size(51, 24);
            this.lblVols.TabIndex = 1;
            this.lblVols.Text = "Vols";
            // 
            // dataGridViewVols
            // 
            this.dataGridViewVols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVols.Location = new System.Drawing.Point(50, 58);
            this.dataGridViewVols.Name = "dataGridViewVols";
            this.dataGridViewVols.Size = new System.Drawing.Size(817, 219);
            this.dataGridViewVols.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetails.Controls.Add(this.btnRefresh);
            this.tabDetails.Controls.Add(this.dataGridViewCA);
            this.tabDetails.Controls.Add(this.dataGridViewPassagers);
            this.tabDetails.Controls.Add(this.lblCADetails);
            this.tabDetails.Controls.Add(this.lblPassagersVol);
            this.tabDetails.Controls.Add(this.txtCAVol);
            this.tabDetails.Controls.Add(this.txtNbPlacesRestantes);
            this.tabDetails.Controls.Add(this.txtOccupationVol);
            this.tabDetails.Controls.Add(this.txtNbPassagers);
            this.tabDetails.Controls.Add(this.cmbDateVol);
            this.tabDetails.Controls.Add(this.cmbVolDetails);
            this.tabDetails.Controls.Add(this.lblCAVol);
            this.tabDetails.Controls.Add(this.lblPlacesRestantes);
            this.tabDetails.Controls.Add(this.lblOccupation);
            this.tabDetails.Controls.Add(this.lblNbPassagers);
            this.tabDetails.Controls.Add(this.lblDateVolDetails);
            this.tabDetails.Controls.Add(this.lblVolDetails);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(925, 575);
            this.tabDetails.TabIndex = 1;
            this.tabDetails.Text = "Détails";
            // 
            // dataGridViewCA
            // 
            this.dataGridViewCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCA.Location = new System.Drawing.Point(503, 276);
            this.dataGridViewCA.Name = "dataGridViewCA";
            this.dataGridViewCA.Size = new System.Drawing.Size(391, 265);
            this.dataGridViewCA.TabIndex = 15;
            // 
            // dataGridViewPassagers
            // 
            this.dataGridViewPassagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassagers.Location = new System.Drawing.Point(32, 276);
            this.dataGridViewPassagers.Name = "dataGridViewPassagers";
            this.dataGridViewPassagers.Size = new System.Drawing.Size(390, 265);
            this.dataGridViewPassagers.TabIndex = 14;
            // 
            // lblCADetails
            // 
            this.lblCADetails.AutoSize = true;
            this.lblCADetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCADetails.Location = new System.Drawing.Point(499, 223);
            this.lblCADetails.Name = "lblCADetails";
            this.lblCADetails.Size = new System.Drawing.Size(159, 24);
            this.lblCADetails.TabIndex = 13;
            this.lblCADetails.Text = "Chiffre d\'affaires";
            // 
            // lblPassagersVol
            // 
            this.lblPassagersVol.AutoSize = true;
            this.lblPassagersVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassagersVol.Location = new System.Drawing.Point(28, 223);
            this.lblPassagersVol.Name = "lblPassagersVol";
            this.lblPassagersVol.Size = new System.Drawing.Size(197, 24);
            this.lblPassagersVol.TabIndex = 12;
            this.lblPassagersVol.Text = "Passagers sur le vol";
            // 
            // txtCAVol
            // 
            this.txtCAVol.Enabled = false;
            this.txtCAVol.Location = new System.Drawing.Point(466, 144);
            this.txtCAVol.Name = "txtCAVol";
            this.txtCAVol.Size = new System.Drawing.Size(121, 20);
            this.txtCAVol.TabIndex = 11;
            // 
            // txtNbPlacesRestantes
            // 
            this.txtNbPlacesRestantes.Enabled = false;
            this.txtNbPlacesRestantes.Location = new System.Drawing.Point(178, 144);
            this.txtNbPlacesRestantes.Name = "txtNbPlacesRestantes";
            this.txtNbPlacesRestantes.Size = new System.Drawing.Size(121, 20);
            this.txtNbPlacesRestantes.TabIndex = 10;
            // 
            // txtOccupationVol
            // 
            this.txtOccupationVol.Enabled = false;
            this.txtOccupationVol.Location = new System.Drawing.Point(466, 80);
            this.txtOccupationVol.Name = "txtOccupationVol";
            this.txtOccupationVol.Size = new System.Drawing.Size(121, 20);
            this.txtOccupationVol.TabIndex = 9;
            // 
            // txtNbPassagers
            // 
            this.txtNbPassagers.Enabled = false;
            this.txtNbPassagers.Location = new System.Drawing.Point(178, 80);
            this.txtNbPassagers.Name = "txtNbPassagers";
            this.txtNbPassagers.Size = new System.Drawing.Size(121, 20);
            this.txtNbPassagers.TabIndex = 8;
            // 
            // cmbDateVol
            // 
            this.cmbDateVol.FormattingEnabled = true;
            this.cmbDateVol.Location = new System.Drawing.Point(466, 22);
            this.cmbDateVol.Name = "cmbDateVol";
            this.cmbDateVol.Size = new System.Drawing.Size(121, 21);
            this.cmbDateVol.TabIndex = 7;
            // 
            // cmbVolDetails
            // 
            this.cmbVolDetails.FormattingEnabled = true;
            this.cmbVolDetails.Location = new System.Drawing.Point(178, 22);
            this.cmbVolDetails.Name = "cmbVolDetails";
            this.cmbVolDetails.Size = new System.Drawing.Size(121, 21);
            this.cmbVolDetails.TabIndex = 6;
            // 
            // lblCAVol
            // 
            this.lblCAVol.AutoSize = true;
            this.lblCAVol.Location = new System.Drawing.Point(360, 147);
            this.lblCAVol.Name = "lblCAVol";
            this.lblCAVol.Size = new System.Drawing.Size(53, 13);
            this.lblCAVol.TabIndex = 5;
            this.lblCAVol.Text = "CA du vol";
            // 
            // lblPlacesRestantes
            // 
            this.lblPlacesRestantes.AutoSize = true;
            this.lblPlacesRestantes.Location = new System.Drawing.Point(28, 147);
            this.lblPlacesRestantes.Name = "lblPlacesRestantes";
            this.lblPlacesRestantes.Size = new System.Drawing.Size(85, 13);
            this.lblPlacesRestantes.TabIndex = 4;
            this.lblPlacesRestantes.Text = "Places restantes";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(360, 80);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 3;
            this.lblOccupation.Text = "Occupation";
            // 
            // lblNbPassagers
            // 
            this.lblNbPassagers.AutoSize = true;
            this.lblNbPassagers.Location = new System.Drawing.Point(28, 80);
            this.lblNbPassagers.Name = "lblNbPassagers";
            this.lblNbPassagers.Size = new System.Drawing.Size(110, 13);
            this.lblNbPassagers.TabIndex = 2;
            this.lblNbPassagers.Text = "Nombre de passagers";
            // 
            // lblDateVolDetails
            // 
            this.lblDateVolDetails.AutoSize = true;
            this.lblDateVolDetails.Location = new System.Drawing.Point(360, 25);
            this.lblDateVolDetails.Name = "lblDateVolDetails";
            this.lblDateVolDetails.Size = new System.Drawing.Size(30, 13);
            this.lblDateVolDetails.TabIndex = 1;
            this.lblDateVolDetails.Text = "Date";
            // 
            // lblVolDetails
            // 
            this.lblVolDetails.AutoSize = true;
            this.lblVolDetails.Location = new System.Drawing.Point(28, 25);
            this.lblVolDetails.Name = "lblVolDetails";
            this.lblVolDetails.Size = new System.Drawing.Size(22, 13);
            this.lblVolDetails.TabIndex = 0;
            this.lblVolDetails.Text = "Vol";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(681, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 57);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Rafraîchir";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 626);
            this.Controls.Add(this.tabsAdmin);
            this.Name = "AdminForm";
            this.Text = "Interface Administrateur";
            this.tabsAdmin.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVols)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassagers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsAdmin;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.Label lblPrixGeneralDetails;
        private System.Windows.Forms.Label lblVolsGeneralDetails;
        private System.Windows.Forms.ComboBox cmbTranchePrix;
        private System.Windows.Forms.TextBox txtVolsInput;
        private System.Windows.Forms.Button btnFiltreVols;
        private System.Windows.Forms.DataGridView dataGridViewPrix;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblVols;
        private System.Windows.Forms.DataGridView dataGridViewVols;
        private System.Windows.Forms.TextBox txtCAVol;
        private System.Windows.Forms.TextBox txtNbPlacesRestantes;
        private System.Windows.Forms.TextBox txtOccupationVol;
        private System.Windows.Forms.TextBox txtNbPassagers;
        private System.Windows.Forms.ComboBox cmbDateVol;
        private System.Windows.Forms.ComboBox cmbVolDetails;
        private System.Windows.Forms.Label lblCAVol;
        private System.Windows.Forms.Label lblPlacesRestantes;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblNbPassagers;
        private System.Windows.Forms.Label lblDateVolDetails;
        private System.Windows.Forms.Label lblVolDetails;
        private System.Windows.Forms.DataGridView dataGridViewCA;
        private System.Windows.Forms.DataGridView dataGridViewPassagers;
        private System.Windows.Forms.Label lblCADetails;
        private System.Windows.Forms.Label lblPassagersVol;
        private System.Windows.Forms.Button btnRefresh;
    }
}

