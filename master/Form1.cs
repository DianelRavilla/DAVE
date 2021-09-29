using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Security.AccessControl;
using Microsoft.Win32;
using System.Media;
using System.Drawing;
using NAudio.Wave; // for sound card access
using NAudio.Dsp; // for fft
using System.Drawing.Imaging; // for ImageLockMode
using System.Runtime.InteropServices; // for Marshal
using System.Threading;

namespace DAVE
{
    public partial class Form1 : Form
    {
        Validacion v = new Validacion();
        Codigo code;
        string CODE;            //Variable que almacena el codigo base
        int SUITE;              //Habilitacion SUITE      
        SoundPlayer errorSound = new SoundPlayer("Sound\\error1.wav");

        public Form1()
        {
            InitializeComponent();
            InicializarImagen();

            //Inicializacion de componentes
            gbxGenerar.Visible = false;
            gbxLeer.Visible = false;
            gbxMotor.Visible = false;
            btnCrearCodigo.Enabled = false;
            btnDescifrarCodigo.Enabled = false;
            btnReproducir.Enabled = false;
            cbxNivel.SelectedIndex = 0;
            labelUSUARIO.Visible = false;

            //Componentes de motor
            pictureBoxVENTANA.Visible = false;
            pic_level_back.Visible = false;
            pic_level_front.Visible = false;

            //SUITE
            pictureBoxPRO.Visible = false;

            //VERIFICANDO SUITE MODE
            REGISTRAR_SUITE();
        }
        public void InicializarImagen()
        {
            Cronometro.Enabled = true;
            Cronometro.Interval = 1300;
            pictureBox2.Image = Image.FromFile("Wallpaper1.gif"); //IMPORTANTE
        }
        public void InicializarImagenMotor()
        {
            Cronometro2.Enabled = true;
            Cronometro2.Interval = 800;
            pictureBoxMOTOR.Image = Image.FromFile("AnimacionMotor.gif"); //IMPORTANTE
        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            pictureBox2.Enabled = false;
            Cronometro.Stop();
            this.DialogResult = DialogResult.OK;
        }
        private void Cronometro2_Tick(object sender, EventArgs e)
        {
            pictureBoxMOTOR.Enabled = false;
            Cronometro2.Stop();
            this.DialogResult = DialogResult.OK;
        }

        int a = 1;  //Boton Generar
        int b = 1;  //Boton Leer
        int c = 1;  //Boton Motor
        //BOTON GENERAR//////////////////////////////////////////////////////////
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            gbxLeer.Visible = false;
            gbxMotor.Visible = false;
            if (a == 1)
            {
                gbxGenerar.Visible = true;
                a = 0;
            }
            else
            {
                gbxGenerar.Visible = false;
                a = 1;
            }
            c = 1;
            b = 1;
        }
        //BOTON LEER//////////////////////////////////////////////////////////
        private void BtnLeer_Click(object sender, EventArgs e)
        {
            gbxGenerar.Visible = false;
            gbxMotor.Visible = false;
            if (b == 1)
            {
                gbxLeer.Visible = true;
                b = 0;
            }
            else
            {
                gbxLeer.Visible = false;
                b = 1;
            }
            c = 1;
            a = 1;
        }
        //BOTON MOTOR//////////////////////////////////////////////////////////
        private void BtnMotor_Click(object sender, EventArgs e)
        {
            //Componentes de motor
            pictureBoxVENTANA.Visible = false;
            gbxQRSS.Visible = false;
            pic_level_back.Visible = false;
            pic_level_front.Visible = false;

            if (SUITE == 1)
            {
                pictureBoxMOTOR.Enabled = true;
                InicializarImagenMotor();
                gbxGenerar.Visible = false;
                gbxLeer.Visible = false;
                if (c == 1)
                {
                    gbxMotor.Visible = true;
                    c = 0;
                }
                else
                {
                    gbxMotor.Visible = false;
                    c = 1;
                }
                a = 1;
                b = 1;
            }
            else
            {
                MessageBox.Show("Debes Adquirir el Modo SUITE");
            }
        }

        //VALIDACIONES_VALIDACIONES_VALIDACIONES_VALIDACIONES_VALIDACIONES_VALIDACIONES_
        //Valiacion cbxNivel
        private void cbxNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        private void cbxNivel_Click(object sender, EventArgs e)
        {
            //Restablecimiento de la barra de carga
            progressBar1.Step = -100;
            progressBar1.PerformStep();
            if (txtMensaje.Text != "")
            {
                btnCrearCodigo.Enabled = true;
            }
        }
        //Validacion cbxNivel2
        private void cbxNivel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        private void cbxNivel2_Click(object sender, EventArgs e)
        {
            //Restablecimiento de la barra de carga
            progressBar2.Step = -100;
            progressBar2.PerformStep();
            if (txtRuta2.Text != "")
            {
                btnDescifrarCodigo.Enabled = true;
            }
        }
        //Validacion txtCodigo
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        //Validacion txtCodigo2
        private void txtCodigo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        //Validacion LstMensaje
        private void LstMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        //Validacion txtMensaje & boton Generar Codigo
        private void txtMensaje_Click(object sender, EventArgs e)
        {
            //Restablecimiento de la barra de carga
            progressBar1.Step = -100;
            progressBar1.PerformStep();

            if (txtMensaje.Text != "")
            {
                btnCrearCodigo.Enabled = true;
            }
        }
        private void txtMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCrearCodigo.Enabled = true;
        }
        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "")
            {
                btnCrearCodigo.Enabled = false;
            }
            else
            {
                btnCrearCodigo.Enabled = true;
            }
        }
        //Validacion txtRuta2 & boton Descifrar Codigo
        private void TxtRuta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restablecimiento de la barra de carga
            progressBar2.Step = -100;
            progressBar2.PerformStep();

            if (txtRuta2.Text != "")
            {
                btnDescifrarCodigo.Enabled = true;
            }

        }


        //CASOS PARA ENCRIPTACION
        public int casoEncriptacion;
        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNivel.Text == "1")
            {
                casoEncriptacion = 1;
            }
            if (cbxNivel.Text == "2")
            {
                casoEncriptacion = 2;
            }        
        }

        //ERRORES
        public int errores()
        {
            if (cbxNivel.Text == "")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int errores2()
        {
            if (txtCodigo2.Text == "")
            {
                return 1;
            }
            if (txtRuta2.Text == "")
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        //BOTON GENERAR CODIGO/////////////////////////////////////////////////////////////
        private void btnCrearCodigo_Click(object sender, EventArgs e)
        {
            int error = errores();  //Bandera de errores
            string mensaje = null;  //Variable que almacena el mensaje          

            //Validacion Boton Generar Codigo
            if (txtMensaje.Text == "" || cbxNivel.Text == "")
            {
                btnCrearCodigo.Enabled = false;
            }
            else
            {
                btnCrearCodigo.Enabled = true;
            }

            //Carga de la barra de progeso
            if (txtMensaje.Text != "" && cbxNivel.Text != "")
            {
                progressBar1.Step = 100;
                progressBar1.PerformStep();
            }

            //Lectura del mensaje
            mensaje = txtMensaje.Text;

            //Integridad de la generacion de codigo
            if (error == 0) //Sin errores
            {
                code = new Codigo(casoEncriptacion, mensaje);

                //Almacenamiento del codigo base
                CODE = code.Codificar();
                txtCodigo.Text = code.Previsualizar(CODE);

            }
            else if (error == 1)
            {
                errorSound.Play();
                MessageBox.Show("Debes seleccionar al menos un nivel");
            }
            else
            {
                errorSound.Play();
                MessageBox.Show("Error Indefinido. Vuele a intentarlo");
            }

            btnCrearCodigo.Enabled = false;
            txtRuta.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            int bandera = 0;
            string ruta = null;

            if (SUITE == 0)
            {
                sfd.Filter = "Archivo txt (*.txt)|*.txt|Archivo rtf (*.rtf)|*.rtf";
            }
            if (SUITE == 1)
            {
                sfd.Filter = "Archivo txt (*.txt)|*.txt|Archivo rtf (*.rtf)|*.rtf|Archivo DAVE (*.dave)|*.dave";
            }
            sfd.Title = "Generar";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ruta = sfd.FileName;
                txtRuta.Text = "Ruta: " + ruta;
                bandera = 1;
            }
            sfd.Dispose();

            try
            {
                if (bandera == 1) //RUTA CORRECTA!
                {
                    string linea = CODE;
                    using (StreamWriter outputFile = new StreamWriter(ruta))
                    {
                        outputFile.WriteLine(linea);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR: El archivo esta siendo ocupado en la instancia de DAVE");
            }
        }

        //BOTON LEER CODIGO////////////////////////////////////////////////////////////////////
        private void btnCargarCodigo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            int bandera = 0;
            string ruta = null;

            //Progress bar2
            progressBar1.Step = -100;
            progressBar1.PerformStep();

            if (SUITE == 0)
            {
                ofd.Filter = "Archivo txt (*.txt)|*.txt|Archivo rtf (*.rtf)|*.rtf";
            }
            if (SUITE == 1)
            {
                ofd.Filter = "Archivo txt (*.txt)|*.txt|Archivo rtf (*.rtf)|*.rtf|Archivo DAVE (*.dave)|*.dave";
            }
            ofd.Title = "Abrir";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;
                txtRuta2.Text = ruta;
                bandera = 1;
            }
            ofd.Dispose();

            if (bandera == 1) //RUTA CORRECTA!
            {
                string linea;
                using (StreamReader inputFile = new StreamReader(ruta))
                {
                    linea = inputFile.ReadLine();
                    if (!linea.Contains("////////////////////DAVE/////////////////Code_Form"))
                    {
                        errorSound.Play();
                        MessageBox.Show("Este no es un archivo enriptado por DAVE");
                    }
                    else
                    {
                        if (SUITE == 1)
                        {
                            linea = linea.Replace("SUITE_V1.0<<REGISTERED>>:", "");
                            linea = linea.Replace("////////////////////DAVE/////////////////Code_Form", "");
                            txtCodigo2.Text = linea;
                        }
                        else
                        {
                            if (linea.Contains("SUITE_V1.0<<REGISTERED>>"))
                            {
                                errorSound.Play();
                                MessageBox.Show("Este archivo solo se puede abrir con la version SUITE de DAVE");
                            }
                            else
                            {
                                linea = linea.Replace("////////////////////DAVE/////////////////Code_Form", "");
                                txtCodigo2.Text = linea;
                            }
                        }
                    }

                }
            }

            btnDescifrarCodigo.Enabled = true;
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            int error = errores2();  //Bandera de errores        

            //Validacion de Boton
            if (txtCodigo2.Text == "")
            {
                btnDescifrarCodigo.Enabled = false;
            }
            else
            {
                btnDescifrarCodigo.Enabled = true;
            }

            //Progress bar2
            progressBar2.Step = 100;
            progressBar2.PerformStep();

            //Diferenciacion de casos
            string ruta;
            ruta = txtRuta2.Text.Replace("Ruta: ", "");
            string cadena = File.ReadAllText(ruta);

            int casoDes = 0;
            if (cadena.Contains("////////////////////DAVE/////////////////Code_Form:::1:::"))
            {
                casoDes = 1;
                cadena = cadena.Replace("////////////////////DAVE/////////////////Code_Form:::1:::", "");
            }
            if (cadena.Contains("////////////////////DAVE/////////////////Code_Form:::2:::"))
            {
                casoDes = 2;
                cadena = cadena.Replace("////////////////////DAVE/////////////////Code_Form:::2:::", "");
            }         
            if (casoDes != 0)
            {
                MessageBox.Show("Nivel Identificado: " + casoDes);
            }
            else
            {
                errorSound.Play();
                MessageBox.Show("Incapaz de Identificar, Archivo Corrompido");
            }
            //Integridad de la generacion de codigo
            if (error == 0) //Sin errores
            {
                code = new Codigo(casoDes, cadena);
                txtMensaje2.Text = code.Decodificar(casoDes, cadena);
            }
            if (error == 1)
            {
                errorSound.Play();
                MessageBox.Show("El campo CODIGO esta vacio");
            }
            if (error == 2)
            {
                errorSound.Play();
                MessageBox.Show("Ruta invalida");
            }

            txtRuta2.Clear();
            btnDescifrarCodigo.Enabled = false;
        }

        private void BtnGuardarMensaje_Click(object sender, EventArgs e)
        {
            if (txtMensaje2.Text == "")
            {
                btnGuardarMensaje.Enabled = false;
            }
            else
            {
                btnGuardarMensaje.Enabled = true;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            int bandera = 0;
            string ruta = null;

            if (SUITE == 0)
            {
                sfd.Filter = "Archivo txt (*.txt)|*.txt|Archivo rtf (*.rtf)|*.rtf";
            }
            if (SUITE == 1)
            {
                sfd.Filter = "Archivo txt (*.txt)|*.txt|Archivo rtf (*.rtf)|*.rtf|Archivo DAVE (*.dave)|*.dave";
            }
            sfd.Title = "Generar";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ruta = sfd.FileName;
                MessageBox.Show("Archivo Guardado Correctamente en: " + ruta);
                bandera = 1;
            }
            sfd.Dispose();

            if (bandera == 1) //RUTA CORRECTA!
            {
                CODE = txtMensaje2.Text;
                string linea = CODE;
                using (StreamWriter outputFile = new StreamWriter(ruta))
                {
                    outputFile.WriteLine(linea);
                }
            }
        }

        //BOTON SUITE MODE
        public void BtnSuite_Click(object sender, EventArgs e)
        {
            Suite_Activation SU = new Suite_Activation();
            SU.ShowDialog();

            Reiniciar();
            REGISTRAR_SUITE();
        }

        //LIMPIEZA DE ELEMENTOS
        private void btnLimpiarCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
        }
        private void btnLimpiarCodigo2_Click(object sender, EventArgs e)
        {
            txtCodigo2.Clear();
        }
        private void btnLimpiarMensaje_Click(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            progressBar1.Step = -100;
            progressBar1.PerformStep();
        }
        private void BtnLimpiarMensaje2_Click(object sender, EventArgs e)
        {
            txtMensaje2.Clear();
            progressBar2.Step = -100;
            progressBar2.PerformStep();
        }
        //BOTON REINCIAR/////////////////////////////////////////////////////////////////////////////////
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        public void Reiniciar()
        {
            gbxGenerar.Visible = false;
            gbxLeer.Visible = false;
            gbxMotor.Visible = false;
            pictureBox2.Enabled = true;
            a = 1;
            b = 1;
            c = 1;
            InicializarImagen();

            txtCodigo.Text = "";
            txtCodigo2.Text = "";
            txtMensaje.Text = "";
            txtMensaje2.Text = "";
            txtRuta.Text = "";
            txtRuta2.Text = "";
        }

        //REGISTRAR EXTENSION UNICA DEL ARCHIVO EN EL SISTEMA
        private void REGISTRAR_SUITE()
        {
            //VERIFICANDO SUITE MODE
            StreamReader obj = new StreamReader("License.txt");
            string LICENSIA = obj.ReadLine();

            if (LICENSIA == null)
            {
                SUITE = 0;
            }
            else
            {
                if (LICENSIA.Contains("--_-&%$i7yIUvis9q8wueoasd09w_ÑO(w9e:;M)&DRSEAETDVGES0706EIRUITEXGGAESGOBGPAALED2508asd0ijnCpasy7UHW)RUHsdjihP)/"))
                {
                    SUITE = 1;
                    btnSuite.Visible = false;
                    pictureBoxPRO.Visible = true;
                    pictureBox1.Visible = false;
                    string usuario = LICENSIA.Replace("--_-&%$i7yIUvis9q8wueoasd09w_ÑO(w9e:;M)&DRSEAETDVGES0706EIRUITEXGGAESGOBGPAALED2508asd0ijnCpasy7UHW)RUHsdjihP)/", "");
                    labelUSUARIO.Visible = true;
                    labelUSUARIO.Text = "Registrado a nombre de: " + usuario;
                }
            }

            if (SUITE == 1)
            {
                REGISTRAR_SUITE_EXTENSION();
            }
        }
        private void REGISTRAR_SUITE_EXTENSION()
        {
            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            //Añadiendo permisos para editar el registro
            RegistrySecurity rs = new RegistrySecurity();
            RegistryAccessRule rar = new RegistryAccessRule(user, RegistryRights.FullControl,
                InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None, AccessControlType.Allow);

            rs.AddAccessRule(rar);

            //Añadiendo registro de extension
            RegistryKey clave1 = Registry.CurrentUser.OpenSubKey("Software", true);
            clave1.CreateSubKey("Classes");
            clave1 = clave1.OpenSubKey("Classes", true);

            //Creando Extension de archivo
            clave1.CreateSubKey(".dave");
            clave1 = clave1.OpenSubKey(".dave", true);
            clave1.SetValue("", "archivo.dave");

            clave1.Close();

            ////////////////////////////////////////////////////////////////////////
            RegistryKey clave2 = Registry.CurrentUser.OpenSubKey("Software", true);
            clave2.CreateSubKey("Classes");
            clave2 = clave2.OpenSubKey("Classes", true);

            clave2.CreateSubKey("archivo.dave");
            clave2 = clave2.OpenSubKey("archivo.dave", true);
            clave2.SetValue("", "Archivo Encriptado DAVE");

            clave2.CreateSubKey("DefaultIcon");
            clave2 = clave2.OpenSubKey("DefaultIcon", true);
            clave2.SetValue("", Application.StartupPath + "\\Ext.ico");

            clave2.Close();

            ////////////////////////////////////////////////////////////////////////
            RegistryKey clave3 = Registry.CurrentUser.OpenSubKey("Software", true);
            clave3.CreateSubKey("Classes");
            clave3 = clave3.OpenSubKey("Classes", true);

            clave3.CreateSubKey("archivo.dave");
            clave3 = clave3.OpenSubKey("archivo.dave", true);
            clave3.SetValue("", "Archivo Encriptado DAVE");

            clave3.CreateSubKey("shell");
            clave3 = clave3.OpenSubKey("shell", true);

            clave3.CreateSubKey("open");
            clave3 = clave3.OpenSubKey("open", true);

            clave3.CreateSubKey("command");
            clave3 = clave3.OpenSubKey("command", true);
            clave3.SetValue("", "\"" + Application.StartupPath + "\\DAVE.exe\" \"%1\"");

            clave3.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.CommandLine.Contains("\" \""))
            {               
                string ruta = Environment.CommandLine.Split(new char[] { '"' })[3];               
                gbxLeer.Visible = true;

                txtCodigo2.Text = File.ReadAllText(ruta);
            }
        }

        public string INTERPRETAR;
        private void BtnCargarMotor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            int bandera = 0;

            ofd.Filter = "Archivo DAVE (*.dave)|*.dave";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                INTERPRETAR = ofd.FileName;
                bandera = 1;
            }
            ofd.Dispose();

            if (bandera == 1) //INTERPRETAR CORRECTA!
            {
                string linea;
                using (StreamReader inputFile = new StreamReader(INTERPRETAR))
                {
                    linea = inputFile.ReadLine();
                    if (linea.Contains("////////////////////DAVE/////////////////Code_Form"))
                    {
                        MessageBox.Show("Archivo Correcto");
                        linea = linea.Replace("////////////////////DAVE/////////////////Code_Form", "");
                        linea = linea.Replace(".,.</", "");
                        linea = linea.Replace("/>.,.", "");
                        linea = linea.Replace("/>.,-", "");
                        linea = linea.Replace("/", "");
                        txtCodigo3.Text = linea;

                    }
                    else if (linea.Contains("SUITE_V1.0<<REGISTERED>>:///DAVE/////////////////Code_Form"))
                    {
                        MessageBox.Show("Archivo Correcto");
                        linea = linea.Replace("SUITE_V1.0<<REGISTERED>>:///DAVE/////////////////Code_Form", "");
                        linea = linea.Replace(".,.</", "");
                        linea = linea.Replace("/>.,.", "");
                        linea = linea.Replace("/>.,-", "");
                        linea = linea.Replace("/", "");
                        txtCodigo3.Text = linea;
                    }
                    else
                    {
                        errorSound.Play();
                        MessageBox.Show("Este no es un archivo enriptado por DAVE");
                    }
                }
            }
            if (txtCodigo3.Text != "")
            {
                btnReproducir.Enabled = true;
            }
            else
            {
                btnReproducir.Enabled = false;
            }

            IniciarVisualizador();
            //Componentes de motor
            pictureBoxVENTANA.Visible = true;
            gbxQRSS.Visible = true;
            pic_level_front.Visible = true;
            pic_level_back.Visible = true;
        }

        private void TxtCodigo3_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo3.Text == "")
            {
                btnReproducir.Enabled = false;
            }
            else
            {
                btnReproducir.Enabled = true;
            }
        }

        private void BtnReproducir_Click(object sender, EventArgs e)
        {           
            StreamReader inputFile = new StreamReader(INTERPRETAR);
            string cadena = inputFile.ReadLine();

            int casoDes = 0;
            if (cadena.Contains("////////////////////DAVE/////////////////Code_Form:::1:::"))
            {
                casoDes = 1;
                cadena = cadena.Replace("////////////////////DAVE/////////////////Code_Form:::1:::", "");
            }
            if (cadena.Contains("////////////////////DAVE/////////////////Code_Form:::2:::"))
            {
                casoDes = 2;
                cadena = cadena.Replace("////////////////////DAVE/////////////////Code_Form:::2:::", "");
            }          
            if (casoDes != 0)
            {
                MessageBox.Show("Nivel Identificado: " + casoDes);
            }
            else
            {
                errorSound.Play();
                MessageBox.Show("Incapaz de Identificar, Archivo Corrompido");
            }          

            code = new Codigo(casoDes, cadena);
            string mensaje = code.Decodificar(casoDes, cadena);
            txtCodigo3.Text = mensaje;

            ReproducirMensaje(mensaje);           
        }

        public void ReproducirMensaje(string mensaje)
        {
            char[] vec = new char[mensaje.Length-1];
            vec = mensaje.ToCharArray();          
            Reproductor rep;

            for (int i=0; i<mensaje.Length; i++)
            {               
                rep = new Reproductor(vec[i]);
                int times = 3;
                while(times > 0)
                {
                    Application.DoEvents();
                    Thread.Sleep(200);
                    times--;
                }
            }
        }

        public void IniciarVisualizador()
        {
            // MIS MODIFICACIONES
            nud_fft_size.Text = "10";
            nud_fft_step_ms.Text = "9";
            cmb_colormap.Text = "blue";
            nud_spec_width.Text = "575";

            // Llenar el ComboBox con los dispositivos de audio disponibles
            combo_device.Items.Clear();
            int device_number = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < device_number; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                combo_device.Items.Add(deviceInfo.ProductName);
            }
            if (combo_device.Items.Count > 0) combo_device.SelectedIndex = 0;
            else MessageBox.Show("ERROR: No hay dispositivos de grabacion disponibles");
            combo_rate.SelectedIndex = 0;

            // Llenar el resto de los datos graficos de usuario GUI
            gui_calculations_update();
        }

        //INICIAR Y PARAR GRABACION
        public static WaveIn waveIn;
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            gui_calculations_update();

            if (buttonStart.Text == "start")
            {
                // INCIANDO GRABACION
                // Cambio de datos en el GUI
                buttonStart.Text = "stop";
                captured_buffers = 0;
                combo_device.Enabled = false;
                combo_rate.Enabled = false;
                nud_buffer_size.Enabled = false;
                nud_fft_size.Enabled = false;
                nud_fft_step_ms.Enabled = false;
                nud_spec_width.Enabled = false;

                // limpiar e iniciar la transmision entrante de audio
                unanalyzed_audio = new List<short>();

                // pre-carga de las variables importantes
                audio_rate = int.Parse(combo_rate.Text);

                // Iniciar el dispositivo de grabacion
                waveIn = new WaveIn();
                waveIn.DataAvailable += Audio_buffer_captured;
                waveIn.DeviceNumber = 0;
                waveIn.WaveFormat = new WaveFormat(audio_rate, 1);
                waveIn.BufferMilliseconds = audio_buffer_ms;
                waveIn.StartRecording();

                // inicar el auto-analysis timer
                timer1.Enabled = true;
            }
            else
            {
                // FINALIZANDO GRABACION
                // parar el dispositivo de grabacion
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;

                // Cambio de datos en el GUI
                timer1.Enabled = false;
                buttonStart.Text = "start";
                combo_device.Enabled = true;
                combo_rate.Enabled = true;
                nud_buffer_size.Enabled = true;
                nud_fft_size.Enabled = true;
                nud_fft_step_ms.Enabled = true;
                nud_spec_width.Enabled = true;
                pic_level_front.Height = pic_level_back.Height;
            }
        }

        public int captured_buffers;
        public int audio_peak_value;
        List<short> unanalyzed_audio;

        private void Audio_buffer_captured(object sender, WaveInEventArgs args)
        {
            try
            {
                // añadir el audio nuevo a la creciente lista de audio sin analizar
                for (int i = 0; i < args.BytesRecorded; i += 2)
                {
                    unanalyzed_audio.Add((short)((args.Buffer[i + 1] << 8) | args.Buffer[i + 0]));
                }

                // calcular envolvente (valor pico)
                int buffer_points = args.Buffer.Length / 2;
                List<short> recent_audio = unanalyzed_audio.GetRange(unanalyzed_audio.Count - buffer_points, buffer_points);
                int current_peak = recent_audio.Max();
                audio_peak_value = Math.Max(audio_peak_value, current_peak);

                // actualizar la GUI
                captured_buffers += 1;
                lbl_buffers_captured.Text = captured_buffers.ToString();

                // El medidor de nivel de audio es un poco divertido. Es un fondo rojo con un primer plano gris de cambio de tamaño.
                lbl_unanalyzed_sec.Text = string.Format("{0:F}", unanalyzed_audio.Count / (double)audio_rate);
                pic_level_front.Height = pic_level_back.Height - (int)(pic_level_back.Height * ((double)current_peak) / (double)audio_peak_value);
            }
            catch
            {
                MessageBox.Show("Estabilizando...");
            }

        }


        //BITMAP ROUTINES       
        private static List<List<double>> spec_data; // una lista de valores de píxeles de columna

        private void Data_init()
        {
            // llenar "datos" con datos aleatorios 2D
            spec_data = new List<List<double>>();
            for (int x = 0; x < spectrograph_width_px; x++)
            {
                List<double> column = new List<double>();
                for (int y = 0; y < spectrograph_height_px; y++)
                {
                    column.Add(0);
                }
                spec_data.Add(column);
            }
            System.Console.WriteLine("SPEC DATA: {0} x {1}", spec_data.Count, spec_data[0].Count);
        }

        public void Update_bitmap_with_data()
        {
            // crear un mapa de bits con el que trabajaremos
            Bitmap bitmap = new Bitmap(spec_data.Count, spec_data[0].Count, PixelFormat.Format8bppIndexed);

            // modificar el mapa de color indexado
            switch (cmb_colormap.Text)
            {
                case "gray":
                    bitmap.Palette = pallette_gray(bitmap.Palette);
                    break;
                case "blue":
                    bitmap.Palette = pallette_blue(bitmap.Palette);
                    break;
                case "green":
                    bitmap.Palette = pallette_green(bitmap.Palette);
                    break;
                case "spectrum":
                    bitmap.Palette = pallette_spectrum(bitmap.Palette);
                    break;
                default:
                    bitmap.Palette = pallette_blue(bitmap.Palette);
                    break;
            }

            // prepararse para acceder a los datos a través del objeto bitmapdata
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                                    ImageLockMode.ReadOnly, bitmap.PixelFormat);

            // crear un vector de bytes para reflejar cada píxel en la imagen
            byte[] pixels = new byte[bitmapData.Stride * bitmap.Height];

            // llenar el vector de píxeles con datos
            for (int col = 0; col < spec_data.Count; col++)
            {
                // Seleccioné esto manualmente para obtener un número que "se veía bien"
                double scaleFactor = (double)nud_scale_factor.Value;

                for (int row = 0; row < spec_data[col].Count; row++)
                {
                    int bytePosition = row * bitmapData.Stride + col;
                    double pixelVal = spec_data[col][row] * scaleFactor;
                    pixelVal = Math.Max(0, pixelVal);
                    pixelVal = Math.Min(255, pixelVal);
                    pixels[bytePosition] = (byte)(pixelVal);
                }
            }

            // convertir el vector de bytes en un mapa de bits
            Marshal.Copy(pixels, 0, bitmapData.Scan0, pixels.Length);
            bitmap.UnlockBits(bitmapData);

            // aplicar el mapa de bits al cuadro de imagen
            pictureBoxVENTANA.Image = bitmap;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.FileName = "capture.bmp";
            d.ShowDialog();
            pictureBoxVENTANA.Image.Save(d.FileName);
        }

        // MAPAS DE COLOR PERSONALIZADOS
        ColorPalette pallette_gray(ColorPalette pal)
        {
            for (int i = 0; i < 256; i++)
                pal.Entries[i] = Color.FromArgb(255, i, i, i);
            return pal;
        }
        ColorPalette pallette_blue(ColorPalette pal)
        {
            for (int i = 0; i < 256; i++)
            {
                int rampFirst = Math.Min(255, (i * 2));
                int rampLast = Math.Max(0, (i - 128) * 2);
                pal.Entries[i] = Color.FromArgb(255, rampLast, i, rampFirst);
            }
            return pal;
        }
        ColorPalette pallette_green(ColorPalette pal)
        {
            for (int i = 0; i < 256; i++)
            {
                int rampFirst = Math.Min(255, (i * 2));
                int rampLast = Math.Max(0, (i - 128) * 2);
                pal.Entries[i] = Color.FromArgb(255, rampLast, rampFirst, i);
            }
            return pal;
        }
        ColorPalette pallette_spectrum(ColorPalette pal)
        {
            int r, g, b;
            for (int i = 0; i < 256; i++)
            {
                r = i * 4 - 128 * 4;
                b = 128 * 2 - i * 4;
                g = i * 4;
                if (i > 128) g = 256 * 4 - g;

                r = Math.Max(0, Math.Min(255, r));
                g = Math.Max(0, Math.Min(255, g));
                b = Math.Max(0, Math.Min(255, b));
                pal.Entries[i] = Color.FromArgb(255, r, g, b);
            }
            return pal;
        }

        // ANÁLISIS AUTOMÁTICO DE DATOS NO ANALIZADOS
        private void Analyze_audio_chunks()
        {
            while (unanalyzed_audio.Count() > fft_size)
            {
                Analyze_audio_chunk();
            }
        }

        private void Analyze_audio_chunk()
        {
            if (unanalyzed_audio.Count() < fft_size) return;

            // hacer la FFT en la primera parte de los datos de audio no analizados
            Complex[] fft_buffer = new Complex[fft_size];
            for (int i = 0; i < fft_size; i++)
            {
                fft_buffer[i].X = (float)(unanalyzed_audio[i] * FastFourierTransform.HammingWindow(i, fft_size));
                fft_buffer[i].Y = 0;
            }
            FastFourierTransform.FFT(true, (int)Math.Log(fft_size, 2.0), fft_buffer);

            //una lista con valores FFT
            List<double> new_data = new List<double>();
            for (int i = fft_size / 2; i > 0; i--)
            {
                double val;
                val = (double)fft_buffer[i].X + (double)fft_buffer[i].Y; // sqrt(X^2+Y^2)?
                val = Math.Abs(val);
                if (cb_logscale.Checked) val = Math.Log(val);
                new_data.Add(val);
            }

            // incluir estos datos FFT en el extremo derecho de los datos
            spec_data.RemoveAt(0);
            spec_data.Add(new_data);

            // eliminar algo de audio del búfer no analizado
            unanalyzed_audio.RemoveRange(0, fft_step_size);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            System.Console.WriteLine("TICK {0}", captured_buffers);
            Analyze_audio_chunks();
            Update_bitmap_with_data();
        }

        // francine estuvo aqui <3
        // INTERFAZ MATEMÁTICA DE USUARIO Y VALOR VERIFICACIÓN
        private int audio_rate;
        private int audio_buffer_ms;

        private static int buffer_size_points;
        private static int fft_size;
        private static int fft_step_size;
        private static int spectrograph_height_px;
        private static int spectrograph_width_px;
        private static double spectrograph_resolution;

        private void Nud_buffer_size_ValueChanged(object sender, EventArgs e)
        {
            gui_calculations_update();
            if (Convert.ToInt32(nud_buffer_size.Text) > 99)
            {
                nud_buffer_size.Text = "100";
            }
            if (Convert.ToInt32(nud_buffer_size.Text) < 1)
            {
                nud_buffer_size.Text = "1";
            }
        }
        private void Combo_rate_SelectedIndexChanged(object sender, EventArgs e) { gui_calculations_update(); }
        private void Nud_fft_size_ValueChanged(object sender, EventArgs e)
        {
            gui_calculations_update();
            if (Convert.ToInt32(nud_fft_size.Text) > 11)
            {
                nud_fft_size.Text = "100";
            }
            if (Convert.ToInt32(nud_fft_size.Text) < 9)
            {
                nud_fft_size.Text = "1";
            }
        }
        private void Nud_fft_step_ms_ValueChanged(object sender, EventArgs e) { gui_calculations_update(); }
        private void Nud_spec_width_ValueChanged(object sender, EventArgs e) { gui_calculations_update(); }

        // cambiar la grabación de audio y la configuración de FFT
        private void gui_calculations_update()
        {
            // frecuencia de muestreo
            audio_rate = int.Parse(combo_rate.Text);

            // tamaño del búfer
            audio_buffer_ms = (int)nud_buffer_size.Value;
            buffer_size_points = (int)((double)audio_buffer_ms / 1000.0 * audio_rate);
            lbl_buffer_size_points.Text = string.Format("{0} points", buffer_size_points);

            // tamaño fft
            fft_size = (int)Math.Pow(2, (int)nud_fft_size.Value);
            lbl_fft_size.Text = string.Format("{0} points", fft_size.ToString());

            // pasoS fft
            fft_step_size = (int)((double)nud_fft_step_ms.Value / 1000.0 * audio_rate);
            lbl_fft_step_ms.Text = string.Format("{0} points", fft_step_size.ToString());

            // ancho del espectrógrafo
            spectrograph_width_px = (int)nud_spec_width.Value;

            // estadísticas sobre el espectrógrafo
            lbl_peak_freq.Text = string.Format("{0:##,###} Hz", (((double)audio_rate) / 2));
            spectrograph_height_px = fft_size / 2;
            spectrograph_resolution = (double)audio_rate / (double)spectrograph_height_px;
            lbl_resolution.Text = string.Format("{0:n2} Hz / px", spectrograph_resolution);
            lbl_spec_size.Text = string.Format("{0} px", spectrograph_height_px);
            lbl_spec_width_time.Text = string.Format("{0:n2} sec", (double)nud_fft_step_ms.Value / 1000.0 * spectrograph_width_px);

            // arreglar el cuadro de imagen
            pictureBoxVENTANA.Width = spectrograph_width_px;
            pictureBoxVENTANA.Height = spectrograph_height_px;

            // selección de mapa de colores
            if (cmb_colormap.Text == "") cmb_colormap.SelectedIndex = 0;

            // llenar cuadro de imagen con espacio en blanco
            Data_init();
        }
        private void TxtCodigo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        private void Combo_device_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        private void Combo_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        private void Cmb_colormap_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NoSePuedeEscribir(e);
        }
        private void Sonido_Tick(object sender, EventArgs e)
        {
            Sonido.Stop();
        }
    }   
}