namespace Keylogger.Views
{
    partial class MainWindow
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
            label1 = new Label();
            RichTxtKeyboard = new RichTextBox();
            RichTxtMouseButtons = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            CmbBoxEvents = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            RichTxtMousePosition = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Keyboard";
            // 
            // RichTxtKeyboard
            // 
            RichTxtKeyboard.BackColor = SystemColors.ControlLight;
            RichTxtKeyboard.BorderStyle = BorderStyle.None;
            RichTxtKeyboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtKeyboard.HideSelection = false;
            RichTxtKeyboard.Location = new Point(24, 97);
            RichTxtKeyboard.Name = "RichTxtKeyboard";
            RichTxtKeyboard.ReadOnly = true;
            RichTxtKeyboard.Size = new Size(562, 541);
            RichTxtKeyboard.TabIndex = 1;
            RichTxtKeyboard.Text = "";
            // 
            // RichTxtMouseButtons
            // 
            RichTxtMouseButtons.BackColor = SystemColors.ControlLight;
            RichTxtMouseButtons.BorderStyle = BorderStyle.None;
            RichTxtMouseButtons.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtMouseButtons.HideSelection = false;
            RichTxtMouseButtons.Location = new Point(609, 97);
            RichTxtMouseButtons.Name = "RichTxtMouseButtons";
            RichTxtMouseButtons.ReadOnly = true;
            RichTxtMouseButtons.Size = new Size(562, 241);
            RichTxtMouseButtons.TabIndex = 3;
            RichTxtMouseButtons.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(609, 17);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Mouse";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 58);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 4;
            label3.Text = "Evento a capturar:";
            // 
            // CmbBoxEvents
            // 
            CmbBoxEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxEvents.FormattingEnabled = true;
            CmbBoxEvents.Location = new Point(155, 57);
            CmbBoxEvents.Name = "CmbBoxEvents";
            CmbBoxEvents.Size = new Size(135, 23);
            CmbBoxEvents.TabIndex = 5;
            CmbBoxEvents.SelectedIndexChanged += CmbBoxEvents_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(609, 57);
            label4.Name = "label4";
            label4.Size = new Size(162, 22);
            label4.TabIndex = 6;
            label4.Text = "Botones presionados:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(609, 355);
            label5.Name = "label5";
            label5.Size = new Size(162, 22);
            label5.TabIndex = 7;
            label5.Text = "Posición del cursor:";
            // 
            // RichTxtMousePosition
            // 
            RichTxtMousePosition.BackColor = SystemColors.ControlLight;
            RichTxtMousePosition.BorderStyle = BorderStyle.None;
            RichTxtMousePosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtMousePosition.HideSelection = false;
            RichTxtMousePosition.Location = new Point(609, 397);
            RichTxtMousePosition.Name = "RichTxtMousePosition";
            RichTxtMousePosition.ReadOnly = true;
            RichTxtMousePosition.Size = new Size(562, 241);
            RichTxtMousePosition.TabIndex = 8;
            RichTxtMousePosition.Text = "";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 667);
            Controls.Add(RichTxtMousePosition);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CmbBoxEvents);
            Controls.Add(label3);
            Controls.Add(RichTxtMouseButtons);
            Controls.Add(label2);
            Controls.Add(RichTxtKeyboard);
            Controls.Add(label1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Keylogger - D. Wong";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CmbBoxEvents;
        private RichTextBox RichTxtKeyboard;
        private RichTextBox RichTxtMouseButtons;
        private Label label4;
        private Label label5;
        private RichTextBox RichTxtMousePosition;
    }
}
