using Microsoft.VisualBasic;
using System.Threading;
namespace AprendendocsharpSmtp
{
    public partial class Login : Form
    {
        Thread? nt;
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuarioL.Text =="admin" && txtSenhaL.Text == "admin")
            {
                this.Close();
                nt = new Thread(novoform);
               
                nt.Start();

            }
            else if (txtUsuarioL.Text == "" && txtSenhaL.Text == "")
            {
                MessageBox.Show("Favor informa usuario ou Senha!!");
            }
            else
            {
                MessageBox.Show("Acesso negado Usuario ou senha invalido");
            }
        }

        private void novoform()
        {
            Application.Run(new Frm_Telaprincipal());
        }
    }
}