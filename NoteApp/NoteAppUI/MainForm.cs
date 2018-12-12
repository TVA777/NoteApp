using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
	public partial class MainForm : Form
	{
		private Project _project = new Project();

		public MainForm()
		{
			InitializeComponent();
			this.Text = "Главное окно программы";
			this.Size = new Size(400, 250);
			comboBox1.Items.Add(NoteCategory.Work);
			comboBox1.Items.Add(NoteCategory.Home);
			comboBox1.Items.Add(NoteCategory.Finance);
			comboBox1.Items.Add(NoteCategory.Different);
			comboBox1.Items.Add(NoteCategory.Health_and_sport);
			comboBox1.Items.Add(NoteCategory.People);
			comboBox1.Items.Add(NoteCategory.Documents);
		

		}
		private void Edit_Click(object sender, EventArgs e)
		{
			EditForm EdForm = new EditForm();
			EdForm.ShowDialog();
			var selectedIndex = listbox1.SelectedIndex;
			var selectedData = _project.Notes[selectedIndex];
			var inner = new EditForm(); //Создаем форму
			inner.Note = selectedData; //Передаем форме данные
			inner.ShowDialog(); //Отображаем форму для редактирования
			var updatedData = inner.Note; //Забираем измененные данные
											 //Осталось удалить старые данные по выбранному индексу
											 // и заменить их на обновленные
			listbox1.Items.RemoveAt(selectedIndex);
			_project.Notes.RemoveAt(selectedIndex);
			_project.Notes.Insert(selectedIndex, updatedData);
			var time = updatedData.timeModificated.ToLongTimeString();
			var text = updatedData.NoteText;
			listbox1.Items.Insert(selectedIndex, time + " " + text);

		}
		private void Add_Click(object sender, EventArgs e)
		{
			EditForm EdForm = new EditForm();
			EdForm.ShowDialog();
			
		}
		private void Remove_Click(object sender, EventArgs e)
		{
			
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			label1.Text = (sender as ListBox).Text;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void removeNoteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			
		}

		private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
	

		}

		private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm AbForm = new AboutForm();
			AbForm.Show();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditForm EdForm = new EditForm();
			EdForm.Show();
		}	
			

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			label2.Text = (sender as ComboBox).Text;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
		
			Console.WriteLine(DateTime.Now);
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			Console.WriteLine(DateTime.Now);
		}
	}
}