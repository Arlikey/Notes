using MaterialSkin.Controls;
using System.ComponentModel;

namespace Notes
{
    public partial class NoteBook : MaterialForm
    {
        private BindingList<Note> notes;
        public NoteBook()
        {
            InitializeComponent();
            notes = new BindingList<Note>();
            materialListBox1.DataContext = notes;
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            AddNoteForm addNoteForm = new AddNoteForm();
            addNoteForm.Size = this.Size;
            addNoteForm.StartPosition = FormStartPosition.CenterParent;
            addNoteForm.AddNote += AddNoteForm_AddNote;
            addNoteForm.ShowDialog();
        }

        private void AddNoteForm_AddNote(Note obj)
        {
            materialListBox1.Items.Add(new MaterialSkin.MaterialListBoxItem(obj.Title));
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if(materialListBox1.SelectedIndex == -1)
            {
                return;
            }
            materialListBox1.RemoveItemAt(materialListBox1.SelectedIndex);
        }
    }

    public class Note
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public override string ToString()
        {
            return Title;
        }
    }
}
