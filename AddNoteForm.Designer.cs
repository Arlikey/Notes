namespace Notes
{
    partial class AddNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            refreshNoteButton = new Button();
            applyNoteButton = new Button();
            noteTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            noteDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            noteTitleTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            noteDescriptionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            SuspendLayout();
            // 
            // refreshNoteButton
            // 
            refreshNoteButton.BackgroundImage = Properties.Resources.free_icon_refresh_2805355;
            refreshNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            refreshNoteButton.Cursor = Cursors.Hand;
            refreshNoteButton.FlatAppearance.BorderSize = 0;
            refreshNoteButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            refreshNoteButton.FlatStyle = FlatStyle.Flat;
            refreshNoteButton.Location = new Point(505, 334);
            refreshNoteButton.Name = "refreshNoteButton";
            refreshNoteButton.Size = new Size(58, 51);
            refreshNoteButton.TabIndex = 3;
            refreshNoteButton.UseVisualStyleBackColor = true;
            refreshNoteButton.Click += refreshNoteButton_Click;
            // 
            // applyNoteButton
            // 
            applyNoteButton.BackgroundImage = Properties.Resources.free_icon_plus_3303893;
            applyNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            applyNoteButton.Cursor = Cursors.Hand;
            applyNoteButton.FlatAppearance.BorderSize = 0;
            applyNoteButton.FlatStyle = FlatStyle.Flat;
            applyNoteButton.Location = new Point(14, 334);
            applyNoteButton.Name = "applyNoteButton";
            applyNoteButton.Size = new Size(58, 51);
            applyNoteButton.TabIndex = 2;
            applyNoteButton.UseVisualStyleBackColor = true;
            applyNoteButton.Click += applyNoteButton_Click;
            // 
            // noteTitleLabel
            // 
            noteTitleLabel.AutoSize = true;
            noteTitleLabel.Depth = 0;
            noteTitleLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            noteTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            noteTitleLabel.Location = new Point(14, 77);
            noteTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            noteTitleLabel.Name = "noteTitleLabel";
            noteTitleLabel.Size = new Size(185, 24);
            noteTitleLabel.TabIndex = 4;
            noteTitleLabel.Text = "Название заметки :";
            // 
            // noteDescriptionLabel
            // 
            noteDescriptionLabel.AutoSize = true;
            noteDescriptionLabel.Depth = 0;
            noteDescriptionLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            noteDescriptionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            noteDescriptionLabel.Location = new Point(14, 157);
            noteDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            noteDescriptionLabel.Name = "noteDescriptionLabel";
            noteDescriptionLabel.Size = new Size(185, 24);
            noteDescriptionLabel.TabIndex = 4;
            noteDescriptionLabel.Text = "Описание заметки :";
            // 
            // noteTitleTextBox
            // 
            noteTitleTextBox.BackColor = Color.FromArgb(255, 255, 255);
            noteTitleTextBox.BorderStyle = BorderStyle.None;
            noteTitleTextBox.Depth = 0;
            noteTitleTextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            noteTitleTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            noteTitleTextBox.Location = new Point(14, 104);
            noteTitleTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            noteTitleTextBox.Name = "noteTitleTextBox";
            noteTitleTextBox.Size = new Size(549, 40);
            noteTitleTextBox.TabIndex = 5;
            noteTitleTextBox.Text = "";
            // 
            // noteDescriptionTextBox
            // 
            noteDescriptionTextBox.BackColor = Color.FromArgb(255, 255, 255);
            noteDescriptionTextBox.BorderStyle = BorderStyle.None;
            noteDescriptionTextBox.Depth = 0;
            noteDescriptionTextBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            noteDescriptionTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            noteDescriptionTextBox.Location = new Point(14, 194);
            noteDescriptionTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            noteDescriptionTextBox.Name = "noteDescriptionTextBox";
            noteDescriptionTextBox.Size = new Size(549, 134);
            noteDescriptionTextBox.TabIndex = 5;
            noteDescriptionTextBox.Text = "";
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 398);
            Controls.Add(noteDescriptionTextBox);
            Controls.Add(noteTitleTextBox);
            Controls.Add(noteDescriptionLabel);
            Controls.Add(noteTitleLabel);
            Controls.Add(refreshNoteButton);
            Controls.Add(applyNoteButton);
            MaximizeBox = false;
            Name = "AddNoteForm";
            Text = "Добавление заметки";
            FormClosing += AddNoteForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshNoteButton;
        private Button applyNoteButton;
        private MaterialSkin.Controls.MaterialLabel noteTitleLabel;
        private MaterialSkin.Controls.MaterialLabel noteDescriptionLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox noteTitleTextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox noteDescriptionTextBox;
    }
}