using System.Windows.Controls;

namespace ExpenseTracker.ExpensesContents
{
    public partial class ExpensesUserController : UserControl
    {
        public ExpensesUserController()
        {
            InitializeComponent();
        }

        private void RowDefinition_CleanUpVirtualizedItem(object sender, CleanUpVirtualizedItemEventArgs e)
        {

        }
    }
}