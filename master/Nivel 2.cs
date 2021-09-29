using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAVE
{
    class Nivel_2
    {
        private string mensaje;
        Random s = new Random();

        public Nivel_2()
        {
            this.mensaje = "";
        }
        public Nivel_2(string m)
        {
            this.mensaje = m;
        }
        public string codificar()
        {
            string codigo = "";

            //Convirtiendo a vector
            char[] array = mensaje.ToCharArray();
            int variacion;
            string linea;

            //Codificacion de nivel 1
            for (int i = 0; i < mensaje.Length; i++)
            {
                //Para Vocales MAYUSCULAS
                if (array[i] == 'A')
                {
                    variacion = s.Next(0,2);
                    linea = ".,.</?gja)0sc¿|/>.,.";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'E')
                {
                    variacion = s.Next(3,5);
                    linea = ".,.</=<D78¡ske)/>.,.";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'I')
                {
                    variacion = s.Next(6, 8);
                    linea = ".,.</¡ib¡cls!|$/>.,.";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'O')
                {
                    variacion = s.Next(9, 11);
                    linea = ".,.</CnLrpy&nso/>.,.";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'U')
                {
                    variacion = s.Next(12, 14);
                    linea = ".,.</cJjusKlMdN/>.,.";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }

                //Para VOcales minusculas
                if (array[i] == 'a')
                {
                    variacion = s.Next(0, 2);
                    linea = ".,.</?gja)0sc¿|/>.,-";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'e')
                {
                    variacion = s.Next(3, 5);
                    linea = ".,.</=<D78¡ske)/>.,-";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'i')
                {
                    variacion = s.Next(6, 8);
                    linea = ".,.</¡ib¡cls!|$/>.,-";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'o')
                {
                    variacion = s.Next(9, 11);
                    linea = ".,.</CnLrpy&nso/>.,-";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }
                else if (array[i] == 'u')
                {
                    variacion = s.Next(12, 14);
                    linea = ".,.</cJjusKlMdN/>.,-";
                    linea = variar(linea, variacion);      //Metodo Variar
                    codigo = codigo + linea;
                }

                //Para Consonantes MAYUSCULAS
                else if (array[i] == 'B')
                    codigo = codigo + ".,.</bJcBs/>.,.";
                else if (array[i] == 'C')
                    codigo = codigo + ".,.</KcMdN/>.,.";
                else if (array[i] == 'D')
                    codigo = codigo + ".,.</dJhDs/>.,.";
                else if (array[i] == 'F')
                    codigo = codigo + ".,.</ksmgu/>.,.";
                else if (array[i] == 'G')
                    codigo = codigo + ".,.</Dptsf/>.,.";
                else if (array[i] == 'H')
                    codigo = codigo + ".,.</cvbgs/>.,.";
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

                //Para Consonantes minusculas
                else if (array[i] == 'b')
                    codigo = codigo + ".,.</bJcBs/>.,-";
                else if (array[i] == 'c')
                    codigo = codigo + ".,.</KcMdN/>.,-";
                else if (array[i] == 'd')
                    codigo = codigo + ".,.</dJhDs/>.,-";
                else if (array[i] == 'f')
                    codigo = codigo + ".,.</ksmgu/>.,-";
                else if (array[i] == 'g')
                    codigo = codigo + ".,.</Dptsf/>.,-";
                else if (array[i] == 'h')
                    codigo = codigo + ".,.</cvbgs/>.,-";
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

                //Caracteres Especiales
                else if (array[i] == '.')
                    codigo = codigo + ")-123456-(";
                else if (array[i] == ',')
                    codigo = codigo + ")-123678-(";
                else if (array[i] == ':')
                    codigo = codigo + ")-123789-(";
                else if (array[i] == ';')
                    codigo = codigo + ")-123890-(";
                else if (array[i] == '-')
                    codigo = codigo + ")-12390’-(";
                else if (array[i] == '_')
                    codigo = codigo + ")-234567-(";
                else if (array[i] == '*')
                    codigo = codigo + ")-234678-(";
                else if (array[i] == '+')
                    codigo = codigo + ")-234789-(";
                else if (array[i] == '/')
                    codigo = codigo + ")-234890-(";
                else if (array[i] == '!')
                    codigo = codigo + ")-345678-(";
                else if (array[i] == '?')
                    codigo = codigo + ")-345789-(";
                else if (array[i] == '"')
                    codigo = codigo + ")-34590’-(";
                else if (array[i] == '<')
                    codigo = codigo + ")-456789-(";
                else if (array[i] == '>')
                    codigo = codigo + ")-456890-(";
                else if (array[i] == '°')
                    codigo = codigo + ")-45690’-(";
                else if (array[i] == '=')
                    codigo = codigo + ")-567890-(";
                else if (array[i] == '&')
                    codigo = codigo + ")-‘09645-(";
                else if (array[i] == '#')
                    codigo = codigo + ")-‘82523-(";
                else if (array[i] == '$')
                    codigo = codigo + ")-‘5084’-(";
                else if (array[i] == '@')
                    codigo = codigo + ")-‘’¿7’’-(";

                //Espacio
                else if (array[i] == ' ')
                    codigo = codigo + "</1fJoSr182c/>";

                //Culaquier otro caracter
                else
                    codigo = codigo + "";
            }

            return codigo;
        }
        private string variar(string line, int var)
        {
            int maymin;
            if (line.Contains('-'))
            {
                maymin = 1;         //minusculas
            }
            else
            {
                maymin = 0;         //MAYUSCULAS
            }

            line = line.Replace(".,.</", "");
            line = line.Replace("/>.,.", "");

            string dato = line;

            switch (var)
            {
                case 0:
                    {
                        line = line.Replace(dato, "¡¡$rfh%p=¡");
                    }
                    break;
                case 1:
                    {
                        line = line.Replace(dato, "¿¿uho/jk/u");
                    }
                    break;
                case 2:
                    {
                        line = line.Replace(dato, "0=ian89añ'");
                    }
                    break;
                case 3:
                    {
                        line = line.Replace(dato, "alnc&a02H=");
                    }
                    break;
                case 4:
                    {
                        line = line.Replace(dato, "!a03498as)");
                    }
                    break;
                case 5:
                    {
                        line = line.Replace(dato, "!!!!!!=???");
                    }
                    break;
                case 6:
                    {
                        line = line.Replace(dato, "!!uaj!=???");
                    }
                    break;
                case 7:
                    {
                        line = line.Replace(dato, "!!!!!p9i??");
                    }
                    break;
                case 8:
                    {
                        line = line.Replace(dato, "!!u!!!=???");
                    }
                    break;
                case 9:
                    {
                        line = line.Replace(dato, "!!!00opas?");
                    }
                    break;
                case 10:
                    {
                        line = line.Replace(dato, "!7!!!!=???");
                    }
                    break;
                case 11:
                    {
                        line = line.Replace(dato, "jdnrof03n?");
                    }
                    break;
                case 12:
                    {
                        line = line.Replace(dato, "!!!!!!=333");
                    }
                    break;
                case 13:
                    {
                        line = line.Replace(dato, "!!vce4=???");
                    }
                    break;
                case 14:
                    {
                        line = line.Replace(dato, "!!!!!!¿???");
                    }
                    break;
            }

            if (maymin == 1) //Minusculas
            {
                line = ".,.</" + line + "/>.,-";
            }
            else if (maymin == 0)   //Mayusculas
            {
                line = ".,.</" + line + "/>.,.";
            }

            return line;
        }
        public string decodificar(string cod)
        {
            //Decodificacion de nivel 1
            for (int i = 0; i < cod.Length; i++)
            {
                //Para Minusculas
                cod = cod.Replace(".,.</¡¡$rfh%p=¡/>.,-", "a");
                cod = cod.Replace(".,.</¿¿uho/jk/u/>.,-", "a");
                cod = cod.Replace(".,.</0=ian89añ'/>.,-", "a");
                cod = cod.Replace(".,.</bJcBs/>.,-", "b");
                cod = cod.Replace(".,.</KcMdN/>.,-", "c");
                cod = cod.Replace(".,.</dJhDs/>.,-", "d");
                cod = cod.Replace(".,.</alnc&a02H=/>.,-", "e");
                cod = cod.Replace(".,.</!a03498as)/>.,-", "e");
                cod = cod.Replace(".,.</!!!!!!=???/>.,-", "e");
                cod = cod.Replace(".,.</ksmgu/>.,-", "f");
                cod = cod.Replace(".,.</Dptsf/>.,-", "g");
                cod = cod.Replace(".,.</cvbgs/>.,-", "h");
                cod = cod.Replace(".,.</!!uaj!=???/>.,-", "i");
                cod = cod.Replace(".,.</!!!!!p9i??/>.,-", "i");
                cod = cod.Replace(".,.</!!u!!!=???/>.,-", "i");
                cod = cod.Replace(".,.</hjksk/>.,-", "j");
                cod = cod.Replace(".,.</prtyw/>.,-", "k");
                cod = cod.Replace(".,.</lpnbv/>.,-", "l");
                cod = cod.Replace(".,.</xcdrt/>.,-", "m");
                cod = cod.Replace(".,.</mnvyq/>.,-", "n");
                cod = cod.Replace(".,.</plñyq/>.,-", "ñ");
                cod = cod.Replace(".,.</!!!00opas?/>.,-", "o");
                cod = cod.Replace(".,.</!7!!!!=???/>.,-", "o");
                cod = cod.Replace(".,.</jdnrof03n?/>.,-", "o");
                cod = cod.Replace(".,.</jlwrñ/>.,-", "p");
                cod = cod.Replace(".,.</zxmnj/>.,-", "q");
                cod = cod.Replace(".,.</plñmn/>.,-", "r");
                cod = cod.Replace(".,.</mnrtp/>.,-", "s");
                cod = cod.Replace(".,.</qrtyp/>.,-", "t");
                cod = cod.Replace(".,.</!!!!!!=333/>.,-", "u");
                cod = cod.Replace(".,.</!!vce4=???/>.,-", "u");
                cod = cod.Replace(".,.</!!!!!!¿???/>.,-", "u");
                cod = cod.Replace(".,.</nbpzx/>.,-", "v");
                cod = cod.Replace(".,.</pñlzx/>.,-", "w");
                cod = cod.Replace(".,.</mlkpy/>.,-", "x");
                cod = cod.Replace(".,.</dvTyZ/>.,-", "y");
                cod = cod.Replace(".,.</dJiDs/>.,-", "z");

                //Para Mayusculas
                cod = cod.Replace(".,.</¡¡$rfh%p=¡/>.,.", "A");
                cod = cod.Replace(".,.</¿¿uho/jk/u/>.,.", "A");
                cod = cod.Replace(".,.</0=ian89añ'/>.,.", "A");
                cod = cod.Replace(".,.</bJcBs/>.,.", "B");
                cod = cod.Replace(".,.</KcMdN/>.,.", "C");
                cod = cod.Replace(".,.</dJhDs/>.,.", "D");
                cod = cod.Replace(".,.</alnc&a02H=/>.,.", "E");
                cod = cod.Replace(".,.</!a03498as)/>.,.", "E");
                cod = cod.Replace(".,.</!!!!!!=???/>.,.", "E");
                cod = cod.Replace(".,.</ksmgu/>.,.", "F");
                cod = cod.Replace(".,.</Dptsf/>.,.", "G");
                cod = cod.Replace(".,.</cvbgs/>.,.", "H");
                cod = cod.Replace(".,.</!!uaj!=???/>.,.", "I");
                cod = cod.Replace(".,.</!!!!!p9i??/>.,.", "I");
                cod = cod.Replace(".,.</!!u!!!=???/>.,.", "I");
                cod = cod.Replace(".,.</hjksk/>.,.", "J");
                cod = cod.Replace(".,.</prtyw/>.,.", "K");
                cod = cod.Replace(".,.</lpnbv/>.,.", "L");
                cod = cod.Replace(".,.</xcdrt/>.,.", "M");
                cod = cod.Replace(".,.</mnvyq/>.,.", "N");
                cod = cod.Replace(".,.</plñyq/>.,.", "Ñ");;
                cod = cod.Replace(".,.</!!!00opas?/>.,.", "O");
                cod = cod.Replace(".,.</!7!!!!=???/>.,.", "O");
                cod = cod.Replace(".,.</jdnrof03n?/>.,.", "O");
                cod = cod.Replace(".,.</jlwrñ/>.,.", "P");
                cod = cod.Replace(".,.</zxmnj/>.,.", "Q");
                cod = cod.Replace(".,.</plñmn/>.,.", "R");
                cod = cod.Replace(".,.</mnrtp/>.,.", "S");
                cod = cod.Replace(".,.</qrtyp/>.,.", "T");
                cod = cod.Replace(".,.</!!!!!!=333/>.,.", "U");
                cod = cod.Replace(".,.</!!vce4=???/>.,.", "U");
                cod = cod.Replace(".,.</!!!!!!¿???/>.,.", "U");
                cod = cod.Replace(".,.</nbpzx/>.,.", "V");
                cod = cod.Replace(".,.</pñlzx/>.,.", "W");
                cod = cod.Replace(".,.</mlkpy/>.,.", "X");
                cod = cod.Replace(".,.</dvTyZ/>.,.", "Y");
                cod = cod.Replace(".,.</dJiDs/>.,.", "Z");              

                //Para numeros
                cod = cod.Replace("/NuM%@rez/", "0");
                cod = cod.Replace("/NuM%@eno/", "1");
                cod = cod.Replace("/NuM%@owt/", "2");
                cod = cod.Replace("/NuM%@rht/", "3");
                cod = cod.Replace("/NuM%@uof/", "4");
                cod = cod.Replace("/NuM%@vif/", "5");
                cod = cod.Replace("/NuM%@xis/", "6");
                cod = cod.Replace("/NuM%@ves/", "7");
                cod = cod.Replace("/NuM%@gie/", "8");
                cod = cod.Replace("/NuM%@nin/", "9");

                //Espacio
                cod = cod.Replace("</1fJoSr182c/>", " ");

                //Caracteres Especiales
                cod = cod.Replace(")-123456-(",".");
                cod = cod.Replace(")-123678-(",",");
                cod = cod.Replace(")-123789-(",":");
                cod = cod.Replace(")-123890-(",";");
                cod = cod.Replace(")-12390’-(","-");
                cod = cod.Replace(")-234567-(","_");
                cod = cod.Replace(")-234678-(","*");
                cod = cod.Replace(")-234789-(","+");
                cod = cod.Replace(")-234890-(","/");
                cod = cod.Replace(")-345678-(","!");
                cod = cod.Replace(")-345789-(","?");
                cod = cod.Replace(")-34590’-(","\"");
                cod = cod.Replace(")-456789-(","<");
                cod = cod.Replace(")-456890-(",">");
                cod = cod.Replace(")-45690’-(","°");
                cod = cod.Replace(")-567890-(","=");
                cod = cod.Replace(")-‘09645-(","&");
                cod = cod.Replace(")-‘82523-(","#"); 
                cod = cod.Replace(")-‘5084’-(","$");
                cod = cod.Replace(")-‘’¿7’’-(","@");
            }
            return cod;
        }
    }
}
