using System;
using System.Windows.Forms;

namespace CalculadoraProjeto
{
    public partial class Form1 : Form
    {
        // Variáveis para armazenar os números e a operação selecionada
        private double primeiroNumero = 0; // Armazena o primeiro número
        private double segundoNumero = 0;   // Armazena o segundo número
        private string operacao = "";        // Armazena a operação selecionada

        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes da interface
        }

        private void texVisor_TextChanged(object sender, EventArgs e)
        {
            // Evento chamado quando o texto no visor muda (não precisa de implementação aqui)
        }

        // Função para adicionar dígitos ao visor
        private void AdicionarDigito(string digito)
        {
            // Se o visor contém "0", limpa o visor antes de adicionar um novo dígito
            if (texVisor.Text == "0")
            {
                texVisor.Clear(); // Limpa o visor
            }
            texVisor.Text += digito; // Adiciona o dígito ao visor
        }

        // Métodos para cada botão numérico (0 a 9)
        private void btn0_Click(object sender, EventArgs e)
        {
            AdicionarDigito("0"); // Chama a função para adicionar o dígito 0
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarDigito("1"); // Chama a função para adicionar o dígito 1
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarDigito("2"); // Chama a função para adicionar o dígito 2
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarDigito("3"); // Chama a função para adicionar o dígito 3
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarDigito("4"); // Chama a função para adicionar o dígito 4
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarDigito("5"); // Chama a função para adicionar o dígito 5
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarDigito("6"); // Chama a função para adicionar o dígito 6
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarDigito("7"); // Chama a função para adicionar o dígito 7
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarDigito("8"); // Chama a função para adicionar o dígito 8
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarDigito("9"); // Chama a função para adicionar o dígito 9
        }

        // Método para adicionar a operação de adição
        private void btn_adicao_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto do visor em um número
            if (double.TryParse(texVisor.Text, out primeiroNumero))
            {
                operacao = "+"; // Define a operação como adição
                texVisor.Text += " + "; // Adiciona a operação ao visor
            }
            else
            {
                // Mensagem de erro se o valor no visor não for um número válido
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        // Método para adicionar a operação de subtração
        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(texVisor.Text, out primeiroNumero))
            {
                operacao = "-"; // Define a operação como subtração
                texVisor.Text += " - "; // Adiciona a operação ao visor
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        // Método para adicionar a operação de multiplicação
        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(texVisor.Text, out primeiroNumero))
            {
                operacao = "*"; // Define a operação como multiplicação
                texVisor.Text += " * "; // Adiciona a operação ao visor
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        // Método para adicionar a operação de divisão
        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(texVisor.Text, out primeiroNumero))
            {
                operacao = "/"; // Define a operação como divisão
                texVisor.Text += " / "; // Adiciona a operação ao visor
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        // Método para calcular o resultado quando o botão igual é pressionado
        private void btn_igual_Click(object sender, EventArgs e)
        {
            // Divide o texto do visor em partes, usando espaços como delimitadores
            string[] partes = texVisor.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Verifica se a entrada tem o formato correto
            if (partes.Length == 3 && double.TryParse(partes[0], out primeiroNumero) && double.TryParse(partes[2], out segundoNumero))
            {
                double resultado = 0; // Variável para armazenar o resultado

                // Calcula o resultado com base na operação selecionada
                switch (partes[1])
                {
                    case "+":
                        resultado = primeiroNumero + segundoNumero; // Adição
                        break;
                    case "-":
                        resultado = primeiroNumero - segundoNumero; // Subtração
                        break;
                    case "*":
                        resultado = primeiroNumero * segundoNumero; // Multiplicação
                        break;
                    case "/":
                        // Verifica se o segundo número não é zero antes de dividir
                        if (segundoNumero != 0)
                        {
                            resultado = primeiroNumero / segundoNumero; // Divisão
                        }
                        else
                        {
                            MessageBox.Show("Divisão por zero não é permitida."); // Mensagem de erro
                            return;
                        }
                        break;
                    default:
                        break;
                }

                texVisor.Text = resultado.ToString(); // Exibe o resultado no visor
            }
            else
            {
                // Mensagem de erro se o formato da operação for inválido
                MessageBox.Show("Formato da operação inválido.");
            }
        }

        // Método para limpar o visor e resetar os valores
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            texVisor.Clear(); // Limpa o visor
            primeiroNumero = 0; // Reseta o primeiro número
            segundoNumero = 0; // Reseta o segundo número
            operacao = ""; // Reseta a operação
        }
    }
}
