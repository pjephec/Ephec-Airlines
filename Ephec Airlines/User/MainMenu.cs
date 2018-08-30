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
using System.Reflection;

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
            InitializeTabModification();
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
        // Dès que le texte de la textbox change, ça veut dire qu'on veut un vol retour et on trigger un get des dates du retour s'il y en a
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
        // Réserver un vol
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
                    if (cpt > nbPlacesRestantes) { // s'il y a plus de voyageurs pour cette réservation que de places disponibles, fallback et on cherche les bonnes dates
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
                    InitializeTabOverview(); // on recharge les données
                    InitializeTabModification(); // on recharge les données
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
        // Initialisation du tab des modifications avec les vols réservés
        private void InitializeTabModification() {
            List<RES_GetResByClientId_Result> oList = new List<RES_GetResByClientId_Result>();
            try {
                cmbListeVolsReserves.DataSource = BLReservations.GetResClient(_Client.CLIENT_ID);
                cmbListeVolsReserves.ValueMember = "RES_ID";
                cmbListeVolsReserves.DisplayMember = "VOL_CODE";
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                CustomError Cex = new CustomError(666);
                MessageBox.Show(Cex.Message);
            }
        }

        private void cmbListeVolsReserves_SelectedIndexChanged(object sender, EventArgs e) {
            RES_GetResByClientId_Result oMonVol = (RES_GetResByClientId_Result)cmbListeVolsReserves.SelectedItem;
            BLAccompagnateurs oBlVoyageur = new BLAccompagnateurs();
            List<CLI_GetClientMoneyInfo_Result> oListInfo = new List<CLI_GetClientMoneyInfo_Result>();
            List<ACC_GetAccompagnateurChiffreParTete_Result> oList = new List<ACC_GetAccompagnateurChiffreParTete_Result>();
            DataTable oData = new DataTable();
            DataView oView = new DataView();
            try {
                oListInfo = BLClients.GetClientMoneyInfo(_Client.CLIENT_ID, oMonVol.RES_ID);
                foreach (CLI_GetClientMoneyInfo_Result row in oListInfo) {
                    txtPrixVol.Text = row.TRA_PRIX.ToString();
                    txtPrixTotalReservation.Text = row.RES_PRIX.ToString();
                }
                txtDateVol.Text = oMonVol.PLAN_VOL_DATE.ToShortDateString();
                oView = BLAccompagnateurs.GetVoyageursAvecPrixData(oMonVol.RES_ID);
                oList = BLAccompagnateurs.GetVoyageursAvecPrix(oMonVol.RES_ID);
                DataTable oDataTable = ToDataTable(oList);
                BindingList<ACC_GetAccompagnateurChiffreParTete_Result> oBList = new BindingList<ACC_GetAccompagnateurChiffreParTete_Result>(oList);
                dataGridViewVoyageursMod.DataSource = oList;
                dataGridViewVoyageursMod.Columns[0].Visible = false;
                dataGridViewVoyageursMod.Columns[4].ReadOnly = true;
                cmbVoyageurAModifier.DataSource = oList;
                cmbVoyageurAModifier.ValueMember = "ACC_ID";
                cmbVoyageurAModifier.DisplayMember = "ACC_NOM";
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        public DataTable ToDataTable<T>(List<T> items) {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props) {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        // Rafraîchier les données du tab de la modification de vols
        private void btnRefreshModifs_Click(object sender, EventArgs e) {
            InitializeTabModification();
        }

        private void btnSupprimerReservation_Click(object sender, EventArgs e) {
            RES_GetResByClientId_Result oResult = (RES_GetResByClientId_Result)cmbListeVolsReserves.SelectedItem;
            int tmp = oResult.RES_ID;
            try {
                BLReservations.DeleteResId(oResult.RES_ID);
                MessageBox.Show("Réservation avec id " + tmp.ToString() + " effectuée");
                List<RES_GetResByClientId_Result> oList = BLReservations.GetResClient(_Client.CLIENT_ID);
                cmbListeVolsReserves.DataSource = oList;
                cmbListeVolsReserves.ValueMember = "RES_ID";
                cmbListeVolsReserves.DisplayMember = "VOL_CODE";
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                CustomError crEx = new CustomError(666);
                MessageBox.Show(crEx.Message);

            }
        }
    }
}
