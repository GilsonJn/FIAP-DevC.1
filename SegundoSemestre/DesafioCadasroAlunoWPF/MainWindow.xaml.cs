using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesafioCadasroAlunoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // O Dicionário exigido pelo desafio
        private Dictionary<int, string> _alunos = new Dictionary<int, string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // --- Lógica do Botão ADICIONAR ---
        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            txtMensagem.Text = ""; // Limpa mensagens antigas

            // Validação 1: ID é número?
            if (!int.TryParse(txtId.Text, out int id))
            {
                ExibirMensagem("[Erro] O ID deve ser um número inteiro.", Brushes.Red);
                return;
            }

            // Validação 2: ID já existe no Dictionary?
            if (_alunos.ContainsKey(id))
            {
                ExibirMensagem($"[Erro] O ID {id} já está cadastrado.", Brushes.Red);
                return;
            }

            // Validação 3: Nome está vazio?
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrWhiteSpace(nome))
            {
                ExibirMensagem("[Erro] O nome do aluno é obrigatório.", Brushes.Red);
                return;
            }

            // Salva no Dictionary
            _alunos.Add(id, nome);

            ExibirMensagem($"[Sucesso] Aluno '{nome}' cadastrado!", Brushes.Green);

            // Limpa os campos para o próximo cadastro
            txtId.Clear();
            txtNome.Clear();
            txtId.Focus();

            AtualizarLista();
        }

        // --- Lógica do Botão BUSCAR ---
        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                ExibirMensagem("[Erro] Digite um ID numérico para buscar.", Brushes.Red);
                return;
            }

            // Busca no Dictionary usando o TryGetValue
            if (_alunos.TryGetValue(id, out string nomeEncontrado))
            {
                ExibirMensagem($"[Encontrado] ID: {id} | Nome: {nomeEncontrado}", Brushes.Blue);
            }
            else
            {
                ExibirMensagem($"[Aviso] Nenhum aluno com o ID {id}.", Brushes.DarkOrange);
            }
        }

        // --- Métodos Auxiliares ---
        private void AtualizarLista()
        {
            // O WPF precisa que o ItemsSource seja reatribuído para enxergar itens novos no Dictionary
            lstAlunos.ItemsSource = null;
            lstAlunos.ItemsSource = _alunos;
        }

        private void ExibirMensagem(string texto, SolidColorBrush cor)
        {
            txtMensagem.Text = texto;
            txtMensagem.Foreground = cor;
        }
    }
}