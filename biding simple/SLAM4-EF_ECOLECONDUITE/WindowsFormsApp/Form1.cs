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
            var req = from v in monModele.VEHICULEs
                      select v;
            vEHICULEBindingSource.DataSource = req.ToList();
            dataGridView1.DataSource = vEHICULEBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monModele.SaveChanges();
        }

        private bool ajout = false;

        //Evènement déclenché dès une saisie début sur une nouvelle ligne du datagrid
        private void UserAddRow(object sender, DataGridViewRowEventArgs e)
        {
            //ajout potentiel d'une ligne
            ajout = true;
        }

        private void RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Est-ce un ajout ?
            if (ajout)
            {
                //Déclaration d'un véhicule
                var veh = new VEHICULE();
                //Si la colonne modele qui traduit une voiture est null
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value is null)
                {
                    //C'est une Moto
                    veh = new VEHICULE()
                    {
                        id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        modele = null,
                        cylindree = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                        voitureO_N = false
                    };
                }
                else
                {
                    //C'est une voiture
                    veh = new VEHICULE()
                    {
                        id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        modele = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        cylindree = null,
                        voitureO_N = true
                    };
                }
            //Ajout du véhicule dans la liste
            monModele.VEHICULEs.Add(veh);
            //L'ajout est terminé
            ajout = false;
            }
        }
    }
}
