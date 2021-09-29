using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAVE
{
    class Codigo
    {
        private int caso;
        private string mensaje;
        private string codigo;
        private string mensajeDescifrado;
        private Nivel_1 lv1;
        private Nivel_2 lv2;
      
        public Codigo()
        {
            this.caso = 0;
            this.mensaje = "";
        }
        public Codigo(int c, string m)
        {
            this.caso = c;
            this.mensaje = m;
        }

        public string Codificar()
        {
            if (caso == 1)
            {
                lv1 = new Nivel_1(mensaje);
                codigo = lv1.codificar();
                return "////////////////////DAVE/////////////////Code_Form:::1:::" + codigo;
            }
            if (caso == 2)
            {
                lv2 = new Nivel_2(mensaje);
                codigo = lv2.codificar();
                return "////////////////////DAVE/////////////////Code_Form:::2:::" + codigo;;
            }          
            else
            {
                codigo = "Error de Codificacion";
                return codigo;
            }
        }

        public string Previsualizar(string c)
        {
            c = c.Replace("////////////////////DAVE/////////////////Code_Form:::1:::", "");
            c = c.Replace("////////////////////DAVE/////////////////Code_Form:::2:::", "");
            c = c.Replace("////////////////////DAVE/////////////////Code_Form:::3:::", "");
            c = c.Replace(".,.</", "");
            c = c.Replace("/>.,.", "");
            c = c.Replace("/>.,-", "");
            c = c.Replace(")-", "");
            c = c.Replace("-(", "");
            c = c.Replace("/", "");
            return c;
        }

        public string Decodificar(int caso, string codigo)
        {
            if (caso == 1)
            {
                lv1 = new Nivel_1();
                mensajeDescifrado = lv1.decodificar(codigo);
                return mensajeDescifrado;
            }
            if (caso == 2)
            {
                lv2 = new Nivel_2();
                mensajeDescifrado = lv2.decodificar(codigo);
                return mensajeDescifrado;
            }
            else
            {
                mensajeDescifrado = "Error de Decodificacion";
                return mensajeDescifrado;
            }
        }
    }
}
