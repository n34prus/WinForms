
namespace HomeLightGUI
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabColour = new System.Windows.Forms.TabPage();
            this.splitContainerColour = new System.Windows.Forms.SplitContainer();
            this.tabClock = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabDeveloper = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.valueDATA6rx = new System.Windows.Forms.Label();
            this.valueDATA5rx = new System.Windows.Forms.Label();
            this.valueDATA4rx = new System.Windows.Forms.Label();
            this.valueDATA3rx = new System.Windows.Forms.Label();
            this.valueDATA2rx = new System.Windows.Forms.Label();
            this.valueDATA1rx = new System.Windows.Forms.Label();
            this.valueDATA7rx = new System.Windows.Forms.Label();
            this.labelDATA7rx = new System.Windows.Forms.Label();
            this.labelDATA6rx = new System.Windows.Forms.Label();
            this.labelDATA5rx = new System.Windows.Forms.Label();
            this.labelDATA4rx = new System.Windows.Forms.Label();
            this.label7labelDATA3rx = new System.Windows.Forms.Label();
            this.labelDATA2rx = new System.Windows.Forms.Label();
            this.labelDATA1rx = new System.Windows.Forms.Label();
            this.labelDATA0rx = new System.Windows.Forms.Label();
            this.labelValuerx = new System.Windows.Forms.Label();
            this.valueDATA0rx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSendForm = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCRCValue = new System.Windows.Forms.Label();
            this.textBoxData6tx = new System.Windows.Forms.TextBox();
            this.textBoxData5tx = new System.Windows.Forms.TextBox();
            this.textBoxData4tx = new System.Windows.Forms.TextBox();
            this.textBoxData3tx = new System.Windows.Forms.TextBox();
            this.textBoxData2tx = new System.Windows.Forms.TextBox();
            this.textBoxData1tx = new System.Windows.Forms.TextBox();
            this.labelDATA7tx = new System.Windows.Forms.Label();
            this.labelDATA6tx = new System.Windows.Forms.Label();
            this.labelDATA5tx = new System.Windows.Forms.Label();
            this.labelDATA4tx = new System.Windows.Forms.Label();
            this.labelDATA3tx = new System.Windows.Forms.Label();
            this.labelDATA2tx = new System.Windows.Forms.Label();
            this.labelDATA1tx = new System.Windows.Forms.Label();
            this.labelDATA0tx = new System.Windows.Forms.Label();
            this.labelValuetx = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxData0tx = new System.Windows.Forms.TextBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.tableLayoutPanelRawColour = new System.Windows.Forms.TableLayoutPanel();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.labelBlue = new System.Windows.Forms.Label();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.labelGreen = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.trackBarWhite = new System.Windows.Forms.TrackBar();
            this.labelWhite = new System.Windows.Forms.Label();
            this.textBoxWhite = new System.Windows.Forms.TextBox();
            this.labelBlack = new System.Windows.Forms.Label();
            this.textBoxBlack = new System.Windows.Forms.TextBox();
            this.trackBarBlack = new System.Windows.Forms.TrackBar();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.tabControl.SuspendLayout();
            this.tabColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerColour)).BeginInit();
            this.splitContainerColour.Panel1.SuspendLayout();
            this.splitContainerColour.SuspendLayout();
            this.tabClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.tabDeveloper.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelRawColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabColour);
            this.tabControl.Controls.Add(this.tabClock);
            this.tabControl.Controls.Add(this.tabDeveloper);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 419);
            this.tabControl.TabIndex = 0;
            // 
            // tabColour
            // 
            this.tabColour.Controls.Add(this.splitContainerColour);
            this.tabColour.Location = new System.Drawing.Point(4, 22);
            this.tabColour.Name = "tabColour";
            this.tabColour.Padding = new System.Windows.Forms.Padding(3);
            this.tabColour.Size = new System.Drawing.Size(864, 393);
            this.tabColour.TabIndex = 0;
            this.tabColour.Text = "Цвет";
            this.tabColour.UseVisualStyleBackColor = true;
            // 
            // splitContainerColour
            // 
            this.splitContainerColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerColour.Location = new System.Drawing.Point(3, 3);
            this.splitContainerColour.Name = "splitContainerColour";
            this.splitContainerColour.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerColour.Panel1
            // 
            this.splitContainerColour.Panel1.Controls.Add(this.tableLayoutPanelRawColour);
            this.splitContainerColour.Size = new System.Drawing.Size(858, 387);
            this.splitContainerColour.SplitterDistance = 264;
            this.splitContainerColour.TabIndex = 5;
            // 
            // tabClock
            // 
            this.tabClock.Controls.Add(this.splitContainer1);
            this.tabClock.Location = new System.Drawing.Point(4, 22);
            this.tabClock.Name = "tabClock";
            this.tabClock.Padding = new System.Windows.Forms.Padding(3);
            this.tabClock.Size = new System.Drawing.Size(864, 393);
            this.tabClock.TabIndex = 2;
            this.tabClock.Text = "Часы";
            this.tabClock.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(858, 387);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabDeveloper
            // 
            this.tabDeveloper.Controls.Add(this.tableLayoutPanel1);
            this.tabDeveloper.Location = new System.Drawing.Point(4, 22);
            this.tabDeveloper.Name = "tabDeveloper";
            this.tabDeveloper.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeveloper.Size = new System.Drawing.Size(864, 393);
            this.tabDeveloper.TabIndex = 1;
            this.tabDeveloper.Text = "Разработчик";
            this.tabDeveloper.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSendForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDebug, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.valueDATA6rx, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA5rx, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA4rx, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA3rx, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA2rx, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA1rx, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA7rx, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA7rx, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA6rx, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA5rx, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA4rx, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7labelDATA3rx, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA2rx, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA1rx, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDATA0rx, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelValuerx, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.valueDATA0rx, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(852, 140);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // valueDATA6rx
            // 
            this.valueDATA6rx.AutoSize = true;
            this.valueDATA6rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA6rx.Location = new System.Drawing.Point(598, 70);
            this.valueDATA6rx.Name = "valueDATA6rx";
            this.valueDATA6rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA6rx.TabIndex = 30;
            this.valueDATA6rx.Text = "-";
            this.valueDATA6rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA5rx
            // 
            this.valueDATA5rx.AutoSize = true;
            this.valueDATA5rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA5rx.Location = new System.Drawing.Point(513, 70);
            this.valueDATA5rx.Name = "valueDATA5rx";
            this.valueDATA5rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA5rx.TabIndex = 29;
            this.valueDATA5rx.Text = "-";
            this.valueDATA5rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA4rx
            // 
            this.valueDATA4rx.AutoSize = true;
            this.valueDATA4rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA4rx.Location = new System.Drawing.Point(428, 70);
            this.valueDATA4rx.Name = "valueDATA4rx";
            this.valueDATA4rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA4rx.TabIndex = 28;
            this.valueDATA4rx.Text = "-";
            this.valueDATA4rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA3rx
            // 
            this.valueDATA3rx.AutoSize = true;
            this.valueDATA3rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA3rx.Location = new System.Drawing.Point(343, 70);
            this.valueDATA3rx.Name = "valueDATA3rx";
            this.valueDATA3rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA3rx.TabIndex = 27;
            this.valueDATA3rx.Text = "-";
            this.valueDATA3rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA2rx
            // 
            this.valueDATA2rx.AutoSize = true;
            this.valueDATA2rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA2rx.Location = new System.Drawing.Point(258, 70);
            this.valueDATA2rx.Name = "valueDATA2rx";
            this.valueDATA2rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA2rx.TabIndex = 26;
            this.valueDATA2rx.Text = "-";
            this.valueDATA2rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA1rx
            // 
            this.valueDATA1rx.AutoSize = true;
            this.valueDATA1rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA1rx.Location = new System.Drawing.Point(173, 70);
            this.valueDATA1rx.Name = "valueDATA1rx";
            this.valueDATA1rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA1rx.TabIndex = 25;
            this.valueDATA1rx.Text = "-";
            this.valueDATA1rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA7rx
            // 
            this.valueDATA7rx.AutoSize = true;
            this.valueDATA7rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA7rx.Location = new System.Drawing.Point(683, 70);
            this.valueDATA7rx.Name = "valueDATA7rx";
            this.valueDATA7rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA7rx.TabIndex = 21;
            this.valueDATA7rx.Text = "-";
            this.valueDATA7rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA7rx
            // 
            this.labelDATA7rx.AutoSize = true;
            this.labelDATA7rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA7rx.Location = new System.Drawing.Point(683, 0);
            this.labelDATA7rx.Name = "labelDATA7rx";
            this.labelDATA7rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA7rx.TabIndex = 8;
            this.labelDATA7rx.Text = "DATA7 (CRC)";
            this.labelDATA7rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA6rx
            // 
            this.labelDATA6rx.AutoSize = true;
            this.labelDATA6rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA6rx.Location = new System.Drawing.Point(598, 0);
            this.labelDATA6rx.Name = "labelDATA6rx";
            this.labelDATA6rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA6rx.TabIndex = 7;
            this.labelDATA6rx.Text = "DATA6";
            this.labelDATA6rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA5rx
            // 
            this.labelDATA5rx.AutoSize = true;
            this.labelDATA5rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA5rx.Location = new System.Drawing.Point(513, 0);
            this.labelDATA5rx.Name = "labelDATA5rx";
            this.labelDATA5rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA5rx.TabIndex = 6;
            this.labelDATA5rx.Text = "DATA5";
            this.labelDATA5rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA4rx
            // 
            this.labelDATA4rx.AutoSize = true;
            this.labelDATA4rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA4rx.Location = new System.Drawing.Point(428, 0);
            this.labelDATA4rx.Name = "labelDATA4rx";
            this.labelDATA4rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA4rx.TabIndex = 5;
            this.labelDATA4rx.Text = "DATA4";
            this.labelDATA4rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7labelDATA3rx
            // 
            this.label7labelDATA3rx.AutoSize = true;
            this.label7labelDATA3rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7labelDATA3rx.Location = new System.Drawing.Point(343, 0);
            this.label7labelDATA3rx.Name = "label7labelDATA3rx";
            this.label7labelDATA3rx.Size = new System.Drawing.Size(79, 70);
            this.label7labelDATA3rx.TabIndex = 4;
            this.label7labelDATA3rx.Text = "DATA3";
            this.label7labelDATA3rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA2rx
            // 
            this.labelDATA2rx.AutoSize = true;
            this.labelDATA2rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA2rx.Location = new System.Drawing.Point(258, 0);
            this.labelDATA2rx.Name = "labelDATA2rx";
            this.labelDATA2rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA2rx.TabIndex = 3;
            this.labelDATA2rx.Text = "DATA2";
            this.labelDATA2rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA1rx
            // 
            this.labelDATA1rx.AutoSize = true;
            this.labelDATA1rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA1rx.Location = new System.Drawing.Point(173, 0);
            this.labelDATA1rx.Name = "labelDATA1rx";
            this.labelDATA1rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA1rx.TabIndex = 2;
            this.labelDATA1rx.Text = "DATA1";
            this.labelDATA1rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA0rx
            // 
            this.labelDATA0rx.AutoSize = true;
            this.labelDATA0rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA0rx.Location = new System.Drawing.Point(88, 0);
            this.labelDATA0rx.Name = "labelDATA0rx";
            this.labelDATA0rx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA0rx.TabIndex = 1;
            this.labelDATA0rx.Text = "DATA0";
            this.labelDATA0rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValuerx
            // 
            this.labelValuerx.AutoSize = true;
            this.labelValuerx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValuerx.Location = new System.Drawing.Point(3, 70);
            this.labelValuerx.Name = "labelValuerx";
            this.labelValuerx.Size = new System.Drawing.Size(79, 70);
            this.labelValuerx.TabIndex = 0;
            this.labelValuerx.Text = "Значение";
            this.labelValuerx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDATA0rx
            // 
            this.valueDATA0rx.AutoSize = true;
            this.valueDATA0rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDATA0rx.Location = new System.Drawing.Point(88, 70);
            this.valueDATA0rx.Name = "valueDATA0rx";
            this.valueDATA0rx.Size = new System.Drawing.Size(79, 70);
            this.valueDATA0rx.TabIndex = 22;
            this.valueDATA0rx.Text = "-";
            this.valueDATA0rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(852, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Прием";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSendForm
            // 
            this.labelSendForm.AutoSize = true;
            this.labelSendForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSendForm.Location = new System.Drawing.Point(3, 0);
            this.labelSendForm.Name = "labelSendForm";
            this.labelSendForm.Size = new System.Drawing.Size(852, 36);
            this.labelSendForm.TabIndex = 0;
            this.labelSendForm.Text = "Отправка";
            this.labelSendForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.labelCRCValue, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData6tx, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData5tx, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData4tx, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData3tx, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData2tx, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData1tx, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA7tx, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA6tx, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA5tx, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA4tx, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA3tx, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA2tx, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA1tx, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDATA0tx, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelValuetx, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSend, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxData0tx, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 140);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelCRCValue
            // 
            this.labelCRCValue.AutoSize = true;
            this.labelCRCValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCRCValue.Location = new System.Drawing.Point(683, 70);
            this.labelCRCValue.Name = "labelCRCValue";
            this.labelCRCValue.Size = new System.Drawing.Size(79, 70);
            this.labelCRCValue.TabIndex = 21;
            this.labelCRCValue.Text = "0";
            this.labelCRCValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxData6tx
            // 
            this.textBoxData6tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData6tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData6tx.Location = new System.Drawing.Point(598, 73);
            this.textBoxData6tx.MaxLength = 3;
            this.textBoxData6tx.Name = "textBoxData6tx";
            this.textBoxData6tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData6tx.TabIndex = 18;
            this.textBoxData6tx.Text = "0";
            this.textBoxData6tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxData5tx
            // 
            this.textBoxData5tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData5tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData5tx.Location = new System.Drawing.Point(513, 73);
            this.textBoxData5tx.MaxLength = 3;
            this.textBoxData5tx.Name = "textBoxData5tx";
            this.textBoxData5tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData5tx.TabIndex = 17;
            this.textBoxData5tx.Text = "0";
            this.textBoxData5tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxData4tx
            // 
            this.textBoxData4tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData4tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData4tx.Location = new System.Drawing.Point(428, 73);
            this.textBoxData4tx.MaxLength = 3;
            this.textBoxData4tx.Name = "textBoxData4tx";
            this.textBoxData4tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData4tx.TabIndex = 16;
            this.textBoxData4tx.Text = "0";
            this.textBoxData4tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxData3tx
            // 
            this.textBoxData3tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData3tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData3tx.Location = new System.Drawing.Point(343, 73);
            this.textBoxData3tx.MaxLength = 3;
            this.textBoxData3tx.Name = "textBoxData3tx";
            this.textBoxData3tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData3tx.TabIndex = 15;
            this.textBoxData3tx.Text = "0";
            this.textBoxData3tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxData2tx
            // 
            this.textBoxData2tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData2tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData2tx.Location = new System.Drawing.Point(258, 73);
            this.textBoxData2tx.MaxLength = 3;
            this.textBoxData2tx.Name = "textBoxData2tx";
            this.textBoxData2tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData2tx.TabIndex = 14;
            this.textBoxData2tx.Text = "0";
            this.textBoxData2tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxData1tx
            // 
            this.textBoxData1tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData1tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData1tx.Location = new System.Drawing.Point(173, 73);
            this.textBoxData1tx.MaxLength = 3;
            this.textBoxData1tx.Name = "textBoxData1tx";
            this.textBoxData1tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData1tx.TabIndex = 13;
            this.textBoxData1tx.Text = "0";
            this.textBoxData1tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDATA7tx
            // 
            this.labelDATA7tx.AutoSize = true;
            this.labelDATA7tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA7tx.Location = new System.Drawing.Point(683, 0);
            this.labelDATA7tx.Name = "labelDATA7tx";
            this.labelDATA7tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA7tx.TabIndex = 8;
            this.labelDATA7tx.Text = "DATA7 (CRC)";
            this.labelDATA7tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA6tx
            // 
            this.labelDATA6tx.AutoSize = true;
            this.labelDATA6tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA6tx.Location = new System.Drawing.Point(598, 0);
            this.labelDATA6tx.Name = "labelDATA6tx";
            this.labelDATA6tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA6tx.TabIndex = 7;
            this.labelDATA6tx.Text = "DATA6";
            this.labelDATA6tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA5tx
            // 
            this.labelDATA5tx.AutoSize = true;
            this.labelDATA5tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA5tx.Location = new System.Drawing.Point(513, 0);
            this.labelDATA5tx.Name = "labelDATA5tx";
            this.labelDATA5tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA5tx.TabIndex = 6;
            this.labelDATA5tx.Text = "DATA5";
            this.labelDATA5tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA4tx
            // 
            this.labelDATA4tx.AutoSize = true;
            this.labelDATA4tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA4tx.Location = new System.Drawing.Point(428, 0);
            this.labelDATA4tx.Name = "labelDATA4tx";
            this.labelDATA4tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA4tx.TabIndex = 5;
            this.labelDATA4tx.Text = "DATA4";
            this.labelDATA4tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA3tx
            // 
            this.labelDATA3tx.AutoSize = true;
            this.labelDATA3tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA3tx.Location = new System.Drawing.Point(343, 0);
            this.labelDATA3tx.Name = "labelDATA3tx";
            this.labelDATA3tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA3tx.TabIndex = 4;
            this.labelDATA3tx.Text = "DATA3";
            this.labelDATA3tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA2tx
            // 
            this.labelDATA2tx.AutoSize = true;
            this.labelDATA2tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA2tx.Location = new System.Drawing.Point(258, 0);
            this.labelDATA2tx.Name = "labelDATA2tx";
            this.labelDATA2tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA2tx.TabIndex = 3;
            this.labelDATA2tx.Text = "DATA2";
            this.labelDATA2tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA1tx
            // 
            this.labelDATA1tx.AutoSize = true;
            this.labelDATA1tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA1tx.Location = new System.Drawing.Point(173, 0);
            this.labelDATA1tx.Name = "labelDATA1tx";
            this.labelDATA1tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA1tx.TabIndex = 2;
            this.labelDATA1tx.Text = "DATA1";
            this.labelDATA1tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDATA0tx
            // 
            this.labelDATA0tx.AutoSize = true;
            this.labelDATA0tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDATA0tx.Location = new System.Drawing.Point(88, 0);
            this.labelDATA0tx.Name = "labelDATA0tx";
            this.labelDATA0tx.Size = new System.Drawing.Size(79, 70);
            this.labelDATA0tx.TabIndex = 1;
            this.labelDATA0tx.Text = "DATA0";
            this.labelDATA0tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValuetx
            // 
            this.labelValuetx.AutoSize = true;
            this.labelValuetx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValuetx.Location = new System.Drawing.Point(3, 70);
            this.labelValuetx.Name = "labelValuetx";
            this.labelValuetx.Size = new System.Drawing.Size(79, 70);
            this.labelValuetx.TabIndex = 0;
            this.labelValuetx.Text = "Значение";
            this.labelValuetx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSend
            // 
            this.buttonSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSend.Location = new System.Drawing.Point(768, 73);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(81, 64);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxData0tx
            // 
            this.textBoxData0tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData0tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData0tx.Location = new System.Drawing.Point(88, 73);
            this.textBoxData0tx.MaxLength = 3;
            this.textBoxData0tx.Name = "textBoxData0tx";
            this.textBoxData0tx.Size = new System.Drawing.Size(79, 29);
            this.textBoxData0tx.TabIndex = 10;
            this.textBoxData0tx.Text = "0";
            this.textBoxData0tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDebug.Location = new System.Drawing.Point(3, 364);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(852, 23);
            this.labelDebug.TabIndex = 5;
            this.labelDebug.Text = "debug messages";
            this.labelDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelRawColour
            // 
            this.tableLayoutPanelRawColour.ColumnCount = 3;
            this.tableLayoutPanelRawColour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelRawColour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelRawColour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelRawColour.Controls.Add(this.labelSpeed, 0, 5);
            this.tableLayoutPanelRawColour.Controls.Add(this.textBoxBlue, 1, 2);
            this.tableLayoutPanelRawColour.Controls.Add(this.labelBlue, 0, 2);
            this.tableLayoutPanelRawColour.Controls.Add(this.textBoxGreen, 1, 1);
            this.tableLayoutPanelRawColour.Controls.Add(this.labelGreen, 0, 1);
            this.tableLayoutPanelRawColour.Controls.Add(this.trackBarRed, 2, 0);
            this.tableLayoutPanelRawColour.Controls.Add(this.trackBarGreen, 2, 1);
            this.tableLayoutPanelRawColour.Controls.Add(this.trackBarBlue, 2, 2);
            this.tableLayoutPanelRawColour.Controls.Add(this.labelRed, 0, 0);
            this.tableLayoutPanelRawColour.Controls.Add(this.textBoxRed, 1, 0);
            this.tableLayoutPanelRawColour.Controls.Add(this.trackBarWhite, 2, 3);
            this.tableLayoutPanelRawColour.Controls.Add(this.labelWhite, 0, 3);
            this.tableLayoutPanelRawColour.Controls.Add(this.textBoxWhite, 1, 3);
            this.tableLayoutPanelRawColour.Controls.Add(this.labelBlack, 0, 4);
            this.tableLayoutPanelRawColour.Controls.Add(this.textBoxBlack, 1, 4);
            this.tableLayoutPanelRawColour.Controls.Add(this.trackBarBlack, 2, 4);
            this.tableLayoutPanelRawColour.Controls.Add(this.textBoxSpeed, 1, 5);
            this.tableLayoutPanelRawColour.Controls.Add(this.trackBarSpeed, 2, 5);
            this.tableLayoutPanelRawColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRawColour.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRawColour.Name = "tableLayoutPanelRawColour";
            this.tableLayoutPanelRawColour.RowCount = 6;
            this.tableLayoutPanelRawColour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelRawColour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelRawColour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelRawColour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelRawColour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelRawColour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelRawColour.Size = new System.Drawing.Size(858, 264);
            this.tableLayoutPanelRawColour.TabIndex = 5;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSpeed.Location = new System.Drawing.Point(3, 215);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(122, 49);
            this.labelSpeed.TabIndex = 16;
            this.labelSpeed.Text = "Скорость";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBlue.Location = new System.Drawing.Point(131, 89);
            this.textBoxBlue.MaxLength = 3;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(122, 29);
            this.textBoxBlue.TabIndex = 9;
            this.textBoxBlue.Text = "0";
            this.textBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBlue.Location = new System.Drawing.Point(3, 86);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(122, 43);
            this.labelBlue.TabIndex = 8;
            this.labelBlue.Text = "Синий";
            this.labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGreen.Location = new System.Drawing.Point(131, 46);
            this.textBoxGreen.MaxLength = 3;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(122, 29);
            this.textBoxGreen.TabIndex = 7;
            this.textBoxGreen.Text = "0";
            this.textBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGreen.Location = new System.Drawing.Point(3, 43);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(122, 43);
            this.labelGreen.TabIndex = 6;
            this.labelGreen.Text = "Зеленый";
            this.labelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarRed.Location = new System.Drawing.Point(259, 3);
            this.trackBarRed.Maximum = 51;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(596, 37);
            this.trackBarRed.SmallChange = 5;
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarGreen.Location = new System.Drawing.Point(259, 46);
            this.trackBarGreen.Maximum = 51;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(596, 37);
            this.trackBarGreen.SmallChange = 5;
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBlue.Location = new System.Drawing.Point(259, 89);
            this.trackBarBlue.Maximum = 51;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(596, 37);
            this.trackBarBlue.SmallChange = 5;
            this.trackBarBlue.TabIndex = 3;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRed.Location = new System.Drawing.Point(3, 0);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(122, 43);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "Красный";
            this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRed.Location = new System.Drawing.Point(131, 3);
            this.textBoxRed.MaxLength = 3;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(122, 29);
            this.textBoxRed.TabIndex = 5;
            this.textBoxRed.Text = "0";
            this.textBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarWhite
            // 
            this.trackBarWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarWhite.Location = new System.Drawing.Point(259, 132);
            this.trackBarWhite.Maximum = 51;
            this.trackBarWhite.Name = "trackBarWhite";
            this.trackBarWhite.Size = new System.Drawing.Size(596, 37);
            this.trackBarWhite.SmallChange = 5;
            this.trackBarWhite.TabIndex = 12;
            this.trackBarWhite.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // labelWhite
            // 
            this.labelWhite.AutoSize = true;
            this.labelWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWhite.Location = new System.Drawing.Point(3, 129);
            this.labelWhite.Name = "labelWhite";
            this.labelWhite.Size = new System.Drawing.Size(122, 43);
            this.labelWhite.TabIndex = 10;
            this.labelWhite.Text = "Белый";
            this.labelWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWhite
            // 
            this.textBoxWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWhite.Location = new System.Drawing.Point(131, 132);
            this.textBoxWhite.MaxLength = 3;
            this.textBoxWhite.Name = "textBoxWhite";
            this.textBoxWhite.Size = new System.Drawing.Size(122, 29);
            this.textBoxWhite.TabIndex = 11;
            this.textBoxWhite.Text = "0";
            this.textBoxWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBlack
            // 
            this.labelBlack.AutoSize = true;
            this.labelBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBlack.Location = new System.Drawing.Point(3, 172);
            this.labelBlack.Name = "labelBlack";
            this.labelBlack.Size = new System.Drawing.Size(122, 43);
            this.labelBlack.TabIndex = 13;
            this.labelBlack.Text = "Черный";
            this.labelBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBlack
            // 
            this.textBoxBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBlack.Location = new System.Drawing.Point(131, 175);
            this.textBoxBlack.MaxLength = 3;
            this.textBoxBlack.Name = "textBoxBlack";
            this.textBoxBlack.Size = new System.Drawing.Size(122, 29);
            this.textBoxBlack.TabIndex = 14;
            this.textBoxBlack.Text = "0";
            this.textBoxBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarBlack
            // 
            this.trackBarBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBlack.Location = new System.Drawing.Point(259, 175);
            this.trackBarBlack.Maximum = 51;
            this.trackBarBlack.Name = "trackBarBlack";
            this.trackBarBlack.Size = new System.Drawing.Size(596, 37);
            this.trackBarBlack.SmallChange = 5;
            this.trackBarBlack.TabIndex = 15;
            this.trackBarBlack.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpeed.Location = new System.Drawing.Point(131, 218);
            this.textBoxSpeed.MaxLength = 3;
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(122, 29);
            this.textBoxSpeed.TabIndex = 17;
            this.textBoxSpeed.Text = "0";
            this.textBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarSpeed.Location = new System.Drawing.Point(259, 218);
            this.trackBarSpeed.Maximum = 51;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(596, 43);
            this.trackBarSpeed.SmallChange = 5;
            this.trackBarSpeed.TabIndex = 18;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 419);
            this.Controls.Add(this.tabControl);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyForm_FormClosed);
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabColour.ResumeLayout(false);
            this.splitContainerColour.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerColour)).EndInit();
            this.splitContainerColour.ResumeLayout(false);
            this.tabClock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabDeveloper.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelRawColour.ResumeLayout(false);
            this.tableLayoutPanelRawColour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabColour;
        private System.Windows.Forms.TabPage tabDeveloper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSendForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelCRCValue;
        private System.Windows.Forms.TextBox textBoxData6tx;
        private System.Windows.Forms.TextBox textBoxData5tx;
        private System.Windows.Forms.TextBox textBoxData4tx;
        private System.Windows.Forms.TextBox textBoxData3tx;
        private System.Windows.Forms.TextBox textBoxData2tx;
        private System.Windows.Forms.TextBox textBoxData1tx;
        private System.Windows.Forms.Label labelDATA7tx;
        private System.Windows.Forms.Label labelDATA6tx;
        private System.Windows.Forms.Label labelDATA5tx;
        private System.Windows.Forms.Label labelDATA4tx;
        private System.Windows.Forms.Label labelDATA3tx;
        private System.Windows.Forms.Label labelDATA2tx;
        private System.Windows.Forms.Label labelDATA1tx;
        private System.Windows.Forms.Label labelDATA0tx;
        private System.Windows.Forms.Label labelValuetx;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxData0tx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label valueDATA7rx;
        private System.Windows.Forms.Label labelDATA7rx;
        private System.Windows.Forms.Label labelDATA6rx;
        private System.Windows.Forms.Label labelDATA5rx;
        private System.Windows.Forms.Label labelDATA4rx;
        private System.Windows.Forms.Label label7labelDATA3rx;
        private System.Windows.Forms.Label labelDATA2rx;
        private System.Windows.Forms.Label labelDATA1rx;
        private System.Windows.Forms.Label labelDATA0rx;
        private System.Windows.Forms.Label labelValuerx;
        private System.Windows.Forms.Label valueDATA6rx;
        private System.Windows.Forms.Label valueDATA5rx;
        private System.Windows.Forms.Label valueDATA4rx;
        private System.Windows.Forms.Label valueDATA3rx;
        private System.Windows.Forms.Label valueDATA2rx;
        private System.Windows.Forms.Label valueDATA1rx;
        private System.Windows.Forms.Label valueDATA0rx;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.TabPage tabClock;
        private System.Windows.Forms.SplitContainer splitContainerColour;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRawColour;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TrackBar trackBarWhite;
        private System.Windows.Forms.Label labelWhite;
        private System.Windows.Forms.TextBox textBoxWhite;
        private System.Windows.Forms.Label labelBlack;
        private System.Windows.Forms.TextBox textBoxBlack;
        private System.Windows.Forms.TrackBar trackBarBlack;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
    }
}

