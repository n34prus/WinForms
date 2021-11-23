
namespace HomeLightGUI
{
    partial class SelectPortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPortForm));
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelSelectCom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectCom = new System.Windows.Forms.Button();
            this.comboBoxSelectCom = new System.Windows.Forms.ComboBox();
            this.labelSelectCom = new System.Windows.Forms.Label();
            this.tableLayoutPanelSelectCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSelectCom
            // 
            this.tableLayoutPanelSelectCom.ColumnCount = 3;
            this.tableLayoutPanelSelectCom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.19672F));
            this.tableLayoutPanelSelectCom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.80328F));
            this.tableLayoutPanelSelectCom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanelSelectCom.Controls.Add(this.buttonSelectCom, 2, 0);
            this.tableLayoutPanelSelectCom.Controls.Add(this.comboBoxSelectCom, 1, 0);
            this.tableLayoutPanelSelectCom.Controls.Add(this.labelSelectCom, 0, 0);
            this.tableLayoutPanelSelectCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSelectCom.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSelectCom.Name = "tableLayoutPanelSelectCom";
            this.tableLayoutPanelSelectCom.RowCount = 1;
            this.tableLayoutPanelSelectCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSelectCom.Size = new System.Drawing.Size(459, 28);
            this.tableLayoutPanelSelectCom.TabIndex = 0;
            // 
            // buttonSelectCom
            // 
            this.buttonSelectCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectCom.Location = new System.Drawing.Point(314, 3);
            this.buttonSelectCom.Name = "buttonSelectCom";
            this.buttonSelectCom.Size = new System.Drawing.Size(142, 22);
            this.buttonSelectCom.TabIndex = 0;
            this.buttonSelectCom.Text = "ОК";
            this.buttonSelectCom.UseVisualStyleBackColor = true;
            this.buttonSelectCom.Click += new System.EventHandler(this.buttonSelectCom_Click);
            // 
            // comboBoxSelectCom
            // 
            this.comboBoxSelectCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSelectCom.FormattingEnabled = true;
            this.comboBoxSelectCom.Location = new System.Drawing.Point(153, 3);
            this.comboBoxSelectCom.Name = "comboBoxSelectCom";
            this.comboBoxSelectCom.Size = new System.Drawing.Size(155, 21);
            this.comboBoxSelectCom.TabIndex = 1;
            // 
            // labelSelectCom
            // 
            this.labelSelectCom.AutoSize = true;
            this.labelSelectCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectCom.Location = new System.Drawing.Point(3, 0);
            this.labelSelectCom.Name = "labelSelectCom";
            this.labelSelectCom.Size = new System.Drawing.Size(144, 28);
            this.labelSelectCom.TabIndex = 2;
            this.labelSelectCom.Text = "Select COM port";
            this.labelSelectCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 28);
            this.Controls.Add(this.tableLayoutPanelSelectCom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectPortForm";
            this.Text = "HomeLight GUI";
            this.tableLayoutPanelSelectCom.ResumeLayout(false);
            this.tableLayoutPanelSelectCom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSelectCom;
        private System.Windows.Forms.Button buttonSelectCom;
        private System.Windows.Forms.ComboBox comboBoxSelectCom;
        private System.Windows.Forms.Label labelSelectCom;
    }
}

