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
using BusinessErrors;
using EntityClient;

namespace User
{
    public partial class UserFormSelect : Form
    {
        private const string ERREUR_SERVEUR = "Une erreur de connection au serveur est survenue. Vérifiez la connection string...";
        public UserFormSelect()
        {
            InitializeComponent();
        }

        private void userFormSelect_Load(object sender, EventArgs e)
        {
            // populate combobox
            List<CLI_FetchTousClients_Result> clientList = new List<CLI_FetchTousClients_Result>();
            try {
                clientList = BLClients.GetAllClients();
                comboBox1.DataSource = clientList;
                comboBox1.ValueMember = "CLIENT_ID";
                comboBox1.DisplayMember = "CLIENT_LOGIN";
                CLI_FetchTousClients_Result oCLi = (CLI_FetchTousClients_Result)comboBox1.SelectedItem;
                txtClientName.Text = oCLi.CLIENT_NOM.ToString() + " " + oCLi.CLIENT_PRENOM.ToString();
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                CustomError cEx = new CustomError(666);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                CLI_FetchTousClients_Result oCLi = (CLI_FetchTousClients_Result)comboBox1.SelectedItem;
                txtClientName.Text = oCLi.CLIENT_NOM.ToString() + " " + oCLi.CLIENT_PRENOM.ToString(); ;
            }
            catch (CustomError cEx) {
                MessageBox.Show(cEx.Message);
            }
            catch (Exception ex) {

                CustomError cEx = new CustomError(666);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            CLI_FetchTousClients_Result oCli = (CLI_FetchTousClients_Result)comboBox1.SelectedItem;
            MainMenu oClFrm = new MainMenu(oCli);
            oClFrm.ShowDialog();
        }
    }
}
