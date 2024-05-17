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
using static System.Net.Mime.MediaTypeNames;

namespace Notes
{
    public partial class AddNoteForm : MaterialForm
    {
        public event Action<Note> AddNote;
        public AddNoteForm()
        {
            InitializeComponent();
            noteTitleTextBox.TextChanged += NoteTitleTextBox_TextChanged;
        }

        private void NoteTitleTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noteTitleTextBox.Text))
            {
                warnLabel.Visible = true;
                applyNoteButton.Enabled = false;
            }
            else
            {
                warnLabel.Visible = false;
                applyNoteButton.Enabled = true;
            }
        }

        private void applyNoteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noteTitleTextBox.Text))
            {
                warnLabel.Visible = true;
                applyNoteButton.Enabled = false;
                return;
            }
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
