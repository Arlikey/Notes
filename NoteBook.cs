using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System.ComponentModel;

namespace Notes
{
    public partial class NoteBook : MaterialForm
    {
        private BindingList<Note> notes;
        private Panel lastExpandedPanel;
        public NoteBook()
        {
            InitializeComponent();

            notes = new BindingList<Note>();
        }
        private void CreateNotePanel(Note note)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Click += Panel_Click;
            panel.MouseEnter += Panel_MouseEnter;
            panel.MouseLeave += Panel_MouseLeave;
            panel.BackColor = Color.Transparent;
            panel.Tag = note;

            Label title = new Label();
            title.Text = note.Title;
            title.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            title.AutoSize = true;
            title.Click += Panel_Click;
            title.MouseEnter += Panel_MouseEnter;
            title.MouseLeave += Panel_MouseLeave;
            panel.Controls.Add(title);
            title.Location = new Point((ClientSize.Width - title.Width) / 2, 10);

            panel.Size = new Size(ClientSize.Width, title.Height + 20);
            title.MaximumSize = new Size(panel.Width, 0);

            Label description = new Label();
            description.Text = note.Description;
            description.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            description.AutoSize = true;
            description.Location = new Point(10, title.Height + 30);
            description.MaximumSize = new Size(panel.Width - 20, 0);
            description.Visible = false;


            panel.Controls.Add(description);
            panel2.Controls.Add(panel);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel clickedPanel)
            {
                panel = clickedPanel;
            }
            else if (sender is Label clickedLabel && clickedLabel.Parent is Panel parentPanel)
            {
                panel = parentPanel;
            }

            if (panel != null)
            {

                foreach (Control control in panel.Controls)
                {
                    if (control is Label description && control != panel.Controls[0])
                    {
                        description.Visible = !description.Visible;

                        if (description.Visible)
                        {
                            panel.BackColor = Color.FromArgb(45, 160, 252);
                            panel.Size = new Size(ClientSize.Width, panel.Controls[0].Height + description.Height + 30);
                            if (lastExpandedPanel != null)
                            {
                                lastExpandedPanel.BackColor = Color.Transparent;
                            }
                            lastExpandedPanel = panel;
                        }
                        else
                        {
                            panel.BackColor = Color.Transparent;
                            panel.Size = new Size(ClientSize.Width, panel.Controls[0].Height + 20);
                            if (lastExpandedPanel == panel)
                            {
                                lastExpandedPanel = null;
                            }
                        }

                        break;
                    }
                }
            }
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel clickedPanel)
            {
                panel = clickedPanel;
            }
            else if (sender is Label clickedLabel && clickedLabel.Parent is Panel parentPanel)
            {
                panel = parentPanel;
            }
            if (panel != null)
            {
                if (panel.BackColor == Color.FromArgb(45, 160, 252))
                {
                    panel.BackColor = Color.FromArgb(45, 62, 252);
                    return;
                }
                panel.BackColor = Color.DarkGray;
            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel clickedPanel)
            {
                panel = clickedPanel;
            }
            else if (sender is Label clickedLabel && clickedLabel.Parent is Panel parentPanel)
            {
                panel = parentPanel;
            }
            if (panel != null)
            {
                if (panel.BackColor == Color.FromArgb(45, 160, 252) || panel.BackColor == Color.FromArgb(45, 62, 252))
                {
                    panel.BackColor = Color.FromArgb(45, 160, 252);
                    return;
                }
                panel.BackColor = Color.Transparent;
            }
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
            notes.Add(obj);
            CreateNotePanel(obj);
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if (lastExpandedPanel != null)
            {
                Note note = lastExpandedPanel.Tag as Note;
                if (note != null)
                {
                    notes.Remove(note);
                }
                panel2.Controls.Remove(lastExpandedPanel);
                lastExpandedPanel.Dispose();
                lastExpandedPanel = null;
            }
        }

        private void SaveNotesToFile(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("Введите название для файла : ", "Сохранение в файл");
            try
            {
                using (StreamWriter writer = new StreamWriter($"{fileName}.txt"))
                {
                    foreach (Note note in notes)
                    {
                        writer.WriteLine($"{note.Title} : {note.Description}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении заметок в файл: " + ex.Message);
            }
            MessageBox.Show($"Файл был успешно сохранен!");
        }

        private void LoadNotesFromFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                try
                {
                    var filePath = openFileDialog.FileName;

                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 2)
                        {
                            Note note = new Note { Title = parts[0], Description = parts[1] };
                            CreateNotePanel(note);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении заметок из файла: " + ex.Message);
                }
            }
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
