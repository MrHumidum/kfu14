namespace TaskManager.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;

        /// <summary>
        /// Освобождение ресурсов.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализация компонентов формы
        /// </summary>
        private void InitializeComponent()
        {
            inputBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            taskListBox = new ListBox();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(10, 10);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(260, 23);
            inputBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(280, 38);
            addButton.Name = "addButton";
            addButton.Size = new Size(164, 58);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(280, 102);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(164, 58);
            updateButton.TabIndex = 2;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(280, 166);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(164, 58);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(10, 40);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(260, 184);
            taskListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            ClientSize = new Size(641, 283);
            Controls.Add(inputBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(taskListBox);
            Name = "MainForm";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
