
namespace Lab7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab7.DataSet1();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOp = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.txtIdPersoana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLocalitate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.persoaneTableAdapter = new Lab7.DataSet1TableAdapters.PersoaneTableAdapter();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localitatiTableAdapter = new Lab7.DataSet1TableAdapters.LocalitatiTableAdapter();
            this.localitatiPersoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localitatiPersoaneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Lab7.DataSet1();
            this.localitatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.persoaneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idPersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocalitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiPersoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiPersoaneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // persoaneBindingSource
            // 
            this.persoaneBindingSource.DataMember = "Persoane";
            this.persoaneBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(57, 34);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(155, 34);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(252, 34);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(498, 34);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(642, 34);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOp);
            this.panel1.Controls.Add(this.PB);
            this.panel1.Controls.Add(this.txtIdPersoana);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSpImagine);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbLocalitate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSalariu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCNP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(431, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 269);
            this.panel1.TabIndex = 6;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(149, 11);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(47, 13);
            this.lblOp.TabIndex = 19;
            this.lblOp.Text = "Operatie";
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(193, 71);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(151, 123);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 18;
            this.PB.TabStop = false;
            // 
            // txtIdPersoana
            // 
            this.txtIdPersoana.Location = new System.Drawing.Point(63, 174);
            this.txtIdPersoana.Name = "txtIdPersoana";
            this.txtIdPersoana.Size = new System.Drawing.Size(124, 20);
            this.txtIdPersoana.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(63, 148);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(124, 20);
            this.txtSpImagine.TabIndex = 15;
            this.txtSpImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpImagine_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Poza";
            // 
            // cmbLocalitate
            // 
            this.cmbLocalitate.FormattingEnabled = true;
            this.cmbLocalitate.Location = new System.Drawing.Point(63, 121);
            this.cmbLocalitate.Name = "cmbLocalitate";
            this.cmbLocalitate.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalitate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Localitate";
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(63, 94);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(124, 20);
            this.txtSalariu.TabIndex = 11;
            this.txtSalariu.Leave += new System.EventHandler(this.txtSalariu_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salariu";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(63, 68);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(124, 20);
            this.txtCNP.TabIndex = 9;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CNP";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(63, 42);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(247, 20);
            this.txtNume.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // localitatiBindingSource
            // 
            this.localitatiBindingSource.DataMember = "Localitati";
            this.localitatiBindingSource.DataSource = this.dataSet1;
            // 
            // localitatiTableAdapter
            // 
            this.localitatiTableAdapter.ClearBeforeFill = true;
            // 
            // localitatiPersoaneBindingSource
            // 
            this.localitatiPersoaneBindingSource.DataMember = "LocalitatiPersoane";
            this.localitatiPersoaneBindingSource.DataSource = this.localitatiBindingSource;
            // 
            // localitatiPersoaneBindingSource1
            // 
            this.localitatiPersoaneBindingSource1.DataMember = "LocalitatiPersoane";
            this.localitatiPersoaneBindingSource1.DataSource = this.localitatiBindingSource;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localitatiBindingSource1
            // 
            this.localitatiBindingSource1.DataMember = "Localitati";
            this.localitatiBindingSource1.DataSource = this.dataSet11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersoanaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.salariuDataGridViewTextBoxColumn,
            this.idLocalitateDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.dLocalitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.persoaneBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 269);
            this.dataGridView1.TabIndex = 7;
            // 
            // persoaneBindingSource1
            // 
            this.persoaneBindingSource1.DataMember = "Persoane";
            this.persoaneBindingSource1.DataSource = this.dataSet11;
            // 
            // idPersoanaDataGridViewTextBoxColumn
            // 
            this.idPersoanaDataGridViewTextBoxColumn.DataPropertyName = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.HeaderText = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.Name = "idPersoanaDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // salariuDataGridViewTextBoxColumn
            // 
            this.salariuDataGridViewTextBoxColumn.DataPropertyName = "Salariu";
            this.salariuDataGridViewTextBoxColumn.HeaderText = "Salariu";
            this.salariuDataGridViewTextBoxColumn.Name = "salariuDataGridViewTextBoxColumn";
            // 
            // idLocalitateDataGridViewTextBoxColumn
            // 
            this.idLocalitateDataGridViewTextBoxColumn.DataPropertyName = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.HeaderText = "IdLocalitate";
            this.idLocalitateDataGridViewTextBoxColumn.Name = "idLocalitateDataGridViewTextBoxColumn";
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            // 
            // dLocalitateDataGridViewTextBoxColumn
            // 
            this.dLocalitateDataGridViewTextBoxColumn.DataPropertyName = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.DataSource = this.localitatiBindingSource;
            this.dLocalitateDataGridViewTextBoxColumn.DisplayMember = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.dLocalitateDataGridViewTextBoxColumn.HeaderText = "DLocalitate";
            this.dLocalitateDataGridViewTextBoxColumn.Name = "dLocalitateDataGridViewTextBoxColumn";
            this.dLocalitateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dLocalitateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiPersoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiPersoaneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.TextBox txtIdPersoana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLocalitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblOp;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private DataSet1TableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private DataSet1TableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
        private System.Windows.Forms.BindingSource localitatiPersoaneBindingSource;
        private System.Windows.Forms.BindingSource localitatiPersoaneBindingSource1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource localitatiBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource persoaneBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dLocalitateDataGridViewTextBoxColumn;
    }
}

