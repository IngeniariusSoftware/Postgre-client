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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("postgres");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabsCotrol = new System.Windows.Forms.TabControl();
            this.SchemePage = new System.Windows.Forms.TabPage();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.TreeScheme = new System.Windows.Forms.TreeView();
            this.ConsolePage = new System.Windows.Forms.TabPage();
            this.Scintilla = new ScintillaNET.Scintilla();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageLog = new System.Windows.Forms.TabPage();
            this.ResultPage = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultView = new System.Windows.Forms.DataGridView();
            this.TabsCotrol.SuspendLayout();
            this.SchemePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.ConsolePage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PageLog.SuspendLayout();
            this.ResultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabsCotrol
            // 
            this.TabsCotrol.Controls.Add(this.SchemePage);
            this.TabsCotrol.Controls.Add(this.ConsolePage);
            this.TabsCotrol.ItemSize = new System.Drawing.Size(60, 25);
            this.TabsCotrol.Location = new System.Drawing.Point(-1, -2);
            this.TabsCotrol.Name = "TabsCotrol";
            this.TabsCotrol.SelectedIndex = 0;
            this.TabsCotrol.Size = new System.Drawing.Size(1007, 537);
            this.TabsCotrol.TabIndex = 0;
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
            this.TreeScheme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SchemeTreeView_MouseClick);
            // 
            // ConsolePage
            // 
            this.ConsolePage.Controls.Add(this.tabControl1);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageLog);
            this.tabControl1.Controls.Add(this.ResultPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 322);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 182);
            this.tabControl1.TabIndex = 2;
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
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(3, 6);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(974, 142);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.Text = "";
            // 
            // ResultView
            // 
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(4, 4);
            this.ResultView.Name = "ResultView";
            this.ResultView.Size = new System.Drawing.Size(973, 144);
            this.ResultView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 541);
            this.Controls.Add(this.TabsCotrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1021, 580);
            this.Name = "MainForm";
            this.Text = "Работа с базой";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.TabsCotrol.ResumeLayout(false);
            this.SchemePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ConsolePage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.PageLog.ResumeLayout(false);
            this.ResultPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.ResumeLayout(false);

        }
    


        #endregion

        private System.Windows.Forms.TabControl TabsCotrol;
        private System.Windows.Forms.TabPage SchemePage;
        private System.Windows.Forms.TabPage ConsolePage;
        private System.Windows.Forms.TreeView TreeScheme;
        private System.Windows.Forms.DataGridView DataView;
        private ScintillaNET.Scintilla Scintilla;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageLog;
        private System.Windows.Forms.TabPage ResultPage;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.DataGridView ResultView;
    }
}