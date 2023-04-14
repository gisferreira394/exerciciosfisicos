using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exerciciosfisicos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
textBox1.Clear();
            Tempo.Value = 0;
           textBox2.Clear();
comboBox1.Focus();

            }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor preencha o dado acima !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (Convert.ToInt32(textBox1.Text) < 1 || Convert.ToInt32(textBox1.Text) > 200)
            {
                MessageBox.Show("Peso deve estar entre 1kg e 200kg", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox2.Clear();
            }

            else
            {
                switch (comboBox1.SelectedItem)
                {
                    case "Ciclismo":
                        textBox2.Text = (Convert.ToDecimal(textBox1.Text) * Tempo.Value * 2).ToString(); break;

                    case "Academia":
                        textBox2.Text = (Convert.ToDecimal(textBox1.Text) * Tempo.Value * 2).ToString(); break;

                    case "Corrida":
                        textBox2.Text = (Convert.ToDecimal(textBox1.Text) * Tempo.Value * 2).ToString(); break;

                    case "Natação":
                        textBox2.Text = (Convert.ToDecimal(textBox1.Text) * Tempo.Value * 2).ToString(); break;

                    case "Box":
                        textBox2.Text = (Convert.ToDecimal(textBox1.Text) * Tempo.Value * 2).ToString(); break;

                    default:
                        MessageBox.Show("Escolha uma opção");
                        break;
                }
            }
            }

        }
    }
