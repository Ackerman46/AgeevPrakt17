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
using System.Windows.Shapes;

namespace AgeevPrakt17
{
    /// <summary>
    /// Логика взаимодействия для AddList.xaml
    /// </summary>
    public partial class AddList : Window
    {
        AgeevBDEntities db = AgeevBDEntities.GetContext();
        Student p1 = new Student();
        public AddList()
        {
            InitializeComponent();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            short.TryParse(GroupnumTB.Text, out short groupnum);
            int.TryParse(ExerciseTB.Text, out int exercisenum);
            short.TryParse(HardCB.Text, out short hardnum);
            short.TryParse(GradeCB.Text, out short gradenum);
            if (NameTB.Text.Length == 0) errors.AppendLine("Введите имя");
            if (FamilyTB.Text.Length == 0) errors.AppendLine("Введите фамилию");
            if (groupnum < 0 || groupnum == 0) errors.AppendLine("Корректно введите номер группы");
            if (DisciplineTB.Text.Length == 0) errors.AppendLine("Введите название дисциплины");
            if (exercisenum < 0 || exercisenum == 0) errors.AppendLine("Корректно введите номер задания");
            if (HardCB.Text != "1" && HardCB.Text != "2" && HardCB.Text != "3") errors.AppendLine("Корректно задайте уровень сложности задания");
            if (GradeCB.Text != "0" && GradeCB.Text != "1") errors.AppendLine("Корректно задайте оценку");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                p1.Frist_name = NameTB.Text;
                p1.Family = FamilyTB.Text;
                p1.Last_name = LnameTB.Text;
                p1.Group_number = groupnum;
                p1.academic_discipline = DisciplineTB.Text;
                p1.exercise___num = exercisenum;
                p1.hard_level = hardnum;
                p1.grade = gradenum;
            }
            try
            {
                db.Students.Add(p1);
                db.SaveChanges();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void CancelBt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
