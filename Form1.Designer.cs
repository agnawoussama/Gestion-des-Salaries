
namespace Gestion_des_Salaries
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
            this.btn_ajt = new System.Windows.Forms.Button();
            this.btn_vld = new System.Windows.Forms.Button();
            this.btn_annl = new System.Windows.Forms.Button();
            this.txtbx_code = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_nom_un = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_nbr_slrr = new System.Windows.Forms.Label();
            this.lbl_nom_un = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_nbr_slr = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbtn_celib = new System.Windows.Forms.RadioButton();
            this.rdbtn_marrie = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbx_code_un = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_matr = new System.Windows.Forms.TextBox();
            this.lbl_nom_unit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_mdf = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.btn_savetxt = new System.Windows.Forms.Button();
            this.btn_load_txt = new System.Windows.Forms.Button();
            this.btn_save_xml = new System.Windows.Forms.Button();
            this.btn_load_xml = new System.Windows.Forms.Button();
            this.btn_load_dat = new System.Windows.Forms.Button();
            this.btn_save_dat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajt
            // 
            this.btn_ajt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ajt.Location = new System.Drawing.Point(540, 24);
            this.btn_ajt.Name = "btn_ajt";
            this.btn_ajt.Size = new System.Drawing.Size(83, 27);
            this.btn_ajt.TabIndex = 0;
            this.btn_ajt.Text = "Ajouter";
            this.btn_ajt.UseVisualStyleBackColor = true;
            this.btn_ajt.Click += new System.EventHandler(this.btn_ajt_Click);
            // 
            // btn_vld
            // 
            this.btn_vld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vld.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_vld.Location = new System.Drawing.Point(240, 168);
            this.btn_vld.Name = "btn_vld";
            this.btn_vld.Size = new System.Drawing.Size(90, 27);
            this.btn_vld.TabIndex = 1;
            this.btn_vld.Text = "Valider";
            this.btn_vld.UseVisualStyleBackColor = true;
            this.btn_vld.Click += new System.EventHandler(this.btn_vld_Click);
            // 
            // btn_annl
            // 
            this.btn_annl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_annl.Location = new System.Drawing.Point(355, 168);
            this.btn_annl.Name = "btn_annl";
            this.btn_annl.Size = new System.Drawing.Size(88, 28);
            this.btn_annl.TabIndex = 2;
            this.btn_annl.Text = "Annuler";
            this.btn_annl.UseVisualStyleBackColor = true;
            this.btn_annl.Click += new System.EventHandler(this.btn_annl_Click);
            // 
            // txtbx_code
            // 
            this.txtbx_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_code.Location = new System.Drawing.Point(101, 28);
            this.txtbx_code.Name = "txtbx_code";
            this.txtbx_code.Size = new System.Drawing.Size(150, 22);
            this.txtbx_code.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtbox_nom_un);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbx_code);
            this.groupBox1.Controls.Add(this.btn_ajt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unité";
            // 
            // txtbox_nom_un
            // 
            this.txtbox_nom_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom_un.Location = new System.Drawing.Point(337, 28);
            this.txtbox_nom_un.Name = "txtbox_nom_un";
            this.txtbox_nom_un.Size = new System.Drawing.Size(150, 22);
            this.txtbox_nom_un.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(288, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestion des Salaries";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.lbl_nbr_slrr);
            this.groupBox2.Controls.Add(this.lbl_nom_un);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.lbl_nbr_slr);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rdbtn_celib);
            this.groupBox2.Controls.Add(this.rdbtn_marrie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbx_code_un);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtbx_nom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_annl);
            this.groupBox2.Controls.Add(this.txtbx_matr);
            this.groupBox2.Controls.Add(this.btn_vld);
            this.groupBox2.Controls.Add(this.lbl_nom_unit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 200);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salarié";
            // 
            // lbl_nbr_slrr
            // 
            this.lbl_nbr_slrr.AutoSize = true;
            this.lbl_nbr_slrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbr_slrr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nbr_slrr.Location = new System.Drawing.Point(654, 38);
            this.lbl_nbr_slrr.Name = "lbl_nbr_slrr";
            this.lbl_nbr_slrr.Size = new System.Drawing.Size(0, 16);
            this.lbl_nbr_slrr.TabIndex = 29;
            // 
            // lbl_nom_un
            // 
            this.lbl_nom_un.AutoSize = true;
            this.lbl_nom_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_un.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nom_un.Location = new System.Drawing.Point(437, 37);
            this.lbl_nom_un.Name = "lbl_nom_un";
            this.lbl_nom_un.Size = new System.Drawing.Size(0, 16);
            this.lbl_nom_un.TabIndex = 28;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(441, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 22);
            this.numericUpDown1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // lbl_nbr_slr
            // 
            this.lbl_nbr_slr.AutoSize = true;
            this.lbl_nbr_slr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbr_slr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nbr_slr.Location = new System.Drawing.Point(552, 37);
            this.lbl_nbr_slr.Name = "lbl_nbr_slr";
            this.lbl_nbr_slr.Size = new System.Drawing.Size(86, 16);
            this.lbl_nbr_slr.TabIndex = 25;
            this.lbl_nbr_slr.Text = "Nbr Salariés:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(322, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Date d\'affectation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(322, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Echelle:";
            // 
            // rdbtn_celib
            // 
            this.rdbtn_celib.AutoSize = true;
            this.rdbtn_celib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_celib.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbtn_celib.Location = new System.Drawing.Point(209, 143);
            this.rdbtn_celib.Name = "rdbtn_celib";
            this.rdbtn_celib.Size = new System.Drawing.Size(84, 19);
            this.rdbtn_celib.TabIndex = 21;
            this.rdbtn_celib.TabStop = true;
            this.rdbtn_celib.Text = "Celibataire";
            this.rdbtn_celib.UseVisualStyleBackColor = true;
            // 
            // rdbtn_marrie
            // 
            this.rdbtn_marrie.AutoSize = true;
            this.rdbtn_marrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_marrie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbtn_marrie.Location = new System.Drawing.Point(146, 143);
            this.rdbtn_marrie.Name = "rdbtn_marrie";
            this.rdbtn_marrie.Size = new System.Drawing.Size(57, 19);
            this.rdbtn_marrie.TabIndex = 20;
            this.rdbtn_marrie.TabStop = true;
            this.rdbtn_marrie.Text = "Marié";
            this.rdbtn_marrie.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(19, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Situation Familiale:";
            // 
            // cmbx_code_un
            // 
            this.cmbx_code_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_code_un.FormattingEnabled = true;
            this.cmbx_code_un.Location = new System.Drawing.Point(125, 37);
            this.cmbx_code_un.Name = "cmbx_code_un";
            this.cmbx_code_un.Size = new System.Drawing.Size(168, 24);
            this.cmbx_code_un.TabIndex = 18;
            this.cmbx_code_un.SelectedIndexChanged += new System.EventHandler(this.cmbx_code_un_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nom:";
            // 
            // txtbx_nom
            // 
            this.txtbx_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nom.Location = new System.Drawing.Point(125, 106);
            this.txtbx_nom.Name = "txtbx_nom";
            this.txtbx_nom.Size = new System.Drawing.Size(168, 22);
            this.txtbx_nom.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Matricule:";
            // 
            // txtbx_matr
            // 
            this.txtbx_matr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_matr.Location = new System.Drawing.Point(125, 70);
            this.txtbx_matr.Name = "txtbx_matr";
            this.txtbx_matr.Size = new System.Drawing.Size(168, 22);
            this.txtbx_matr.TabIndex = 14;
            // 
            // lbl_nom_unit
            // 
            this.lbl_nom_unit.AutoSize = true;
            this.lbl_nom_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_unit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nom_unit.Location = new System.Drawing.Point(322, 35);
            this.lbl_nom_unit.Name = "lbl_nom_unit";
            this.lbl_nom_unit.Size = new System.Drawing.Size(74, 16);
            this.lbl_nom_unit.TabIndex = 12;
            this.lbl_nom_unit.Text = "Nom Unité:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code unité:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 178);
            this.dataGridView1.TabIndex = 14;
            // 
            // btn_sup
            // 
            this.btn_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sup.Location = new System.Drawing.Point(464, 497);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(94, 40);
            this.btn_sup.TabIndex = 27;
            this.btn_sup.Text = "Supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_mdf
            // 
            this.btn_mdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mdf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_mdf.Location = new System.Drawing.Point(567, 497);
            this.btn_mdf.Name = "btn_mdf";
            this.btn_mdf.Size = new System.Drawing.Size(90, 40);
            this.btn_mdf.TabIndex = 28;
            this.btn_mdf.Text = "Modifier";
            this.btn_mdf.UseVisualStyleBackColor = true;
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_quit.Location = new System.Drawing.Point(663, 497);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(92, 40);
            this.btn_quit.TabIndex = 29;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(567, 4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(64, 24);
            this.test.TabIndex = 30;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // btn_savetxt
            // 
            this.btn_savetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savetxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_savetxt.Location = new System.Drawing.Point(12, 488);
            this.btn_savetxt.Name = "btn_savetxt";
            this.btn_savetxt.Size = new System.Drawing.Size(90, 27);
            this.btn_savetxt.TabIndex = 31;
            this.btn_savetxt.Text = "Save(txt)";
            this.btn_savetxt.UseVisualStyleBackColor = true;
            this.btn_savetxt.Click += new System.EventHandler(this.btn_savetxt_Click);
            // 
            // btn_load_txt
            // 
            this.btn_load_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_txt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_load_txt.Location = new System.Drawing.Point(12, 521);
            this.btn_load_txt.Name = "btn_load_txt";
            this.btn_load_txt.Size = new System.Drawing.Size(90, 27);
            this.btn_load_txt.TabIndex = 32;
            this.btn_load_txt.Text = "Load(txt)";
            this.btn_load_txt.UseVisualStyleBackColor = true;
            this.btn_load_txt.Click += new System.EventHandler(this.btn_load_txt_Click);
            // 
            // btn_save_xml
            // 
            this.btn_save_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_xml.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save_xml.Location = new System.Drawing.Point(129, 488);
            this.btn_save_xml.Name = "btn_save_xml";
            this.btn_save_xml.Size = new System.Drawing.Size(90, 27);
            this.btn_save_xml.TabIndex = 33;
            this.btn_save_xml.Text = "Save(xml)";
            this.btn_save_xml.UseVisualStyleBackColor = true;
            // 
            // btn_load_xml
            // 
            this.btn_load_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_xml.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_load_xml.Location = new System.Drawing.Point(129, 521);
            this.btn_load_xml.Name = "btn_load_xml";
            this.btn_load_xml.Size = new System.Drawing.Size(90, 27);
            this.btn_load_xml.TabIndex = 34;
            this.btn_load_xml.Text = "Load(xml)";
            this.btn_load_xml.UseVisualStyleBackColor = true;
            // 
            // btn_load_dat
            // 
            this.btn_load_dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_dat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_load_dat.Location = new System.Drawing.Point(247, 521);
            this.btn_load_dat.Name = "btn_load_dat";
            this.btn_load_dat.Size = new System.Drawing.Size(90, 27);
            this.btn_load_dat.TabIndex = 36;
            this.btn_load_dat.Text = "Load(dat)";
            this.btn_load_dat.UseVisualStyleBackColor = true;
            // 
            // btn_save_dat
            // 
            this.btn_save_dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_dat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save_dat.Location = new System.Drawing.Point(247, 488);
            this.btn_save_dat.Name = "btn_save_dat";
            this.btn_save_dat.Size = new System.Drawing.Size(90, 27);
            this.btn_save_dat.TabIndex = 35;
            this.btn_save_dat.Text = "Save(dat)";
            this.btn_save_dat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 555);
            this.Controls.Add(this.btn_load_dat);
            this.Controls.Add(this.btn_save_dat);
            this.Controls.Add(this.btn_load_xml);
            this.Controls.Add(this.btn_save_xml);
            this.Controls.Add(this.btn_load_txt);
            this.Controls.Add(this.btn_savetxt);
            this.Controls.Add(this.test);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_mdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajt;
        private System.Windows.Forms.Button btn_vld;
        private System.Windows.Forms.Button btn_annl;
        private System.Windows.Forms.TextBox txtbx_code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_nom_unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_nom_un;
        private System.Windows.Forms.TextBox txtbx_matr;
        private System.Windows.Forms.RadioButton rdbtn_marrie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbx_code_un;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbtn_celib;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_nbr_slr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_mdf;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_nbr_slrr;
        private System.Windows.Forms.Label lbl_nom_un;
        private System.Windows.Forms.Button btn_savetxt;
        private System.Windows.Forms.Button btn_load_txt;
        private System.Windows.Forms.Button btn_save_xml;
        private System.Windows.Forms.Button btn_load_xml;
        private System.Windows.Forms.Button btn_load_dat;
        private System.Windows.Forms.Button btn_save_dat;
    }
}

