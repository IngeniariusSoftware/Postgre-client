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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Таблицы");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Представления");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Процедуры");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Схема", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabsCotrol = new System.Windows.Forms.TabControl();
            this.SchemePage = new System.Windows.Forms.TabPage();
            this.SchemeTreeView = new System.Windows.Forms.TreeView();
            this.ConsolePage = new System.Windows.Forms.TabPage();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.TabsCotrol.SuspendLayout();
            this.SchemePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
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
            this.TabsCotrol.Size = new System.Drawing.Size(1008, 537);
            this.TabsCotrol.TabIndex = 0;
            // 
            // SchemePage
            // 
            this.SchemePage.Controls.Add(this.DataView);
            this.SchemePage.Controls.Add(this.SchemeTreeView);
            this.SchemePage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SchemePage.Location = new System.Drawing.Point(4, 29);
            this.SchemePage.Name = "SchemePage";
            this.SchemePage.Padding = new System.Windows.Forms.Padding(3);
            this.SchemePage.Size = new System.Drawing.Size(1000, 504);
            this.SchemePage.TabIndex = 0;
            this.SchemePage.Text = "Схема";
            this.SchemePage.UseVisualStyleBackColor = true;
            // 
            // SchemeTreeView
            // 
            this.SchemeTreeView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SchemeTreeView.Location = new System.Drawing.Point(3, 3);
            this.SchemeTreeView.Name = "SchemeTreeView";
            treeNode1.Name = "SchemeTables";
            treeNode1.Text = "Таблицы";
            treeNode2.Name = "SchemeViews";
            treeNode2.Text = "Представления";
            treeNode3.Name = "SchemeProcedures";
            treeNode3.Text = "Процедуры";
            treeNode4.Name = "TreeScheme";
            treeNode4.Text = "Схема";
            this.SchemeTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.SchemeTreeView.Size = new System.Drawing.Size(231, 498);
            this.SchemeTreeView.TabIndex = 0;
            this.SchemeTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SchemeTreeView_MouseClick);
            // 
            // ConsolePage
            // 
            this.ConsolePage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsolePage.Location = new System.Drawing.Point(4, 29);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsolePage.Size = new System.Drawing.Size(1000, 504);
            this.ConsolePage.TabIndex = 1;
            this.ConsolePage.Text = "Консоль";
            this.ConsolePage.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(233, 3);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(761, 498);
            this.DataView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 534);
            this.Controls.Add(this.TabsCotrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Работа с базой";
            this.TabsCotrol.ResumeLayout(false);
            this.SchemePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }
    


        #endregion

        private System.Windows.Forms.TabControl TabsCotrol;
        private System.Windows.Forms.TabPage SchemePage;
        private System.Windows.Forms.TabPage ConsolePage;
        private System.Windows.Forms.TreeView SchemeTreeView;
        private System.Windows.Forms.DataGridView DataView;
    }
}