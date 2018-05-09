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
    public partial class frmMultiplicacion : Form
    {
        public frmMultiplicacion()
        {
            InitializeComponent();
        }

        /* Variables Globales*/
        string cinta;
        char[] word, arrow;
        int counter, index, stepCounter;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblCadena.Text = txtCadena.Text;
            string[] cadenaSplit = txtCadena.Text.Split('x');
            int multiplicando = cadenaSplit[0].Length;
            int multiplicador = cadenaSplit[1].Length;
            int cantBetas = multiplicando * multiplicador; 
            string betas = "";
            for (int i = 0; i < cantBetas; i++)
            {
                betas += '♭';
            }
            cinta = txtCadena.Text + '=' + betas;            
            cinta = "♭" + cinta ;
            lblCadena.Text = "♭"+ lblCadena.Text  + "=" + betas;
            word = cinta.ToCharArray();            
            counter = 0;
            index = 0;
            stepCounter = 0;
            lblCinta.Text = "";
            lblState.Text = "Q0";
            lblSteps.Text = "0";
            lblCinta.Text = "";
            //Se llena el label lblCinta con el caracter ♭, hasta el length de la cadena ingresada.
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 1) lblCinta.Text += '↓';
                else lblCinta.Text += "♭";
            }
            arrow = lblCinta.Text.ToCharArray();
            arrow[0] = '♭';
            //Si el usuario no ingresa una cadena, se debe de pedir que la ingrese.
            if (txtCadena.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ingrese una cadena!");
            }
            else
            {
                TM(word[index], "Q0");
            }
        }

        public async void TM(char currentChar, string state)
        {
            await HoldOn();
            switch (state)
            {
                case "Q0":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = '♭';
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q6");
                            break;
                        case '♭':
                            counter++;
                            index++;
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q0");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;

                case "Q1":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 'c';
                            counter++;
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q2");
                            break;

                        case 'x': case '=':
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = 's';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q2":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = '1';
                            counter++;
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q2");             
                            break;
                        case 'x': case '=':
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 's';
                            counter++;
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q2");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = '1';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();               
                            TM(word[index], "Q3");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q3":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = '1';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q3");                
                            break;
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = 's';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q3");                
                            break;
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 'c';
                            counter++;
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q1");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q4":
                    switch (currentChar)
                    {
                        case 'x': case '=':
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = 's';
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            word[index] = '1';
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q5":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            word[index] = '1';
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q7");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q6":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = '1';
                            counter++;
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q6");
                            break;
                        case 'x': case '=':
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 's';
                            counter++;
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q1");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;

                case "Q7":
                    switch (currentChar)
                    {
                        case 'x':
                        case 's':
                        case '=':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = 's';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q8");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;

                case "Q8":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = '1';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q9");
                            break;

                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = '♭';
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q10");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;

                case "Q9":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = '1';
                            counter--;
                            index--;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q9");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = '♭';
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q0");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;

                case "Q10":
                    switch (currentChar)
                    {
                        case 'x':
                        case '=':
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = '♭';
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q11");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;

                case "Q11":
                    switch (currentChar)
                    {
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = '♭';
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q11");
                            break;
                        case 'x': case '=':
                        case 's':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            word[index] = '=';
                            index++;
                            lblCinta.Text = new string(arrow);
                            lblCadena.Text = new string(word);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();                
                            TM(word[index], "Q12");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q12":
                    lblCadena.Text = new string(word);
                    lblCinta.Text = new string(arrow);
                    lblState.Text = state;
                    lblSteps.Text = stepCounter.ToString();
                    MessageBox.Show("Cadena aceptada por la maquina de turing!");
                    break;
            }
        }

        /* Metodo para pausar la secuencia de la maquina */
        async Task HoldOn()
        {
            await Task.Delay(1000);
        }
    }
}
