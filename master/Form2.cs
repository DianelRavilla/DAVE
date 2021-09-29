using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAVE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Cronometro.Enabled = true;
            Cronometro.Interval = 3000;

            if (!File.Exists("License.txt"))
            {
                StreamWriter writer = new StreamWriter("License.txt");
                writer.WriteLine("");
                writer.Close();
            }
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            Cronometro.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            Cronometro.Enabled = true;
            Cronometro.Interval = 3000;
        }
    }
}
