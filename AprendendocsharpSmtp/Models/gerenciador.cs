using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendocsharpSmtp.Models
{
    public partial class gerenciador : Form
    {
        Thread nt;

        public gerenciador()
        {
            

            InitializeComponent();
        }

        private void validadorSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoform1);

            nt.Start();

        }

        private void novoform1(object? obj)
        {
            Application.Run(new Frm_Telaprincipal());
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0\n\n" + "Autor: Leandro Santos\n\n" + "Data: 30/12/2022"  );
        }

        private void validadorFTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implement");
        }
    }
}
