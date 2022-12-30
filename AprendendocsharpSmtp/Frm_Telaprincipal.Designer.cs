namespace AprendendocsharpSmtp
{
    partial class Frm_Telaprincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRement = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserSMTP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassSMTP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail Destino:";
            // 
            // txtRement
            // 
            this.txtRement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRement.Location = new System.Drawing.Point(130, 57);
            this.txtRement.Name = "txtRement";
            this.txtRement.Size = new System.Drawing.Size(189, 23);
            this.txtRement.TabIndex = 1;
            // 
            // txtSMTP
            // 
            this.txtSMTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSMTP.Location = new System.Drawing.Point(375, 63);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(171, 23);
            this.txtSMTP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SMTP:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssunto.Location = new System.Drawing.Point(130, 111);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(189, 23);
            this.txtAssunto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assunto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMSG
            // 
            this.txtMSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSG.Location = new System.Drawing.Point(130, 176);
            this.txtMSG.Multiline = true;
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.Size = new System.Drawing.Size(183, 128);
            this.txtMSG.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensagem:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(183, 339);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorta.Location = new System.Drawing.Point(375, 111);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(61, 23);
            this.txtPorta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Porta:";
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(461, 112);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(44, 19);
            this.checkBoxSSL.TabIndex = 11;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario:";
            // 
            // txtUserSMTP
            // 
            this.txtUserSMTP.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserSMTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserSMTP.Location = new System.Drawing.Point(375, 193);
            this.txtUserSMTP.Name = "txtUserSMTP";
            this.txtUserSMTP.Size = new System.Drawing.Size(152, 23);
            this.txtUserSMTP.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Senha:";
            // 
            // txtPassSMTP
            // 
            this.txtPassSMTP.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassSMTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassSMTP.Location = new System.Drawing.Point(375, 234);
            this.txtPassSMTP.Name = "txtPassSMTP";
            this.txtPassSMTP.Size = new System.Drawing.Size(152, 23);
            this.txtPassSMTP.TabIndex = 15;
            this.txtPassSMTP.UseSystemPasswordChar = true;
            // 
            // Frm_Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassSMTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserSMTP);
            this.Controls.Add(this.checkBoxSSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMSG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSMTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPorta);
            this.Name = "Frm_Telaprincipal";
            this.ShowIcon = false;
            this.Text = "Validador SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRement;
        private TextBox txtSMTP;
        private Label label2;
        private TextBox txtAssunto;
        private Label label3;
        private TextBox txtMSG;
        private Label label4;
        private Button btnEnviar;
        private TextBox txtPorta;
        private Label label5;
        private CheckBox checkBoxSSL;
        private Label label6;
        private TextBox txtUserSMTP;
        private Label label7;
        private TextBox txtPassSMTP;
    }
}