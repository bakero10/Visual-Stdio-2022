using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        // Primer click del jugador.
        Label primerClick = null;

        // Segundo click del jugador.
        Label segundoClick = null;

        // Para elegir iconos aleatorios para los cuadrados
        Random random = new Random();

        int tiempo1 = 50;
        // Cada una de estas letras es un icono en la fuente Webdings,
        // y cada icono aparece dos veces en esta lista
        List<string> icons = new List<string>()
        {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z",
        "a", "a", "c", "c"
        };
        private void AsignacionAleatoriaIconos()
        {
            // El TableLayoutPanel tiene 20 etiquetas,
            // y la lista de iconos tiene 20 iconos,
            // por lo que se extrae un icono al azar de la lista
            // y se agrega a cada etiqueta
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label icono = control as Label;
                if (icono != null)
                {
                    int numeroAleatorio = random.Next(icons.Count);
                    icono.Text = icons[numeroAleatorio];
                    icono.ForeColor = icono.BackColor;
                    icons.RemoveAt(numeroAleatorio);
                    Console.WriteLine(icons.Count);

                }
            }
        }
        public Form1()
        {
           
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // El temporizador solo se enciende después de dos no coincidencias.
            // se han mostrado iconos al jugador,
            // así que ignore cualquier clic si el temporizador está funcionando
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Si la etiqueta en la que se hizo clic es negra, el jugador hizo clic
                // en un ícono que ya ha sido revelado --
                // ignorar el click.
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // Si firstClicked es nulo, este es el primer icono
                // en el par en el que el jugador hizo clic,
                // así que establezca firstClicked en la etiqueta que el jugador
                // hace clic, cambia su color a negro y regresa
                if (primerClick == null)
                {
                    primerClick = clickedLabel;
                    primerClick.ForeColor = Color.Black;
                    return;
                }

                // Si el jugador llega tan lejos, el temporizador no corre
                // firstClicked no es nulo,
                // entonces este debe ser el segundo ícono en el que el jugador hizo click
                // Establecer su color en negro
                segundoClick = clickedLabel;
                segundoClick.ForeColor = Color.Black;
                
                // Comprobar si el jugador ganó
                comprobarParejas();

                // SI DESTAPA DOS ICONOS IGUALES--------------------- 
                // Se mantienen descubiertos y restablecemos firstClicked y secondClicked
                // para que el jugador pueda hacer clic en otros iconos
                if (primerClick.Text == segundoClick.Text)
                {

                    primerClick.ForeColor = Color.Red;
                    primerClick = null;
                    
                    segundoClick.ForeColor = Color.Red; 
                    segundoClick = null;
                   
                    // Reproducir sonido aplauso
                    SoundPlayer sonidoAcierto = new SoundPlayer();
                    sonidoAcierto.SoundLocation = "C:/Users/Bakero/Downloads/Carrera.wav";
                    sonidoAcierto.Play();
                    return;
                }

                // Si el jugador llega tan lejos, el jugador
                // hizo clic en dos íconos diferentes, así que inicie el
                // temporizador(que esperará tres cuartos de
                // un segundo y luego ocultar los iconos)
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Parar el tiempo.
            timer1.Stop();

            // Ocultar ambos iconos
            primerClick.ForeColor = primerClick.BackColor;
            segundoClick.ForeColor = segundoClick.BackColor;

            // Reproducir sonido abucheo
            SoundPlayer sonidoAcierto = new SoundPlayer();
            sonidoAcierto.SoundLocation = "C:/Users/Bakero/Downloads/boooo.wav";
            sonidoAcierto.Play();

            // Restablecer firstClicked y secondClicked.
            // así que la próxima vez que una etiqueta sea clickada
            // el programa sabe que es el primer click.
            primerClick = null;
            segundoClick = null;
        }
        private void comprobarParejas()
        {
            // Revisa todas las etiquetas en TableLayoutPanel,
            // comprobando cada una para ver si su icono coincide
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconoEtiqueta = control as Label;

                if (iconoEtiqueta != null)
                {
                    if (iconoEtiqueta.ForeColor == iconoEtiqueta.BackColor)
                        return;
                }
            }

            // Si el bucle no regresa, no encuentra ningun icono sin igual
            // Eso significa que el usuario ganó. Mostrar un mensaje y cerrar el 
            timer2.Stop();
            MessageBox.Show("Has emparejado todos los iconos!", "Enhorabuena");
            Close();


        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            timer2.Start();
            AsignacionAleatoriaIconos();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempo1 = tiempo1 - 1;
            label222.Text = tiempo1 + " segundos";
            if (label222.Text.Equals("0 segundos")){
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Has perdido!", "ATONTAO¡");
                Close();
            }
        }
    }
}
