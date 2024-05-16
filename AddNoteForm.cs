using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class AddNoteForm : MaterialForm
    {
        public event Action<Note> AddNote;
        public AddNoteForm()
        {
            InitializeComponent();
        }

        private void applyNoteButton_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Title = noteTitleTextBox.Text;
            note.Description = noteDescriptionTextBox.Text;
            AddNote?.Invoke(note);
            Close();
        }

        private void refreshNoteButton_Click(object sender, EventArgs e)
        {
            noteTitleTextBox.Text = string.Empty;
            noteDescriptionTextBox.Text = string.Empty;
        }

        private void AddNoteForm_FormClosing(object sender, FormClosingEventArgs e) { }
    }
}
