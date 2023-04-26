using System;
using System.Security;
using System.Windows.Forms;
using TimeTracker1.AuthClasses;
using TimeTracker1.DataBase;
using Excel = Microsoft.Office.Interop.Excel;

namespace TimeTracker1
{
    public partial class FormAnalyze : Form
    {
        private ClassUserAuht user;
        private ClassDataBase database;

        public FormAnalyze()
        {
            InitializeComponent();
        }

        private void FormAnalyze_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (!user.Roles.Contains(1))
            {
                dataGridView1.Rows.Add(user.UserId, user.Lastname, user.Firstname, user.Middlename, user.Phone, user.Email);
            }
            else
            {
                var resultFunc = database.SelectFunction("select * from autorization.user");
                while (resultFunc.Read())
                {
                    dataGridView1.Rows.Add(resultFunc.GetValue(0).ToString().Split(' ')[0], resultFunc.GetValue(2), resultFunc.GetValue(1), resultFunc.GetValue(3), resultFunc.GetValue(4), resultFunc.GetValue(5));

                    if (!resultFunc.IsDBNull(6) && resultFunc.GetBoolean(6))
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.White;

                    }
                }
                resultFunc.Close();
            }
        }

        public void SetUser(ClassUserAuht _user)
        {
            this.user = _user;
        }
        public void SetDB(ClassDataBase _db)
        {
            this.database = _db;
        }

        private void FormAnalyze_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            textBoxDateEnd.Text = string.Empty;
            textBoxDateStart.Text = string.Empty;
            dataGridView1.Refresh();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите вариант отчета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDateStart.Text) || string.IsNullOrEmpty(textBoxDateEnd.Text))
            {
                MessageBox.Show("Заполните фильтр даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView1.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Выберите логин(ы) интересующих пользователей в таблице!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Данных таймера
            var cellUsers = dataGridView1.SelectedCells;

            Excel.Application app = new Excel.Application
            {
                //Количество листов в рабочей книге
                SheetsInNewWorkbook = 1
            };
            //Добавить рабочую книгу
            Excel.Workbook workBook = app.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            app.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);

            switch (comboBox1.SelectedIndex)
            {
                //Пользователь - Приложение
                case 0:
                    sheet.Name = "Пользователь - Приложение";
                    int cnt = 0;
                    int indexX0 = 2;
                    sheet.Cells[1, 1] = "Пользователь";
                    sheet.Cells[1, 2] = "Дата";
                    sheet.Cells[1, 3] = "Приложение";
                    sheet.Cells[1, 4] = "Время работы";
                    for (int i = 0; i < cellUsers.Count; i++)
                    {
                        string userlogin = cellUsers[i].Value.ToString();
                        var resultFunc = database.SelectFunction($"select u.login, t.date, t.description, sum(t.duration) from public.timer t inner join autorization.user u " +
                            $"on t.user_id = u.user_id where u.user_id = "+cellUsers[i].Value+ " and t.date >= to_date('" + textBoxDateStart.Text + "', 'yyyy-mm-dd') and" +
                            " t.date <= to_date('" + textBoxDateEnd.Text + "', 'yyyy-mm-dd')  group by u.login, t.date, t.description order by t.date;");
                        if (resultFunc != null)
                        {
                            while (resultFunc.Read())
                            {
                                String sumtime= resultFunc.GetValue(3).ToString();
                                if (sumtime[0]!='0' || sumtime[1] != '0' || sumtime[3] != '0' || sumtime[4] != '0')
                                {
                                sheet.Cells[indexX0, 1] = resultFunc.GetValue(0).ToString();
                                sheet.Cells[indexX0, 2] = resultFunc.GetValue(1).ToString().Split(' ')[0];
                                sheet.Cells[indexX0, 3] = resultFunc.GetValue(2).ToString();
                                sheet.Cells[indexX0, 4] = sumtime;
                                indexX0++;
                                cnt++;
                                }
                            }
                            resultFunc.Close();
                        }

                    }
                    sheet.Columns[1].ColumnWidth = 15;
                    sheet.Columns[2].ColumnWidth = 10;
                    sheet.Columns[3].ColumnWidth = 70;
                    sheet.Columns[4].ColumnWidth = 13;

                    sheet.Cells.Font.Name = "Times New Roman";
                    sheet.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    sheet.Cells.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    Excel.Chart excelchart0 = (Excel.Chart)app.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    excelchart0.Activate();

                    //Изменяем тип диаграммы
                    app.ActiveChart.ChartType = Excel.XlChartType.xlLineMarkers;

                    //Перемещаем диаграмму на лист 1
                    app.ActiveChart.Location(Excel.XlChartLocation.xlLocationAsObject, "Пользователь - Приложение");
                    //Получаем ссылку на лист 1
                    var excelsheets0 = workBook.Worksheets;
                    sheet = (Excel.Worksheet)excelsheets0.get_Item(1);
                    //Перемещаем диаграмму в нужное место
                    sheet.Shapes.Item(1).IncrementTop(-300);
                    sheet.Shapes.Item(1).IncrementLeft(370);

                    //Задаем размеры диаграммы
                    sheet.Shapes.Item(1).Height = 500;
                    sheet.Shapes.Item(1).Width = cnt*80;

                    break;
                //Пользователь - День
                case 1:
                    sheet.Name = "Пользователь - Дата";
                    int indexX = 2;
                    cnt = 0;
                    sheet.Cells[1, 1] = "Пользователь";
                    sheet.Cells[1, 2] = "Дата";
                    sheet.Cells[1, 3] = "Время работы";
                    for (int i = 0; i < cellUsers.Count; i++)
                    {
                        string userlogin = cellUsers[i].Value.ToString();
                        var resultFunc = database.SelectFunction($"select u.login, t.date, sum(t.duration) from public.timer t inner join autorization.user u " +
                            $"on t.user_id = u.user_id where u.user_id = " + cellUsers[i].Value + " and t.date >= to_date('" + textBoxDateStart.Text + "', 'yyyy-mm-dd') and t.date <= to_date('" + textBoxDateEnd.Text + "', 'yyyy-mm-dd') group by u.login, t.date order by t.date;");
                        if (resultFunc != null)
                        {

                            while (resultFunc.Read())
                            {
                                String sumtime = resultFunc.GetValue(2).ToString();
                                if (sumtime[0] != '0' || sumtime[1] != '0' || sumtime[3] != '0' || sumtime[4] != '0')
                                {
                                    sheet.Cells[indexX, 1] = resultFunc.GetValue(0).ToString();
                                    sheet.Cells[indexX, 2] = resultFunc.GetValue(1).ToString().Split(' ')[0];
                                    sheet.Cells[indexX, 3] = resultFunc.GetValue(2).ToString();
                                    indexX++;
                                    cnt++;
                                }
                            }
                            resultFunc.Close();
                        }
                    }
                    sheet.Columns[1].ColumnWidth = 15;
                    sheet.Columns[2].ColumnWidth = 10;
                    sheet.Columns[3].ColumnWidth = 15;
                    sheet.Cells.Font.Name = "Times New Roman";
                    sheet.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    sheet.Cells.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    Excel.Chart excelchart = (Excel.Chart)app.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    excelchart.Activate();

                    //Изменяем тип диаграммы
                    //app.ActiveChart.ChartType = Excel.XlChartType.xlLineMarkers;

                    //Перемещаем диаграмму на лист 1
                    app.ActiveChart.Location(Excel.XlChartLocation.xlLocationAsObject, "Пользователь - Дата");
                    //Получаем ссылку на лист 1
                    var excelsheets = workBook.Worksheets;
                    sheet = (Excel.Worksheet)excelsheets.get_Item(1);
                    //Перемещаем диаграмму в нужное место
                    sheet.Shapes.Item(1).IncrementTop(-300);
                    sheet.Shapes.Item(1).IncrementLeft(70);

                    //Задаем размеры диаграммы
                    sheet.Shapes.Item(1).Height = 500;
                    sheet.Shapes.Item(1).Width = cnt*80;

                    break;
                default:
                    MessageBox.Show("Неизвестный вариант графика!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            string nameRep = $"Report_{DateTime.Now.ToShortDateString().ToString()}_{DateTime.Now.Hour.ToString()}_{DateTime.Now.Minute.ToString()}_{DateTime.Now.Second.ToString()}.xlsx";
            //Сохранение отчета
            app.Application.ActiveWorkbook.SaveAs(nameRep, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //Завершение работы с excel
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);

            MessageBox.Show($"Отчет {nameRep} успешно сформирован!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxDateStart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
