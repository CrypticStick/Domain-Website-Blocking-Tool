namespace Trump_s_Website_Deporter_TM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LstBoxBlocked = new System.Windows.Forms.ListBox();
            this.TxtBoxURL = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkLstBoxSystems = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnRecieve = new System.Windows.Forms.Button();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.ChkBoxLocal = new System.Windows.Forms.CheckBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TxtBoxStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstBoxBlocked
            // 
            this.LstBoxBlocked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstBoxBlocked.FormattingEnabled = true;
            this.LstBoxBlocked.Location = new System.Drawing.Point(9, 87);
            this.LstBoxBlocked.Name = "LstBoxBlocked";
            this.LstBoxBlocked.ScrollAlwaysVisible = true;
            this.LstBoxBlocked.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstBoxBlocked.Size = new System.Drawing.Size(229, 212);
            this.LstBoxBlocked.TabIndex = 0;
            this.LstBoxBlocked.Click += new System.EventHandler(this.LstBoxBlocked_Click);
            // 
            // TxtBoxURL
            // 
            this.TxtBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxURL.Location = new System.Drawing.Point(9, 37);
            this.TxtBoxURL.Multiline = true;
            this.TxtBoxURL.Name = "TxtBoxURL";
            this.TxtBoxURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxURL.Size = new System.Drawing.Size(230, 45);
            this.TxtBoxURL.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(9, 8);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Location = new System.Drawing.Point(163, 8);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Website / IP";
            // 
            // ChkLstBoxSystems
            // 
            this.ChkLstBoxSystems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkLstBoxSystems.FormattingEnabled = true;
            this.ChkLstBoxSystems.Location = new System.Drawing.Point(245, 85);
            this.ChkLstBoxSystems.Name = "ChkLstBoxSystems";
            this.ChkLstBoxSystems.Size = new System.Drawing.Size(195, 214);
            this.ChkLstBoxSystems.TabIndex = 5;
            this.ChkLstBoxSystems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkLstBoxSystems_ItemCheck);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Network Computer Search";
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.Location = new System.Drawing.Point(350, 8);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(90, 23);
            this.BtnApply.TabIndex = 7;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnRecieve
            // 
            this.BtnRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecieve.Location = new System.Drawing.Point(245, 8);
            this.BtnRecieve.Name = "BtnRecieve";
            this.BtnRecieve.Size = new System.Drawing.Size(99, 23);
            this.BtnRecieve.TabIndex = 8;
            this.BtnRecieve.Text = "Recieve List";
            this.BtnRecieve.UseVisualStyleBackColor = true;
            this.BtnRecieve.Click += new System.EventHandler(this.BtnRecieve_Click);
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxSearch.Location = new System.Drawing.Point(245, 59);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(195, 20);
            this.TxtBoxSearch.TabIndex = 9;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // ChkBoxLocal
            // 
            this.ChkBoxLocal.AutoSize = true;
            this.ChkBoxLocal.Location = new System.Drawing.Point(9, 305);
            this.ChkBoxLocal.Name = "ChkBoxLocal";
            this.ChkBoxLocal.Size = new System.Drawing.Size(166, 17);
            this.ChkBoxLocal.TabIndex = 10;
            this.ChkBoxLocal.Text = "Only configure this computer?";
            this.ChkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // TxtBoxStatus
            // 
            this.TxtBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxStatus.Location = new System.Drawing.Point(245, 302);
            this.TxtBoxStatus.Name = "TxtBoxStatus";
            this.TxtBoxStatus.ReadOnly = true;
            this.TxtBoxStatus.Size = new System.Drawing.Size(195, 20);
            this.TxtBoxStatus.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 325);
            this.Controls.Add(this.TxtBoxStatus);
            this.Controls.Add(this.ChkBoxLocal);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.BtnRecieve);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChkLstBoxSystems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtBoxURL);
            this.Controls.Add(this.LstBoxBlocked);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Trump\'s Website Deporter TM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxBlocked;
        private System.Windows.Forms.TextBox TxtBoxURL;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ChkLstBoxSystems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnRecieve;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.CheckBox ChkBoxLocal;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox TxtBoxStatus;
    }
}

