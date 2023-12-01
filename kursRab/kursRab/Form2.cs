using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;


namespace kursRab
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet2.logpass". При необходимости она может быть перемещена или удалена.
            this.logpassTableAdapter.Fill(this.ip521_Sofronov_KRDataSet2.logpass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1.Фильмы_для_лиц_старше_17_лет". При необходимости она может быть перемещена или удалена.
            this.фильмы_для_лиц_старше_17_летTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1.Фильмы_для_лиц_старше_17_лет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1.самый_первый_купленный_билет". При необходимости она может быть перемещена или удалена.
            this.самый_первый_купленный_билетTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1.самый_первый_купленный_билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1.Посетители_старше_18_лет". При необходимости она может быть перемещена или удалена.
            this.посетители_старше_18_летTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1.Посетители_старше_18_лет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1.Минимальная_стоимость_билета". При необходимости она может быть перемещена или удалена.
            this.минимальная_стоимость_билетаTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1.Минимальная_стоимость_билета);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1.Максимальная_стоимость_билета". При необходимости она может быть перемещена или удалена.
            this.максимальная_стоимость_билетаTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1.Максимальная_стоимость_билета);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1._Кол_во_сеансов_в_1_зале_за_все_время". При необходимости она может быть перемещена или удалена.
            this.кол_во_сеансов_в_1_зале_за_все_времяTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1._Кол_во_сеансов_в_1_зале_за_все_время);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1._Кол_во_свободных_залов". При необходимости она может быть перемещена или удалена.
            this.кол_во_свободных_заловTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1._Кол_во_свободных_залов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1._Кол_во_купленных_билетов_дороже_500_рублей". При необходимости она может быть перемещена или удалена.
            this.кол_во_купленных_билетов_дороже_500_рублейTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1._Кол_во_купленных_билетов_дороже_500_рублей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1._Кол_во_занятых_залов". При необходимости она может быть перемещена или удалена.
            this.кол_во_занятых_заловTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1._Кол_во_занятых_залов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet1.Билеты_купленные_за_20_лет". При необходимости она может быть перемещена или удалена.
            this.билеты_купленные_за_20_летTableAdapter.Fill(this.ip521_Sofronov_KRDataSet1.Билеты_купленные_за_20_лет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet.tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.ip521_Sofronov_KRDataSet.tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet.rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.ip521_Sofronov_KRDataSet.rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet.customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.ip521_Sofronov_KRDataSet.customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ip521_Sofronov_KRDataSet.films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.ip521_Sofronov_KRDataSet.films);

           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl2.Visible = false;
        }

        private void представленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl2.Visible = true;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.Update(this.ip521_Sofronov_KRDataSet.tickets);
            this.roomsTableAdapter.Update(this.ip521_Sofronov_KRDataSet.rooms);
            this.customersTableAdapter.Update(this.ip521_Sofronov_KRDataSet.customers);
            this.filmsTableAdapter.Update(this.ip521_Sofronov_KRDataSet.films);
        }

        private void фильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Your Message ", "Title", "Default Response");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                dataGridView1.Rows[i].Visible = dataGridView1[1, i].Value.ToString() == UserAnswer;

        }
    }
}
