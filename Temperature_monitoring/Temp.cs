using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_monitoring
{
    public partial class Temp : Form
    {
        int Max_temp = 0;
        int Min_temp = 0;
        int Max_time = 0;
        int Min_time = 0;

        public Temp()
        {
            InitializeComponent();
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Время";
            //column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "Time";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Факт";
            column2.Name = "Fact";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Допустимое значение";
            column3.Name = "Dopusc";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Отклонение";
            column4.Name = "Otclon";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            OutputTable.Columns.Add(column1);
            OutputTable.Columns.Add(column2);
            OutputTable.Columns.Add(column3);
            OutputTable.Columns.Add(column4);

            OutputTable.AllowUserToAddRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Temp_min_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Raschet_Click(object sender, EventArgs e)
        {

            try
            {
                int norma = 0;
                int summ_time = 0;
                string vid_rb;

                //int data_time_10 = 0;

                Max_temp = Convert.ToInt32(Temp_max1.Text);
                Min_temp = Convert.ToInt32(Temp_min1.Text);
                Max_time = Convert.ToInt32(Time_max1.Text);
                Min_time = Convert.ToInt32(Time_min1.Text);
                //data_time_10 = Convert.ToInt32(Data_time1.Text);
                vid_rb = Convert.ToString(Vid1.Text);
                int porog_ment = 0;
                int porog_semg = 0;



                string[] str = Temp_fish1.Text.Split(' ');
                int[] arr = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    arr[i] = Convert.ToInt32(str[i]);
                    summ_time = summ_time + 1;
                }

                for (int j = 0; j < summ_time; j++)
                {
                    OutputTable.Rows.Add();
                    OutputTable["Time", OutputTable.Rows.Count - 1].Value = j + 1;
                    norma = arr[j];
                    OutputTable["Fact", OutputTable.Rows.Count - 1].Value = norma;

                    if (vid_rb.Contains("Минтай"))
                    {
                        Max_temp = Min_temp;
                        if (norma > Max_temp)
                        {
                            OutputTable["Dopusc", OutputTable.Rows.Count - 1].Value = Max_temp;
                            OutputTable["Otclon", OutputTable.Rows.Count - 1].Value = norma - Max_temp;
                            porog_ment = porog_ment + 1;

                        }
                        else
                        {
                            OutputTable["Time", OutputTable.Rows.Count - 1].Value = null;
                            OutputTable["Fact", OutputTable.Rows.Count - 1].Value = null;
                            OutputTable["Dopusc", OutputTable.Rows.Count - 1].Value = null;
                            OutputTable["Otclon", OutputTable.Rows.Count - 1].Value = null;
                        }
                    }
                    if (porog_ment > Max_time)
                    {
                        porog_ment = porog_ment * 10;
                        MessageBox.Show("Порог максмально допустимой температуры превышен на " + porog_ment + " минут");
                        MessageBox.Show("Нарушено условие хранение рыбы");
                    }


                    else if (vid_rb.Contains("Семга"))
                    {
                        if (norma > Max_temp)
                        {
                            OutputTable["Dopusc", OutputTable.Rows.Count - 1].Value = Max_temp;
                            OutputTable["Otclon", OutputTable.Rows.Count - 1].Value = norma - Max_temp;
                            porog_semg = porog_semg + 10;
                        }
                        if (norma < Min_temp)
                        {
                            OutputTable["Dopusc", OutputTable.Rows.Count - 1].Value = Min_temp;
                            OutputTable["Otclon", OutputTable.Rows.Count - 1].Value = norma - Min_temp;
                            porog_semg = porog_semg + 10;
                        }
                        else
                        {
                            OutputTable["Time", OutputTable.Rows.Count - 1].Value = null;
                            OutputTable["Fact", OutputTable.Rows.Count - 1].Value = null;
                            OutputTable["Dopusc", OutputTable.Rows.Count - 1].Value = null;
                            OutputTable["Otclon", OutputTable.Rows.Count - 1].Value = null;
                        }
                        if (porog_semg > Min_time)
                        {
                            //porog_semg = porog_semg * 10;
                            MessageBox.Show("Порог минимально допустимой температуры превышен на " + porog_semg + " минут");
                            MessageBox.Show("Нарушено условие хранение рыбы");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Data_time1_TextChanged(object sender, EventArgs e)
        {
            //Data_time1.Text = String.Format("Вы выбрали: {0}", Data_time1.Value.ToLongTimeString());
            //Data_time1.ShowUpDown = true;
            //Data_time1.CustomFormat = "hh:mm";
            //Data_time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

        }
    }
}
