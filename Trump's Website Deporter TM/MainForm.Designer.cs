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
            this.BackWorkerSystemList = new System.ComponentModel.BackgroundWorker();
            this.BackWorkerRemote = new System.ComponentModel.BackgroundWorker();
            this.PrgrsBarRemote = new System.Windows.Forms.ProgressBar();
            this.BtnExport = new System.Windows.Forms.Button();
            this.TxtBoxLog = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxBlocked
            // 
            this.LstBoxBlocked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstBoxBlocked.FormattingEnabled = true;
            this.LstBoxBlocked.Location = new System.Drawing.Point(9, 88);
            this.LstBoxBlocked.Name = "LstBoxBlocked";
            this.LstBoxBlocked.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstBoxBlocked.Size = new System.Drawing.Size(225, 186);
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
            this.TxtBoxURL.Size = new System.Drawing.Size(225, 45);
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
            this.BtnRemove.Location = new System.Drawing.Point(159, 8);
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
            this.label1.Location = new System.Drawing.Point(89, 13);
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
            this.ChkLstBoxSystems.Location = new System.Drawing.Point(246, 88);
            this.ChkLstBoxSystems.Name = "ChkLstBoxSystems";
            this.ChkLstBoxSystems.Size = new System.Drawing.Size(225, 184);
            this.ChkLstBoxSystems.TabIndex = 5;
            this.ChkLstBoxSystems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkLstBoxSystems_ItemCheck);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Network Computer Search";
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnApply.Location = new System.Drawing.Point(9, 280);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(55, 29);
            this.BtnApply.TabIndex = 7;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnRecieve
            // 
            this.BtnRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRecieve.Location = new System.Drawing.Point(70, 280);
            this.BtnRecieve.Name = "BtnRecieve";
            this.BtnRecieve.Size = new System.Drawing.Size(55, 29);
            this.BtnRecieve.TabIndex = 8;
            this.BtnRecieve.Text = "Recieve";
            this.BtnRecieve.UseVisualStyleBackColor = true;
            this.BtnRecieve.Click += new System.EventHandler(this.BtnRecieve_Click);
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxSearch.Location = new System.Drawing.Point(246, 37);
            this.TxtBoxSearch.Multiline = true;
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxSearch.Size = new System.Drawing.Size(225, 45);
            this.TxtBoxSearch.TabIndex = 9;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // ChkBoxLocal
            // 
            this.ChkBoxLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkBoxLocal.AutoSize = true;
            this.ChkBoxLocal.Location = new System.Drawing.Point(159, 287);
            this.ChkBoxLocal.Name = "ChkBoxLocal";
            this.ChkBoxLocal.Size = new System.Drawing.Size(166, 17);
            this.ChkBoxLocal.TabIndex = 10;
            this.ChkBoxLocal.Text = "Only configure this computer?";
            this.ChkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // BackWorkerSystemList
            // 
            this.BackWorkerSystemList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackWorkerSystemList_DoWork);
            this.BackWorkerSystemList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackWorkerSystemList_RunWorkerCompleted);
            // 
            // BackWorkerRemote
            // 
            this.BackWorkerRemote.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackWorkerRemote_DoWork);
            this.BackWorkerRemote.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackWorkerRemote_RunWorkerCompleted);
            // 
            // PrgrsBarRemote
            // 
            this.PrgrsBarRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrgrsBarRemote.Location = new System.Drawing.Point(381, 12);
            this.PrgrsBarRemote.Maximum = 1;
            this.PrgrsBarRemote.Name = "PrgrsBarRemote";
            this.PrgrsBarRemote.Size = new System.Drawing.Size(90, 19);
            this.PrgrsBarRemote.Step = 1;
            this.PrgrsBarRemote.TabIndex = 11;
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Enabled = false;
            this.BtnExport.Location = new System.Drawing.Point(355, 280);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(55, 29);
            this.BtnExport.TabIndex = 12;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Visible = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // TxtBoxLog
            // 
            this.TxtBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxLog.Location = new System.Drawing.Point(9, 319);
            this.TxtBoxLog.Name = "TxtBoxLog";
            this.TxtBoxLog.ReadOnly = true;
            this.TxtBoxLog.Size = new System.Drawing.Size(462, 20);
            this.TxtBoxLog.TabIndex = 13;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Location = new System.Drawing.Point(416, 280);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(55, 29);
            this.BtnRefresh.TabIndex = 14;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 345);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.TxtBoxLog);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.PrgrsBarRemote);
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
        private System.ComponentModel.BackgroundWorker BackWorkerSystemList;
        private System.ComponentModel.BackgroundWorker BackWorkerRemote;
        private System.Windows.Forms.ProgressBar PrgrsBarRemote;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.TextBox TxtBoxLog;
        private System.Windows.Forms.Button BtnRefresh;
    }
}

