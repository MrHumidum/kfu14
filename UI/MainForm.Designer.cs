namespace TaskManager.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox taskInputBox;
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
            taskInputBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            taskListBox = new ListBox();
            userInputBox = new TextBox();
            dateTimeInputBox = new DateTimePicker();
            userLabel = new Label();
            taskLabel = new Label();
            dateTimeLabel = new Label();
            SuspendLayout();
            // 
            // taskInputBox
            // 
            taskInputBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskInputBox.Location = new Point(672, 79);
            taskInputBox.Name = "taskInputBox";
            taskInputBox.Size = new Size(237, 23);
            taskInputBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.Location = new Point(672, 161);
            addButton.Name = "addButton";
            addButton.Size = new Size(237, 32);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Location = new Point(672, 199);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(237, 32);
            updateButton.TabIndex = 2;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Location = new Point(672, 237);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(237, 32);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // taskListBox
            // 
            taskListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(10, 10);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(643, 319);
            taskListBox.TabIndex = 4;
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
            // 
            // userInputBox
            // 
            userInputBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userInputBox.Location = new Point(672, 28);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(237, 23);
            userInputBox.TabIndex = 5;
            // 
            // dateTimeInputBox
            // 
            dateTimeInputBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeInputBox.Location = new Point(672, 132);
            dateTimeInputBox.Name = "dateTimeInputBox";
            dateTimeInputBox.Size = new Size(237, 23);
            dateTimeInputBox.TabIndex = 6;
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.Location = new Point(672, 10);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(81, 15);
            userLabel.TabIndex = 7;
            userLabel.Text = "Исполнитель";
            // 
            // taskLabel
            // 
            taskLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(672, 61);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(45, 15);
            taskLabel.TabIndex = 8;
            taskLabel.Text = "Задача";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new Point(672, 114);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(54, 15);
            dateTimeLabel.TabIndex = 9;
            dateTimeLabel.Text = "Дедлайн";
            // 
            // MainForm
            // 
            ClientSize = new Size(921, 354);
            Controls.Add(dateTimeLabel);
            Controls.Add(taskLabel);
            Controls.Add(userLabel);
            Controls.Add(dateTimeInputBox);
            Controls.Add(userInputBox);
            Controls.Add(taskInputBox);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(taskListBox);
            Name = "MainForm";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox userInputBox;
        private DateTimePicker dateTimeInputBox;
        private Label userLabel;
        private Label taskLabel;
        private Label dateTimeLabel;
    }
}
