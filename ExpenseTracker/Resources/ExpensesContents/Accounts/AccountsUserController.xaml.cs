using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;

namespace ExpenseTracker.ExpensesContents
{
    public partial class AccountsUserController : UserControl
    {
        private string accountName;

        public AccountsUserController()
        {
            InitializeComponent();
        }

        string AccountName
        {
            get { return accountName; }
            set
            {
                accountName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AccountName)));
            }
        }

        private void ButtonAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}