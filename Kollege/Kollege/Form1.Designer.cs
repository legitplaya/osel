using System.Windows.Forms;

namespace Kollege
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.заявленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ip521_SofronovDataSet = new Kollege.ip521_SofronovDataSet();
            this.экзаменыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявленияTableAdapter = new Kollege.ip521_SofronovDataSetTableAdapters.ЗаявленияTableAdapter();
            this.экзаменыTableAdapter = new Kollege.ip521_SofronovDataSetTableAdapters.ЭкзаменыTableAdapter();
            this.специальностиTableAdapter = new Kollege.ip521_SofronovDataSetTableAdapters.СпециальностиTableAdapter();
            this.оценкиTableAdapter = new Kollege.ip521_SofronovDataSetTableAdapters.ОценкиTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.кодоценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодабитуриентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодэкзаменаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.кодспециальностиDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вакансийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодэкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодспециальностиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коддисциплиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.положительныйбаллDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодзаявленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодабитуриентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодспециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lbRecordCount1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.заявленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip521_SofronovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // заявленияBindingSource
            // 
            this.заявленияBindingSource.DataMember = "Заявления";
            this.заявленияBindingSource.DataSource = this.ip521_SofronovDataSet;
            // 
            // ip521_SofronovDataSet
            // 
            this.ip521_SofronovDataSet.DataSetName = "ip521_SofronovDataSet";
            this.ip521_SofronovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экзаменыBindingSource
            // 
            this.экзаменыBindingSource.DataMember = "Экзамены";
            this.экзаменыBindingSource.DataSource = this.ip521_SofronovDataSet;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.ip521_SofronovDataSet;
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.ip521_SofronovDataSet;
            // 
            // заявленияTableAdapter
            // 
            this.заявленияTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменыTableAdapter
            // 
            this.экзаменыTableAdapter.ClearBeforeFill = true;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 423);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Оценки";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодоценкиDataGridViewTextBoxColumn,
            this.кодабитуриентаDataGridViewTextBoxColumn1,
            this.кодэкзаменаDataGridViewTextBoxColumn1,
            this.оценкаDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.оценкиBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(792, 423);
            this.dataGridView5.TabIndex = 0;
            // 
            // кодоценкиDataGridViewTextBoxColumn
            // 
            this.кодоценкиDataGridViewTextBoxColumn.DataPropertyName = "Код_оценки";
            this.кодоценкиDataGridViewTextBoxColumn.HeaderText = "Код_оценки";
            this.кодоценкиDataGridViewTextBoxColumn.Name = "кодоценкиDataGridViewTextBoxColumn";
            this.кодоценкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодабитуриентаDataGridViewTextBoxColumn1
            // 
            this.кодабитуриентаDataGridViewTextBoxColumn1.DataPropertyName = "Код_абитуриента";
            this.кодабитуриентаDataGridViewTextBoxColumn1.HeaderText = "Код_абитуриента";
            this.кодабитуриентаDataGridViewTextBoxColumn1.Name = "кодабитуриентаDataGridViewTextBoxColumn1";
            // 
            // кодэкзаменаDataGridViewTextBoxColumn1
            // 
            this.кодэкзаменаDataGridViewTextBoxColumn1.DataPropertyName = "Код_экзамена";
            this.кодэкзаменаDataGridViewTextBoxColumn1.HeaderText = "Код_экзамена";
            this.кодэкзаменаDataGridViewTextBoxColumn1.Name = "кодэкзаменаDataGridViewTextBoxColumn1";
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Специальности";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодспециальностиDataGridViewTextBoxColumn2,
            this.названиеDataGridViewTextBoxColumn,
            this.вакансийDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.специальностиBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(792, 423);
            this.dataGridView4.TabIndex = 0;
            // 
            // кодспециальностиDataGridViewTextBoxColumn2
            // 
            this.кодспециальностиDataGridViewTextBoxColumn2.DataPropertyName = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn2.HeaderText = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn2.Name = "кодспециальностиDataGridViewTextBoxColumn2";
            this.кодспециальностиDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // вакансийDataGridViewTextBoxColumn
            // 
            this.вакансийDataGridViewTextBoxColumn.DataPropertyName = "Вакансий";
            this.вакансийDataGridViewTextBoxColumn.HeaderText = "Вакансий";
            this.вакансийDataGridViewTextBoxColumn.Name = "вакансийDataGridViewTextBoxColumn";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Экзамены";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодэкзаменаDataGridViewTextBoxColumn,
            this.кодспециальностиDataGridViewTextBoxColumn1,
            this.коддисциплиныDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.положительныйбаллDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.экзаменыBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(792, 423);
            this.dataGridView3.TabIndex = 0;
            // 
            // кодэкзаменаDataGridViewTextBoxColumn
            // 
            this.кодэкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Код_экзамена";
            this.кодэкзаменаDataGridViewTextBoxColumn.HeaderText = "Код_экзамена";
            this.кодэкзаменаDataGridViewTextBoxColumn.Name = "кодэкзаменаDataGridViewTextBoxColumn";
            this.кодэкзаменаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодспециальностиDataGridViewTextBoxColumn1
            // 
            this.кодспециальностиDataGridViewTextBoxColumn1.DataPropertyName = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn1.HeaderText = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn1.Name = "кодспециальностиDataGridViewTextBoxColumn1";
            // 
            // коддисциплиныDataGridViewTextBoxColumn
            // 
            this.коддисциплиныDataGridViewTextBoxColumn.DataPropertyName = "Код_дисциплины";
            this.коддисциплиныDataGridViewTextBoxColumn.HeaderText = "Код_дисциплины";
            this.коддисциплиныDataGridViewTextBoxColumn.Name = "коддисциплиныDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // положительныйбаллDataGridViewTextBoxColumn
            // 
            this.положительныйбаллDataGridViewTextBoxColumn.DataPropertyName = "Положительный_балл";
            this.положительныйбаллDataGridViewTextBoxColumn.HeaderText = "Положительный_балл";
            this.положительныйбаллDataGridViewTextBoxColumn.Name = "положительныйбаллDataGridViewTextBoxColumn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заявления";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодзаявленияDataGridViewTextBoxColumn,
            this.кодабитуриентаDataGridViewTextBoxColumn,
            this.кодспециальностиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.заявленияBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 417);
            this.dataGridView2.TabIndex = 0;
            // 
            // кодзаявленияDataGridViewTextBoxColumn
            // 
            this.кодзаявленияDataGridViewTextBoxColumn.DataPropertyName = "Код_заявления";
            this.кодзаявленияDataGridViewTextBoxColumn.HeaderText = "Код_заявления";
            this.кодзаявленияDataGridViewTextBoxColumn.Name = "кодзаявленияDataGridViewTextBoxColumn";
            this.кодзаявленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодабитуриентаDataGridViewTextBoxColumn
            // 
            this.кодабитуриентаDataGridViewTextBoxColumn.DataPropertyName = "Код_абитуриента";
            this.кодабитуриентаDataGridViewTextBoxColumn.HeaderText = "Код_абитуриента";
            this.кодабитуриентаDataGridViewTextBoxColumn.Name = "кодабитуриентаDataGridViewTextBoxColumn";
            // 
            // кодспециальностиDataGridViewTextBoxColumn
            // 
            this.кодспециальностиDataGridViewTextBoxColumn.DataPropertyName = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn.HeaderText = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn.Name = "кодспециальностиDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абитуриенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbRecordCount});
            this.statusStrip1.Location = new System.Drawing.Point(3, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 417);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbRecordCount1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 427);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(800, 22);
            this.statusStrip2.TabIndex = 3;
            // 
            // lbRecordCount1
            // 
            this.lbRecordCount1.Name = "lbRecordCount1";
            this.lbRecordCount1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заявленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip521_SofronovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private ip521_SofronovDataSet ip521_SofronovDataSet;
        private System.Windows.Forms.BindingSource заявленияBindingSource;
        private ip521_SofronovDataSetTableAdapters.ЗаявленияTableAdapter заявленияTableAdapter;
        private System.Windows.Forms.BindingSource экзаменыBindingSource;
        private ip521_SofronovDataSetTableAdapters.ЭкзаменыTableAdapter экзаменыTableAdapter;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private ip521_SofronovDataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private ip521_SofronovDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодоценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодабитуриентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодэкзаменаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециальностиDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вакансийDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодэкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециальностиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn положительныйбаллDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаявленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодабитуриентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbRecordCount;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lbRecordCount1;
    }
}

