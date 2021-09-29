using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using NAudio.Wave;

namespace DAVE
{
    class Reproductor
    {
        private char caracter;
        SoundPlayer letra;

        public Reproductor(char c)
        {
            this.caracter = c;
            Reproducir();
        }
        private void Reproducir()
        {
            switch (caracter)
            {
                //Mayusculas
                case 'A':
                    {
                        letra = new SoundPlayer("Sound\\A.wav");
                        letra.Play();
                        break;
                    }
                case 'B':
                    {
                        letra = new SoundPlayer("Sound\\B.wav");
                        letra.Play();
                        break;
                    }
                case 'C':
                    {
                        letra = new SoundPlayer("Sound\\C.wav");
                        letra.Play();
                        break;
                    }
                case 'D':
                    {
                        letra = new SoundPlayer("Sound\\D.wav");
                        letra.Play();
                        break;
                    }
                case 'E':
                    {
                        letra = new SoundPlayer("Sound\\E.wav");
                        letra.Play();
                        break;
                    }
                case 'F':
                    {
                        letra = new SoundPlayer("Sound\\F.wav");
                        letra.Play();
                        break;
                    }
                case 'G':
                    {
                        letra = new SoundPlayer("Sound\\G.wav");
                        letra.Play();
                        break;
                    }
                case 'H':
                    {
                        letra = new SoundPlayer("Sound\\H.wav");
                        letra.Play();
                        break;
                    }
                case 'I':
                    {
                        letra = new SoundPlayer("Sound\\I.wav");
                        letra.Play();
                        break;
                    }
                case 'J':
                    {
                        letra = new SoundPlayer("Sound\\J.wav");
                        letra.Play();
                        break;
                    }
                case 'K':
                    {
                        letra = new SoundPlayer("Sound\\K.wav");
                        letra.Play();
                        break;
                    }
                case 'L':
                    {
                        letra = new SoundPlayer("Sound\\L.wav");
                        letra.Play();
                        break;
                    }
                case 'M':
                    {
                        letra = new SoundPlayer("Sound\\M.wav");
                        letra.Play();
                        break;
                    }
                case 'N':
                    {
                        letra = new SoundPlayer("Sound\\N.wav");
                        letra.Play();
                        break;
                    }
                case 'Ñ':
                    {
                        letra = new SoundPlayer("Sound\\Ñ.wav");
                        letra.Play();
                        break;
                    }
                case 'O':
                    {
                        letra = new SoundPlayer("Sound\\O.wav");
                        letra.Play();
                        break;
                    }
                case 'P':
                    {
                        letra = new SoundPlayer("Sound\\P.wav");
                        letra.Play();
                        break;
                    }
                case 'Q':
                    {
                        letra = new SoundPlayer("Sound\\Q.wav");
                        letra.Play();
                        break;
                    }
                case 'R':
                    {
                        letra = new SoundPlayer("Sound\\R.wav");
                        letra.Play();
                        break;
                    }
                case 'S':
                    {
                        letra = new SoundPlayer("Sound\\S.wav");
                        letra.Play();
                        break;
                    }
                case 'T':
                    {
                        letra = new SoundPlayer("Sound\\T.wav");
                        letra.Play();
                        break;
                    }
                case 'U':
                    {
                        letra = new SoundPlayer("Sound\\U.wav");
                        letra.Play();
                        break;
                    }
                case 'V':
                    {
                        letra = new SoundPlayer("Sound\\V.wav");
                        letra.Play();
                        break;
                    }
                case 'W':
                    {
                        letra = new SoundPlayer("Sound\\W.wav");
                        letra.Play();
                        break;
                    }
                case 'X':
                    {
                        letra = new SoundPlayer("Sound\\X.wav");
                        letra.Play();
                        break;
                    }
                case 'Y':
                    {
                        letra = new SoundPlayer("Sound\\Y.wav");
                        letra.Play();
                        break;
                    }
                case 'Z':
                    {
                        letra = new SoundPlayer("Sound\\Z.wav");
                        letra.Play();
                        break;
                    }

                //Minusculas
                case 'a':
                    {
                        letra = new SoundPlayer("Sound\\am.wav");
                        letra.Play();
                        break;
                    }
                case 'b':
                    {
                        letra = new SoundPlayer("Sound\\bm.wav");
                        letra.Play();
                        break;
                    }
                case 'c':
                    {
                        letra = new SoundPlayer("Sound\\cm.wav");
                        letra.Play();
                        break;
                    }
                case 'd':
                    {
                        letra = new SoundPlayer("Sound\\dm.wav");
                        letra.Play();
                        break;
                    }
                case 'e':
                    {
                        letra = new SoundPlayer("Sound\\em.wav");
                        letra.Play();
                        break;
                    }
                case 'f':
                    {
                        letra = new SoundPlayer("Sound\\fm.wav");
                        letra.Play();
                        break;
                    }
                case 'g':
                    {
                        letra = new SoundPlayer("Sound\\gm.wav");
                        letra.Play();
                        break;
                    }
                case 'h':
                    {
                        letra = new SoundPlayer("Sound\\hm.wav");
                        letra.Play();
                        break;
                    }
                case 'i':
                    {
                        letra = new SoundPlayer("Sound\\im.wav");
                        letra.Play();
                        break;
                    }
                case 'j':
                    {
                        letra = new SoundPlayer("Sound\\jm.wav");
                        letra.Play();
                        break;
                    }
                case 'k':
                    {
                        letra = new SoundPlayer("Sound\\km.wav");
                        letra.Play();
                        break;
                    }
                case 'l':
                    {
                        letra = new SoundPlayer("Sound\\lm.wav");
                        letra.Play();
                        break;
                    }
                case 'm':
                    {
                        letra = new SoundPlayer("Sound\\mm.wav");
                        letra.Play();
                        break;
                    }
                case 'n':
                    {
                        letra = new SoundPlayer("Sound\\nm.wav");
                        letra.Play();
                        break;
                    }
                case 'ñ':
                    {
                        letra = new SoundPlayer("Sound\\ñm.wav");
                        letra.Play();
                        break;
                    }
                case 'o':
                    {
                        letra = new SoundPlayer("Sound\\om.wav");
                        letra.Play();
                        break;
                    }
                case 'p':
                    {
                        letra = new SoundPlayer("Sound\\pm.wav");
                        letra.Play();
                        break;
                    }
                case 'q':
                    {
                        letra = new SoundPlayer("Sound\\qm.wav");
                        letra.Play();
                        break;
                    }
                case 'r':
                    {
                        letra = new SoundPlayer("Sound\\rm.wav");
                        letra.Play();
                        break;
                    }
                case 's':
                    {
                        letra = new SoundPlayer("Sound\\sm.wav");
                        letra.Play();
                        break;
                    }
                case 't':
                    {
                        letra = new SoundPlayer("Sound\\tm.wav");
                        letra.Play();
                        break;
                    }
                case 'u':
                    {
                        letra = new SoundPlayer("Sound\\um.wav");
                        letra.Play();
                        break;
                    }
                case 'v':
                    {
                        letra = new SoundPlayer("Sound\\vm.wav");
                        letra.Play();
                        break;
                    }
                case 'w':
                    {
                        letra = new SoundPlayer("Sound\\wm.wav");
                        letra.Play();
                        break;
                    }
                case 'x':
                    {
                        letra = new SoundPlayer("Sound\\xm.wav");
                        letra.Play();
                        break;
                    }
                case 'y':
                    {
                        letra = new SoundPlayer("Sound\\ym.wav");
                        letra.Play();
                        break;
                    }
                case 'z':
                    {
                        letra = new SoundPlayer("Sound\\zm.wav");
                        letra.Play();
                        break;
                    }

                //ESPACIO
                case ' ':
                    {
                        break;
                    }

                //Numeros
                //ESPACIO
                case '0':
                    {
                        letra = new SoundPlayer("Sound\\0.wav");
                        letra.Play();
                        break;
                    }
                case '1':
                    {
                        letra = new SoundPlayer("Sound\\1.wav");
                        letra.Play();
                        break;
                    }
                case '2':
                    {
                        letra = new SoundPlayer("Sound\\2.wav");
                        letra.Play();
                        break;
                    }
                case '3':
                    {
                        letra = new SoundPlayer("Sound\\3.wav");
                        letra.Play();
                        break;
                    }
                case '4':
                    {
                        letra = new SoundPlayer("Sound\\4.wav");
                        letra.Play();
                        break;
                    }
                case '5':
                    {
                        letra = new SoundPlayer("Sound\\5.wav");
                        letra.Play();
                        break;
                    }
                case '6':
                    {
                        letra = new SoundPlayer("Sound\\6.wav");
                        letra.Play();
                        break;
                    }
                case '7':
                    {
                        letra = new SoundPlayer("Sound\\7.wav");
                        letra.Play();
                        break;
                    }
                case '8':
                    {
                        letra = new SoundPlayer("Sound\\8.wav");
                        letra.Play();
                        break;
                    }
                case '9':
                    {
                        letra = new SoundPlayer("Sound\\9.wav");
                        letra.Play();
                        break;
                    }

            }          
        }
    }
}