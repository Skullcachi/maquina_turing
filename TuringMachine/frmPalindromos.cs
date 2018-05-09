using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class frmPalindromos : Form
    {
        public frmPalindromos()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblCadena.Text = txtCadena.Text;
            cinta = txtCadena.Text;
            cinta = cinta + "♭";
            lblCadena.Text += "♭";
            word = cinta.ToCharArray();
            lblCinta.Text = "";
            counter = 0;
            index = 0;
            stepCounter = 0;
            lblState.Text = "Q0";
            lblSteps.Text = "0";
            lblCinta.Text = "↓";
            for (int i = 0; i < word.Length - 1; i++)
            {
                lblCinta.Text += "♭";
            }
            arrow = lblCinta.Text.ToCharArray();
            arrow[0] = '↓';
            if (txtCadena.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ingrese una cadena!");
            }
            else
            {
                TM(word[index], "Q0");
            }
        }

        /* Variables Globales */
        char[] word;
        int index = 0;
        int counter = 0;
        int stepCounter = 0;
        string cinta = "";
        char[] arrow;

        /// <summary>
        /// This method starts the process of the turing machine.
        /// </summary>
        /// <param name="currentChar">This is the current character being analyzed</param>
        /// <param name="state">This is the current state of the Turing Machine</param>
        public async void TM(char currentChar, string state)
        {
            await HoldOn();
            switch (state)
            {
                case "Q0":
                    switch (currentChar)
                    {
                        case 'a':
                            stepCounter++;
                            word[index] = '♭';
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            index++;
                            counter++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q1");
                            break;
                        case 'b':
                            stepCounter++;
                            word[index] = '♭';                            
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q2");
                            break;
                        case 'c':
                            stepCounter++;
                            word[index] = '♭';
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            index++;
                            counter++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q3");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q8");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q1":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q11");
                            break;
                        case '♭':
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            stepCounter++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q8");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q2":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q9");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q8");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q3":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q10");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q8");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q4":
                    switch (currentChar)
                    {
                        case 'a':
                            stepCounter++;
                            word[index] = '♭';
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            index--;
                            counter--;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q5":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            index--;
                            counter--;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            index++;
                            counter++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q0");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q6":
                    switch (currentChar)
                    {
                        case 'b':
                            stepCounter++;
                            word[index] = '♭';
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            index--;
                            counter--;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q7":
                    switch (currentChar)
                    {
                        case 'c':
                            stepCounter++;
                            word[index] = '♭';
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            index--;
                            counter--;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q8":
                    lblCadena.Text = new string(word);
                    lblCinta.Text = new string(arrow);
                    lblState.Text = state;
                    lblSteps.Text = stepCounter.ToString();
                    MessageBox.Show("Cadena aceptada por la maquina de turing!");
                    break;
                case "Q9":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q9");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q6");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q10":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q10");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q7");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
                case "Q11":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q11");
                            break;
                        case '♭':
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            index--;
                            stepCounter++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);                            
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;
                        default:
                            MessageBox.Show("Warning! The current character is not recognized by the turing machine.");
                            break;
                    }
                    break;
            }
        }





        /* Metodo para pausar la secuencia de la maquina */
        async Task HoldOn()
        {
            await Task.Delay(1000);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
