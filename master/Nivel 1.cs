using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAVE
{
    class Nivel_1
    {
        private string mensaje;

        public Nivel_1()
        {
            this.mensaje ="";
        }
        public Nivel_1 (string m)
        {
            this.mensaje = m;
        }
        public string codificar()
        {
            string codigo = "";

            //Convirtiendo a vector
            char[] array = mensaje.ToCharArray();

            //Codificacion de nivel 1
            for(int i = 0; i<mensaje.Length; i++)
            {
                //Para Mayusculas
                if (array[i] == 'A')
                    codigo = codigo + ".,.</?gja)0sc¿|/>.,.";
                else if (array[i] == 'B')
                    codigo = codigo + ".,.</bJcBs/>.,.";
                else if (array[i] == 'C')
                    codigo = codigo + ".,.</KcMdN/>.,.";
                else if (array[i] == 'D')
                    codigo = codigo + ".,.</dJhDs/>.,.";
                else if (array[i] == 'E')
                    codigo = codigo + ".,.</=<D78¡ske)/>.,.";
                else if (array[i] == 'F')
                    codigo = codigo + ".,.</ksmgu/>.,.";
                else if (array[i] == 'G')
                    codigo = codigo + ".,.</Dptsf/>.,.";
                else if (array[i] == 'H')
                    codigo = codigo + ".,.</cvbgs/>.,.";
                else if (array[i] == 'I')
                    codigo = codigo + ".,.</¡ib¡cls!|$/>.,.";
                else if (array[i] == 'J')
                    codigo = codigo + ".,.</hjksk/>.,.";
                else if (array[i] == 'K')
                    codigo = codigo + ".,.</prtyw/>.,.";
                else if (array[i] == 'L')
                    codigo = codigo + ".,.</lpnbv/>.,.";
                else if (array[i] == 'M')
                    codigo = codigo + ".,.</xcdrt/>.,.";
                else if (array[i] == 'N')
                    codigo = codigo + ".,.</mnvyq/>.,.";
                else if (array[i] == 'Ñ')
                    codigo = codigo + ".,.</plñyq/>.,.";
                else if (array[i] == 'O')
                    codigo = codigo + ".,.</CnLrpy&nso/>.,.";
                else if (array[i] == 'P')
                    codigo = codigo + ".,.</jlwrñ/>.,.";
                else if (array[i] == 'Q')
                    codigo = codigo + ".,.</zxmnj/>.,.";
                else if (array[i] == 'R')
                    codigo = codigo + ".,.</plñmn/>.,.";
                else if (array[i] == 'S')
                    codigo = codigo + ".,.</mnrtp/>.,.";
                else if (array[i] == 'T')
                    codigo = codigo + ".,.</qrtyp/>.,.";
                else if (array[i] == 'U')
                    codigo = codigo + ".,.</cJjusKlMdN/>.,.";
                else if (array[i] == 'V')
                    codigo = codigo + ".,.</nbpzx/>.,.";
                else if (array[i] == 'W')
                    codigo = codigo + ".,.</pñlzx/>.,.";
                else if (array[i] == 'X')
                    codigo = codigo + ".,.</mlkpy/>.,.";
                else if (array[i] == 'Y')
                    codigo = codigo + ".,.</dvTyZ/>.,.";
                else if (array[i] == 'Z')
                    codigo = codigo + ".,.</dJiDs/>.,.";

                //Para Minusculas
                else if (array[i] == 'a')
                    codigo = codigo + ".,.</?gja)0sc¿|/>.,-";
                else if (array[i] == 'b')
                    codigo = codigo + ".,.</bJcBs/>.,-";
                else if (array[i] == 'c')
                    codigo = codigo + ".,.</KcMdN/>.,-";
                else if (array[i] == 'd')
                    codigo = codigo + ".,.</dJhDs/>.,-";
                else if (array[i] == 'e')
                    codigo = codigo + ".,.</=<D78¡ske)/>.,-";
                else if (array[i] == 'f')
                    codigo = codigo + ".,.</ksmgu/>.,-";
                else if (array[i] == 'g')
                    codigo = codigo + ".,.</Dptsf/>.,-";
                else if (array[i] == 'h')
                    codigo = codigo + ".,.</cvbgs/>.,-";
                else if (array[i] == 'i')
                    codigo = codigo + ".,.</¡ib¡cls!|$/>.,-";
                else if (array[i] == 'j')
                    codigo = codigo + ".,.</hjksk/>.,-";
                else if (array[i] == 'k')
                    codigo = codigo + ".,.</prtyw/>.,-";
                else if (array[i] == 'l')
                    codigo = codigo + ".,.</lpnbv/>.,-";
                else if (array[i] == 'm')
                    codigo = codigo + ".,.</xcdrt/>.,-";
                else if (array[i] == 'n')
                    codigo = codigo + ".,.</mnvyq/>.,-";
                else if (array[i] == 'ñ')
                    codigo = codigo + ".,.</plñyq/>.,-";
                else if (array[i] == 'o')
                    codigo = codigo + ".,.</CnLrpy&nso/>.,-";
                else if (array[i] == 'p')
                    codigo = codigo + ".,.</jlwrñ/>.,-";
                else if (array[i] == 'q')
                    codigo = codigo + ".,.</zxmnj/>.,-";
                else if (array[i] == 'r')
                    codigo = codigo + ".,.</plñmn/>.,-";
                else if (array[i] == 's')
                    codigo = codigo + ".,.</mnrtp/>.,-";
                else if (array[i] == 't')
                    codigo = codigo + ".,.</qrtyp/>.,-";
                else if (array[i] == 'u')
                    codigo = codigo + ".,.</cJjusKlMdN/>.,-";
                else if (array[i] == 'v')
                    codigo = codigo + ".,.</nbpzx/>.,-";
                else if (array[i] == 'w')
                    codigo = codigo + ".,.</pñlzx/>.,-";
                else if (array[i] == 'x')
                    codigo = codigo + ".,.</mlkpy/>.,-";
                else if (array[i] == 'y')
                    codigo = codigo + ".,.</dvTyZ/>.,-";
                else if (array[i] == 'z')
                    codigo = codigo + ".,.</dJiDs/>.,-";

                //Para numeros
                else if (array[i] == '0')
                    codigo = codigo + "/NuM%@rez/";
                else if (array[i] == '1')
                    codigo = codigo + "/NuM%@eno/";
                else if (array[i] == '2')
                    codigo = codigo + "/NuM%@owt/";
                else if (array[i] == '3')
                    codigo = codigo + "/NuM%@rht/";
                else if (array[i] == '4')
                    codigo = codigo + "/NuM%@uof/";
                else if (array[i] == '5')
                    codigo = codigo + "/NuM%@vif/";
                else if (array[i] == '6')
                    codigo = codigo + "/NuM%@xis/";
                else if (array[i] == '7')
                    codigo = codigo + "/NuM%@ves/";
                else if (array[i] == '8')
                    codigo = codigo + "/NuM%@gie/";
                else if (array[i] == '9')
                    codigo = codigo + "/NuM%@nin/";

                //Espacio
                else if (array[i] == ' ')
                    codigo = codigo + "</1fJoSr182c/>";

                //Culaquier otro caracter
                else
                    codigo = codigo + "";
            }

            return codigo;
        }
        public string decodificar(string cod)
        {
            //Decodificacion de nivel 1
            for (int i = 0; i < cod.Length; i++)
            {
                //Para Mayusculas
                cod = cod.Replace(".,.</?gja)0sc¿|/>.,.","A");
                cod = cod.Replace(".,.</bJcBs/>.,.","B");
                cod = cod.Replace(".,.</KcMdN/>.,.","C");
                cod = cod.Replace(".,.</dJhDs/>.,.","D");
                cod = cod.Replace(".,.</=<D78¡ske)/>.,.","E");
                cod = cod.Replace(".,.</ksmgu/>.,.","F");
                cod = cod.Replace(".,.</Dptsf/>.,.","G");
                cod = cod.Replace(".,.</cvbgs/>.,.","H");
                cod = cod.Replace(".,.</¡ib¡cls!|$/>.,.","I");
                cod = cod.Replace(".,.</hjksk/>.,.","J");
                cod = cod.Replace(".,.</prtyw/>.,.","K");
                cod = cod.Replace(".,.</lpnbv/>.,.","L");
                cod = cod.Replace(".,.</xcdrt/>.,.","M");
                cod = cod.Replace(".,.</mnvyq/>.,.","N");
                cod = cod.Replace(".,.</plñyq/>.,.","Ñ");
                cod = cod.Replace(".,.</CnLrpy&nso/>.,.","O");
                cod = cod.Replace(".,.</jlwrñ/>.,.","P");
                cod = cod.Replace(".,.</zxmnj/>.,.","Q");
                cod = cod.Replace(".,.</plñmn/>.,.","R");
                cod = cod.Replace(".,.</mnrtp/>.,.","S");
                cod = cod.Replace(".,.</qrtyp/>.,.","T");
                cod = cod.Replace(".,.</cJjusKlMdN/>.,.","U"); 
                cod = cod.Replace(".,.</nbpzx/>.,.","V");
                cod = cod.Replace(".,.</pñlzx/>.,.","W");
                cod = cod.Replace(".,.</mlkpy/>.,.","X");
                cod = cod.Replace(".,.</dvTyZ/>.,.","Y");
                cod = cod.Replace(".,.</dJiDs/>.,.","Z");


                //Para Minusculas
                cod = cod.Replace(".,.</?gja)0sc¿|/>.,-", "a");
                cod = cod.Replace(".,.</bJcBs/>.,-", "b");
                cod = cod.Replace(".,.</KcMdN/>.,-", "c");
                cod = cod.Replace(".,.</dJhDs/>.,-", "d");
                cod = cod.Replace(".,.</=<D78¡ske)/>.,-", "e");
                cod = cod.Replace(".,.</ksmgu/>.,-", "f");
                cod = cod.Replace(".,.</Dptsf/>.,-", "g");
                cod = cod.Replace(".,.</cvbgs/>.,-", "h");
                cod = cod.Replace(".,.</¡ib¡cls!|$/>.,-", "i");
                cod = cod.Replace(".,.</hjksk/>.,-", "j");
                cod = cod.Replace(".,.</prtyw/>.,-", "k");
                cod = cod.Replace(".,.</lpnbv/>.,-", "l");
                cod = cod.Replace(".,.</xcdrt/>.,-", "m");
                cod = cod.Replace(".,.</mnvyq/>.,-", "n");
                cod = cod.Replace(".,.</plñyq/>.,-", "ñ");
                cod = cod.Replace(".,.</CnLrpy&nso/>.,-", "o");
                cod = cod.Replace(".,.</jlwrñ/>.,-", "p");
                cod = cod.Replace(".,.</zxmnj/>.,-", "q");
                cod = cod.Replace(".,.</plñmn/>.,-", "r");
                cod = cod.Replace(".,.</mnrtp/>.,-", "s");
                cod = cod.Replace(".,.</qrtyp/>.,-", "t");
                cod = cod.Replace(".,.</cJjusKlMdN/>.,-", "u");
                cod = cod.Replace(".,.</nbpzx/>.,-", "v");
                cod = cod.Replace(".,.</pñlzx/>.,-", "w");
                cod = cod.Replace(".,.</mlkpy/>.,-", "x");
                cod = cod.Replace(".,.</dvTyZ/>.,-", "y");
                cod = cod.Replace(".,.</dJiDs/>.,-", "z");

                //Para numeros
                cod = cod.Replace("/NuM%@rez/","0");
                cod = cod.Replace("/NuM%@eno/","1");
                cod = cod.Replace("/NuM%@owt/","2");
                cod = cod.Replace("/NuM%@rht/","3");
                cod = cod.Replace("/NuM%@uof/","4");
                cod = cod.Replace("/NuM%@vif/","5");
                cod = cod.Replace("/NuM%@xis/","6");
                cod = cod.Replace("/NuM%@ves/","7");
                cod = cod.Replace("/NuM%@gie/","8");
                cod = cod.Replace("/NuM%@nin/","9");

                //Espacio
                cod = cod.Replace("</1fJoSr182c/>", " ");
            }

            return cod;
        }
    }
}
