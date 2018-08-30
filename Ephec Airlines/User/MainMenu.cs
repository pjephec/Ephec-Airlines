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

namespace User
{
    public partial class MainMenu : Form
    {
        private CLI_FetchTousClients_Result _Client;
        public MainMenu()
        {
            InitializeComponent();
        }
        
        // TAB RESERVATIONS

        // Récupération du client sélectionné
        public MainMenu(CLI_FetchTousClients_Result clt) 
        {
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
                txtVolRetour.Enabled = true;
                cmbDateVolRetour.Enabled = true;
            }
            else {
                txtVolRetour.Clear();
                txtVolRetour.Enabled = false;
                cmbDateVolRetour.Text = "";
                cmbDateVolRetour.Enabled = false;
            }
        }

        private void cmbVolAller_SelectedIndexChanged(object sender, EventArgs e) {
            VOL_SelectAllListChoix_Result oVol = (VOL_SelectAllListChoix_Result)cmbVolAller.SelectedItem;
            BLVols oBlVol = new BLVols();
            List<PLA_GetDateByVolId_Result> oList = new List<PLA_GetDateByVolId_Result>();
            try {
                cmbDateVolAller.DataSource = BLPlannings.GetDatesVol(oVol.VOL_ID); // on récupère les dates pour le vol choisi
                cmbDateVolAller.ValueMember = "PLA_ID";
                cmbDateVolAller.DisplayMember = "PLA_DATE_VOL";
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

        private void tabDetails_Click(object sender, EventArgs e) {

        }


        // TAB MODIFIER VOL
    }
}
