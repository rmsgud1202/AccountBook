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
        private MainWindowViewModel viewModel;

        public MainWindow()
        { 
            InitializeComponent();
            this.DataContext = viewModel;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //var currentYear = DateTime.Today.Year;
            //var currentMonth = DateTime.Today.Month;
            //var currentDay = DateTime.Today.Day;
            //SelectedDateTime = $"{currentYear}-{currentMonth}-{currentDay}";
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
    }
}
