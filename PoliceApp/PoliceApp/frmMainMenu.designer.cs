namespace PoliceApp
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordpadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDunAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspensionDunAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réactivationDunAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.congeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decorationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanctionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1,
            this.patientToolStripMenuItem,
            this.procedureToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.logoutToolStripMenuItem1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.logoutToolStripMenuItem1.Text = "Application";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.deconnexionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.patientToolStripMenuItem.Text = "Policier";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // procedureToolStripMenuItem
            // 
            this.procedureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congeToolStripMenuItem,
            this.affectationToolStripMenuItem,
            this.formationToolStripMenuItem,
            this.decorationToolStripMenuItem,
            this.sanctionToolStripMenuItem});
            this.procedureToolStripMenuItem.Name = "procedureToolStripMenuItem";
            this.procedureToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.procedureToolStripMenuItem.Text = "Gestion RH policier";
            this.procedureToolStripMenuItem.Click += new System.EventHandler(this.procedureToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departementToolStripMenuItem,
            this.utilisateurToolStripMenuItem,
            this.sanctionToolStripMenuItem1});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.invoiceToolStripMenuItem.Text = "Paramétrage";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.wordpadToolStripMenuItem,
            this.mSWordToolStripMenuItem,
            this.taskManagerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.toolsToolStripMenuItem.Text = "Outils";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.calculatorToolStripMenuItem.Text = "Calculatrice";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // wordpadToolStripMenuItem
            // 
            this.wordpadToolStripMenuItem.Name = "wordpadToolStripMenuItem";
            this.wordpadToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.wordpadToolStripMenuItem.Text = "Wordpad";
            this.wordpadToolStripMenuItem.Click += new System.EventHandler(this.wordpadToolStripMenuItem_Click);
            // 
            // mSWordToolStripMenuItem
            // 
            this.mSWordToolStripMenuItem.Name = "mSWordToolStripMenuItem";
            this.mSWordToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.mSWordToolStripMenuItem.Text = "MS Word";
            this.mSWordToolStripMenuItem.Click += new System.EventHandler(this.mSWordToolStripMenuItem_Click);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.taskManagerToolStripMenuItem.Text = "Gestionnaire des tâches";
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiqueDunAgentToolStripMenuItem,
            this.suspensionDunAgentToolStripMenuItem,
            this.réactivationDunAgentToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // historiqueDunAgentToolStripMenuItem
            // 
            this.historiqueDunAgentToolStripMenuItem.Name = "historiqueDunAgentToolStripMenuItem";
            this.historiqueDunAgentToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.historiqueDunAgentToolStripMenuItem.Text = "Journaux d\'un utilisateur";
            // 
            // suspensionDunAgentToolStripMenuItem
            // 
            this.suspensionDunAgentToolStripMenuItem.Name = "suspensionDunAgentToolStripMenuItem";
            this.suspensionDunAgentToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.suspensionDunAgentToolStripMenuItem.Text = "Suspension d\'un utilisateur";
            // 
            // réactivationDunAgentToolStripMenuItem
            // 
            this.réactivationDunAgentToolStripMenuItem.Name = "réactivationDunAgentToolStripMenuItem";
            this.réactivationDunAgentToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.réactivationDunAgentToolStripMenuItem.Text = "Réactivation d\'un utilisateur";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.aboutToolStripMenuItem.Text = "A propos";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.lblTime});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 548);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(808, 22);
            this.StatusStrip1.TabIndex = 4;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(669, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(124, 17);
            this.lblTime.Text = "toolStripStatusLabel5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 89;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::PoliceApp.Properties.Resources.images__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // congeToolStripMenuItem
            // 
            this.congeToolStripMenuItem.Name = "congeToolStripMenuItem";
            this.congeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.congeToolStripMenuItem.Text = "Conge";
            this.congeToolStripMenuItem.Click += new System.EventHandler(this.congeToolStripMenuItem_Click);
            // 
            // affectationToolStripMenuItem
            // 
            this.affectationToolStripMenuItem.Name = "affectationToolStripMenuItem";
            this.affectationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.affectationToolStripMenuItem.Text = "Affectation";
            this.affectationToolStripMenuItem.Click += new System.EventHandler(this.affectationToolStripMenuItem_Click_1);
            // 
            // formationToolStripMenuItem
            // 
            this.formationToolStripMenuItem.Name = "formationToolStripMenuItem";
            this.formationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.formationToolStripMenuItem.Text = "Formation";
            this.formationToolStripMenuItem.Click += new System.EventHandler(this.formationToolStripMenuItem_Click);
            // 
            // decorationToolStripMenuItem
            // 
            this.decorationToolStripMenuItem.Name = "decorationToolStripMenuItem";
            this.decorationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.decorationToolStripMenuItem.Text = "Decoration";
            this.decorationToolStripMenuItem.Click += new System.EventHandler(this.decorationToolStripMenuItem_Click);
            // 
            // sanctionToolStripMenuItem
            // 
            this.sanctionToolStripMenuItem.Name = "sanctionToolStripMenuItem";
            this.sanctionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sanctionToolStripMenuItem.Text = "Sanction";
            this.sanctionToolStripMenuItem.Click += new System.EventHandler(this.sanctionToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.departementToolStripMenuItem.Text = "Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click_1);
            // 
            // sanctionToolStripMenuItem1
            // 
            this.sanctionToolStripMenuItem1.Name = "sanctionToolStripMenuItem1";
            this.sanctionToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.sanctionToolStripMenuItem1.Text = "Sanction";
            this.sanctionToolStripMenuItem1.Click += new System.EventHandler(this.sanctionToolStripMenuItem1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(808, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicaton";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordpadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem procedureToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDunAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspensionDunAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réactivationDunAgentToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem congeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decorationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanctionToolStripMenuItem1;
    }
}