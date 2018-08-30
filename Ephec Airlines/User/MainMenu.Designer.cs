namespace User
{
    partial class MainMenu
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
            this.tabsUser = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblVols = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.dateTimePickerVoyageur5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVoyageur4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVoyageur3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVoyageur2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVoyageur1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenomVoyageur5 = new System.Windows.Forms.TextBox();
            this.txtPrenomVoyageur4 = new System.Windows.Forms.TextBox();
            this.txtPrenomVoyageur3 = new System.Windows.Forms.TextBox();
            this.txtPrenomVoyageur2 = new System.Windows.Forms.TextBox();
            this.txtPrenomVoyageur1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomVoyageur5 = new System.Windows.Forms.TextBox();
            this.txtNomVoyageur4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCADetails = new System.Windows.Forms.Label();
            this.txtNomVoyageur3 = new System.Windows.Forms.TextBox();
            this.txtNomVoyageur2 = new System.Windows.Forms.TextBox();
            this.txtNomVoyageur1 = new System.Windows.Forms.TextBox();
            this.lblCAVol = new System.Windows.Forms.Label();
            this.lblPlacesRestantes = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblNbPassagers = new System.Windows.Forms.Label();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.cmbDateVolRetour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAllerRetour = new System.Windows.Forms.RadioButton();
            this.radioAller = new System.Windows.Forms.RadioButton();
            this.lblPassagersVol = new System.Windows.Forms.Label();
            this.cmbDateVolAller = new System.Windows.Forms.ComboBox();
            this.cmbVolAller = new System.Windows.Forms.ComboBox();
            this.lblDateVolDetails = new System.Windows.Forms.Label();
            this.lblVolDetails = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblVolModif = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouterVoy = new System.Windows.Forms.Button();
            this.txtDateVoyMod = new System.Windows.Forms.TextBox();
            this.txtPrenomVoyMod = new System.Windows.Forms.TextBox();
            this.txtNomVoyMod = new System.Windows.Forms.TextBox();
            this.btnMettreAJourVoy = new System.Windows.Forms.Button();
            this.btnSupprimerVoy = new System.Windows.Forms.Button();
            this.cmbVoyageurAModifier = new System.Windows.Forms.ComboBox();
            this.txtPrixTotalReservation = new System.Windows.Forms.TextBox();
            this.txtPrixVol = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSupprimerReservation = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDateVol = new System.Windows.Forms.TextBox();
            this.dataGridViewVoyageursMod = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbListeVolsReserves = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVolRetour = new System.Windows.Forms.TextBox();
            this.tabsUser.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoyageursMod)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsUser
            // 
            this.tabsUser.Controls.Add(this.tabGeneral);
            this.tabsUser.Controls.Add(this.tabDetails);
            this.tabsUser.Controls.Add(this.tabPage1);
            this.tabsUser.Location = new System.Drawing.Point(12, 12);
            this.tabsUser.Multiline = true;
            this.tabsUser.Name = "tabsUser";
            this.tabsUser.SelectedIndex = 0;
            this.tabsUser.Size = new System.Drawing.Size(868, 601);
            this.tabsUser.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneral.Controls.Add(this.btnRefresh);
            this.tabGeneral.Controls.Add(this.lblVols);
            this.tabGeneral.Controls.Add(this.dataGridViewReservations);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(860, 575);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Réservations";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(356, 500);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 57);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Rafraîchir";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblVols
            // 
            this.lblVols.AutoSize = true;
            this.lblVols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVols.Location = new System.Drawing.Point(26, 20);
            this.lblVols.Name = "lblVols";
            this.lblVols.Size = new System.Drawing.Size(130, 24);
            this.lblVols.TabIndex = 1;
            this.lblVols.Text = "Réservations";
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(30, 58);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.Size = new System.Drawing.Size(794, 419);
            this.dataGridViewReservations.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetails.Controls.Add(this.txtVolRetour);
            this.tabDetails.Controls.Add(this.dateTimePickerVoyageur5);
            this.tabDetails.Controls.Add(this.dateTimePickerVoyageur4);
            this.tabDetails.Controls.Add(this.dateTimePickerVoyageur3);
            this.tabDetails.Controls.Add(this.dateTimePickerVoyageur2);
            this.tabDetails.Controls.Add(this.dateTimePickerVoyageur1);
            this.tabDetails.Controls.Add(this.label7);
            this.tabDetails.Controls.Add(this.label6);
            this.tabDetails.Controls.Add(this.txtPrenomVoyageur5);
            this.tabDetails.Controls.Add(this.txtPrenomVoyageur4);
            this.tabDetails.Controls.Add(this.txtPrenomVoyageur3);
            this.tabDetails.Controls.Add(this.txtPrenomVoyageur2);
            this.tabDetails.Controls.Add(this.txtPrenomVoyageur1);
            this.tabDetails.Controls.Add(this.label5);
            this.tabDetails.Controls.Add(this.txtNomVoyageur5);
            this.tabDetails.Controls.Add(this.txtNomVoyageur4);
            this.tabDetails.Controls.Add(this.label4);
            this.tabDetails.Controls.Add(this.btnSubmit);
            this.tabDetails.Controls.Add(this.lblCADetails);
            this.tabDetails.Controls.Add(this.txtNomVoyageur3);
            this.tabDetails.Controls.Add(this.txtNomVoyageur2);
            this.tabDetails.Controls.Add(this.txtNomVoyageur1);
            this.tabDetails.Controls.Add(this.lblCAVol);
            this.tabDetails.Controls.Add(this.lblPlacesRestantes);
            this.tabDetails.Controls.Add(this.lblOccupation);
            this.tabDetails.Controls.Add(this.lblNbPassagers);
            this.tabDetails.Controls.Add(this.btnReinitialiser);
            this.tabDetails.Controls.Add(this.cmbDateVolRetour);
            this.tabDetails.Controls.Add(this.label1);
            this.tabDetails.Controls.Add(this.label2);
            this.tabDetails.Controls.Add(this.radioAllerRetour);
            this.tabDetails.Controls.Add(this.radioAller);
            this.tabDetails.Controls.Add(this.lblPassagersVol);
            this.tabDetails.Controls.Add(this.cmbDateVolAller);
            this.tabDetails.Controls.Add(this.cmbVolAller);
            this.tabDetails.Controls.Add(this.lblDateVolDetails);
            this.tabDetails.Controls.Add(this.lblVolDetails);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(860, 575);
            this.tabDetails.TabIndex = 1;
            this.tabDetails.Text = "Ajouter Vol";
            // 
            // dateTimePickerVoyageur5
            // 
            this.dateTimePickerVoyageur5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVoyageur5.Location = new System.Drawing.Point(547, 426);
            this.dateTimePickerVoyageur5.Name = "dateTimePickerVoyageur5";
            this.dateTimePickerVoyageur5.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerVoyageur5.TabIndex = 66;
            // 
            // dateTimePickerVoyageur4
            // 
            this.dateTimePickerVoyageur4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVoyageur4.Location = new System.Drawing.Point(547, 387);
            this.dateTimePickerVoyageur4.Name = "dateTimePickerVoyageur4";
            this.dateTimePickerVoyageur4.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerVoyageur4.TabIndex = 65;
            // 
            // dateTimePickerVoyageur3
            // 
            this.dateTimePickerVoyageur3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVoyageur3.Location = new System.Drawing.Point(547, 349);
            this.dateTimePickerVoyageur3.Name = "dateTimePickerVoyageur3";
            this.dateTimePickerVoyageur3.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerVoyageur3.TabIndex = 64;
            // 
            // dateTimePickerVoyageur2
            // 
            this.dateTimePickerVoyageur2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVoyageur2.Location = new System.Drawing.Point(547, 310);
            this.dateTimePickerVoyageur2.Name = "dateTimePickerVoyageur2";
            this.dateTimePickerVoyageur2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerVoyageur2.TabIndex = 63;
            // 
            // dateTimePickerVoyageur1
            // 
            this.dateTimePickerVoyageur1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVoyageur1.Location = new System.Drawing.Point(547, 270);
            this.dateTimePickerVoyageur1.Name = "dateTimePickerVoyageur1";
            this.dateTimePickerVoyageur1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerVoyageur1.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Date de naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Prénom";
            // 
            // txtPrenomVoyageur5
            // 
            this.txtPrenomVoyageur5.Location = new System.Drawing.Point(357, 426);
            this.txtPrenomVoyageur5.Name = "txtPrenomVoyageur5";
            this.txtPrenomVoyageur5.Size = new System.Drawing.Size(121, 20);
            this.txtPrenomVoyageur5.TabIndex = 59;
            // 
            // txtPrenomVoyageur4
            // 
            this.txtPrenomVoyageur4.Location = new System.Drawing.Point(357, 387);
            this.txtPrenomVoyageur4.Name = "txtPrenomVoyageur4";
            this.txtPrenomVoyageur4.Size = new System.Drawing.Size(121, 20);
            this.txtPrenomVoyageur4.TabIndex = 58;
            // 
            // txtPrenomVoyageur3
            // 
            this.txtPrenomVoyageur3.Location = new System.Drawing.Point(357, 349);
            this.txtPrenomVoyageur3.Name = "txtPrenomVoyageur3";
            this.txtPrenomVoyageur3.Size = new System.Drawing.Size(121, 20);
            this.txtPrenomVoyageur3.TabIndex = 57;
            // 
            // txtPrenomVoyageur2
            // 
            this.txtPrenomVoyageur2.Location = new System.Drawing.Point(357, 310);
            this.txtPrenomVoyageur2.Name = "txtPrenomVoyageur2";
            this.txtPrenomVoyageur2.Size = new System.Drawing.Size(121, 20);
            this.txtPrenomVoyageur2.TabIndex = 56;
            // 
            // txtPrenomVoyageur1
            // 
            this.txtPrenomVoyageur1.Location = new System.Drawing.Point(357, 270);
            this.txtPrenomVoyageur1.Name = "txtPrenomVoyageur1";
            this.txtPrenomVoyageur1.Size = new System.Drawing.Size(121, 20);
            this.txtPrenomVoyageur1.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nom";
            // 
            // txtNomVoyageur5
            // 
            this.txtNomVoyageur5.Location = new System.Drawing.Point(174, 426);
            this.txtNomVoyageur5.Name = "txtNomVoyageur5";
            this.txtNomVoyageur5.Size = new System.Drawing.Size(121, 20);
            this.txtNomVoyageur5.TabIndex = 53;
            // 
            // txtNomVoyageur4
            // 
            this.txtNomVoyageur4.Location = new System.Drawing.Point(174, 387);
            this.txtNomVoyageur4.Name = "txtNomVoyageur4";
            this.txtNomVoyageur4.Size = new System.Drawing.Size(121, 20);
            this.txtNomVoyageur4.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Voyageur 5";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(225, 470);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 57);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.Text = "Soumettre";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblCADetails
            // 
            this.lblCADetails.AutoSize = true;
            this.lblCADetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCADetails.Location = new System.Drawing.Point(20, 211);
            this.lblCADetails.Name = "lblCADetails";
            this.lblCADetails.Size = new System.Drawing.Size(110, 24);
            this.lblCADetails.TabIndex = 49;
            this.lblCADetails.Text = "Voyageurs";
            // 
            // txtNomVoyageur3
            // 
            this.txtNomVoyageur3.Location = new System.Drawing.Point(174, 349);
            this.txtNomVoyageur3.Name = "txtNomVoyageur3";
            this.txtNomVoyageur3.Size = new System.Drawing.Size(121, 20);
            this.txtNomVoyageur3.TabIndex = 48;
            // 
            // txtNomVoyageur2
            // 
            this.txtNomVoyageur2.Location = new System.Drawing.Point(174, 310);
            this.txtNomVoyageur2.Name = "txtNomVoyageur2";
            this.txtNomVoyageur2.Size = new System.Drawing.Size(121, 20);
            this.txtNomVoyageur2.TabIndex = 47;
            // 
            // txtNomVoyageur1
            // 
            this.txtNomVoyageur1.Location = new System.Drawing.Point(174, 270);
            this.txtNomVoyageur1.Name = "txtNomVoyageur1";
            this.txtNomVoyageur1.Size = new System.Drawing.Size(121, 20);
            this.txtNomVoyageur1.TabIndex = 46;
            // 
            // lblCAVol
            // 
            this.lblCAVol.AutoSize = true;
            this.lblCAVol.Location = new System.Drawing.Point(25, 390);
            this.lblCAVol.Name = "lblCAVol";
            this.lblCAVol.Size = new System.Drawing.Size(61, 13);
            this.lblCAVol.TabIndex = 45;
            this.lblCAVol.Text = "Voyageur 4";
            // 
            // lblPlacesRestantes
            // 
            this.lblPlacesRestantes.AutoSize = true;
            this.lblPlacesRestantes.Location = new System.Drawing.Point(24, 313);
            this.lblPlacesRestantes.Name = "lblPlacesRestantes";
            this.lblPlacesRestantes.Size = new System.Drawing.Size(61, 13);
            this.lblPlacesRestantes.TabIndex = 44;
            this.lblPlacesRestantes.Text = "Voyageur 2";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(24, 352);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(61, 13);
            this.lblOccupation.TabIndex = 43;
            this.lblOccupation.Text = "Voyageur 3";
            // 
            // lblNbPassagers
            // 
            this.lblNbPassagers.AutoSize = true;
            this.lblNbPassagers.Location = new System.Drawing.Point(24, 273);
            this.lblNbPassagers.Name = "lblNbPassagers";
            this.lblNbPassagers.Size = new System.Drawing.Size(61, 13);
            this.lblNbPassagers.TabIndex = 42;
            this.lblNbPassagers.Text = "Voyageur 1";
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Enabled = false;
            this.btnReinitialiser.Location = new System.Drawing.Point(440, 470);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(151, 57);
            this.btnReinitialiser.TabIndex = 25;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            // 
            // cmbDateVolRetour
            // 
            this.cmbDateVolRetour.Enabled = false;
            this.cmbDateVolRetour.FormattingEnabled = true;
            this.cmbDateVolRetour.Location = new System.Drawing.Point(440, 135);
            this.cmbDateVolRetour.Name = "cmbDateVolRetour";
            this.cmbDateVolRetour.Size = new System.Drawing.Size(121, 21);
            this.cmbDateVolRetour.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vol Retour";
            // 
            // radioAllerRetour
            // 
            this.radioAllerRetour.AutoSize = true;
            this.radioAllerRetour.Location = new System.Drawing.Point(119, 103);
            this.radioAllerRetour.Name = "radioAllerRetour";
            this.radioAllerRetour.Size = new System.Drawing.Size(80, 17);
            this.radioAllerRetour.TabIndex = 18;
            this.radioAllerRetour.Text = "Aller Retour";
            this.radioAllerRetour.UseVisualStyleBackColor = true;
            this.radioAllerRetour.CheckedChanged += new System.EventHandler(this.radioAllerRetour_CheckedChanged);
            // 
            // radioAller
            // 
            this.radioAller.AutoSize = true;
            this.radioAller.Checked = true;
            this.radioAller.Location = new System.Drawing.Point(28, 103);
            this.radioAller.Name = "radioAller";
            this.radioAller.Size = new System.Drawing.Size(79, 17);
            this.radioAller.TabIndex = 17;
            this.radioAller.TabStop = true;
            this.radioAller.Text = "Aller Simple";
            this.radioAller.UseVisualStyleBackColor = true;
            // 
            // lblPassagersVol
            // 
            this.lblPassagersVol.AutoSize = true;
            this.lblPassagersVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassagersVol.Location = new System.Drawing.Point(22, 25);
            this.lblPassagersVol.Name = "lblPassagersVol";
            this.lblPassagersVol.Size = new System.Drawing.Size(113, 24);
            this.lblPassagersVol.TabIndex = 12;
            this.lblPassagersVol.Text = "Destination";
            // 
            // cmbDateVolAller
            // 
            this.cmbDateVolAller.FormattingEnabled = true;
            this.cmbDateVolAller.Location = new System.Drawing.Point(440, 65);
            this.cmbDateVolAller.Name = "cmbDateVolAller";
            this.cmbDateVolAller.Size = new System.Drawing.Size(121, 21);
            this.cmbDateVolAller.TabIndex = 7;
            // 
            // cmbVolAller
            // 
            this.cmbVolAller.FormattingEnabled = true;
            this.cmbVolAller.Location = new System.Drawing.Point(107, 65);
            this.cmbVolAller.Name = "cmbVolAller";
            this.cmbVolAller.Size = new System.Drawing.Size(260, 21);
            this.cmbVolAller.TabIndex = 6;
            this.cmbVolAller.SelectedIndexChanged += new System.EventHandler(this.cmbVolAller_SelectedIndexChanged);
            // 
            // lblDateVolDetails
            // 
            this.lblDateVolDetails.AutoSize = true;
            this.lblDateVolDetails.Location = new System.Drawing.Point(391, 68);
            this.lblDateVolDetails.Name = "lblDateVolDetails";
            this.lblDateVolDetails.Size = new System.Drawing.Size(30, 13);
            this.lblDateVolDetails.TabIndex = 1;
            this.lblDateVolDetails.Text = "Date";
            // 
            // lblVolDetails
            // 
            this.lblVolDetails.AutoSize = true;
            this.lblVolDetails.Location = new System.Drawing.Point(25, 68);
            this.lblVolDetails.Name = "lblVolDetails";
            this.lblVolDetails.Size = new System.Drawing.Size(22, 13);
            this.lblVolDetails.TabIndex = 0;
            this.lblVolDetails.Text = "Vol";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblVolModif);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAjouterVoy);
            this.tabPage1.Controls.Add(this.txtDateVoyMod);
            this.tabPage1.Controls.Add(this.txtPrenomVoyMod);
            this.tabPage1.Controls.Add(this.txtNomVoyMod);
            this.tabPage1.Controls.Add(this.btnMettreAJourVoy);
            this.tabPage1.Controls.Add(this.btnSupprimerVoy);
            this.tabPage1.Controls.Add(this.cmbVoyageurAModifier);
            this.tabPage1.Controls.Add(this.txtPrixTotalReservation);
            this.tabPage1.Controls.Add(this.txtPrixVol);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnSupprimerReservation);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtDateVol);
            this.tabPage1.Controls.Add(this.dataGridViewVoyageursMod);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cmbListeVolsReserves);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 575);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modifier Vol";
            // 
            // lblVolModif
            // 
            this.lblVolModif.AutoSize = true;
            this.lblVolModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolModif.Location = new System.Drawing.Point(26, 20);
            this.lblVolModif.Name = "lblVolModif";
            this.lblVolModif.Size = new System.Drawing.Size(132, 24);
            this.lblVolModif.TabIndex = 54;
            this.lblVolModif.Text = "Modifier Vols";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Nom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Prénom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Voyageur à modifier";
            // 
            // btnAjouterVoy
            // 
            this.btnAjouterVoy.Location = new System.Drawing.Point(158, 503);
            this.btnAjouterVoy.Name = "btnAjouterVoy";
            this.btnAjouterVoy.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterVoy.TabIndex = 49;
            this.btnAjouterVoy.Text = "Ajouter";
            this.btnAjouterVoy.UseVisualStyleBackColor = true;
            // 
            // txtDateVoyMod
            // 
            this.txtDateVoyMod.Location = new System.Drawing.Point(383, 453);
            this.txtDateVoyMod.Name = "txtDateVoyMod";
            this.txtDateVoyMod.Size = new System.Drawing.Size(100, 20);
            this.txtDateVoyMod.TabIndex = 45;
            // 
            // txtPrenomVoyMod
            // 
            this.txtPrenomVoyMod.Location = new System.Drawing.Point(239, 454);
            this.txtPrenomVoyMod.Name = "txtPrenomVoyMod";
            this.txtPrenomVoyMod.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomVoyMod.TabIndex = 44;
            // 
            // txtNomVoyMod
            // 
            this.txtNomVoyMod.Location = new System.Drawing.Point(81, 453);
            this.txtNomVoyMod.Name = "txtNomVoyMod";
            this.txtNomVoyMod.Size = new System.Drawing.Size(100, 20);
            this.txtNomVoyMod.TabIndex = 43;
            // 
            // btnMettreAJourVoy
            // 
            this.btnMettreAJourVoy.Location = new System.Drawing.Point(239, 503);
            this.btnMettreAJourVoy.Name = "btnMettreAJourVoy";
            this.btnMettreAJourVoy.Size = new System.Drawing.Size(92, 23);
            this.btnMettreAJourVoy.TabIndex = 42;
            this.btnMettreAJourVoy.Text = "Mettre à jour";
            this.btnMettreAJourVoy.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerVoy
            // 
            this.btnSupprimerVoy.Location = new System.Drawing.Point(337, 503);
            this.btnSupprimerVoy.Name = "btnSupprimerVoy";
            this.btnSupprimerVoy.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerVoy.TabIndex = 40;
            this.btnSupprimerVoy.Text = "Supprimer";
            this.btnSupprimerVoy.UseVisualStyleBackColor = true;
            // 
            // cmbVoyageurAModifier
            // 
            this.cmbVoyageurAModifier.FormattingEnabled = true;
            this.cmbVoyageurAModifier.Location = new System.Drawing.Point(151, 411);
            this.cmbVoyageurAModifier.MaxDropDownItems = 5;
            this.cmbVoyageurAModifier.Name = "cmbVoyageurAModifier";
            this.cmbVoyageurAModifier.Size = new System.Drawing.Size(121, 21);
            this.cmbVoyageurAModifier.TabIndex = 39;
            // 
            // txtPrixTotalReservation
            // 
            this.txtPrixTotalReservation.Location = new System.Drawing.Point(152, 149);
            this.txtPrixTotalReservation.Name = "txtPrixTotalReservation";
            this.txtPrixTotalReservation.ReadOnly = true;
            this.txtPrixTotalReservation.Size = new System.Drawing.Size(100, 20);
            this.txtPrixTotalReservation.TabIndex = 38;
            // 
            // txtPrixVol
            // 
            this.txtPrixVol.Location = new System.Drawing.Point(152, 123);
            this.txtPrixVol.Name = "txtPrixVol";
            this.txtPrixVol.ReadOnly = true;
            this.txtPrixVol.Size = new System.Drawing.Size(100, 20);
            this.txtPrixVol.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Prix Total Réservation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Prix Client";
            // 
            // btnSupprimerReservation
            // 
            this.btnSupprimerReservation.Location = new System.Drawing.Point(304, 100);
            this.btnSupprimerReservation.Name = "btnSupprimerReservation";
            this.btnSupprimerReservation.Size = new System.Drawing.Size(179, 43);
            this.btnSupprimerReservation.TabIndex = 34;
            this.btnSupprimerReservation.Text = "Effacer Réservation";
            this.btnSupprimerReservation.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Date de la réservation";
            // 
            // txtDateVol
            // 
            this.txtDateVol.Location = new System.Drawing.Point(152, 97);
            this.txtDateVol.Name = "txtDateVol";
            this.txtDateVol.ReadOnly = true;
            this.txtDateVol.Size = new System.Drawing.Size(100, 20);
            this.txtDateVol.TabIndex = 32;
            // 
            // dataGridViewVoyageursMod
            // 
            this.dataGridViewVoyageursMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoyageursMod.Location = new System.Drawing.Point(21, 242);
            this.dataGridViewVoyageursMod.Name = "dataGridViewVoyageursMod";
            this.dataGridViewVoyageursMod.Size = new System.Drawing.Size(574, 150);
            this.dataGridViewVoyageursMod.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Modifier Voyageurs";
            // 
            // cmbListeVolsReserves
            // 
            this.cmbListeVolsReserves.FormattingEnabled = true;
            this.cmbListeVolsReserves.Location = new System.Drawing.Point(131, 65);
            this.cmbListeVolsReserves.Name = "cmbListeVolsReserves";
            this.cmbListeVolsReserves.Size = new System.Drawing.Size(121, 21);
            this.cmbListeVolsReserves.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Vols réservés";
            // 
            // txtVolRetour
            // 
            this.txtVolRetour.Enabled = false;
            this.txtVolRetour.Location = new System.Drawing.Point(107, 136);
            this.txtVolRetour.Name = "txtVolRetour";
            this.txtVolRetour.Size = new System.Drawing.Size(260, 20);
            this.txtVolRetour.TabIndex = 67;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 623);
            this.Controls.Add(this.tabsUser);
            this.Name = "MainMenu";
            this.Text = "Interface Utilisateur";
            this.tabsUser.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabDetails.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoyageursMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsUser;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblVols;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.ComboBox cmbDateVolRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAllerRetour;
        private System.Windows.Forms.RadioButton radioAller;
        private System.Windows.Forms.Label lblPassagersVol;
        private System.Windows.Forms.ComboBox cmbDateVolAller;
        private System.Windows.Forms.ComboBox cmbVolAller;
        private System.Windows.Forms.Label lblDateVolDetails;
        private System.Windows.Forms.Label lblVolDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblVolModif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouterVoy;
        private System.Windows.Forms.TextBox txtDateVoyMod;
        private System.Windows.Forms.TextBox txtPrenomVoyMod;
        private System.Windows.Forms.TextBox txtNomVoyMod;
        private System.Windows.Forms.Button btnMettreAJourVoy;
        private System.Windows.Forms.Button btnSupprimerVoy;
        private System.Windows.Forms.ComboBox cmbVoyageurAModifier;
        private System.Windows.Forms.TextBox txtPrixTotalReservation;
        private System.Windows.Forms.TextBox txtPrixVol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSupprimerReservation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDateVol;
        private System.Windows.Forms.DataGridView dataGridViewVoyageursMod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbListeVolsReserves;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoyageur5;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoyageur4;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoyageur3;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoyageur2;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoyageur1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenomVoyageur5;
        private System.Windows.Forms.TextBox txtPrenomVoyageur4;
        private System.Windows.Forms.TextBox txtPrenomVoyageur3;
        private System.Windows.Forms.TextBox txtPrenomVoyageur2;
        private System.Windows.Forms.TextBox txtPrenomVoyageur1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomVoyageur5;
        private System.Windows.Forms.TextBox txtNomVoyageur4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCADetails;
        private System.Windows.Forms.TextBox txtNomVoyageur3;
        private System.Windows.Forms.TextBox txtNomVoyageur2;
        private System.Windows.Forms.TextBox txtNomVoyageur1;
        private System.Windows.Forms.Label lblCAVol;
        private System.Windows.Forms.Label lblPlacesRestantes;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblNbPassagers;
        private System.Windows.Forms.TextBox txtVolRetour;
    }
}