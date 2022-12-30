using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendocsharpSmtp.Util
{
    public class FunctionUtil
    {
        public void Log(string msg, string Log = "log")
        {
            string nomeArquivo = @".\" + Log + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";

            StreamWriter writer = new StreamWriter(nomeArquivo);

           
            writer.Write("teste\n");

            writer.Close();

        }

      
    }
}
