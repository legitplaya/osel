using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kollege
{
    public partial class Form1 : Form
    {
        private DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            LoadData();
            
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
          
            tabControl1.SelectedTab = tabPage1;

            UpdateRecordCount();
            lbRecordCount1.Text = $"Количество записей: {dataGridView1.Rows.Count - 1}";

        }
       
        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRecordCount();
            TabPage selectedTab = tabControl1.SelectedTab;
            if (selectedTab == tabPage1)
                lbRecordCount1.Text = $"Количество записей: {dataGridView1.Rows.Count-1}";
            else if (selectedTab == tabPage2)
                lbRecordCount1.Text = $"Количество записей: {dataGridView2.Rows.Count-1}";
            else if (selectedTab == tabPage3)
                lbRecordCount1.Text = $"Количество записей: {dataGridView3.Rows.Count-1}";
            else if (selectedTab == tabPage4)
                lbRecordCount1.Text = $"Количество записей: {dataGridView4.Rows.Count-1}";
            else if (selectedTab == tabPage5)
                lbRecordCount1.Text = $"Количество записей: {dataGridView5.Rows.Count-1}";
        }
        private void UpdateRecordCount()
        {
            // Определяем, какая вкладка выбрана
            string selectedTable = tabControl1.SelectedTab?.Name;

            // Проверяем, что dataSet существует и содержит выбранную таблицу
            if (dataSet?.Tables[selectedTable] is DataTable dataTable)
            {
                // Обновляем счетчик записей в StatusStrip
                lbRecordCount1.Text = $"Количество записей: {dataTable.Rows.Count}";
            }
            else
            {
                // Обработка случая, если dataSet или таблица отсутствуют
                lbRecordCount1.Text = "Количество записей: 0";
            }
        }

        private void LoadData()
        {
            dataSet = new DataSet();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConString))
            {
                conn.Open();

                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Абитуриенты", conn);
                adapter1.Fill(dataSet, "Абитуриенты");

                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Заявления", conn);
                adapter2.Fill(dataSet, "Заявления");

                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM Экзамены", conn);
                adapter2.Fill(dataSet, "Экзамены");

                SqlDataAdapter adapter4 = new SqlDataAdapter("SELECT * FROM Специальности", conn);
                adapter2.Fill(dataSet, "Специальности");

                SqlDataAdapter adapter5 = new SqlDataAdapter("SELECT * FROM Оценки", conn);
                adapter2.Fill(dataSet, "Оценки");
                // Добавьте дополнительные адаптеры для других таблиц, если необходимо

                conn.Close();
            }

            // Используйте dataSet.Tables["TableName"] для доступа к каждой таблице
            dataGridView1.DataSource = dataSet.Tables["Абитуриенты"];
            dataGridView2.DataSource = dataSet.Tables["Заявления"];
            dataGridView1.DataSource = dataSet.Tables["Экзамены"];
            dataGridView2.DataSource = dataSet.Tables["Специальности"];
            dataGridView1.DataSource = dataSet.Tables["Оценки"];
            // ... добавьте другие DataGridView для других таблиц, если необходимо
        }
    }
}
