namespace watermark
{
    partial class FormMain
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buutonforload = new System.Windows.Forms.Button();
            this.labelwater = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelbefore = new System.Windows.Forms.Label();
            this.labelafter = new System.Windows.Forms.Label();
            this.labelwmA = new System.Windows.Forms.Label();
            this.labelwmB = new System.Windows.Forms.Label();
            this.kutterbutton = new System.Windows.Forms.Button();
            this.labelurl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buutonforload
            // 
            this.buutonforload.Enabled = false;
            this.buutonforload.Location = new System.Drawing.Point(248, 199);
            this.buutonforload.Name = "buutonforload";
            this.buutonforload.Size = new System.Drawing.Size(191, 38);
            this.buutonforload.TabIndex = 0;
            this.buutonforload.Text = "Загрузить изображение";
            this.toolTip1.SetToolTip(this.buutonforload, "Для активации кнопки введите ЦВЗ в после для ввода.");
            this.buutonforload.UseVisualStyleBackColor = true;
            this.buutonforload.Click += new System.EventHandler(this.loadimagebutton_Click);
            // 
            // labelwater
            // 
            this.labelwater.AutoSize = true;
            this.labelwater.Location = new System.Drawing.Point(245, 49);
            this.labelwater.Name = "labelwater";
            this.labelwater.Size = new System.Drawing.Size(74, 13);
            this.labelwater.TabIndex = 1;
            this.labelwater.Text = "Введите ЦВЗ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 107);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Последовательность бит",
            "Строка"});
            this.comboBox.Location = new System.Drawing.Point(48, 68);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(156, 21);
            this.comboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберете тип ЦВЗ";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // labelbefore
            // 
            this.labelbefore.AutoSize = true;
            this.labelbefore.Location = new System.Drawing.Point(45, 349);
            this.labelbefore.Name = "labelbefore";
            this.labelbefore.Size = new System.Drawing.Size(93, 13);
            this.labelbefore.TabIndex = 6;
            this.labelbefore.Text = "До встраивания:";
            // 
            // labelafter
            // 
            this.labelafter.AutoSize = true;
            this.labelafter.Location = new System.Drawing.Point(45, 399);
            this.labelafter.Name = "labelafter";
            this.labelafter.Size = new System.Drawing.Size(110, 13);
            this.labelafter.TabIndex = 7;
            this.labelafter.Text = "После встраивания:";
            // 
            // labelwmA
            // 
            this.labelwmA.AutoSize = true;
            this.labelwmA.Location = new System.Drawing.Point(169, 349);
            this.labelwmA.Name = "labelwmA";
            this.labelwmA.Size = new System.Drawing.Size(0, 13);
            this.labelwmA.TabIndex = 8;
            // 
            // labelwmB
            // 
            this.labelwmB.AutoSize = true;
            this.labelwmB.Location = new System.Drawing.Point(169, 399);
            this.labelwmB.Name = "labelwmB";
            this.labelwmB.Size = new System.Drawing.Size(0, 13);
            this.labelwmB.TabIndex = 9;
            // 
            // kutterbutton
            // 
            this.kutterbutton.Enabled = false;
            this.kutterbutton.Location = new System.Drawing.Point(248, 290);
            this.kutterbutton.Name = "kutterbutton";
            this.kutterbutton.Size = new System.Drawing.Size(191, 38);
            this.kutterbutton.TabIndex = 10;
            this.kutterbutton.Text = "Встраивание и восстановление ЦВЗ";
            this.kutterbutton.UseVisualStyleBackColor = true;
            this.kutterbutton.Click += new System.EventHandler(this.kutterbutton_Click);
            // 
            // labelurl
            // 
            this.labelurl.AutoSize = true;
            this.labelurl.Location = new System.Drawing.Point(248, 255);
            this.labelurl.Name = "labelurl";
            this.labelurl.Size = new System.Drawing.Size(0, 13);
            this.labelurl.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(508, 461);
            this.Controls.Add(this.labelurl);
            this.Controls.Add(this.kutterbutton);
            this.Controls.Add(this.labelwmB);
            this.Controls.Add(this.labelwmA);
            this.Controls.Add(this.labelafter);
            this.Controls.Add(this.labelbefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelwater);
            this.Controls.Add(this.buutonforload);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 40, 40);
            this.Text = "Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buutonforload;
        private System.Windows.Forms.Label labelwater;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelbefore;
        private System.Windows.Forms.Label labelafter;
        private System.Windows.Forms.Label labelwmA;
        private System.Windows.Forms.Label labelwmB;
        private System.Windows.Forms.Button kutterbutton;
        private System.Windows.Forms.Label labelurl;
    }
}

