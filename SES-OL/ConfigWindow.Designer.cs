namespace SES_OL
{
    partial class ConfigWindow
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

        public string SiteName
        {
            get
            {
                return nameBox.Text;
            }
            set
            {
                nameBox.Text = value;
            }
        }

        public int Method
        {
            get
            {
                return viaBox.SelectedIndex;
            }
            set
            {
                viaBox.SelectedIndex = value;
            }
        }

        public string Destination
        {
            get
            {
                return toBox.Text;
            }
            set
            {
                toBox.Text = value;
            }
        }

        public string AuthToken
        {
            get
            {
                return authTokenBox.Text;
            }
            set
            {
                authTokenBox.Text = value;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.viaLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.authTokenLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.viaBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.authTokenBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Controls.Add(this.nameLabel, 0, 0);
            this.tablePanel.Controls.Add(this.viaLabel, 0, 1);
            this.tablePanel.Controls.Add(this.toLabel, 0, 2);
            this.tablePanel.Controls.Add(this.authTokenLabel, 0, 3);
            this.tablePanel.Controls.Add(this.nameBox, 1, 0);
            this.tablePanel.Controls.Add(this.viaBox, 1, 1);
            this.tablePanel.Controls.Add(this.toBox, 1, 2);
            this.tablePanel.Controls.Add(this.authTokenBox, 1, 3);
            this.tablePanel.Location = new System.Drawing.Point(12, 12);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 4;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePanel.Size = new System.Drawing.Size(597, 216);
            this.tablePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(147, 43);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viaLabel
            // 
            this.viaLabel.AutoSize = true;
            this.viaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viaLabel.Location = new System.Drawing.Point(3, 43);
            this.viaLabel.Name = "viaLabel";
            this.viaLabel.Size = new System.Drawing.Size(147, 43);
            this.viaLabel.TabIndex = 1;
            this.viaLabel.Text = "Submit via";
            this.viaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Location = new System.Drawing.Point(3, 86);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(147, 43);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "Submit to";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authTokenLabel
            // 
            this.authTokenLabel.AutoSize = true;
            this.authTokenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authTokenLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.authTokenLabel.Location = new System.Drawing.Point(3, 138);
            this.authTokenLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.authTokenLabel.Name = "authTokenLabel";
            this.authTokenLabel.Size = new System.Drawing.Size(147, 78);
            this.authTokenLabel.TabIndex = 3;
            this.authTokenLabel.Text = "Authorization token";
            // 
            // nameBox
            // 
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameBox.Location = new System.Drawing.Point(153, 5);
            this.nameBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(444, 26);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // viaBox
            // 
            this.viaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viaBox.FormattingEnabled = true;
            this.viaBox.Items.AddRange(new object[] {
            "Email",
            "Web form"});
            this.viaBox.Location = new System.Drawing.Point(153, 48);
            this.viaBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.viaBox.Name = "viaBox";
            this.viaBox.Size = new System.Drawing.Size(444, 28);
            this.viaBox.TabIndex = 2;
            // 
            // toBox
            // 
            this.toBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toBox.Location = new System.Drawing.Point(153, 91);
            this.toBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(444, 26);
            this.toBox.TabIndex = 3;
            this.toBox.TextChanged += new System.EventHandler(this.toBox_TextChanged);
            // 
            // authTokenBox
            // 
            this.authTokenBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.authTokenBox.Location = new System.Drawing.Point(153, 134);
            this.authTokenBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.authTokenBox.Name = "authTokenBox";
            this.authTokenBox.Size = new System.Drawing.Size(444, 26);
            this.authTokenBox.TabIndex = 4;
            this.authTokenBox.TextChanged += new System.EventHandler(this.authTokenBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(509, 257);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 33);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(403, 257);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 33);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfigWindow
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(623, 307);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigWindow";
            this.Text = "SES Configuration";
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label viaLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label authTokenLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox viaBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox authTokenBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}