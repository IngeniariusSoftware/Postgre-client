namespace Data
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LabelDatabase = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.HostLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.DataBaseTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.EyeIcon = new System.Windows.Forms.PictureBox();
            this.LampIcon = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(226, 164);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(90, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(229, 32);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(111, 18);
            this.UserLabel.TabIndex = 10;
            this.UserLabel.Text = "Пользователь";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(229, 91);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 18);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LabelDatabase
            // 
            this.LabelDatabase.AutoSize = true;
            this.LabelDatabase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDatabase.Location = new System.Drawing.Point(38, 91);
            this.LabelDatabase.Name = "LabelDatabase";
            this.LabelDatabase.Size = new System.Drawing.Size(101, 18);
            this.LabelDatabase.TabIndex = 10;
            this.LabelDatabase.Text = "База данных";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLabel.Location = new System.Drawing.Point(38, 146);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(44, 18);
            this.PortLabel.TabIndex = 7;
            this.PortLabel.Text = "Порт";
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HostLabel.Location = new System.Drawing.Point(38, 32);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(43, 18);
            this.HostLabel.TabIndex = 8;
            this.HostLabel.Text = "Хост";
            // 
            // UserTextBox
            // 
            this.UserTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "postgres"});
            this.UserTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UserTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UserTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTextBox.Location = new System.Drawing.Point(226, 53);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(150, 23);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.UserTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // DataBaseTextBox
            // 
            this.DataBaseTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "postgres"});
            this.DataBaseTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DataBaseTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DataBaseTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataBaseTextBox.Location = new System.Drawing.Point(35, 112);
            this.DataBaseTextBox.Name = "DataBaseTextBox";
            this.DataBaseTextBox.Size = new System.Drawing.Size(150, 23);
            this.DataBaseTextBox.TabIndex = 1;
            this.DataBaseTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.DataBaseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(226, 112);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(150, 23);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // PortTextBox
            // 
            this.PortTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "5432"});
            this.PortTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PortTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PortTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortTextBox.Location = new System.Drawing.Point(35, 167);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(150, 23);
            this.PortTextBox.TabIndex = 5;
            this.PortTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.PortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 231);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(436, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // HostTextBox
            // 
            this.HostTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost"});
            this.HostTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.HostTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.HostTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HostTextBox.Location = new System.Drawing.Point(35, 53);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(150, 23);
            this.HostTextBox.TabIndex = 0;
            this.HostTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.HostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // EyeIcon
            // 
            this.EyeIcon.Image = global::Data.Properties.Resources.CloseEye;
            this.EyeIcon.Location = new System.Drawing.Point(383, 107);
            this.EyeIcon.Name = "EyeIcon";
            this.EyeIcon.Size = new System.Drawing.Size(32, 32);
            this.EyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EyeIcon.TabIndex = 18;
            this.EyeIcon.TabStop = false;
            this.EyeIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EyeIcon_MouseClick);
            // 
            // LampIcon
            // 
            this.LampIcon.Image = global::Data.Properties.Resources.LampOff;
            this.LampIcon.Location = new System.Drawing.Point(332, 152);
            this.LampIcon.Name = "LampIcon";
            this.LampIcon.Size = new System.Drawing.Size(32, 32);
            this.LampIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LampIcon.TabIndex = 3;
            this.LampIcon.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 253);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EyeIcon);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.DataBaseTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.HostLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.LabelDatabase);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LampIcon);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(452, 292);
            this.MinimumSize = new System.Drawing.Size(452, 292);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox LampIcon;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LabelDatabase;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox DataBaseTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.PictureBox EyeIcon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Timer UpdateTimer;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
    }
}

