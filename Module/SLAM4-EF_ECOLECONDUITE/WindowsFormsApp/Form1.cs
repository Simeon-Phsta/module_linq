using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private ECOLECONDUITEEntities monModele;
        public Form1()
        {
            InitializeComponent();
            monModele = new ECOLECONDUITEEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var req = from el in monModele.ELEVEs.Include("LECONs.VEHICULE")
                      select el;
            //récupération de la liste du résultat de la requête dans la bdg eleve
            bdgSourceEleve.DataSource = req.ToList();
            //on affecte la bdg eleve à sa dtgv 
            dataGridView1.DataSource = bdgSourceEleve;
            //on donne à bdg lecon comme data source bdg eleve 
            bdgSourceLecon.DataSource = bdgSourceEleve;
            //en lui donnant le data member lecon de l'include de la requete
            bdgSourceLecon.DataMember = "LECONs";
            //on affecte la bdg lecon à sa dtgv
            dataGridView2.DataSource = bdgSourceLecon;
            //bdg lecon est affecte à la bdg vehicule
            bdgSourceVehicule.DataSource = bdgSourceLecon;
            //bdg vehicule prends le membre vehicule de l'include de la requete 
            bdgSourceVehicule.DataMember = "VEHICULE";
            //bdg vehicule est affecte à la data source de sa dtgv
            dataGridView3.DataSource = bdgSourceVehicule;

        }
    

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string nom = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(nom);
                //var req = from l in monModele.LECONs
                //          where l.ELEVE.nom == nom
                //          select l;
                //dataGridView2.DataSource = req.ToList();

                var req = from el in monModele.LECONs.Include("VEHICULE")
                          where el.ELEVE.nom == nom
                          select el;

                bdgSourceLecon.DataSource = req.ToList();
                dataGridView2.DataSource = bdgSourceLecon;
                bdgSourceVehicule.DataSource = bdgSourceLecon;
                bdgSourceVehicule.DataMember = "VEHICULE";
                dataGridView3.DataSource = bdgSourceVehicule;

            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string nom = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(nom);
                //var req = from l in monModele.LECONs
                //          where l.ELEVE.nom == nom
                //          select l;
                //dataGridView2.DataSource = req.ToList();

                var req = from el in monModele.LECONs.Include("VEHICULE")
                          where el.ELEVE.nom == nom
                          select el;

                bdgSourceLecon.DataSource = req.ToList();
                dataGridView2.DataSource = bdgSourceLecon;
                bdgSourceVehicule.DataSource = bdgSourceLecon;
                bdgSourceVehicule.DataMember = "VEHICULE";
                dataGridView3.DataSource = bdgSourceVehicule;

            }
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }
    }
}
