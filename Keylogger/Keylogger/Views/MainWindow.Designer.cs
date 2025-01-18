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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
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
            panel1 = new Panel();
            panel2 = new Panel();
            DgViewMousePosition = new DataGridView();
            DgMousePositionColumnDate = new DataGridViewTextBoxColumn();
            DgMousePositionColumnMessage = new DataGridViewTextBoxColumn();
            DgColumnMousePositionPosition = new DataGridViewTextBoxColumn();
            DgColumnMousePositionProcessName = new DataGridViewTextBoxColumn();
            DgViewMouseButtons = new DataGridView();
            DgMouseButtonColumnDate = new DataGridViewTextBoxColumn();
            DgViewMouseButtonColumnButton = new DataGridViewTextBoxColumn();
            DgViewMouseButtonColumnPosition = new DataGridViewTextBoxColumn();
            DgViewMouseButtonColumnProcessName = new DataGridViewTextBoxColumn();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgViewMousePosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgViewMouseButtons).BeginInit();
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
            label3.Location = new Point(746, 10);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 4;
            label3.Text = "Event to capture:";
            // 
            // CmbBoxKeyboardEvents
            // 
            CmbBoxKeyboardEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxKeyboardEvents.FormattingEnabled = true;
            CmbBoxKeyboardEvents.Location = new Point(858, 9);
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
            label5.Location = new Point(661, 53);
            label5.Name = "label5";
            label5.Size = new Size(162, 22);
            label5.TabIndex = 7;
            label5.Text = "Cursor position:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1048, 10);
            label6.Name = "label6";
            label6.Size = new Size(47, 22);
            label6.TabIndex = 12;
            label6.Text = "Show:";
            // 
            // CmbBoxKeyFilter
            // 
            CmbBoxKeyFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxKeyFilter.FormattingEnabled = true;
            CmbBoxKeyFilter.Location = new Point(1101, 11);
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
            label7.Location = new Point(426, 49);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 16;
            label7.Text = "Buttons:";
            // 
            // CmbBoxCaptureMouseButtons
            // 
            CmbBoxCaptureMouseButtons.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxCaptureMouseButtons.FormattingEnabled = true;
            CmbBoxCaptureMouseButtons.Location = new Point(483, 46);
            CmbBoxCaptureMouseButtons.Name = "CmbBoxCaptureMouseButtons";
            CmbBoxCaptureMouseButtons.Size = new Size(156, 23);
            CmbBoxCaptureMouseButtons.TabIndex = 17;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(212, 47);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 18;
            label8.Text = "Event:";
            // 
            // CmbBoxMouseEvents
            // 
            CmbBoxMouseEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxMouseEvents.FormattingEnabled = true;
            CmbBoxMouseEvents.Location = new Point(262, 47);
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
            RichTxtKeyboard.Size = new Size(1259, 348);
            RichTxtKeyboard.TabIndex = 13;
            RichTxtKeyboard.TabStop = false;
            RichTxtKeyboard.Text = "";
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
            panel1.Size = new Size(1296, 821);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(DgViewMousePosition);
            panel2.Controls.Add(DgViewMouseButtons);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CmbBoxMouseEvents);
            panel2.Controls.Add(CmbBoxCaptureMouseButtons);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 414);
            panel2.TabIndex = 22;
            // 
            // DgViewMousePosition
            // 
            DgViewMousePosition.AllowUserToAddRows = false;
            DgViewMousePosition.BackgroundColor = SystemColors.ControlLight;
            DgViewMousePosition.BorderStyle = BorderStyle.None;
            DgViewMousePosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgViewMousePosition.Columns.AddRange(new DataGridViewColumn[] { DgMousePositionColumnDate, DgMousePositionColumnMessage, DgColumnMousePositionPosition, DgColumnMousePositionProcessName });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgViewMousePosition.DefaultCellStyle = dataGridViewCellStyle1;
            DgViewMousePosition.Location = new Point(661, 78);
            DgViewMousePosition.Name = "DgViewMousePosition";
            DgViewMousePosition.RowHeadersVisible = false;
            DgViewMousePosition.Size = new Size(615, 320);
            DgViewMousePosition.TabIndex = 21;
            // 
            // DgMousePositionColumnDate
            // 
            DgMousePositionColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgMousePositionColumnDate.HeaderText = "Date";
            DgMousePositionColumnDate.Name = "DgMousePositionColumnDate";
            // 
            // DgMousePositionColumnMessage
            // 
            DgMousePositionColumnMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgMousePositionColumnMessage.HeaderText = "Message";
            DgMousePositionColumnMessage.Name = "DgMousePositionColumnMessage";
            // 
            // DgColumnMousePositionPosition
            // 
            DgColumnMousePositionPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnMousePositionPosition.HeaderText = "Position";
            DgColumnMousePositionPosition.Name = "DgColumnMousePositionPosition";
            // 
            // DgColumnMousePositionProcessName
            // 
            DgColumnMousePositionProcessName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnMousePositionProcessName.HeaderText = "Process name";
            DgColumnMousePositionProcessName.Name = "DgColumnMousePositionProcessName";
            // 
            // DgViewMouseButtons
            // 
            DgViewMouseButtons.AllowUserToAddRows = false;
            DgViewMouseButtons.BackgroundColor = SystemColors.ControlLight;
            DgViewMouseButtons.BorderStyle = BorderStyle.None;
            DgViewMouseButtons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgViewMouseButtons.Columns.AddRange(new DataGridViewColumn[] { DgMouseButtonColumnDate, DgViewMouseButtonColumnButton, DgViewMouseButtonColumnPosition, DgViewMouseButtonColumnProcessName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgViewMouseButtons.DefaultCellStyle = dataGridViewCellStyle2;
            DgViewMouseButtons.Location = new Point(17, 78);
            DgViewMouseButtons.Name = "DgViewMouseButtons";
            DgViewMouseButtons.ReadOnly = true;
            DgViewMouseButtons.RowHeadersVisible = false;
            DgViewMouseButtons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgViewMouseButtons.Size = new Size(622, 320);
            DgViewMouseButtons.TabIndex = 20;
            // 
            // DgMouseButtonColumnDate
            // 
            DgMouseButtonColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgMouseButtonColumnDate.HeaderText = "Date";
            DgMouseButtonColumnDate.Name = "DgMouseButtonColumnDate";
            DgMouseButtonColumnDate.ReadOnly = true;
            // 
            // DgViewMouseButtonColumnButton
            // 
            DgViewMouseButtonColumnButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgViewMouseButtonColumnButton.HeaderText = "Button";
            DgViewMouseButtonColumnButton.Name = "DgViewMouseButtonColumnButton";
            DgViewMouseButtonColumnButton.ReadOnly = true;
            // 
            // DgViewMouseButtonColumnPosition
            // 
            DgViewMouseButtonColumnPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgViewMouseButtonColumnPosition.HeaderText = "Position";
            DgViewMouseButtonColumnPosition.Name = "DgViewMouseButtonColumnPosition";
            DgViewMouseButtonColumnPosition.ReadOnly = true;
            // 
            // DgViewMouseButtonColumnProcessName
            // 
            DgViewMouseButtonColumnProcessName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgViewMouseButtonColumnProcessName.HeaderText = "Process name";
            DgViewMouseButtonColumnProcessName.Name = "DgViewMouseButtonColumnProcessName";
            DgViewMouseButtonColumnProcessName.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)DgViewMousePosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgViewMouseButtons).EndInit();
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
        internal ComboBox CmbBoxCaptureMouseButtons;
        internal StatusStrip statusStrip1;
        internal RichTextBox RichTxtKeyboard;
        private Panel panel1;
        private Panel panel2;
        internal DataGridView DgViewMousePosition;
        internal DataGridView DgViewMouseButtons;
        private DataGridViewTextBoxColumn DgMouseButtonColumnDate;
        private DataGridViewTextBoxColumn DgViewMouseButtonColumnButton;
        private DataGridViewTextBoxColumn DgViewMouseButtonColumnPosition;
        private DataGridViewTextBoxColumn DgViewMouseButtonColumnProcessName;
        private DataGridViewTextBoxColumn DgMousePositionColumnDate;
        private DataGridViewTextBoxColumn DgMousePositionColumnMessage;
        private DataGridViewTextBoxColumn DgColumnMousePositionPosition;
        private DataGridViewTextBoxColumn DgColumnMousePositionProcessName;
    }
}
