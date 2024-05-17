namespace Notes
{
    partial class NoteBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addNoteButton = new Button();
            deleteNoteButton = new Button();
            panel1 = new Panel();
            loadButton = new Button();
            saveButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addNoteButton
            // 
            addNoteButton.BackgroundImage = Properties.Resources.free_icon_plus_3303893;
            addNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            addNoteButton.Cursor = Cursors.Hand;
            addNoteButton.Dock = DockStyle.Left;
            addNoteButton.FlatAppearance.BorderSize = 0;
            addNoteButton.FlatStyle = FlatStyle.Flat;
            addNoteButton.Location = new Point(30, 0);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(59, 65);
            addNoteButton.TabIndex = 0;
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.BackgroundImage = Properties.Resources.free_icon_recycle_bin_3156999;
            deleteNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteNoteButton.Cursor = Cursors.Hand;
            deleteNoteButton.Dock = DockStyle.Right;
            deleteNoteButton.FlatAppearance.BorderSize = 0;
            deleteNoteButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            deleteNoteButton.FlatStyle = FlatStyle.Flat;
            deleteNoteButton.Location = new Point(481, 0);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Size = new Size(58, 65);
            deleteNoteButton.TabIndex = 1;
            deleteNoteButton.UseVisualStyleBackColor = true;
            deleteNoteButton.Click += deleteNoteButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(addNoteButton);
            panel1.Controls.Add(deleteNoteButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 330);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 0, 30, 0);
            panel1.Size = new Size(569, 65);
            panel1.TabIndex = 3;
            // 
            // loadButton
            // 
            loadButton.BackgroundImage = Properties.Resources.free_icon_upload_1250734_removebg_preview;
            loadButton.BackgroundImageLayout = ImageLayout.Zoom;
            loadButton.Cursor = Cursors.Hand;
            loadButton.FlatAppearance.BorderSize = 0;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Bahnschrift SemiBold Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loadButton.Location = new Point(336, 0);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 65);
            loadButton.TabIndex = 2;
            loadButton.Text = "LOAD";
            loadButton.TextAlign = ContentAlignment.BottomCenter;
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadNotesFromFile;
            // 
            // saveButton
            // 
            saveButton.BackgroundImage = Properties.Resources.free_icon_save_2550221;
            saveButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Bahnschrift SemiBold Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(199, 0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(71, 62);
            saveButton.TabIndex = 2;
            saveButton.Text = "SAVE";
            saveButton.TextAlign = ContentAlignment.BottomCenter;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveNotesToFile;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 266);
            panel2.TabIndex = 4;
            // 
            // NoteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 398);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimumSize = new Size(575, 398);
            Name = "NoteBook";
            Text = "Заметки";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addNoteButton;
        private Button deleteNoteButton;
        private Panel panel1;
        private Panel panel2;
        private Button saveButton;
        private Button loadButton;
    }
}
