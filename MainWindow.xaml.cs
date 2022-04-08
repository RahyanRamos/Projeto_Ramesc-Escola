using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_PDS
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtNomeFantasia.Focus();
        }

        private void txtNomeFantasia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtRazaoSocial.Focus();
            }
        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtCnpj.Focus();
            }
        }

        private void txtCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtInscricaoEstadual.Focus();
            }
        }

        private void txtInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtResponsavel.Focus();
            }
        }

        private void txtResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtTelefone.Focus();
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                dtData.Focus();
            }
        }

        private void dtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtRua.Focus();
            }
        }

        private void txtRua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtBairro.Focus();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtCep.Focus();
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtCidade.Focus();
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtUf.Focus();
            }
        }

        private void txtUf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btSalvar_Click(sender, e);
            }
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            string tipo;

            if (tipo1.IsChecked == true)
            {
                tipo = "Pública";
            }
            else
                tipo = "Privada";
               

            MessageBox.Show($"===DADOS DO CADASTRO:=== \n \n \n Nome fantasia: {txtNomeFantasia.Text} \n \n Razão social: {txtRazaoSocial.Text} \n \n CNPJ: {txtCnpj.Text} \n \n Inscrição estadual: {txtInscricaoEstadual.Text} \n \n Responsável: {txtResponsavel.Text} \n \n Telefone do responsável: {txtTelefone.Text} \n \n Data de criação: {dtData.Text} \n \n Tipo: {tipo} \n \n Rua: {txtRua.Text} \n \n Bairro: {txtBairro.Text} \n \n CEP: {txtCep.Text} \n \n Número: {txtNumero.Text} \n \n Cidade: {txtCidade.Text} \n \n UF: {txtUf.Text}", "Cadastrado", MessageBoxButton.OK, MessageBoxImage.Information);


        }
    }
}
