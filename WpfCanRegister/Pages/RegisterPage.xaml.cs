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
using WpfCanRegister.Helpers;

namespace WpfCanRegister.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private RegistrationValidator _validator;

        public delegate void RegistrationCompletedEventHandler(object sender, EventArgs e);
        public event RegistrationCompletedEventHandler RegistrationCompleted;

        public RegisterPage()
        {
            InitializeComponent();
            _validator = new RegistrationValidator();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            int age = int.Parse(AgeTextBox.Text);
            string email = EmailTextBox.Text;

            bool canRegister = _validator.CanRegister(name, age, email);
            if (canRegister)
            {
                RegistrationCompleted?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Регистрация успешна");
            }
            else
            {
                MessageBox.Show("Регистрация не прошла");
            }
            MessageBox.Show(canRegister ? "Регистрация прошла" : "Регистрация не прошла");
        }
    }
}
