using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_des_Salaries
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] col = new string [] { "matricule", "nom", "situation familiale", "echelle", "date affectation" };
            //Remplissage des collumns
            for (int i = 0; i < col.Length; i++) { dataGridView1.Columns.Add(col[i], col[i]); }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Bouton Ajouter
        private void btn_ajt_Click(object sender, EventArgs e)
        {
            // object unite qui porte les infos de unite
            Unite un = new Unite(int.Parse(txtbx_code.Text), txtbox_nom_un.Text);
            // Ajouter l'objet a la liste des unites
            ListeUnite.Unites.Add(un);
            // Ajouter le code dans le combobox
            cmbx_code_un.Items.Add(txtbx_code.Text);
        }

        private void test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Unite.Salaries.Count.ToString());
        }

        //Bouton Valider
        private void btn_vld_Click(object sender, EventArgs e)
        {
            // situation (marie / celibataire)
            string situ = "";
            if (rdbtn_marrie.Checked == true)situ = rdbtn_marrie.Text;
            else 
            if (rdbtn_celib.Checked == true) situ = rdbtn_celib.Text;

            // object salarie qui porte les infos de salarie
            Salarie s = new Salarie(int.Parse(txtbx_matr.Text), txtbx_nom.Text, situ, (int)numericUpDown1.Value, dateTimePicker1.Value);

            Unite.Salaries.Add(s);
            //Creation d'un nouveau ligne dans la datagridview
            var n = dataGridView1.Rows.Add();

            //Remplir les infos de l'object dans la datagridview
            dataGridView1.Rows[n].Cells[0].Value = s.Matr;
            dataGridView1.Rows[n].Cells[1].Value = s.Nom;
            dataGridView1.Rows[n].Cells[2].Value = s.Situ_famil;
            dataGridView1.Rows[n].Cells[3].Value = s.Echelle;
            dataGridView1.Rows[n].Cells[4].Value = s.Date_afct;
        }

        //Combo box Unite
        private void cmbx_code_un_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_nom_un.Text = String.Empty;
            lbl_nbr_slrr.Text = String.Empty;
            // method rechercher pour rechercher le nom a partir d'un code donné dans sa parametre
            string RechercherUnitName(int code)
            {
                foreach (var item in ListeUnite.Unites)
                {
                    if (item.Code == code) return item.Nom;
                }
                return null;
            }

            int RechercherSalarieNbr(int code)
            {
                int cpt = 0;
                foreach (var item in ListeUnite.Unites)
                {
                    if (item.Code == code)
                        cpt++;
                }
                return cpt;
            }

            lbl_nom_un.Text = RechercherUnitName(int.Parse(cmbx_code_un.Text));
            //lbl_nbr_slrr.Text = Unite.Salaries.Count.ToString();
            lbl_nbr_slrr.Text = RechercherSalarieNbr(int.Parse(cmbx_code_un.Text)).ToString();
        }

        //Bouton Annuler
        private void btn_annl_Click(object sender, EventArgs e)
        {
            txtbx_code.Clear();
            txtbox_nom_un.Clear();
            //cmbx_code_un.ResetText();
            txtbx_matr.Clear();
            txtbx_nom.Clear();
            numericUpDown1.Value = 5;
            rdbtn_celib.Checked = false;
            rdbtn_marrie.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        //Bouton Supprimer
        private void btn_sup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer?", "Avertissement", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                    //(or this one) dataGridView1.Rows.Remove(item);
                }
            }                         
        }

        //Bouton Quitter
        private void btn_quit_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }


        private void btn_savetxt_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            //{
            //    File.AppendAllText("t.txt", dataGridView1.Rows[i].Cells[0].Value.ToString() + "\n");
            //    File.AppendAllText("t.txt", dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n");
            //    File.AppendAllText("t.txt", dataGridView1.Rows[i].Cells[2].Value.ToString() + "\n");
            //    File.AppendAllText("t.txt", dataGridView1.Rows[i].Cells[3].Value.ToString() + "\n");
            //    File.AppendAllText("t.txt", dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n");
            //    File.AppendAllText("t.txt","------------------\n");
            //}         

        }

        private void btn_load_txt_Click(object sender, EventArgs e)
        {
            //string path = "t.txt";
            //while ()
            //{

            //}
        }
    }
}
