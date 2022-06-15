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
        public List<ComboBoxItem> items { get; set; }

        public Category()
        {
            InitializeComponent();

            InitComboBox();
        }

        private void InitComboBox()
        {
            items = new List<ComboBoxItem>()
            {
                new ComboBoxItem() { categoryName = "식비" },
                new ComboBoxItem() { categoryName = "교통비" },
                new ComboBoxItem() { categoryName = "문화생활" },
                new ComboBoxItem() { categoryName = "생필품" },
                new ComboBoxItem() { categoryName = "의류" },
                new ComboBoxItem() { categoryName = "미용" },
            };
            categoryComboBox.DisplayMemberPath = "categoryName";
            categoryComboBox.ItemsSource = items;
            categoryComboBox.SelectedIndex = 0;
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

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(categoryComboBox.SelectedValue.ToString());
        }
    }
    public class ComboBoxItem
    {
        public string categoryName { get; set; }
    }
}
