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
using System.Windows.Shapes;

namespace AccountBook.Views
{
    /// <summary>
    /// Category.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Category : Window
    {
        public Category()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Save();
            this.Close();
        }

        private void Save()
        {
            // 편집할 카테고리 Text 저장
            // 추가할 카테고리 Text 저장
        }
    }
}
