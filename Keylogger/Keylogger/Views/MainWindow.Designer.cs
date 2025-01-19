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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            DgViewMouseButtons = new DataGridView();
            DgMouseButtonColumnDate = new DataGridViewTextBoxColumn();
            DgViewMouseButtonColumnButton = new DataGridViewTextBoxColumn();
            DgViewMouseButtonColumnPosition = new DataGridViewTextBoxColumn();
            DgViewMouseButtonColumnProcessName = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            RichTxtMousePosition = new RichTextBox();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgViewMouseButtons).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 0;
            label1.Text = "Keyboard";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 404);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 5;
            label2.Text = "Mouse";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 1);
            label3.Name = "label3";
            label3.Size = new Size(106, 26);
            label3.TabIndex = 1;
            label3.Text = "Event to capture:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmbBoxKeyboardEvents
            // 
            CmbBoxKeyboardEvents.Anchor = AnchorStyles.Right;
            CmbBoxKeyboardEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxKeyboardEvents.FormattingEnabled = true;
            CmbBoxKeyboardEvents.Location = new Point(115, 3);
            CmbBoxKeyboardEvents.Name = "CmbBoxKeyboardEvents";
            CmbBoxKeyboardEvents.Size = new Size(175, 23);
            CmbBoxKeyboardEvents.TabIndex = 2;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0, 0, 3, 8);
            label4.Name = "label4";
            label4.Size = new Size(198, 44);
            label4.TabIndex = 6;
            label4.Text = "Pressed buttons";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(624, 42);
            label5.TabIndex = 7;
            label5.Text = "Cursor position:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(296, 1);
            label6.Name = "label6";
            label6.Size = new Size(42, 26);
            label6.TabIndex = 3;
            label6.Text = "Show:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmbBoxKeyFilter
            // 
            CmbBoxKeyFilter.Anchor = AnchorStyles.Right;
            CmbBoxKeyFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxKeyFilter.FormattingEnabled = true;
            CmbBoxKeyFilter.Location = new Point(344, 3);
            CmbBoxKeyFilter.Name = "CmbBoxKeyFilter";
            CmbBoxKeyFilter.Size = new Size(211, 23);
            CmbBoxKeyFilter.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLbl });
            statusStrip1.Location = new Point(0, 819);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1294, 22);
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
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(193, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 39);
            label7.TabIndex = 9;
            label7.Text = "Buttons:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmbBoxCaptureMouseButtons
            // 
            CmbBoxCaptureMouseButtons.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxCaptureMouseButtons.FormattingEnabled = true;
            CmbBoxCaptureMouseButtons.Location = new Point(257, 10);
            CmbBoxCaptureMouseButtons.Margin = new Padding(3, 10, 0, 3);
            CmbBoxCaptureMouseButtons.Name = "CmbBoxCaptureMouseButtons";
            CmbBoxCaptureMouseButtons.Size = new Size(163, 23);
            CmbBoxCaptureMouseButtons.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 39);
            label8.TabIndex = 7;
            label8.Text = "Event:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CmbBoxMouseEvents
            // 
            CmbBoxMouseEvents.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxMouseEvents.FormattingEnabled = true;
            CmbBoxMouseEvents.Location = new Point(53, 10);
            CmbBoxMouseEvents.Margin = new Padding(3, 10, 3, 3);
            CmbBoxMouseEvents.Name = "CmbBoxMouseEvents";
            CmbBoxMouseEvents.Size = new Size(134, 23);
            CmbBoxMouseEvents.TabIndex = 8;
            // 
            // RichTxtKeyboard
            // 
            RichTxtKeyboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTxtKeyboard.BackColor = SystemColors.ControlLight;
            RichTxtKeyboard.BorderStyle = BorderStyle.None;
            RichTxtKeyboard.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtKeyboard.HideSelection = false;
            RichTxtKeyboard.Location = new Point(13, 62);
            RichTxtKeyboard.Name = "RichTxtKeyboard";
            RichTxtKeyboard.ReadOnly = true;
            RichTxtKeyboard.Size = new Size(1266, 323);
            RichTxtKeyboard.TabIndex = 13;
            RichTxtKeyboard.TabStop = false;
            RichTxtKeyboard.Text = "";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RichTxtKeyboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 401);
            panel1.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(CmbBoxKeyboardEvents);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(CmbBoxKeyFilter);
            flowLayoutPanel1.Location = new Point(721, 14);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(558, 30);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(DgViewMouseButtons, 0, 1);
            tableLayoutPanel3.Location = new Point(10, 428);
            tableLayoutPanel3.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.Size = new Size(635, 390);
            tableLayoutPanel3.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(629, 52);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(CmbBoxMouseEvents);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(CmbBoxCaptureMouseButtons);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(204, 3);
            flowLayoutPanel2.Margin = new Padding(3, 3, 0, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(425, 46);
            flowLayoutPanel2.TabIndex = 23;
            // 
            // DgViewMouseButtons
            // 
            DgViewMouseButtons.AllowUserToAddRows = false;
            DgViewMouseButtons.AllowUserToResizeRows = false;
            DgViewMouseButtons.BackgroundColor = SystemColors.ControlLight;
            DgViewMouseButtons.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Silver;
            dataGridViewCellStyle7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DgViewMouseButtons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DgViewMouseButtons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgViewMouseButtons.Columns.AddRange(new DataGridViewColumn[] { DgMouseButtonColumnDate, DgViewMouseButtonColumnButton, DgViewMouseButtonColumnPosition, DgViewMouseButtonColumnProcessName });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            DgViewMouseButtons.DefaultCellStyle = dataGridViewCellStyle12;
            DgViewMouseButtons.Dock = DockStyle.Fill;
            DgViewMouseButtons.EnableHeadersVisualStyles = false;
            DgViewMouseButtons.Location = new Point(3, 61);
            DgViewMouseButtons.Name = "DgViewMouseButtons";
            DgViewMouseButtons.ReadOnly = true;
            DgViewMouseButtons.RowHeadersVisible = false;
            DgViewMouseButtons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgViewMouseButtons.Size = new Size(629, 326);
            DgViewMouseButtons.TabIndex = 20;
            // 
            // DgMouseButtonColumnDate
            // 
            DgMouseButtonColumnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.ForeColor = Color.White;
            DgMouseButtonColumnDate.DefaultCellStyle = dataGridViewCellStyle8;
            DgMouseButtonColumnDate.HeaderText = "Date";
            DgMouseButtonColumnDate.Name = "DgMouseButtonColumnDate";
            DgMouseButtonColumnDate.ReadOnly = true;
            DgMouseButtonColumnDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            DgMouseButtonColumnDate.Width = 51;
            // 
            // DgViewMouseButtonColumnButton
            // 
            DgViewMouseButtonColumnButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.ForeColor = Color.White;
            DgViewMouseButtonColumnButton.DefaultCellStyle = dataGridViewCellStyle9;
            DgViewMouseButtonColumnButton.HeaderText = "Button";
            DgViewMouseButtonColumnButton.Name = "DgViewMouseButtonColumnButton";
            DgViewMouseButtonColumnButton.ReadOnly = true;
            DgViewMouseButtonColumnButton.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DgViewMouseButtonColumnPosition
            // 
            DgViewMouseButtonColumnPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.ForeColor = Color.White;
            DgViewMouseButtonColumnPosition.DefaultCellStyle = dataGridViewCellStyle10;
            DgViewMouseButtonColumnPosition.HeaderText = "Position";
            DgViewMouseButtonColumnPosition.Name = "DgViewMouseButtonColumnPosition";
            DgViewMouseButtonColumnPosition.ReadOnly = true;
            DgViewMouseButtonColumnPosition.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DgViewMouseButtonColumnProcessName
            // 
            DgViewMouseButtonColumnProcessName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.ForeColor = Color.White;
            DgViewMouseButtonColumnProcessName.DefaultCellStyle = dataGridViewCellStyle11;
            DgViewMouseButtonColumnProcessName.HeaderText = "Process name";
            DgViewMouseButtonColumnProcessName.Name = "DgViewMouseButtonColumnProcessName";
            DgViewMouseButtonColumnProcessName.ReadOnly = true;
            DgViewMouseButtonColumnProcessName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(RichTxtMousePosition, 0, 1);
            tableLayoutPanel1.Location = new Point(651, 444);
            tableLayoutPanel1.Margin = new Padding(3, 3, 15, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(630, 374);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // RichTxtMousePosition
            // 
            RichTxtMousePosition.BorderStyle = BorderStyle.None;
            RichTxtMousePosition.Dock = DockStyle.Fill;
            RichTxtMousePosition.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTxtMousePosition.HideSelection = false;
            RichTxtMousePosition.Location = new Point(3, 45);
            RichTxtMousePosition.Name = "RichTxtMousePosition";
            RichTxtMousePosition.ReadOnly = true;
            RichTxtMousePosition.Size = new Size(624, 326);
            RichTxtMousePosition.TabIndex = 21;
            RichTxtMousePosition.Text = "";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 841);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Keylogger - Made by D. Wong";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgViewMouseButtons).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        internal DataGridView DgViewMouseButtons;
        internal RichTextBox RichTxtMousePosition;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridViewTextBoxColumn DgMouseButtonColumnDate;
        private DataGridViewTextBoxColumn DgViewMouseButtonColumnButton;
        private DataGridViewTextBoxColumn DgViewMouseButtonColumnPosition;
        private DataGridViewTextBoxColumn DgViewMouseButtonColumnProcessName;
    }
}
