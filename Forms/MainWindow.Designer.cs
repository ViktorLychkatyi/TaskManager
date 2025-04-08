namespace TaskManager
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            завершитьToolStripMenuItem = new ToolStripMenuItem();
            задатьПриоритетToolStripMenuItem = new ToolStripMenuItem();
            реальногоВремениToolStripMenuItem = new ToolStripMenuItem();
            высокийToolStripMenuItem = new ToolStripMenuItem();
            вышеСреднегоToolStripMenuItem = new ToolStripMenuItem();
            обычноToolStripMenuItem = new ToolStripMenuItem();
            нижеСреднегоToolStripMenuItem = new ToolStripMenuItem();
            низкийToolStripMenuItem = new ToolStripMenuItem();
            новыйПроцессToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            textBox1 = new TextBox();
            button1 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { завершитьToolStripMenuItem, задатьПриоритетToolStripMenuItem, новыйПроцессToolStripMenuItem, выходToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(162, 92);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // завершитьToolStripMenuItem
            // 
            завершитьToolStripMenuItem.Name = "завершитьToolStripMenuItem";
            завершитьToolStripMenuItem.Size = new Size(161, 22);
            завершитьToolStripMenuItem.Text = "Завершить";
            завершитьToolStripMenuItem.Click += завершитьToolStripMenuItem_Click;
            // 
            // задатьПриоритетToolStripMenuItem
            // 
            задатьПриоритетToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { реальногоВремениToolStripMenuItem, высокийToolStripMenuItem, вышеСреднегоToolStripMenuItem, обычноToolStripMenuItem, нижеСреднегоToolStripMenuItem, низкийToolStripMenuItem });
            задатьПриоритетToolStripMenuItem.Name = "задатьПриоритетToolStripMenuItem";
            задатьПриоритетToolStripMenuItem.Size = new Size(161, 22);
            задатьПриоритетToolStripMenuItem.Text = "Приоритет";
            задатьПриоритетToolStripMenuItem.Click += задатьПриоритетToolStripMenuItem_Click;
            // 
            // реальногоВремениToolStripMenuItem
            // 
            реальногоВремениToolStripMenuItem.Name = "реальногоВремениToolStripMenuItem";
            реальногоВремениToolStripMenuItem.Size = new Size(183, 22);
            реальногоВремениToolStripMenuItem.Text = "Реального времени";
            // 
            // высокийToolStripMenuItem
            // 
            высокийToolStripMenuItem.Name = "высокийToolStripMenuItem";
            высокийToolStripMenuItem.Size = new Size(183, 22);
            высокийToolStripMenuItem.Text = "Высокий";
            // 
            // вышеСреднегоToolStripMenuItem
            // 
            вышеСреднегоToolStripMenuItem.Name = "вышеСреднегоToolStripMenuItem";
            вышеСреднегоToolStripMenuItem.Size = new Size(183, 22);
            вышеСреднегоToolStripMenuItem.Text = "Выше среднего";
            // 
            // обычноToolStripMenuItem
            // 
            обычноToolStripMenuItem.Name = "обычноToolStripMenuItem";
            обычноToolStripMenuItem.Size = new Size(183, 22);
            обычноToolStripMenuItem.Text = "Обычный";
            // 
            // нижеСреднегоToolStripMenuItem
            // 
            нижеСреднегоToolStripMenuItem.Name = "нижеСреднегоToolStripMenuItem";
            нижеСреднегоToolStripMenuItem.Size = new Size(183, 22);
            нижеСреднегоToolStripMenuItem.Text = "Ниже среднего";
            // 
            // низкийToolStripMenuItem
            // 
            низкийToolStripMenuItem.Name = "низкийToolStripMenuItem";
            низкийToolStripMenuItem.Size = new Size(183, 22);
            низкийToolStripMenuItem.Text = "Низкий";
            // 
            // новыйПроцессToolStripMenuItem
            // 
            новыйПроцессToolStripMenuItem.Name = "новыйПроцессToolStripMenuItem";
            новыйПроцессToolStripMenuItem.Size = new Size(161, 22);
            новыйПроцессToolStripMenuItem.Text = "Новый процесс";
            новыйПроцессToolStripMenuItem.Click += новыйПроцессToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(161, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Window;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.ImeMode = ImeMode.Alpha;
            listView1.Location = new Point(0, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(549, 247);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Имя процесса";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ИД";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ОЗУ";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(460, 0);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 4;
            button1.Text = "Нажать";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 260);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диспетчер задач";
            Load += MainWindow_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem завершитьToolStripMenuItem;
        private ToolStripMenuItem задатьПриоритетToolStripMenuItem;
        private ToolStripMenuItem реальногоВремениToolStripMenuItem;
        private ToolStripMenuItem высокийToolStripMenuItem;
        private ToolStripMenuItem вышеСреднегоToolStripMenuItem;
        private ToolStripMenuItem обычноToolStripMenuItem;
        private ToolStripMenuItem нижеСреднегоToolStripMenuItem;
        private ToolStripMenuItem низкийToolStripMenuItem;
        private ListView listView1;
        private ToolStripMenuItem новыйПроцессToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private TextBox textBox1;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}