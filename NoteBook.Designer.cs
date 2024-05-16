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
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            SuspendLayout();
            // 
            // addNoteButton
            // 
            addNoteButton.BackgroundImage = Properties.Resources.free_icon_plus_3303893;
            addNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            addNoteButton.Cursor = Cursors.Hand;
            addNoteButton.FlatAppearance.BorderSize = 0;
            addNoteButton.FlatStyle = FlatStyle.Flat;
            addNoteButton.Location = new Point(14, 334);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(58, 51);
            addNoteButton.TabIndex = 0;
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.BackgroundImage = Properties.Resources.free_icon_recycle_bin_3156999;
            deleteNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            deleteNoteButton.Cursor = Cursors.Hand;
            deleteNoteButton.FlatAppearance.BorderSize = 0;
            deleteNoteButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            deleteNoteButton.FlatStyle = FlatStyle.Flat;
            deleteNoteButton.Location = new Point(505, 334);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Size = new Size(58, 51);
            deleteNoteButton.TabIndex = 1;
            deleteNoteButton.UseVisualStyleBackColor = true;
            deleteNoteButton.Click += deleteNoteButton_Click;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(14, 77);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(549, 233);
            materialListBox1.TabIndex = 2;
            // 
            // NoteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 398);
            Controls.Add(materialListBox1);
            Controls.Add(deleteNoteButton);
            Controls.Add(addNoteButton);
            MaximizeBox = false;
            Name = "NoteBook";
            Text = "Заметки";
            ResumeLayout(false);
        }

        #endregion

        private Button addNoteButton;
        private Button deleteNoteButton;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
    }
}
