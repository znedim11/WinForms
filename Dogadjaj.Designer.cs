namespace WinForms
{
    partial class Dogadjaj
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
            this.btnSMSSalji = new System.Windows.Forms.Button();
            this.cbBHTelecom = new System.Windows.Forms.CheckBox();
            this.cbEronet = new System.Windows.Forms.CheckBox();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSMSSalji
            // 
            this.btnSMSSalji.Location = new System.Drawing.Point(172, 25);
            this.btnSMSSalji.Name = "btnSMSSalji";
            this.btnSMSSalji.Size = new System.Drawing.Size(75, 43);
            this.btnSMSSalji.TabIndex = 0;
            this.btnSMSSalji.Text = "Salji SMS";
            this.btnSMSSalji.UseVisualStyleBackColor = true;
            this.btnSMSSalji.Click += new System.EventHandler(this.btnSMSSalji_Click);
            // 
            // cbBHTelecom
            // 
            this.cbBHTelecom.AutoSize = true;
            this.cbBHTelecom.Location = new System.Drawing.Point(21, 51);
            this.cbBHTelecom.Name = "cbBHTelecom";
            this.cbBHTelecom.Size = new System.Drawing.Size(82, 17);
            this.cbBHTelecom.TabIndex = 1;
            this.cbBHTelecom.Text = "BHTelecom";
            this.cbBHTelecom.UseVisualStyleBackColor = true;
            this.cbBHTelecom.CheckedChanged += new System.EventHandler(this.cbBHTelecom_CheckedChanged);
            // 
            // cbEronet
            // 
            this.cbEronet.AutoSize = true;
            this.cbEronet.Location = new System.Drawing.Point(109, 51);
            this.cbEronet.Name = "cbEronet";
            this.cbEronet.Size = new System.Drawing.Size(57, 17);
            this.cbEronet.TabIndex = 2;
            this.cbEronet.Text = "Eronet";
            this.cbEronet.UseVisualStyleBackColor = true;
            this.cbEronet.CheckedChanged += new System.EventHandler(this.cbEronet_CheckedChanged);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(21, 25);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(145, 20);
            this.txtPoruka.TabIndex = 3;
            this.txtPoruka.TextChanged += new System.EventHandler(this.txtPoruka_TextChanged);
            // 
            // Dogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 86);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.cbEronet);
            this.Controls.Add(this.cbBHTelecom);
            this.Controls.Add(this.btnSMSSalji);
            this.Name = "Dogadjaj";
            this.Text = "Dogadjaj";
            this.Load += new System.EventHandler(this.Dogadjaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSMSSalji;
        private System.Windows.Forms.CheckBox cbBHTelecom;
        private System.Windows.Forms.CheckBox cbEronet;
        private System.Windows.Forms.TextBox txtPoruka;
    }
}