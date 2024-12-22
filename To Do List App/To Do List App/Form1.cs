using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Sütun Oluştur
            todoList.Columns.Add("Başlık");
            todoList.Columns.Add("Açıklama");

            // Datagrdwiew
            ToDoListWiew.DataSource = todoList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListWiew.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // metin alanlarını tablodaki verilerle doldur
            BaşlıkKutusu.Text = todoList.Rows[ToDoListWiew.CurrentCell.RowIndex].ItemArray[0].ToString();
            AçıklamaKutusu.Text = todoList.Rows[ToDoListWiew.CurrentCell.RowIndex].ItemArray[1].ToString();
        }
    

        private void YeniButon_Click(object sender, EventArgs e)
        {
            BaşlıkKutusu.Text = "";
            AçıklamaKutusu.Text = "";
        }

        private void KaydetmeButonu_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListWiew.CurrentCell.RowIndex]["Başlık"] = BaşlıkKutusu.Text;
                todoList.Rows[ToDoListWiew.CurrentCell.RowIndex]["Açıklama"] = AçıklamaKutusu.Text;
            }
            else
            {
                todoList.Rows.Add(BaşlıkKutusu.Text, AçıklamaKutusu.Text);
            }
            // Alanları Temizle
            BaşlıkKutusu.Text = "";
            AçıklamaKutusu.Text = "";
            isEditing = false;
            

        }
    }
}
