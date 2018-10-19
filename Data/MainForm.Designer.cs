namespace Data
{
    using Npgsql;

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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("postgres");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ModeTabControl = new System.Windows.Forms.TabControl();
            this.SchemePage = new System.Windows.Forms.TabPage();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.TreeScheme = new System.Windows.Forms.TreeView();
            this.ConsolePage = new System.Windows.Forms.TabPage();
            this.ResultTabControl = new System.Windows.Forms.TabControl();
            this.ResultPage = new System.Windows.Forms.TabPage();
            this.ResultView = new System.Windows.Forms.DataGridView();
            this.PageLog = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.Scintilla = new ScintillaNET.Scintilla();
            this.ModeTabControl.SuspendLayout();
            this.SchemePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.ConsolePage.SuspendLayout();
            this.ResultTabControl.SuspendLayout();
            this.ResultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.PageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeTabControl
            // 
            this.ModeTabControl.Controls.Add(this.SchemePage);
            this.ModeTabControl.Controls.Add(this.ConsolePage);
            this.ModeTabControl.ItemSize = new System.Drawing.Size(60, 25);
            this.ModeTabControl.Location = new System.Drawing.Point(-1, -2);
            this.ModeTabControl.Name = "ModeTabControl";
            this.ModeTabControl.SelectedIndex = 0;
            this.ModeTabControl.Size = new System.Drawing.Size(1007, 537);
            this.ModeTabControl.TabIndex = 0;
            // 
            // SchemePage
            // 
            this.SchemePage.Controls.Add(this.DataView);
            this.SchemePage.Controls.Add(this.TreeScheme);
            this.SchemePage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SchemePage.Location = new System.Drawing.Point(4, 29);
            this.SchemePage.Name = "SchemePage";
            this.SchemePage.Padding = new System.Windows.Forms.Padding(3);
            this.SchemePage.Size = new System.Drawing.Size(999, 504);
            this.SchemePage.TabIndex = 0;
            this.SchemePage.Text = "Схема";
            this.SchemePage.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(233, 3);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(761, 498);
            this.DataView.TabIndex = 1;
            this.DataView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataView_KeyDown);
            // 
            // TreeScheme
            // 
            this.TreeScheme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeScheme.Location = new System.Drawing.Point(3, 3);
            this.TreeScheme.Name = "TreeScheme";
            treeNode1.Name = "schemes";
            treeNode1.Text = "postgres";
            this.TreeScheme.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TreeScheme.PathSeparator = "/";
            this.TreeScheme.Size = new System.Drawing.Size(231, 498);
            this.TreeScheme.TabIndex = 0;
            this.TreeScheme.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SchemeTreeView_AfterSelect);
            this.TreeScheme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeScheme_KeyDown);
            // 
            // ConsolePage
            // 
            this.ConsolePage.Controls.Add(this.ResultTabControl);
            this.ConsolePage.Controls.Add(this.Scintilla);
            this.ConsolePage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsolePage.Location = new System.Drawing.Point(4, 29);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsolePage.Size = new System.Drawing.Size(999, 504);
            this.ConsolePage.TabIndex = 1;
            this.ConsolePage.Text = "Консоль";
            this.ConsolePage.UseVisualStyleBackColor = true;
            // 
            // ResultTabControl
            // 
            this.ResultTabControl.Controls.Add(this.ResultPage);
            this.ResultTabControl.Controls.Add(this.PageLog);
            this.ResultTabControl.Location = new System.Drawing.Point(3, 322);
            this.ResultTabControl.Name = "ResultTabControl";
            this.ResultTabControl.SelectedIndex = 0;
            this.ResultTabControl.Size = new System.Drawing.Size(991, 182);
            this.ResultTabControl.TabIndex = 2;
            // 
            // ResultPage
            // 
            this.ResultPage.Controls.Add(this.ResultView);
            this.ResultPage.Location = new System.Drawing.Point(4, 27);
            this.ResultPage.Name = "ResultPage";
            this.ResultPage.Padding = new System.Windows.Forms.Padding(3);
            this.ResultPage.Size = new System.Drawing.Size(983, 151);
            this.ResultPage.TabIndex = 1;
            this.ResultPage.Text = "Результат";
            this.ResultPage.UseVisualStyleBackColor = true;
            // 
            // ResultView
            // 
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(4, 4);
            this.ResultView.Name = "ResultView";
            this.ResultView.Size = new System.Drawing.Size(973, 144);
            this.ResultView.TabIndex = 0;
            // 
            // PageLog
            // 
            this.PageLog.Controls.Add(this.LogTextBox);
            this.PageLog.Location = new System.Drawing.Point(4, 27);
            this.PageLog.Name = "PageLog";
            this.PageLog.Padding = new System.Windows.Forms.Padding(3);
            this.PageLog.Size = new System.Drawing.Size(983, 151);
            this.PageLog.TabIndex = 0;
            this.PageLog.Text = "Логи";
            this.PageLog.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(3, 6);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(974, 142);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.Text = "";
            // 
            // Scintilla
            // 
            this.Scintilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scintilla.CaretPeriod = 600;
            this.Scintilla.HScrollBar = false;
            this.Scintilla.Location = new System.Drawing.Point(3, 6);
            this.Scintilla.Name = "Scintilla";
            this.Scintilla.Size = new System.Drawing.Size(991, 310);
            this.Scintilla.TabIndex = 0;
            this.Scintilla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 541);
            this.Controls.Add(this.ModeTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1021, 580);
            this.Name = "MainForm";
            this.Text = "Работа с базой";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.ModeTabControl.ResumeLayout(false);
            this.SchemePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ConsolePage.ResumeLayout(false);
            this.ResultTabControl.ResumeLayout(false);
            this.ResultPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.PageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    


        #endregion

        private System.Windows.Forms.TabControl ModeTabControl;
        private System.Windows.Forms.TabPage SchemePage;
        private System.Windows.Forms.TabPage ConsolePage;
        private System.Windows.Forms.TreeView TreeScheme;
        private System.Windows.Forms.DataGridView DataView;
        private ScintillaNET.Scintilla Scintilla;
        private System.Windows.Forms.TabControl ResultTabControl;
        private System.Windows.Forms.TabPage PageLog;
        private System.Windows.Forms.TabPage ResultPage;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.DataGridView ResultView;
    }
}