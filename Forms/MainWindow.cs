using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Forms;

namespace TaskManager
{
    public partial class MainWindow : Form
    {
        private System.Windows.Forms.Timer processUpdateTimer;

        public MainWindow()
        {
            InitializeComponent();
            LoadProcess();
            this.Text = "Диспетчер задач";

            listView1.FullRowSelect = true;
            listView1.HoverSelection = true;
            listView1.Scrollable = true;

            listView1.View = View.Details;

            processUpdateTimer = new System.Windows.Forms.Timer();
            processUpdateTimer.Interval = 10000;
            processUpdateTimer.Tick += ProcessUpdateTimer_Tick;
            processUpdateTimer.Start();
        }

        private void LoadProcess()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());

                long memoryBytes = process.WorkingSet64;
                double memoryMB = memoryBytes / (1024.0 * 1024.0);

                item.SubItems.Add(memoryMB.ToString("F2") + " MB");
                try
                {
                    item.SubItems.Add(process.PriorityClass.ToString());
                }
                catch
                {
                    item.SubItems.Add("N/A");
                }
                listView1.Items.Add(item);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void запуститьНовуюЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void завершитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);
                try
                {
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    listView1.Items.Remove(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при завершении процесса: " + ex.Message);
                }
            }

        }

        private void задатьПриоритетToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);
                try
                {
                    Process process = Process.GetProcessById(processId);
                    process.PriorityClass = ProcessPriorityClass.High;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении приоритета: " + ex.Message);
                }
            }
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void новыйПроцессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProcess newProcess = new NewProcess();
            newProcess.ShowDialog();
        }

        private void ProcessUpdateTimer_Tick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            LoadProcess();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string filter = textBox1.Text.ToLower();

            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLower().Contains(filter) || process.Id.ToString().Contains(filter))
                {
                    ListViewItem item = new ListViewItem(process.ProcessName);
                    item.SubItems.Add(process.Id.ToString());

                    long memoryBytes = process.WorkingSet64;
                    double memoryMB = memoryBytes / (1024.0 * 1024.0);

                    item.SubItems.Add(memoryMB.ToString("F2") + " MB");
                    try
                    {
                        item.SubItems.Add(process.PriorityClass.ToString());
                    }
                    catch
                    {
                        item.SubItems.Add("N/A");
                    }
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
