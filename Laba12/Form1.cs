using Laba10;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new Gender[] { Gender.Female, Gender.Male };
            comboBox2.DataSource = new Category[] { Category.Beginner, Category.Middle, Category.God };
        }

        TestCollections collections = new TestCollections(1);

        private void ShowCollections()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(collections);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(textBox1.Text, "^[А-Я][а-я]") && Regex.IsMatch(textBox2.Text, "^[А-Я][а-я]"))
                {
                    collections.Add(new Engineer(textBox1.Text, textBox2.Text, (Gender)comboBox1.SelectedItem, (Category)comboBox2.SelectedItem));
                    ShowCollections();
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show($"{ex.Message} {ex.Firstname} {ex.Surname}");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                collections = new TestCollections((int)numericUpDown1.Value);
                collections.AddRandom();
                ShowCollections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(textBox1.Text, "^[А-Я][а-я]") && Regex.IsMatch(textBox2.Text, "^[А-Я][а-я]"))
                {
                    collections.Del(textBox1.Text, textBox2.Text);
                    ShowCollections();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
