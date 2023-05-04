using System;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtnClick(object sender, EventArgs e)
        {
            try
            {
                double var = Convert.ToDouble(textBox1.Text);
                if (comboBox1.SelectedItem.ToString() == "Цельсия")
                {
                    if (comboBox2.SelectedItem.ToString() == "Кельвин")
                        MessageBox.Show($"{var} градусов по Цельсию (°C) = {var + 273.15} градусов по Кельвину (°K).");
                    if (comboBox2.SelectedItem.ToString() == "Фаренгейт")
                        MessageBox.Show($"{var} градусов по Цельсию (°C) ={(decimal)9 / 5 * (decimal)var + 32} градусов по Фаренгейту (°F).");
                    if (comboBox2.SelectedItem.ToString() == "Ранкин")
                        MessageBox.Show($"{var} градусов по Цельсию (°C) ={(decimal)(var + 273.15) * 9 / 5} градусов по Ранкину (°R).");
                    if (comboBox2.SelectedItem.ToString() == "Реомюр")
                        MessageBox.Show($"{var} градусов по Цельсию (°C) ={(decimal)var * 4 / 5} градусов по Реомюру (°Re).");
                }
                else if (comboBox1.SelectedItem.ToString() == "Кельвин")
                {
                    if (comboBox2.SelectedItem.ToString() == "Цельсия")
                        MessageBox.Show($"{var} градусов по Кельвину (°K) = {var - 273.15} градусов по Цельсию (°C).");
                    if (comboBox2.SelectedItem.ToString() == "Фаренгейт")
                        MessageBox.Show($"{var} градусов по Кельвину (°K) ={(decimal)var * 9 / 5 - (decimal)459.67} градусов по Фаренгейту (°F).");
                    if (comboBox2.SelectedItem.ToString() == "Ранкин")
                        MessageBox.Show($"{var} градусов по Кельвину (°K) ={(decimal)var * 9 / 5} градусов по Ранкину (°R).");
                    if (comboBox2.SelectedItem.ToString() == "Реомюр")
                        MessageBox.Show($"{var} градусов по Кельвину (°K) ={(decimal)(var - 273.15) * 4 / 5} градусов по Реомюру (°Re).");
                }
                else if (comboBox1.SelectedItem.ToString() == "Фаренгейт")
                {
                    if (comboBox2.SelectedItem.ToString() == "Цельсия")
                        MessageBox.Show($"{var} градусов по Фаренгейту (°F) = {(decimal)(var - 32) * 5 / 9} градусов по Цельсию (°C).");
                    if (comboBox2.SelectedItem.ToString() == "Кельвин")
                        MessageBox.Show($"{var} градусов по Фаренгейту (°F) ={(decimal)(var + 459.67) * 5 / 9} градусов по Кельвину (°K).");
                    if (comboBox2.SelectedItem.ToString() == "Ранкин")
                        MessageBox.Show($"{var} градусов по Фаренгейту (°F) ={var + 459.67} градусов по Ранкину (°R).");
                    if (comboBox2.SelectedItem.ToString() == "Реомюр")
                        MessageBox.Show($"{var} градусов по Фаренгейту (°F) ={(decimal)(var - 32) * 4 / 9} градусов по Реомюру (°Re).");
                }
                else if (comboBox1.SelectedItem.ToString() == "Ранкин")
                {
                    if (comboBox2.SelectedItem.ToString() == "Цельсия")
                        MessageBox.Show($"{var} градусов по Ранкину (°R) = {(decimal)(var - 491.67) * 5 / 9} градусов по Цельсию (°C).");
                    if (comboBox2.SelectedItem.ToString() == "Фаренгейт")
                        MessageBox.Show($"{var} градусов по Ранкину (°R) ={var - 459.67} градусов по Фаренгейту (°F).");
                    if (comboBox2.SelectedItem.ToString() == "Кельвин")
                        MessageBox.Show($"{var} градусов по Ранкину (°R) ={(decimal)var * 5 / 9} градусов по Кельвину (°K).");
                    if (comboBox2.SelectedItem.ToString() == "Реомюр")
                        MessageBox.Show($"{var} градусов по Ранкину (°R) ={(decimal)(var - 491.67) * 4 / 9} градусов по Реомюру (°Re).");
                }
                else if (comboBox1.SelectedItem.ToString() == "Реомюр")
                {
                    if (comboBox2.SelectedItem.ToString() == "Цельсия")
                        MessageBox.Show($"{var} градусов по Реомюру (°Re) = {(decimal)var * 5 / 4} градусов по Цельсию (°C).");
                    if (comboBox2.SelectedItem.ToString() == "Фаренгейт")
                        MessageBox.Show($"{var} градусов по Реомюру (°Re) ={(decimal)var * 9 / 4 + 32} градусов по Фаренгейту (°F).");
                    if (comboBox2.SelectedItem.ToString() == "Кельвин")
                        MessageBox.Show($"{var} градусов по Реомюру (°Re) ={(decimal)var * 5 / 4 + (decimal)273.15} градусов по Кельвину (°K).");
                    if (comboBox2.SelectedItem.ToString() == "Ранкин")
                        MessageBox.Show($"{var} градусов по Реомюру (°Re) ={(decimal)var * 9 / 4 + (decimal)491.67} градусов по Ранкину (°R).");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод.");
            }
            catch (NotFiniteNumberException)
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }
    }
}