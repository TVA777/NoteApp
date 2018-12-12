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
	public partial class EditForm : Form
	{
		private Note _note;
		public Note Note
		{
			get
			{
				return _note;
			}
			set
			{
				_note = value;
				if (_note != null)
				{
					textBox3.Text = _note.NoteText;
				}

			}
		}

		public EditForm()
		{
			InitializeComponent();
			this.Text = "Add/Edit Note";
			this.Size = new Size(400, 250);
			comboBox2.Items.Add(NoteCategory.Work);
			comboBox2.Items.Add(NoteCategory.Home);
			comboBox2.Items.Add(NoteCategory.Finance);
			comboBox2.Items.Add(NoteCategory.Different);
			comboBox2.Items.Add(NoteCategory.Health_and_sport);
			comboBox2.Items.Add(NoteCategory.People);
			comboBox2.Items.Add(NoteCategory.Documents);
			dateTimePicker1.Enabled = false;
			dateTimePicker2.Enabled = false;
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			_note.NoteText = textBox3.Text;
			_note.timeModificated = DateTime.Now; 
		}
		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		//private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		//{

		//	Console.WriteLine(DateTime.Now);
		//}

		//private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		//{

		//	Console.WriteLine(DateTime.Now);
		//}
	}
}
