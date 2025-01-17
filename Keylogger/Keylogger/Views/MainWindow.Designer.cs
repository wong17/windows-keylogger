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
            RichTxtMouseButtons = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            CmbBoxKeyboardEvents = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CmbBoxKeyFilter = new ComboBox();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLbl = new ToolStripStatusLabel();
            label7 = new Label();
            CmbBoxCaptureMouseButtons = new ComboBox();
            label8 = new Label();
            CmbBoxMouseEvents = new ComboBox();
            RichTxtKeyboard = new RichTextBox();
            RichTxtMousePosition = new RichTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Keyboard";
            // 
            // RichTxtMouseButtons
            // 
            RichTxtMouseButtons.BackColor = SystemColors.ControlLight;
            RichTxtMouseButtons.BorderStyle = BorderStyle.None;
            RichTxtMouseButtons.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtMouseButtons.HideSelection = false;
            RichTxtMouseButtons.Location = new Point(17, 78);
            RichTxtMouseButtons.Name = "RichTxtMouseButtons";
            RichTxtMouseButtons.ReadOnly = true;
            RichTxtMouseButtons.Size = new Size(615, 322);
            RichTxtMouseButtons.TabIndex = 3;
            RichTxtMouseButtons.TabStop = false;
            RichTxtMouseButtons.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Mouse";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(754, 10);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 4;
            label3.Text = "Event to capture:";
            // 
            // CmbBoxKeyboardEvents
            // 
            CmbBoxKeyboardEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxKeyboardEvents.FormattingEnabled = true;
            CmbBoxKeyboardEvents.Location = new Point(866, 9);
            CmbBoxKeyboardEvents.Name = "CmbBoxKeyboardEvents";
            CmbBoxKeyboardEvents.Size = new Size(175, 23);
            CmbBoxKeyboardEvents.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 53);
            label4.Name = "label4";
            label4.Size = new Size(113, 22);
            label4.TabIndex = 6;
            label4.Text = "Pressed buttons";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(670, 53);
            label5.Name = "label5";
            label5.Size = new Size(162, 22);
            label5.TabIndex = 7;
            label5.Text = "Cursor position:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1056, 10);
            label6.Name = "label6";
            label6.Size = new Size(47, 22);
            label6.TabIndex = 12;
            label6.Text = "Show:";
            // 
            // CmbBoxKeyFilter
            // 
            CmbBoxKeyFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxKeyFilter.FormattingEnabled = true;
            CmbBoxKeyFilter.Location = new Point(1109, 11);
            CmbBoxKeyFilter.Name = "CmbBoxKeyFilter";
            CmbBoxKeyFilter.Size = new Size(175, 23);
            CmbBoxKeyFilter.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLbl });
            statusStrip1.Location = new Point(0, 821);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1296, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLbl
            // 
            ToolStripStatusLbl.Name = "ToolStripStatusLbl";
            ToolStripStatusLbl.Size = new Size(0, 17);
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1071, 23);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 16;
            label7.Text = "Buttons:";
            // 
            // CmbBoxCaptureMouseButtons
            // 
            CmbBoxCaptureMouseButtons.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxCaptureMouseButtons.FormattingEnabled = true;
            CmbBoxCaptureMouseButtons.Location = new Point(1128, 23);
            CmbBoxCaptureMouseButtons.Name = "CmbBoxCaptureMouseButtons";
            CmbBoxCaptureMouseButtons.Size = new Size(156, 23);
            CmbBoxCaptureMouseButtons.TabIndex = 17;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(857, 21);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 18;
            label8.Text = "Event:";
            // 
            // CmbBoxMouseEvents
            // 
            CmbBoxMouseEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxMouseEvents.FormattingEnabled = true;
            CmbBoxMouseEvents.Location = new Point(907, 21);
            CmbBoxMouseEvents.Name = "CmbBoxMouseEvents";
            CmbBoxMouseEvents.Size = new Size(134, 23);
            CmbBoxMouseEvents.TabIndex = 19;
            // 
            // RichTxtKeyboard
            // 
            RichTxtKeyboard.BackColor = SystemColors.ControlLight;
            RichTxtKeyboard.BorderStyle = BorderStyle.None;
            RichTxtKeyboard.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtKeyboard.HideSelection = false;
            RichTxtKeyboard.Location = new Point(17, 40);
            RichTxtKeyboard.Name = "RichTxtKeyboard";
            RichTxtKeyboard.ReadOnly = true;
            RichTxtKeyboard.Size = new Size(1267, 348);
            RichTxtKeyboard.TabIndex = 13;
            RichTxtKeyboard.TabStop = false;
            RichTxtKeyboard.Text = "";
            // 
            // RichTxtMousePosition
            // 
            RichTxtMousePosition.BackColor = SystemColors.ControlLight;
            RichTxtMousePosition.BorderStyle = BorderStyle.None;
            RichTxtMousePosition.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtMousePosition.HideSelection = false;
            RichTxtMousePosition.Location = new Point(670, 78);
            RichTxtMousePosition.Name = "RichTxtMousePosition";
            RichTxtMousePosition.ReadOnly = true;
            RichTxtMousePosition.Size = new Size(614, 322);
            RichTxtMousePosition.TabIndex = 20;
            RichTxtMousePosition.TabStop = false;
            RichTxtMousePosition.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(RichTxtKeyboard);
            panel1.Controls.Add(CmbBoxKeyboardEvents);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CmbBoxKeyFilter);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 404);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(RichTxtMouseButtons);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CmbBoxMouseEvents);
            panel2.Controls.Add(RichTxtMousePosition);
            panel2.Controls.Add(CmbBoxCaptureMouseButtons);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 414);
            panel2.TabIndex = 22;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 843);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Keylogger - D. Wong";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        internal ToolStripStatusLabel ToolStripStatusLbl;
        private Label label7;
        private Label label8;
        internal ComboBox CmbBoxKeyboardEvents;
        internal ComboBox CmbBoxKeyFilter;
        internal ComboBox CmbBoxMouseEvents;
        internal RichTextBox RichTxtMouseButtons;
        internal ComboBox CmbBoxCaptureMouseButtons;
        internal StatusStrip statusStrip1;
        internal RichTextBox RichTxtKeyboard;
        internal RichTextBox RichTxtMousePosition;
        private Panel panel1;
        private Panel panel2;
    }
}
