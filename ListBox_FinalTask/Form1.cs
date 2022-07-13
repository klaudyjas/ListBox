using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_FinalTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader czytacz = new StreamReader("dane.txt");
            string linia;
            linia = czytacz.ReadLine();
            while (linia != null)
            {
                listbox.Items.Add(linia);
                linia = czytacz.ReadLine();
            }
            czytacz.Close();
            if (listbox.Items.Count > 0)
                listbox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dzień dobry! Gotowy do działania?", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_z.Text != "")
            {
                Boolean jestDuplikat = false;

                foreach (String element in listbox.Items)
                    if (element.Equals(txt_z.Text))
                        jestDuplikat = true;

                if (!jestDuplikat)
                {
                    if (doEdycji)
                    {
                        int pozDoZmiany = listbox.SelectedIndex;
                        listbox.Items.RemoveAt(pozDoZmiany);
                        listbox.Items.Insert(pozDoZmiany, txt_z.Text);
                        listbox.SelectedIndex = pozDoZmiany;
                        doEdycji = false;
                        txt_z.Focus();
                        txt_z.Clear();
                    }
                    else
                    {
                        int pozNowego = listbox.Items.Add(txt_z.Text);
                        listbox.SelectedIndex = pozNowego;
                    }

                }
                else
                {
                    MessageBox.Show("To zadanie już istnieje!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                panelZ.Visible = false;
                panelBtns.Enabled = true;
                panelList.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wpisz zadanie do dodania", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_dodajz_Click(object sender, EventArgs e)
        {
            panelBtns.Enabled = false;
            panelList.Enabled = false;
            panelZ.Visible = true;
            txt_z.Clear();
            txt_z.Focus();
        }

        private void btn_usunw_Click(object sender, EventArgs e)
        {
            const string message = "Czy na pewno chcesz usunać wszystkie zadania?";
            const string caption = "Potwierdzenie usunięcia wszystkich zadań";
            var result = MessageBox.Show(message, caption,
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                listbox.Items.Clear();
            }
        }

        private void btn_usunz_Click(object sender, EventArgs e)
        {
            int indexZadanie = listbox.SelectedIndex;
            if (indexZadanie >= 0)
            {
                listbox.Items.RemoveAt(indexZadanie);
                listbox.SelectedIndex = indexZadanie - 1;
            }
        }
        private void btn_edytujz_Click(object sender, EventArgs e)
        {
            btn_dodajz_Click(sender, e);
            if (listbox.SelectedIndex >= 0)
            {
                txt_z.Text = listbox.SelectedItem.ToString();
            }
            doEdycji = true;
        }
        bool doEdycji = false;

        private void btn_x_Click(object sender, EventArgs e)
        {
            panelZ.Visible = false;
            panelList.Enabled = true;
            panelBtns.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter zapisywacz = new StreamWriter("dane.txt");
            foreach (String element in listbox.Items)
                zapisywacz.WriteLine(element);
            zapisywacz.Close();
        }
    }
}
