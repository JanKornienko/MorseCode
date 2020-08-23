using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace morseCode
{
    public partial class Morse : Form
    {
        public Morse()
        {
            InitializeComponent();
        }

        public void Characters()
        {
            string[] morse = new string[130];
            morse[33] = "--...-"; //!
            morse[34] = ".-..-."; //"
            morse[40] = "--..."; //(
            morse[41] = "-.--.-"; //)
            morse[44] = "--..--"; //,
            morse[45] = "-....-"; //-
            morse[46] = ".-.-.-"; //.
            morse[47] = "-..-."; //SLASH
            morse[48] = "-----"; //0
            morse[49] = ".----"; //1
            morse[50] = "..---"; //2
            morse[51] = "...--"; //3
            morse[52] = "....-"; //4
            morse[53] = "....."; //5
            morse[54] = "-...."; //6
            morse[55] = "--..."; //7
            morse[56] = "---.."; //8
            morse[57] = "----."; //9
            morse[58] = "---..."; //:
            morse[59] = "-.-.-."; //;
            morse[63] = "..--.."; //?
            morse[64] = ".--.-."; //@
            morse[95] = "..--.-"; //_
            morse[97] = ".-"; //A
            morse[98] = "-..."; //B
            morse[99] = "-.-."; //C
            morse[100] = "-.."; //D
            morse[101] = "."; //E
            morse[102] = "..-."; //F
            morse[103] = "--."; //G
            morse[104] = "...."; //H
            morse[105] = ".."; //I
            morse[106] = ".---"; //J
            morse[107] = "-.-"; //K
            morse[108] = ".-.."; //L
            morse[109] = "--"; //M
            morse[110] = "-."; //N
            morse[111] = "---"; //O
            morse[112] = ".--."; //P
            morse[113] = "--.-"; //Q
            morse[114] = ".-."; //R
            morse[115] = "..."; //S
            morse[116] = "-"; //T
            morse[117] = "..-"; //U
            morse[118] = "...-"; //V
            morse[119] = ".--"; //W
            morse[120] = "-..-"; //X
            morse[121] = "-.--"; //Y
            morse[122] = "--.."; //Z

            string text = textBox1.Text.ToLower(); 

            //Translate to morse code
            foreach (char a in text)
            {
                textBox2.Text += morse[a] + "/";
            }
        }

        public async void Light()
        {
            //Light show
            var lightForm = new Form2();
            lightForm.Show();

            foreach (char one in textBox2.Text)
            {
                if (one == 45)
                {
                    lightForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                }

                if (one == 46)
                {
                    lightForm.BackColor = System.Drawing.SystemColors.ControlLightLight ;
                }

                if (one == 47)
                {
                    lightForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                }

                await Task.Delay(250);
                lightForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                await Task.Delay(50);
            }

            lightForm.Close();
        }

        public async void Sound()
        {
            foreach (char two in textBox2.Text)
            {
                if (two == 45)
                {
                    Console.Beep(500,300);
                }

                if (two == 46)
                {
                    Console.Beep(500,100);
                }

                if (two == 47)
                {
                    await Task.Delay(300);
                }
            }
        }

        public void File()
        {
            string time = DateTime.Now.ToString("dd.MM.yyyy-HH.mm.ss") + ".txt"; //Name of file

            FileStream file = new FileStream(time, FileMode.Create);
            StreamWriter write = new StreamWriter(file);

            write.WriteLine(textBox1.Text);
            write.WriteLine(textBox2.Text);

            write.Close();
            file.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Characters();

            if (radSound.Checked)
            {
                Sound();
            }

            if (textFile.Checked)
            {
                File();
            }

            if (radLight.Checked)
            {
                Light();
            }
        }
    }
}