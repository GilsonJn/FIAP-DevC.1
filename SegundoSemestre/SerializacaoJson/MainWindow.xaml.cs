using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace SerializacaoJson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int idCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SalvarBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa()
                {
                    Id = idCount,
                    Nome = EntradaNome.Text,
                    Idade = int.Parse(EntradaIdade.Text)
                };
                string jsonSaida = JsonSerializer.Serialize(pessoa);
                string nameFile = $"Pessoa{idCount}.json";
                File.WriteAllText(nameFile, jsonSaida);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            EntradaNome.Text = string.Empty;
            EntradaIdade.Text = string.Empty;
            idCount++;
        }

        ObservableCollection<Pessoa> pessoas = new ObservableCollection<Pessoa>();
        private void GetPessoa_Click(object sender, RoutedEventArgs e)
        {
            Pessoa pessoa;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultDirectory = "C:\\Users\\gilso\\Documents\\FACULDADE\\Eng de Software\\3º ano\\C#\\FIAP-DevC.1\\SegundoSemestre\\SerializacaoJson";
                openFileDialog.Filter = "JSON Files (pessoa*.json)|pessoa*.json";
                openFileDialog.ShowDialog();

                string path = openFileDialog.FileName;
                string jsonPessoa = File.ReadAllText(path);
                pessoa = JsonSerializer.Deserialize<Pessoa>(jsonPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (pessoa == null)
            {
                MessageBox.Show("Arquivo não valido!");
                return;
            }
            pessoas.Add(pessoa);
            DataExibido.ItemsSource = pessoas;
        }
    }
}