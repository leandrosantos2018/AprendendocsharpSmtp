using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.IO;
using AprendendocsharpSmtp.Util;

namespace AprendendocsharpSmtp
{
    public partial class Frm_Telaprincipal : Form
    {
        FunctionUtil log = new FunctionUtil();

        public Frm_Telaprincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient SmtpServer = new SmtpClient();
                MailMessage mail = new MailMessage();
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtUserSMTP.Text, txtPassSMTP.Text);
                SmtpServer.Host = txtSMTP.Text;
                SmtpServer.Port = Convert.ToInt32(txtPorta.Text);

                if (checkBoxSSL.Checked == true)
                    SmtpServer.EnableSsl = true;
                else
                    SmtpServer.EnableSsl = false;

                // SmtpServer.EnableSsl = False
                mail.From = new MailAddress(txtUserSMTP.Text);
                mail.To.Add(txtRement.Text);
                mail.Subject = txtAssunto.Text;
                mail.Body = txtMSG.Text;
                // SmtpServer.UseDefaultCredentials = True


                SmtpServer.Send(mail);
                Interaction.MsgBox("E-mail enviado com sucesso", MsgBoxStyle.Information, "Mensagem");

                log.Log("email enviado por " + txtRement.Text, "E-mail enviado!!");


            }


            catch (SmtpException ex)
            {

                log.Log(ex.ToString(), "Erro");
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Servidor não esta Respondendo");
            }


            catch (ArgumentException ex)
            {

                log.Log(ex.ToString(), "Erro");

                if (txtUserSMTP.Text == "")
                    Interaction.MsgBox(@"Favor informa usuario \n" + ex.ToString());

                if (txtPassSMTP.Text == "")
                    Interaction.MsgBox(@"Favor informa a Senha \n" + ex.ToString());
            }



            catch (Exception ex)
            {

                log.Log(ex.ToString(), "Erro");
                Interaction.MsgBox("Erro Genérioco favor entra em contato com Dev");
            }
        }

    }
}

