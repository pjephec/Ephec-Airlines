using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Models;
using BusinessErrors;

namespace Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            InitInfoOverviewTab();
            InitInfoDetailsTab();
        }

        private void AdminForm_Load(object sender, EventArgs e) {
        }

        private void InitInfoOverviewTab() {
            DataSet dataSet = new DataSet();
            try {
                dataSet = BLVols.GetInfos();
                dataGridViewVols.DataSource = dataSet.Tables[0].DefaultView;
                dataGridViewVols.Columns[0].Visible = false;
                cmbTranchePrix.DataSource = BLVols.GetTousVols();
                cmbTranchePrix.ValueMember = "IdVol";
                cmbTranchePrix.DisplayMember = "Code";
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                throw new CustomError(666);
            }
        }

        private void InitInfoDetailsTab() {
            try {
                cmbVolDetails.DataSource = BLVols.GetTousVols();
                cmbVolDetails.ValueMember = "IdVol";
                cmbVolDetails.DisplayMember = "Code";
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                throw new CustomError(666);
            }
        }

        private void btnFiltreVols_Click(object sender, EventArgs e) {
            DataSet dataSet = new DataSet();
            try {
                dataSet = BLVols.GetInfosFiltre(txtVolsInput.Text);
                dataGridViewVols.DataSource = dataSet.Tables[0].DefaultView;
                dataGridViewVols.Columns[0].Visible = false;
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        private void cmbTranchePrix_SelectedIndexChanged(object sender, EventArgs e) {
            Models.Vol oVolSelect = (Models.Vol)cmbTranchePrix.SelectedItem;
            try {
                DataTable oDatatable = BLTranches.GetTrancheParVol(oVolSelect.IdVol);
                dataGridViewPrix.DataSource = oDatatable.DefaultView;
                dataGridViewPrix.Columns[0].Visible = false;
                dataGridViewPrix.Columns[6].Visible = false;
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {

                throw new CustomError(666);
            }
        }

        private void cmbVolDetails_SelectedIndexChanged(object sender, EventArgs e) {
            Models.Vol oVol = (Models.Vol)cmbVolDetails.SelectedItem;
            List<Models.Planning> planningList = BLPlannings.GetDatesByVolId(oVol.IdVol);
            try {
                if (planningList.Count == 0) {
                    cmbVolDetails.Text = ""; // Pas de plannings trouvés, on n'affiche rien
                    dataGridViewPassagers.DataSource = null; // Pas de vols, pas de passagers
                }
                else {
                    cmbVolDetails.DataSource = planningList;
                    cmbVolDetails.ValueMember = "IdPlan";
                    cmbVolDetails.DisplayMember = "DateVol";
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

        private void cmbDateVol_SelectedIndexChanged(object sender, EventArgs e) {
            Models.Vol oVol = (Models.Vol)cmbVolDetails.SelectedItem;
            Models.Planning oPlanning = (Models.Planning)cmbDateVol.SelectedItem;

            DataSet dataSet = new DataSet();
            DataSet oDataCa = new DataSet();
            int nbPassagers;
            int nbPlacesRes;
            decimal tauxOcp;
            decimal ca;

            try {
                dataSet = BLPlannings.GetListePassagers(oVol.IdVol, oPlanning.IdPlan);
                dataGridViewPassagers.DataSource = dataSet.Tables[0].DefaultView;
                BLVols.GetStatsVol(oVol.IdVol, oPlanning.IdPlan, out nbPassagers, out nbPlacesRes, out tauxOcp, out ca);
                oDataCa = BLVols.GetCaTrancheVol(oPlanning.IdPlan);
                if (oDataCa == null) {
                    dataGridViewCA.DataSource = null;
                }
                else {
                    dataGridViewCA.DataSource = oDataCa.Tables[0].DefaultView;
                }
                txtNbPassagers.Text = nbPassagers.ToString();
                txtNbPlacesRestantes.Text = nbPlacesRes.ToString();
                txtOccupationVol.Text = tauxOcp.ToString();
                txtCAVol.Text = ca.ToString();
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                CustomError cEx = new CustomError(666);
                MessageBox.Show(cEx.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            InitInfoDetailsTab();
            dataGridViewCA.DataSource = null;
            dataGridViewPassagers.DataSource = null;
            txtNbPassagers.Text = "";
            txtNbPlacesRestantes.Text = "";
            txtOccupationVol.Text = "";
            txtCAVol.Text = "";
        }
    }
}
