using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHORCADO
{
    public partial class Form1 : Form
    {
               

        public Form1()
        {
            InitializeComponent();
        }

        string PalabraBuscada;
        string[] arreglo;                
        int Errores;
        int Acertadas;
        string CAD;
                

        public void ValidaLetra(string Letra)
        {
            //Aqui se verifica si la palabra contiene ese letra
            string L;
            int encontrado = 0;
            string compara;

            PalabraBuscada.ToCharArray();
            for (int i = 0; i < PalabraBuscada.Length; i++)
            {
                L = Convert.ToString(PalabraBuscada[i]);                
                if (L == Letra)
                {
                    //Mostrar la letra en la posicion de la palabra                                        
                    arreglo[i] = Letra;
                    encontrado = 1;
                    Acertadas++;
                }
                else
                {
                    compara = Convert.ToString(arreglo[i]);
                    //SI NO TENIA YA UN VALOR
                    if (String.Compare(compara, "") == -1)                       
                    {
                        arreglo[i] = "_";
                    }
                    
                }
            }

            if (encontrado == 1)
            {
                string cadena;
                cadena = "";
                //Mostrar el Label
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                   cadena = cadena + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = cadena;
            }
            else
            {
                Errores++;
            }



        }

        public void Deshabilitar()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
        }

        public void Inicializar()
        {
            Errores = 0;
            Acertadas = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;
            button7.BackColor = Color.Yellow;
            button8.BackColor = Color.Yellow;
            button9.BackColor = Color.Yellow;
            button10.BackColor = Color.Yellow;
            button11.BackColor = Color.Yellow;
            button12.BackColor = Color.Yellow;
            button13.BackColor = Color.Yellow;
            button14.BackColor = Color.Yellow;
            button15.BackColor = Color.Yellow;
            button16.BackColor = Color.Yellow;
            button17.BackColor = Color.Yellow;
            button18.BackColor = Color.Yellow;
            button19.BackColor = Color.Yellow;
            button20.BackColor = Color.Yellow;
            button21.BackColor = Color.Yellow;
            button22.BackColor = Color.Yellow;
            button23.BackColor = Color.Yellow;
            button24.BackColor = Color.Yellow;
            button25.BackColor = Color.Yellow;
            button26.BackColor = Color.Yellow;
            button27.BackColor = Color.Yellow;
            arreglo = new string[PalabraBuscada.Length];
            Resultado.Text = "";
            label1.Text = "Escoge " + Convert.ToString(PalabraBuscada.Length) + " letras";
            CAD = "";



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicializar();
            pictureBox1.Visible = true;    
            //RECORRER EL RESULTADO

        }

        
        private void BTN_A_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            
            ValidaLetra("A");            
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);            

            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }
            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Imagenes utilizadas para los distintos pasos del ahorcado
            Graphics g = Graphics.FromHwnd(this.Handle);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(255, 255);
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\INICIAL.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\CABEZA.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\CUERPO.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\BRAZO_DER.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\DOS_BRAZOS.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\PIERNA_DER.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\DOS_PIERNAS.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\AHORCADO.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\CURSOS VARIOS\FUNDACION ESPLAI\C2- PROGRAMACION\PROGRAMAS\TAREAS\AHORCADO\IMAGENES\GANADOR.jpg"));
            imageList1.Draw(g, new Point(40, 40), 0);

            //La palabra a buscar
            PalabraBuscada = "AGUACATE";
            label1.Text = "Escoge " + Convert.ToString(PalabraBuscada.Length) + " letras";
            Errores = 0;
            Inicializar();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            button14.Enabled = false;
            ValidaLetra("N");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }
            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            ValidaLetra("B");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);            
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }
            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.Enabled = false;
            ValidaLetra("C");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.Enabled = false;
            ValidaLetra("D");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button5.Enabled = false;
            ValidaLetra("E");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button6.Enabled = false;
            ValidaLetra("F");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button7.Enabled = false;
            ValidaLetra("G");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button8.Enabled = false;
            ValidaLetra("H");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            button9.Enabled = false;
            ValidaLetra("I");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            button10.Enabled = false;
            ValidaLetra("J");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            button11.Enabled = false;
            ValidaLetra("K");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            button12.Enabled = false;
            ValidaLetra("L");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
            button13.Enabled = false;
            ValidaLetra("M");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            button15.Enabled = false;
            ValidaLetra("Ñ");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red;
            button16.Enabled = false;
            ValidaLetra("O");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Red;
            button17.Enabled = false;
            ValidaLetra("P");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Red;
            button18.Enabled = false;
            ValidaLetra("Q");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Red;
            button19.Enabled = false;
            ValidaLetra("R");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Red;
            button20.Enabled = false;
            ValidaLetra("S");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Red;
            button21.Enabled = false;
            ValidaLetra("T");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Red;
            button22.Enabled = false;
            ValidaLetra("U");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Red;
            button23.Enabled = false;
            ValidaLetra("V");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Red;
            button24.Enabled = false;
            ValidaLetra("W");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Red;
            button25.Enabled = false;
            ValidaLetra("X");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.Red;
            button26.Enabled = false;
            ValidaLetra("Y");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }


        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Red;
            button27.Enabled = false;
            ValidaLetra("Z");
            pictureBox1.Visible = false;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if ((Errores > 0) && (Errores < 7))
            {
                imageList1.Draw(g, new Point(40, 40), Errores);
            }
            else
            {
                if (Errores == 7)
                {
                    //Se termino el juego deshabilitar todos los botones
                    imageList1.Draw(g, new Point(40, 40), 7);
                    Deshabilitar();
                }

            }
            if (Acertadas == PalabraBuscada.Length)
            {
                imageList1.Draw(g, new Point(40, 40), 8);
                for (int i = 0; i < PalabraBuscada.Length; i++)
                {
                    CAD = CAD + Convert.ToString(arreglo[i]) + "   ";
                }
                Resultado.Text = CAD;
                Deshabilitar();
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }
    }
}
