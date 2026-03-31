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
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SerializacaoJsonDesafio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pessoa> listaPessoas = new List<Pessoa>();
        private const string CaminhoArquivo = "cadastro_pessoas.json";
        private int idCount = 1;

        public MainWindow()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!int.TryParse(txtIdade.Text, out int idade) || idade < 0)
            {
                MessageBox.Show("Idade inválida.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Pessoa novaPessoa = new Pessoa
            {
                Id = idCount,
                Nome = txtNome.Text,
                Idade = idade
            };

            listaPessoas.Add(novaPessoa);
            idCount++;

            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Focus();

            AtualizarGrid();
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            AtualizarGrid();
        }   

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string jsonSaida = JsonSerializer.Serialize(listaPessoas, options);

                File.WriteAllText(CaminhoArquivo, jsonSaida);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCarregar_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(CaminhoArquivo))
            {
                MessageBox.Show("Nenhum arquivo JSON encontrado. Salve alguns dados primeiro.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                string jsonEntrada = File.ReadAllText(CaminhoArquivo);
                listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonEntrada) ?? new List<Pessoa>();

                // TRUQUE DE SEGURANÇA: Atualiza o idCount baseado no que veio do arquivo!
                if (listaPessoas.Count > 0)
                {
                    // Pega o maior ID salvo no arquivo e soma 1
                    idCount = listaPessoas.Max(p => p.Id) + 1;
                }

                AtualizarGrid();
                MessageBox.Show($"Dados carregados com sucesso! ({listaPessoas.Count} registros)", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo JSON: {ex.Message}", "Erro de Leitura", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AtualizarGrid()
        {
            dgPessoas.ItemsSource = null;
            dgPessoas.ItemsSource = listaPessoas;
        }
    }
}