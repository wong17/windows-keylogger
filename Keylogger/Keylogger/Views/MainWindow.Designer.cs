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
            TxtKeyboard = new RichTextBox();
            TxtMouse = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "Keyboard";
            // 
            // TxtKeyboard
            // 
            TxtKeyboard.BackColor = SystemColors.Control;
            TxtKeyboard.BorderStyle = BorderStyle.FixedSingle;
            TxtKeyboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtKeyboard.HideSelection = false;
            TxtKeyboard.Location = new Point(24, 44);
            TxtKeyboard.Name = "TxtKeyboard";
            TxtKeyboard.ReadOnly = true;
            TxtKeyboard.Size = new Size(562, 613);
            TxtKeyboard.TabIndex = 1;
            TxtKeyboard.Text = "";
            // 
            // TxtMouse
            // 
            TxtMouse.BorderStyle = BorderStyle.FixedSingle;
            TxtMouse.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMouse.HideSelection = false;
            TxtMouse.Location = new Point(609, 44);
            TxtMouse.Name = "TxtMouse";
            TxtMouse.ReadOnly = true;
            TxtMouse.Size = new Size(562, 613);
            TxtMouse.TabIndex = 3;
            TxtMouse.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(609, 17);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 2;
            label2.Text = "Mouse";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 681);
            Controls.Add(TxtMouse);
            Controls.Add(label2);
            Controls.Add(TxtKeyboard);
            Controls.Add(label1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keylogger";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        internal RichTextBox TxtKeyboard;
        internal RichTextBox TxtMouse;
    }
}
