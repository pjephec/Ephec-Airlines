using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityClient;
using BusinessErrors;
using BusinessLayer;
using System.Transactions;

namespace User {
    public partial class MainMenu : Form {
        private CLI_FetchTousClients_Result _Client;
        public MainMenu() {
            InitializeComponent();
        }

        // TAB RESERVATIONS

        // Récupération du client sélectionné
        public MainMenu(CLI_FetchTousClients_Result clt) {
            _Client = clt;
            InitializeComponent();
            InitializeTabOverview();
            InitializeTabDetails();
        }

        private void InitializeTabOverview() {
            List<RES_GetResByClientId_Result> oList = new List<RES_GetResByClientId_Result>();
            try {
                oList = BLReservations.GetResClient(_Client.CLIENT_ID);
                dataGridViewReservations.DataSource = oList;
                dataGridViewReservations.ReadOnly = true;
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                throw new CustomError(666);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            InitializeComponent();
        }

        // TAB AJOUTER VOL
        private void InitializeTabDetails() {
            try {
                cmbVolAller.DataSource = BLVols.GetVolsSelectionAll(); // on charge la liste des vols
                cmbVolAller.ValueMember = "VOL_ID";
                cmbVolAller.DisplayMember = "LIB_VOL";
                radioAller.Checked = true;
            }
            catch (CustomError cEx) {
            }
            catch (Exception ex) {
                CustomError cEx = new CustomError(666);
            }
        }

        private void radioAllerRetour_CheckedChanged(object sender, EventArgs e) {
            if (radioAllerRetour.Checked) {
                cmbDateVolRetour.Enabled = true;
                populateVolRetour();
            }
            else {
                txtVolRetour.Clear();
                cmbDateVolRetour.Text = "";
                cmbDateVolRetour.Enabled = false;
            }
        }

        private void cmbVolAller_SelectedIndexChanged(object sender, EventArgs e) {
            VOL_SelectAllListChoix_Result oVol = (VOL_SelectAllListChoix_Result)cmbVolAller.SelectedItem;
            List<PLA_GetDateByVolId_Result> oList = new List<PLA_GetDateByVolId_Result>();
            try {
                cmbDateVolAller.DataSource = BLPlannings.GetDatesVol(oVol.VOL_ID); // on récupère les dates pour le vol choisi
                cmbDateVolAller.ValueMember = "PLAN_ID";
                cmbDateVolAller.DisplayMember = "PLAN_VOL_DATE";
                if (radioAllerRetour.Checked) //si le vol retour est choisi
                {
                    VOL_SelectAllListChoixRetour_Result oVolRetour = BLVols.GetVolRetour(oVol.VOL_ID_VILLE_ARR, oVol.VOL_ID_VILLE_DEP); //récup vol retour
                    txtVolRetour.Text = oVolRetour.LIB_VOL.ToString();
                }
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        private void populateVolRetour() {
            VOL_SelectAllListChoix_Result oVol = (VOL_SelectAllListChoix_Result)cmbVolAller.SelectedItem;
            try {
                VOL_SelectAllListChoixRetour_Result oVolRetour = BLVols.GetVolRetour(oVol.VOL_ID_VILLE_ARR, oVol.VOL_ID_VILLE_DEP); //récup vol retour
                txtVolRetour.Text = oVolRetour.LIB_VOL.ToString();
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {

                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        private void txtVolRetour_TextChanged(object sender, EventArgs e) {
            VOL_SelectAllListChoix_Result oVol = (VOL_SelectAllListChoix_Result)cmbVolAller.SelectedItem;
            cmbDateVolRetour.Enabled = true;
            PLA_GetDateByVolId_Result oDateSimple = (PLA_GetDateByVolId_Result)cmbDateVolAller.SelectedItem;
            try {
                VOL_SelectAllListChoixRetour_Result oVolRetour = BLVols.GetVolRetour(oVol.VOL_ID_VILLE_ARR, oVol.VOL_ID_VILLE_DEP);
                List<PLA_GetDateByVolIdDateCritere_Result> oList = BLPlannings.GetDatesVol(oVolRetour.VOL_ID, oDateSimple.PLAN_VOL_DATE);
                cmbDateVolRetour.DataSource = oList;
                cmbDateVolRetour.ValueMember = "PLAN_ID";
                cmbDateVolRetour.DisplayMember = "PLAN_VOL_DATE";
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {

                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            RES_GetAller_Result oAller = new RES_GetAller_Result();
            BLPlannings oBlPlanning = new BLPlannings();
            BLVols oBlVol = new BLVols();
            BLAllerRetours oBlAllerRetour = new BLAllerRetours();
            BLReservations oBlRes = new BLReservations();
            BLAccompagnateurs oBlAccompagnateur = new BLAccompagnateurs();
            VOL_SelectAllListChoix_Result oVolSimple = (VOL_SelectAllListChoix_Result)cmbVolAller.SelectedItem; //vol simple
            PLA_GetDateByVolId_Result oDateSimple = (PLA_GetDateByVolId_Result)cmbDateVolAller.SelectedItem; //Date vol simple
            PLA_GetDateByVolIdDateCritere_Result oDateRetour = (PLA_GetDateByVolIdDateCritere_Result)cmbDateVolRetour.SelectedItem; //Date vol retour
            VOL_SelectAllListChoixRetour_Result oVolRetour = BLVols.GetVolRetour(oVolSimple.VOL_ID_VILLE_ARR, oVolSimple.VOL_ID_VILLE_DEP); //vol retour
            int cpt = 1; // on compte le client
            int nbPlacesRestantes = 1000; //pour le test

            if (txtNomVoyageur1.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                cpt++;
            if (txtNomVoyageur2.TextLength != 0)
                cpt++;
            if (txtNomVoyageur3.TextLength != 0)
                cpt++;
            if (txtNomVoyageur4.TextLength != 0)
                cpt++;
            if (txtNomVoyageur5.TextLength != 0)
                cpt++;
            try {
                using (TransactionScope scope = new TransactionScope()) {
                    oBlPlanning.GetNbPlacesRestantesNEW(oVolSimple.VOL_ID, oDateSimple.PLAN_ID, out nbPlacesRestantes);
                    if (cpt > nbPlacesRestantes) {
                        string datesDispos = null;
                        int nbPlacesRestantesDateDispo;

                        List<PLA_GetDatesMemeVolWithPlaId_Result> oList = new List<PLA_GetDatesMemeVolWithPlaId_Result>();
                        oList = oBlPlanning.GetDatesMemeVol(oVolSimple.VOL_ID, oDateSimple.PLAN_ID);
                        foreach (PLA_GetDatesMemeVolWithPlaId_Result oRes in oList) {
                            oBlPlanning.GetNbPlacesRestantesNEW(oVolSimple.VOL_ID, oRes.PLAN_ID, out nbPlacesRestantesDateDispo);
                            if (cpt < nbPlacesRestantesDateDispo) // récupération des bonnes dates;
                            {
                                datesDispos += oRes.PLAN_VOL_DATE.ToShortDateString() + "; ";
                            }
                        }
                        //throw new CustomError(5) ;
                        throw new CustomError("Place insuffisante sur ce vol.\nAlternatives: " + datesDispos);
                    }
                    if (radioAllerRetour.Checked) {
                        if (cpt > nbPlacesRestantes) {
                            throw new CustomError(6);
                        }
                    }
                    //reservation commence ici
                    int resIns = oBlRes.InsertRes(_Client.CLIENT_ID, oDateSimple.PLAN_ID);
                    if (radioAller.Checked) {
                        oAller = oBlRes.GetResAller(oDateSimple.PLAN_VOL_DATE, _Client.CLIENT_ID, oVolSimple.VOL_ID_VILLE_DEP, oVolSimple.VOL_ID_VILLE_ARR);
                        if (oAller != null) {
                            oBlAllerRetour.ARInsert(oAller.RES_ID.Value, oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                        }
                    }
                    int resVoy = -1;
                    if (resIns != -1) //vérifer condition...
                    {
                        if (txtNomVoyageur1.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                        {
                            if (txtNomVoyageur1.TextLength != 0) {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur1.Text.ToUpper(), txtNomVoyageur1.Text, DateTime.Parse(dateTimePickerVoyageur1.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                            else {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur1.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur1.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                        }
                        if (txtNomVoyageur2.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                        {
                            if (txtNomVoyageur2.TextLength != 0) {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur2.Text.ToUpper(), txtNomVoyageur2.Text, DateTime.Parse(dateTimePickerVoyageur2.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                            else {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur2.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur2.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                        }
                        if (txtNomVoyageur3.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                        {
                            if (txtNomVoyageur3.TextLength != 0) {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur3.Text.ToUpper(), txtNomVoyageur3.Text, DateTime.Parse(dateTimePickerVoyageur3.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                            else {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur3.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur3.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                        }
                        if (txtNomVoyageur4.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                        {
                            if (txtNomVoyageur4.TextLength != 0) {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur1.Text.ToUpper(), txtNomVoyageur4.Text, DateTime.Parse(dateTimePickerVoyageur4.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                            else {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur4.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur4.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                        }
                        if (txtNomVoyageur5.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                        {
                            if (txtNomVoyageur5.TextLength != 0) {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur5.Text.ToUpper(), txtNomVoyageur5.Text, DateTime.Parse(dateTimePickerVoyageur5.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                            else {
                                resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur5.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur5.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                            }
                        }
                        decimal? res = oBlRes.GetResPrixTotal(oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID));
                        if (res == null) {
                            throw new CustomError(1);
                        }
                        if (radioAller.Checked && oAller != null) {
                            MessageBox.Show("Reservation pour Vol aller déjà encodée rajoutée");
                        }
                        else if (radioAller.Checked && oAller == null) {
                            MessageBox.Show("Reservation pour Vol aller ajoutée");
                        }
                    }

                    if (radioAllerRetour.Checked) {
                        resIns = oBlRes.InsertRes(_Client.CLIENT_ID, oDateRetour.PLAN_ID);
                        oBlAllerRetour.ARInsert(oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                        // resIns = oBlRes.InsertResRetour(_Client.CLIENT_ID, oDateRetour.PLAN_ID); si booléen
                        //oBlRes.SetRetour(oBlRes.GetResId(_Client.CLIENT_ID, oDateSimple.PLAN_ID)); // technique du booléen
                        if (resIns != -1) {
                            if (txtNomVoyageur1.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                            {
                                if (txtNomVoyageur1.TextLength != 0) {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur1.Text.ToUpper(), txtNomVoyageur1.Text, DateTime.Parse(dateTimePickerVoyageur1.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                                else {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur1.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur1.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                            }

                            if (txtNomVoyageur2.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                            {
                                if (txtNomVoyageur2.TextLength != 0) {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur2.Text.ToUpper(), txtNomVoyageur2.Text, DateTime.Parse(dateTimePickerVoyageur2.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                                else {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur2.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur2.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                            }
                            if (txtNomVoyageur3.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                            {
                                if (txtNomVoyageur3.TextLength != 0) {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur3.Text.ToUpper(), txtNomVoyageur3.Text, DateTime.Parse(dateTimePickerVoyageur3.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                                else {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur3.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur3.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                            }
                            if (txtNomVoyageur4.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                            {

                                if (txtNomVoyageur4.TextLength != 0) {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur1.Text.ToUpper(), txtNomVoyageur4.Text, DateTime.Parse(dateTimePickerVoyageur4.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                                else {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur4.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur4.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }

                            }
                            if (txtNomVoyageur5.TextLength != 0) //on compte le nombre de voyageurs supplémentaires
                            {
                                if (txtNomVoyageur5.TextLength != 0) {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur5.Text.ToUpper(), txtNomVoyageur5.Text, DateTime.Parse(dateTimePickerVoyageur5.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                                else {
                                    resVoy = oBlAccompagnateur.InsertVoyageur(txtNomVoyageur5.Text.ToUpper(), DateTime.Parse(dateTimePickerVoyageur5.Text), oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                                }
                            }
                            decimal? res = oBlRes.GetResPrixTotal(oBlRes.GetResId(_Client.CLIENT_ID, oDateRetour.PLAN_ID));
                            if (res == null) {
                                throw new CustomError(1);
                            }
                            MessageBox.Show("Reservation du vol retour effectuée");
                        }
                    }
                    scope.Complete();
                }
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (FormatException fEx) {
                CustomError oCst = new CustomError(2);
                MessageBox.Show(oCst.Message);
            }
            catch (Exception ex) {
                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        private void cmbDateVolAller_SelectedIndexChanged(object sender, EventArgs e) {
            if (radioAllerRetour.Checked) {
                PLA_GetDateByVolId_Result oDateSimple = (PLA_GetDateByVolId_Result)cmbDateVolAller.SelectedItem; //Date vol simple
                VOL_SelectAllListChoix_Result oVol = (VOL_SelectAllListChoix_Result)cmbVolAller.SelectedItem;
                BLPlannings oBl = new BLPlannings();
                List<PLA_GetDateByVolIdDateCritere_Result> oList = new List<PLA_GetDateByVolIdDateCritere_Result>();
                VOL_SelectAllListChoixRetour_Result oVolRetour = new VOL_SelectAllListChoixRetour_Result();
                try {
                    oVolRetour = BLVols.GetVolRetour(oVol.VOL_ID_VILLE_ARR, oVol.VOL_ID_VILLE_DEP);
                    oList = BLPlannings.GetDatesVol(oVolRetour.VOL_ID, oDateSimple.PLAN_VOL_DATE);
                    cmbDateVolRetour.DataSource = oList;
                    cmbDateVolRetour.ValueMember = "PLAN_ID";
                    cmbDateVolRetour.DisplayMember = "PLAN_VOL_DATE";
                }
                catch (CustomError cEx) {
                    MessageBox.Show(cEx.Message);
                }
                catch (Exception ex) {

                    CustomError cEx = new CustomError(666);
                    MessageBox.Show(cEx.Message);
                }
            }
        }
        // TAB MODIFIER VOL

    }
}
