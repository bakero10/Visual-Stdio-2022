using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // CREA UN OBJETO RANDOM PARA HACER NUMEROS ALEATORIOS
        Random numeroRandom = new Random();

        // VARIABLES SUMAR
        int suma1;
        int suma2;

        // VARIABLES RESTAR
        int resta1;
        int resta2;

        //  VARIABLES MULTIPLICAR
        int multiplicador;
        int multiplicado;

        // VARIABLES DIVIDIR
        int dividendo;
        int divisor;

        // VATIABLE TIEMPO 
        int tiempo;
        public Form1()
        {
            InitializeComponent();
        }
        private bool respuestaCorrecta()
            //METODO QUE DEVUELVE TRUE SI TODAS LAS RESPUESTAS SON CORRECTAS
            
        {
            if ((suma1 + suma2 == sum.Value)
                && (resta1 - resta2 == difference.Value)
                && (multiplicador * multiplicado == product.Value)
                && (dividendo / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public void comienzoJuego()
        {
            // Completa el problema de suma.
            // Genera dos números aleatorios para sumar.
            // Almacene los valores en las variables 'addend1' y 'addend2'.
            suma1 = numeroRandom.Next(51);
            suma2 = numeroRandom.Next(51);

            // Convierte los dos números generados aleatoriamente
            // en cadenas para que puedan mostrarse
            // en los controles de etiqueta.
            plusLeftLabel.Text = suma1.ToString();
            plusRightLabel.Text = suma2.ToString();

            // 'suma' es el nombre del control NumericUpDown.
            // Este paso asegura que su valor sea cero antes
            // añadiéndole cualquier valor.
            sum.Value = 0;

            // Completa el problema de resta.
            resta1 = numeroRandom.Next(1, 101);
            resta2 = numeroRandom.Next(1, resta1);
            minusLeftLabel.Text = resta1.ToString();
            minusRightLabel.Text = resta2.ToString();
            difference.Value = 0;

            // Completa el problema de multiplicación.
            multiplicador = numeroRandom.Next(2, 11);
            multiplicado = numeroRandom.Next(2, 11);
            timesLeftLabel.Text = multiplicador.ToString();
            timesRightLabel.Text = multiplicado.ToString();
            product.Value = 0;

            // Completa el problema de división.
            divisor = numeroRandom.Next(2, 11);
            int cocienteTemporal = numeroRandom.Next(2, 11);
            dividendo = divisor * cocienteTemporal;
            dividedLeftLabel.Text = dividendo.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Iniciamos el temporizador.
            tiempo = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();
            
            
        }
        private void botonClick(object sender, EventArgs e)
        {
            comienzoJuego();
            etiquetaRoja();
            startButton.Enabled = false;
        }
        private void etiquetaRoja()
        {
            
            
        }

        private void cronometro(object sender, EventArgs e)
        {
            String texto = timeLabel.Text;
            
            if (respuestaCorrecta())
            {
                // Si CheckTheAnswer() devuelve verdadero, entonces el usuario
                // ha obtenido todas las respuestas correctas. detener el temporizador
                // y mostrar un MessageBox.
                               timer1.Stop();
                MessageBox.Show("Has contestado todas las respuestas correctamente!",
                                "Enorabuena!");
                startButton.Enabled = true;
            }
            
            else if (tiempo > 0)
            {
                // Si CheckTheAnswer() devuelve falso, sigue contando
                // abajo.Disminuya el tiempo restante en un segundo y
                // mostrar el nuevo tiempo restante actualizando la
                // etiqueta de tiempo restante.
                tiempo = tiempo - 1;
                timeLabel.Text = tiempo + " segundos";
                if (texto.Equals("6 segundos"))
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            
            else
            {
                // Si el usuario se queda sin tiempo, se detiene el temporizador, mostramos
                // un cuadro de mensaje y se completan las respuestas.
                timer1.Stop();
                timeLabel.Text = "Tiempo!";
                MessageBox.Show("No as conseguido acabar antes de que se acabe el tiempo.", "Lo siento!");
                sum.Value = suma1 + suma2;
                difference.Value = resta1 - resta2;
                product.Value = multiplicador * multiplicado;
                quotient.Value = dividendo / divisor;
                startButton.Enabled = true;
            }
        }

        private void respuestaIntro(object sender, EventArgs e)
        {
            // Seleccione la respuesta completa en el control NumericUpDown.
            NumericUpDown respuestaCaja = sender as NumericUpDown;

            if (respuestaCaja != null)
            {
                int longitudRespuesta = respuestaCaja.Value.ToString().Length;
                respuestaCaja.Select(0, longitudRespuesta);
            }
        }
    }
}
