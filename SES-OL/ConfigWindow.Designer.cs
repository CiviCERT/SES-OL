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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigWindow));
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
            resources.ApplyResources(this.tablePanel, "tablePanel");
            this.tablePanel.Controls.Add(this.nameLabel, 0, 0);
            this.tablePanel.Controls.Add(this.viaLabel, 0, 1);
            this.tablePanel.Controls.Add(this.toLabel, 0, 2);
            this.tablePanel.Controls.Add(this.authTokenLabel, 0, 3);
            this.tablePanel.Controls.Add(this.nameBox, 1, 0);
            this.tablePanel.Controls.Add(this.viaBox, 1, 1);
            this.tablePanel.Controls.Add(this.toBox, 1, 2);
            this.tablePanel.Controls.Add(this.authTokenBox, 1, 3);
            this.tablePanel.Name = "tablePanel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // viaLabel
            // 
            resources.ApplyResources(this.viaLabel, "viaLabel");
            this.viaLabel.Name = "viaLabel";
            // 
            // toLabel
            // 
            resources.ApplyResources(this.toLabel, "toLabel");
            this.toLabel.Name = "toLabel";
            // 
            // authTokenLabel
            // 
            resources.ApplyResources(this.authTokenLabel, "authTokenLabel");
            this.authTokenLabel.Name = "authTokenLabel";
            // 
            // nameBox
            // 
            resources.ApplyResources(this.nameBox, "nameBox");
            this.nameBox.Name = "nameBox";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // viaBox
            // 
            resources.ApplyResources(this.viaBox, "viaBox");
            this.viaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viaBox.FormattingEnabled = true;
            this.viaBox.Items.AddRange(new object[] {
            resources.GetString("viaBox.Items"),
            resources.GetString("viaBox.Items1")});
            this.viaBox.Name = "viaBox";
            // 
            // toBox
            // 
            resources.ApplyResources(this.toBox, "toBox");
            this.toBox.Name = "toBox";
            this.toBox.TextChanged += new System.EventHandler(this.toBox_TextChanged);
            // 
            // authTokenBox
            // 
            resources.ApplyResources(this.authTokenBox, "authTokenBox");
            this.authTokenBox.Name = "authTokenBox";
            this.authTokenBox.TextChanged += new System.EventHandler(this.authTokenBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfigWindow
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigWindow";
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