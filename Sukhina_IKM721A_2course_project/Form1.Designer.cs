﻿namespace Sukhina_IKM721A_2course_project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проНакопичувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.dgwOpen = new System.Windows.Forms.DataGridView();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StackText = new System.Windows.Forms.Label();
            this.LabelStack = new System.Windows.Forms.Label();
            this.Stacktb = new System.Windows.Forms.TextBox();
            this.Peek = new System.Windows.Forms.Button();
            this.Pop = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.Dequeue = new System.Windows.Forms.Button();
            this.Peek_q = new System.Windows.Forms.Button();
            this.Queuetb = new System.Windows.Forms.TextBox();
            this.LabelQueue = new System.Windows.Forms.Label();
            this.QueueText = new System.Windows.Forms.Label();
            this.текстовіФайлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.відкритиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(391, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(351, 255);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(129, 37);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Пуск";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(254, 154);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(332, 31);
            this.tbInput.TabIndex = 2;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // tClock
            // 
            this.tClock.Interval = 25000;
            this.tClock.Tick += new System.EventHandler(this.tClock_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.роботаToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.toolStripSeparator1,
            this.відкритиToolStripMenuItem,
            this.toolStripSeparator2,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.toolStripSeparator3,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // роботаToolStripMenuItem
            // 
            this.роботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пускToolStripMenuItem,
            this.проНакопичувачіToolStripMenuItem,
            this.текстовіФайлиToolStripMenuItem});
            this.роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            this.роботаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.роботаToolStripMenuItem.Text = "Робота";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.bStart_Click);
            // 
            // проНакопичувачіToolStripMenuItem
            // 
            this.проНакопичувачіToolStripMenuItem.Name = "проНакопичувачіToolStripMenuItem";
            this.проНакопичувачіToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.проНакопичувачіToolStripMenuItem.Text = "Про накопичувачі";
            this.проНакопичувачіToolStripMenuItem.Click += new System.EventHandler(this.проНакопичувачіToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "SoM";
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "SoM";
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // dgwOpen
            // 
            this.dgwOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOpen.Location = new System.Drawing.Point(23, 67);
            this.dgwOpen.Name = "dgwOpen";
            this.dgwOpen.Size = new System.Drawing.Size(514, 210);
            this.dgwOpen.TabIndex = 4;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.Location = new System.Drawing.Point(657, 67);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(103, 24);
            this.bSearch.TabIndex = 5;
            this.bSearch.Text = "Пошук";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(639, 97);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(140, 20);
            this.tbSearch.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 430);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.tbInput);
            this.tabPage1.Controls.Add(this.bStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Введення даних";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.dgwOpen);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Controls.Add(this.bSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Робота з файлами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(872, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Стек/Черга";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.StackText);
            this.splitContainer1.Panel1.Controls.Add(this.LabelStack);
            this.splitContainer1.Panel1.Controls.Add(this.Stacktb);
            this.splitContainer1.Panel1.Controls.Add(this.Peek);
            this.splitContainer1.Panel1.Controls.Add(this.Pop);
            this.splitContainer1.Panel1.Controls.Add(this.Push);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.QueueText);
            this.splitContainer1.Panel2.Controls.Add(this.LabelQueue);
            this.splitContainer1.Panel2.Controls.Add(this.Queuetb);
            this.splitContainer1.Panel2.Controls.Add(this.Peek_q);
            this.splitContainer1.Panel2.Controls.Add(this.Dequeue);
            this.splitContainer1.Panel2.Controls.Add(this.Enqueue);
            this.splitContainer1.Size = new System.Drawing.Size(866, 398);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 0;
            // 
            // StackText
            // 
            this.StackText.AutoSize = true;
            this.StackText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StackText.Location = new System.Drawing.Point(184, 112);
            this.StackText.Name = "StackText";
            this.StackText.Size = new System.Drawing.Size(57, 24);
            this.StackText.TabIndex = 5;
            this.StackText.Text = "Стек";
            this.StackText.Click += new System.EventHandler(this.StackText_Click);
            // 
            // LabelStack
            // 
            this.LabelStack.AutoSize = true;
            this.LabelStack.Location = new System.Drawing.Point(180, 298);
            this.LabelStack.Name = "LabelStack";
            this.LabelStack.Size = new System.Drawing.Size(61, 13);
            this.LabelStack.TabIndex = 4;
            this.LabelStack.Text = "LabelStack";
            // 
            // Stacktb
            // 
            this.Stacktb.Location = new System.Drawing.Point(118, 155);
            this.Stacktb.Name = "Stacktb";
            this.Stacktb.Size = new System.Drawing.Size(185, 20);
            this.Stacktb.TabIndex = 3;
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(299, 214);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(75, 23);
            this.Peek.TabIndex = 2;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // Pop
            // 
            this.Pop.Location = new System.Drawing.Point(175, 214);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(75, 23);
            this.Pop.TabIndex = 1;
            this.Pop.Text = "Pop";
            this.Pop.UseVisualStyleBackColor = true;
            this.Pop.Click += new System.EventHandler(this.Pop_Click);
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(40, 214);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 0;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(57, 214);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(75, 23);
            this.Enqueue.TabIndex = 0;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(197, 214);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(75, 23);
            this.Dequeue.TabIndex = 1;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Peek_q
            // 
            this.Peek_q.Location = new System.Drawing.Point(330, 214);
            this.Peek_q.Name = "Peek_q";
            this.Peek_q.Size = new System.Drawing.Size(75, 23);
            this.Peek_q.TabIndex = 2;
            this.Peek_q.Text = "Peek_q";
            this.Peek_q.UseVisualStyleBackColor = true;
            this.Peek_q.Click += new System.EventHandler(this.Peek_q_Click);
            // 
            // Queuetb
            // 
            this.Queuetb.Location = new System.Drawing.Point(130, 155);
            this.Queuetb.Name = "Queuetb";
            this.Queuetb.Size = new System.Drawing.Size(201, 20);
            this.Queuetb.TabIndex = 3;
            // 
            // LabelQueue
            // 
            this.LabelQueue.AutoSize = true;
            this.LabelQueue.Location = new System.Drawing.Point(207, 298);
            this.LabelQueue.Name = "LabelQueue";
            this.LabelQueue.Size = new System.Drawing.Size(65, 13);
            this.LabelQueue.TabIndex = 4;
            this.LabelQueue.Text = "LabelQueue";
            // 
            // QueueText
            // 
            this.QueueText.AutoSize = true;
            this.QueueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueueText.Location = new System.Drawing.Point(205, 112);
            this.QueueText.Name = "QueueText";
            this.QueueText.Size = new System.Drawing.Size(67, 24);
            this.QueueText.TabIndex = 5;
            this.QueueText.Text = "Черга";
            // 
            // текстовіФайлиToolStripMenuItem
            // 
            this.текстовіФайлиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem1,
            this.зберегтиЯкToolStripMenuItem1,
            this.відкритиToolStripMenuItem1});
            this.текстовіФайлиToolStripMenuItem.Name = "текстовіФайлиToolStripMenuItem";
            this.текстовіФайлиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.текстовіФайлиToolStripMenuItem.Text = "Текстові файли";
            // 
            // зберегтиToolStripMenuItem1
            // 
            this.зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            this.зберегтиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem1.Text = "Зберегти";
            this.зберегтиToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // зберегтиЯкToolStripMenuItem1
            // 
            this.зберегтиЯкToolStripMenuItem1.Name = "зберегтиЯкToolStripMenuItem1";
            this.зберегтиЯкToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.зберегтиЯкToolStripMenuItem1.Text = "Зберегти як...";
            this.зберегтиЯкToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(573, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 178);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // відкритиToolStripMenuItem1
            // 
            this.відкритиToolStripMenuItem1.Name = "відкритиToolStripMenuItem1";
            this.відкритиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem1.Text = "Відкрити";
            this.відкритиToolStripMenuItem1.Click += new System.EventHandler(this.відкритиToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem роботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проНакопичувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.DataGridView dgwOpen;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label StackText;
        private System.Windows.Forms.Label LabelStack;
        private System.Windows.Forms.TextBox Stacktb;
        private System.Windows.Forms.Button Peek;
        private System.Windows.Forms.Button Pop;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Label QueueText;
        private System.Windows.Forms.Label LabelQueue;
        private System.Windows.Forms.TextBox Queuetb;
        private System.Windows.Forms.Button Peek_q;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.ToolStripMenuItem текстовіФайлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

