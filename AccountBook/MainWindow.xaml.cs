using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using AccountBook.Common;
using AccountBook.Views;

namespace AccountBook
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel mainViewModel;

        public string categoryName { get; set; }
        public string category2Name { get; set; }
        public string paymentName { get; set; }
        public string payment2Name { get; set; }
        public string ioName { get; set; }
        public string cardName { get; set; }
        public List<MainWindow> categoryItems { get; set; }
        public List<MainWindow> category2Items { get; set; }
        public List<MainWindow> paymentItems { get; set; }
        public List<MainWindow> payment2Items { get; set; }
        public List<MainWindow> ioItems { get; set; }
        public List<MainWindow> cardItems { get; set; }

        public MainWindow()
        { 
            this.DataContext = mainViewModel;
            this.Loaded += MainWindow_Loaded;
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            categoryItems = new List<MainWindow>()
            {
                new MainWindow() { categoryName = "교통비" },
                new MainWindow() { categoryName = "문화생활" },
                new MainWindow() { categoryName = "생필품" },
                new MainWindow() { categoryName = "의류" },
                new MainWindow() { categoryName = "미용" },
            };
            categoryComboBox.DisplayMemberPath = "categoryName";
            categoryComboBox.ItemsSource = categoryItems;
            categoryComboBox.SelectedIndex = 0;

            paymentItems = new List<MainWindow>()
            {
                new MainWindow() { paymentName = "현금" },
                new MainWindow() { paymentName = "카드" },
                new MainWindow() { paymentName = "선택안함" },
            };
            paymentComboBox.DisplayMemberPath = "paymentName";
            paymentComboBox.ItemsSource = paymentItems;
            paymentComboBox.SelectedIndex = 0;

            ioItems = new List<MainWindow>()
            {
                new MainWindow() { ioName = "입금" },
                new MainWindow() { ioName = "출금" },
                new MainWindow() { ioName = "자산이동" },
            };
            ioComboBox.DisplayMemberPath = "ioName";
            ioComboBox.ItemsSource = ioItems;
            ioComboBox.SelectedIndex = 1;

            payment2Items = new List<MainWindow>()
            {
                new MainWindow() { payment2Name = "현금" },
                new MainWindow() { payment2Name = "카드" },
                new MainWindow() { payment2Name = "선택안함" },
            };
            payment2ComboBox.DisplayMemberPath = "payment2Name";
            payment2ComboBox.ItemsSource = payment2Items;
            payment2ComboBox.SelectedIndex = 0;

            category2Items = new List<MainWindow>()
            {
                new MainWindow() { category2Name = "교통비" },
                new MainWindow() { category2Name = "문화생활" },
                new MainWindow() { category2Name = "생필품" },
                new MainWindow() { category2Name = "의류" },
                new MainWindow() { category2Name = "미용" },
            };
            category2ComboBox.DisplayMemberPath = "category2Name";
            category2ComboBox.ItemsSource = category2Items;
            category2ComboBox.SelectedIndex = 0;

            cardItems = new List<MainWindow>()
            {
                new MainWindow() { cardName = "현대카드" },
                new MainWindow() { cardName = "삼성카드" },
                new MainWindow() { cardName = "롯데카드" },
                new MainWindow() { cardName = "카드없음" },
            };
            cardTypeComboBox.DisplayMemberPath = "cardName";
            cardTypeComboBox.ItemsSource = cardItems;
            cardTypeComboBox.SelectedIndex = 0;

            targetDP.SelectedDate = DateTime.Today;
            StartDP.SelectedDate = DateTime.Today;
            EndDP.SelectedDate = DateTime.Today;
        }

        private void CategoryManager_Click(object sender, RoutedEventArgs e)
        {
            // '카테고리 관리' 팝업창 클릭 이벤트
            Category categoryView = new Category();
            categoryView.ShowDialog();
        }

        private void TargetMoneySettingPopup_Click(object sender, RoutedEventArgs e)
        {
            // '목표 금액 예산 설정' 팝업창 클릭 이벤트
            TargetBudget targetBudgetView = new TargetBudget();
            targetBudgetView.ShowDialog();
        }

        private void SearchText_Click(object sender, RoutedEventArgs e)
        {
            // 검색 클릭이벤트
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // 초기화 클릭이벤트
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            // 입력 확인 클릭이벤트
        }

        private void CardTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(cardTypeComboBox.SelectedValue.ToString());
        }
    }
}
