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
            warnLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // refreshNoteButton
            // 
            refreshNoteButton.BackgroundImage = Properties.Resources.free_icon_refresh_2805355;
            refreshNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            refreshNoteButton.Cursor = Cursors.Hand;
            refreshNoteButton.Dock = DockStyle.Right;
            refreshNoteButton.FlatAppearance.BorderSize = 0;
            refreshNoteButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            refreshNoteButton.FlatStyle = FlatStyle.Flat;
            refreshNoteButton.Location = new Point(481, 0);
            refreshNoteButton.Name = "refreshNoteButton";
            refreshNoteButton.Size = new Size(58, 65);
            refreshNoteButton.TabIndex = 3;
            refreshNoteButton.UseVisualStyleBackColor = true;
            refreshNoteButton.Click += refreshNoteButton_Click;
            // 
            // applyNoteButton
            // 
            applyNoteButton.BackgroundImage = Properties.Resources.free_icon_plus_3303893;
            applyNoteButton.BackgroundImageLayout = ImageLayout.Zoom;
            applyNoteButton.Cursor = Cursors.Hand;
            applyNoteButton.Dock = DockStyle.Left;
            applyNoteButton.FlatAppearance.BorderSize = 0;
            applyNoteButton.FlatStyle = FlatStyle.Flat;
            applyNoteButton.Location = new Point(30, 0);
            applyNoteButton.Name = "applyNoteButton";
            applyNoteButton.Size = new Size(58, 65);
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
            // warnLabel
            // 
            warnLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            warnLabel.AutoSize = true;
            warnLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            warnLabel.ForeColor = Color.Red;
            warnLabel.Location = new Point(106, 21);
            warnLabel.Name = "warnLabel";
            warnLabel.Size = new Size(144, 20);
            warnLabel.TabIndex = 6;
            warnLabel.Text = "Укажите название!";
            warnLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(applyNoteButton);
            panel1.Controls.Add(warnLabel);
            panel1.Controls.Add(refreshNoteButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 330);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 0, 30, 0);
            panel1.Size = new Size(569, 65);
            panel1.TabIndex = 7;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 398);
            Controls.Add(panel1);
            Controls.Add(noteDescriptionTextBox);
            Controls.Add(noteTitleTextBox);
            Controls.Add(noteDescriptionLabel);
            Controls.Add(noteTitleLabel);
            MaximizeBox = false;
            MinimumSize = new Size(575, 398);
            Name = "AddNoteForm";
            Text = "Добавление заметки";
            FormClosing += AddNoteForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label warnLabel;
        private Panel panel1;
    }
}