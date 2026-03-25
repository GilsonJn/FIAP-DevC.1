using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace LeitorArquivos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // VALIDAÇÃO DE EXTENSÃO 
        private bool ValidarExtensao(string caminhoArquivo)
        {
            string extensao = Path.GetExtension(caminhoArquivo).ToLower();
            return extensao == ".txt" || extensao == ".bat";
        }

        // CARREGAMENTO
        private void load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos Suportados (*.txt;*.bat)|*.txt;*.bat";

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;

                if (!ValidarExtensao(path))
                {
                    MessageBox.Show("Formato não suportado! Por favor, selecione apenas arquivos .txt ou .bat.", "Acesso Negado", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!File.Exists(path))
                {
                    MessageBox.Show("Arquivo não Encontrado!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                filePath.Text = path;
                contend.Text = "";

                // Tratamento de Exceções Específicas
                try
                {
                    contend.Text = File.ReadAllText(path);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Você não tem permissão de acesso para ler este arquivo.", "Erro de Acesso", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Erro de leitura/escrita no arquivo: " + ex.Message, "Erro de I/O", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro Genérico", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // SALVAMENTO
        private void save_Click(object sender, RoutedEventArgs e)
        {
            string path = filePath.Text;

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Nenhum caminho especificado para salvar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!ValidarExtensao(path))
            {
                MessageBox.Show("Formato inválido! Você só pode salvar arquivos com a extensão .txt ou .bat.", "Operação Bloqueada", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (File.Exists(path))
            {
                MessageBoxResult result = MessageBox.Show("O arquivo já existe. Deseja salvar por cima e substituir o atual?", "Sobrescrever?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    return; 
                }
            }

            try
            {
                File.WriteAllText(path, contend.Text);
                MessageBox.Show(path + " salvo com sucesso.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acesso negado. Você não tem privilégios para gravar neste diretório.", "Erro de Acesso", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("O arquivo pode estar em uso por outro programa. Erro: " + ex.Message, "Erro de I/O", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}