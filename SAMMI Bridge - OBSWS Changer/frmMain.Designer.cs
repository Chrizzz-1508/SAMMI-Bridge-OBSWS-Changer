namespace SAMMI_Bridge___OBSWS_Changer
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBridge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBridge = new System.Windows.Forms.TextBox();
            this.cbOBSWS = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBridge
            // 
            this.btnBridge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBridge.Location = new System.Drawing.Point(624, 12);
            this.btnBridge.Name = "btnBridge";
            this.btnBridge.Size = new System.Drawing.Size(96, 41);
            this.btnBridge.TabIndex = 0;
            this.btnBridge.Text = "...";
            this.btnBridge.UseVisualStyleBackColor = true;
            this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAMMI Bridge";
            // 
            // txtBridge
            // 
            this.txtBridge.Enabled = false;
            this.txtBridge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBridge.Location = new System.Drawing.Point(240, 12);
            this.txtBridge.Name = "txtBridge";
            this.txtBridge.Size = new System.Drawing.Size(368, 41);
            this.txtBridge.TabIndex = 2;
            this.txtBridge.TextChanged += new System.EventHandler(this.txtBridge_TextChanged);
            // 
            // cbOBSWS
            // 
            this.cbOBSWS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOBSWS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOBSWS.FormattingEnabled = true;
            this.cbOBSWS.Items.AddRange(new object[] {
            "4.9.1",
            "5.0.0+"});
            this.cbOBSWS.Location = new System.Drawing.Point(330, 68);
            this.cbOBSWS.Name = "cbOBSWS";
            this.cbOBSWS.Size = new System.Drawing.Size(278, 41);
            this.cbOBSWS.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(624, 68);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(96, 41);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Save";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Websocket Version";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbOBSWS);
            this.Controls.Add(this.txtBridge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBridge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SAMMI Bridge Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBridge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBridge;
        private System.Windows.Forms.ComboBox cbOBSWS;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
    }
}

