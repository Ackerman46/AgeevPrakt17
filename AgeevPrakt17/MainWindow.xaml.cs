using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace AgeevPrakt17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AgeevBDEntities db = AgeevBDEntities.GetContext();
        List<Student> _student;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Агеев Алексей\nЗадание\nСведения об успеваемости студентов. База данных должна содержать следующую информацию: фамилию, имя, отчество студента, номер группы, в которой обучается студент, название учебной дисциплины, номер задания, коэффициент сложности, оценку данного студента по данной дисциплине за данное задание от 0 до 1 (как доля сделанной работы)");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddList f = new AddList();
            f.ShowDialog();
            StudentsDG.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Students.Load();
            StudentsDG.ItemsSource = db.Students.Local.ToBindingList();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = StudentsDG.SelectedIndex;
            if (indexRow != -1)
            {
                Student row = (Student)StudentsDG.Items[indexRow];
                Transmission.Id = row.Id;

                ChangeList f = new ChangeList();
                f.ShowDialog();
                StudentsDG.Items.Refresh();
                StudentsDG.Focus();
            }
        }
        private void DelFromDb_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Вы действительно хотите удалить запись ?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Student row = (Student)StudentsDG.SelectedItems[0];
                    db.Students.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберете запись");
                }
            }
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < StudentsDG.Items.Count; i++)
            {
                var row = (Student)StudentsDG.Items[i];
                string findContent = row.Frist_name;
                try
                {
                    if (findContent != null && findContent.Contains(FindBox.Text))
                    {
                        object item = StudentsDG.Items[i];
                        StudentsDG.SelectedItem = item;
                        StudentsDG.ScrollIntoView(item);
                        StudentsDG.Focus();
                        break;
                    }
                }
                catch
                {

                }

            }
        }

        private void QuantityButton_Click(object sender, RoutedEventArgs e)
        {
            short.TryParse(quantityBox.Text, out short quantity);
            _student = db.Students.ToList();
            var filtered = _student.Where(_student => _student.grade == quantity);
            StudentsDG.ItemsSource = filtered;
        }
        private void filtrstop(object sender, RoutedEventArgs e)
        {
            StudentsDG.ItemsSource = db.Students.Local.ToBindingList();
        }
    }
}
