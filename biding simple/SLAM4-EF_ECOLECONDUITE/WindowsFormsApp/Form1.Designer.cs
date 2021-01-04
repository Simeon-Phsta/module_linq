
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cylindreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voitureONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lECONsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Charger les véhicules";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sauvegarder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.cylindreeDataGridViewTextBoxColumn,
            this.voitureONDataGridViewTextBoxColumn,
            this.lECONsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vEHICULEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(212, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowLeave);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserAddRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "modele";
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            // 
            // cylindreeDataGridViewTextBoxColumn
            // 
            this.cylindreeDataGridViewTextBoxColumn.DataPropertyName = "cylindree";
            this.cylindreeDataGridViewTextBoxColumn.HeaderText = "cylindree";
            this.cylindreeDataGridViewTextBoxColumn.Name = "cylindreeDataGridViewTextBoxColumn";
            // 
            // voitureONDataGridViewTextBoxColumn
            // 
            this.voitureONDataGridViewTextBoxColumn.DataPropertyName = "voitureO_N";
            this.voitureONDataGridViewTextBoxColumn.HeaderText = "voitureO_N";
            this.voitureONDataGridViewTextBoxColumn.Name = "voitureONDataGridViewTextBoxColumn";
            // 
            // lECONsDataGridViewTextBoxColumn
            // 
            this.lECONsDataGridViewTextBoxColumn.DataPropertyName = "LECONs";
            this.lECONsDataGridViewTextBoxColumn.HeaderText = "LECONs";
            this.lECONsDataGridViewTextBoxColumn.Name = "lECONsDataGridViewTextBoxColumn";
            // 
            // vEHICULEBindingSource
            // 
            this.vEHICULEBindingSource.DataSource = typeof(WindowsFormsApp.VEHICULE);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cylindreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voitureONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lECONsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vEHICULEBindingSource;
    }
}

