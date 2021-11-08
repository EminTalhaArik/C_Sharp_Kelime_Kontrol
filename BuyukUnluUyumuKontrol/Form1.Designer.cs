
namespace BuyukUnluUyumuKontrol
{
    partial class frm_kontrol
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
            this.tbx_kelime = new System.Windows.Forms.TextBox();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.lbox_kalin = new System.Windows.Forms.ListBox();
            this.lbox_ince = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbx_kelime
            // 
            this.tbx_kelime.Location = new System.Drawing.Point(74, 32);
            this.tbx_kelime.Name = "tbx_kelime";
            this.tbx_kelime.Size = new System.Drawing.Size(135, 22);
            this.tbx_kelime.TabIndex = 0;
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.Location = new System.Drawing.Point(6, 32);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(62, 17);
            this.lbl_kelime.TabIndex = 1;
            this.lbl_kelime.Text = "Kelime : ";
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(215, 12);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(127, 62);
            this.btn_kontrol.TabIndex = 2;
            this.btn_kontrol.Text = "Büyük Ünlü Uyumu Kontrol Et";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // lbox_kalin
            // 
            this.lbox_kalin.FormattingEnabled = true;
            this.lbox_kalin.ItemHeight = 16;
            this.lbox_kalin.Location = new System.Drawing.Point(9, 108);
            this.lbox_kalin.Name = "lbox_kalin";
            this.lbox_kalin.Size = new System.Drawing.Size(147, 180);
            this.lbox_kalin.TabIndex = 3;
            // 
            // lbox_ince
            // 
            this.lbox_ince.FormattingEnabled = true;
            this.lbox_ince.ItemHeight = 16;
            this.lbox_ince.Location = new System.Drawing.Point(195, 108);
            this.lbox_ince.Name = "lbox_ince";
            this.lbox_ince.Size = new System.Drawing.Size(147, 180);
            this.lbox_ince.TabIndex = 4;
            // 
            // frm_kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 302);
            this.Controls.Add(this.lbox_ince);
            this.Controls.Add(this.lbox_kalin);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.lbl_kelime);
            this.Controls.Add(this.tbx_kelime);
            this.Name = "frm_kontrol";
            this.Text = "Büyük Ünlü Uyumu Kontrol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_kelime;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.ListBox lbox_kalin;
        private System.Windows.Forms.ListBox lbox_ince;
    }
}

