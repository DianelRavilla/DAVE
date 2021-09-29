using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAVE
{
    public partial class Suite_Activation : Form
    {
        public Suite_Activation()
        {
            InitializeComponent();
        }

        private void BtnREGISTRAR_Click(object sender, EventArgs e)
        {
            string registro = txtLLAVEDEREGISTRO.Text.Replace("-","");
            string usuario = txtUsuario.Text;

            int error = 0;
            int bandera = 0;
            if (registro == "DRSEAETDVGES0706EIRUITEXGGAESGOBGPAALED2508")
            {
                bandera = 1;
            }
            else
            {
                error = 1;
            }
            if (txtUsuario.Text == "")
            {
                error = 2;
            }

            if (bandera == 1 && error == 0)
            {
                MessageBox.Show("Registro Exitoso, Gracias por adquirir DAVE " + usuario);
                string ruta = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string cadena = "--_-&%$i7yIUvis9q8wueoasd09w_ÑO(w9e:;M)&" + registro + "asd0ijnCpasy7UHW)RUHsdjihP)/" + usuario;
                File.WriteAllText("License.txt", cadena);
                txtLLAVEDEREGISTRO.Clear();
                this.Close();
            }
            else
            {
                switch (error)
                {
                    case 1:
                        {
                            MessageBox.Show("Llave de registro Invalida");
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Ingresa tu nombre de Usuario");
                            break;
                        }
                }
            }           
        }

        private void BtnCloseSuiteActivation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
