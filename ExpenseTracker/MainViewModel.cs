using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using ExpenseTracker.ExpensesContents;


namespace ExpenseTracker
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ICommand showAcountsUserWindow;
        private readonly ICommand showBillsUserWindow;
        private readonly ICommand showExpensesUserWindow;

        private object currentUserWindow;

        public MainViewModel()
        {
            showAcountsUserWindow = new DelegateCommand(() => CurrentUserWindow = new AccountsViewModel());
            showBillsUserWindow = new DelegateCommand(() => CurrentUserWindow = new BillsViewModel());
            showExpensesUserWindow = new DelegateCommand(() => CurrentUserWindow = new ExpensesViewModel());
            //CurrentUserWindow = new LibraryViewModel();
        }

        public object CurrentUserWindow
        {
            get { return currentUserWindow; }
            set {
                currentUserWindow = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentUserWindow)));
            }
        }

        public ICommand ShowAcountsUserWindow => showAcountsUserWindow;

        public ICommand ShowExpensesUserWindow => showExpensesUserWindow;

        public ICommand ShowBillsUserWindow => showBillsUserWindow;


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
