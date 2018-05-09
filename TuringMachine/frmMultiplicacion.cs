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
            cinta = txtCadena.Text;
            cinta = "♭" + cinta + "♭";
            lblCadena.Text += "♭";
            word = cinta.ToCharArray();            
            counter = 0;
            index = 0;
            stepCounter = 0;
            lblCinta.Text = "";
            lblState.Text = "Q0";
            lblSteps.Text = "0";
            lblCinta.Text = "↓";
            //Se llena el label lblCinta con el caracter ♭, hasta el length de la cadena ingresada.
            for (int i = 0; i < word.Length - 1; i++)
            {
                lblCinta.Text += "♭";
            }
            arrow = lblCinta.Text.ToCharArray();
            arrow[0] = '↓';
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

        public void TM(char currentChar, string state)
        {
            switch (state)
            {
                case "Q0":
                    switch (currentChar)
                    {
                        case 'a': case 'b': case 'c':
                            stepCounter++;
                            arrow[counter + 1] = '↓';
                            word[1] = '♭';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q1");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
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
                            word[index] = '♭';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q1");
                            break;
                        case '♭':
                            stepCounter++;
                            word[index] = 'i';
                            arrow[counter] = '↓';
                            arrow[counter + 1] = '♭';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q2");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
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
                            arrow[counter - 1] = '↓';
                            word[index] = '♭';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q2");
                            break;
                        case '♭':
                            stepCounter++;
                            word[index] = 'i';
                            arrow[counter] = '↓';
                            arrow[counter + 1] = '♭';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
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
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = '♭';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q4":
                    switch (currentChar)
                    {
                        case 'a':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = '1';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        case 'b':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = '2';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q7");
                            break;
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = '3';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q9");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q5":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'i':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = 'a';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q6");
                            break;

                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q6":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'i':
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
                        case '1':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 'a';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;

                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q7":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'i':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q5");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = 'b';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
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
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'i':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q8");
                            break;
                        case '2':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 'b';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;

                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q9":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'i':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q10");
                            break;
                        case '♭':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            word[index] = 'c';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q10");
                            break;

                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q10":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'i':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter - 1] = '↓';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q8");
                            break;
                        case '3':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            word[index] = 'c';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q4");
                            break;

                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
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
                            arrow[counter - 1] = '↓';
                            counter--;
                            index--;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q11");
                            break;
                        case '♭':
                            stepCounter++;
                            word[index] = 'i';
                            arrow[counter] = '↓';
                            arrow[counter + 1] = '♭';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
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
                    switch (currentChar)
                    {
                        case 'a':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q13");
                            break;
                        case 'b':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q14");
                            break;
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q15");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q13":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q13");
                            break;
                        case 'i':
                            stepCounter++;
                            word[index] = 'a';
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q16");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q14":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q14");
                            break;
                        case 'i':
                            stepCounter++;
                            word[index] = 'b';
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q16");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q15":
                    switch (currentChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            stepCounter++;
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q15");
                            break;
                        case 'i':
                            stepCounter++;
                            word[index] = 'b';
                            arrow[counter] = '♭';
                            arrow[counter + 1] = '↓';
                            counter++;
                            index++;
                            lblCadena.Text = new string(word);
                            lblCinta.Text = new string(arrow);
                            lblState.Text = state;
                            lblSteps.Text = stepCounter.ToString();
                            TM(word[index], "Q16");
                            break;
                        default:
                            MessageBox.Show("Warning, the string entered is not valid in this Turing Machine!");
                            break;
                    }
                    break;
                case "Q16":
                    lblCadena.Text = new string(word);
                    lblCinta.Text = new string(arrow);
                    lblState.Text = state;
                    lblSteps.Text = stepCounter.ToString();
                    MessageBox.Show("Cadena aceptada por la maquina de turing!");
                    break;

            }
        }
    }
}
