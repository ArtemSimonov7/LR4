using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР4_Мак_Мин
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  //обрработчик ошибок try -catch для предотвращения не правильного ввода ошибок пользователя
  //сначала выполняется блок try, если возникает ошибка, то срабатывет блок catch
            try
            {
                string username = textBox1.Text;//получаем строку из текстового поля , типа  данных string
                int[] ia = username.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();//делим ее посимвольно если стретился пробел

                int minValue = ia.Min();//находим минимальное число в массиве с помощью встроенной функции Min()

                textBox2.Text = ("Минимальное число: " + minValue);//выводим это число
            }
            catch (Exception ex) //блок обработки ошибки
            {
                MessageBox.Show("Введите массив через пробел"+ex); //вывод сообщения об ошибке
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //обрработчик ошибок try -catch для предотвращения не правильного ввода ошибок пользователя
            //сначала выполняется блок try, если возникает ошибка, то срабатывет блок catch
            try
            {
                string username = textBox1.Text;//объявление переменной username типа стринг и присвоение значения из текстбокса1
                //объявление одномерного массива типа int.
                //запись элементов в массив происходит по элементно путем деления строки username на символы,
                //если встречается пробел (условие деления прописывается в ковычках в скобках)
                int[] ia = username.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

                int maxValue = ia.Max();//находим максимальное число (встроенной функцией Мах)

                textBox3.Text = ("Максимальое число: " + maxValue); //вывод найденного значения в тексбок3
            }
            catch (Exception ex) //блок обработки ошибки
            {
                MessageBox.Show("Введите массив через пробел" + ex); //вывод сообщения об ошибке
            }


        }
    }
}
