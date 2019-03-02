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
            this.kutterbutton = new System.Windows.Forms.Button();
            this.labelurl = new System.Windows.Forms.Label();
            this.labelMistakes = new System.Windows.Forms.Label();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buutonforload
            // 
            this.buutonforload.Enabled = false;
            this.buutonforload.Location = new System.Drawing.Point(462, 68);
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
            // kutterbutton
            // 
            this.kutterbutton.Enabled = false;
            this.kutterbutton.Location = new System.Drawing.Point(462, 137);
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
            this.labelurl.Location = new System.Drawing.Point(245, 209);
            this.labelurl.Name = "labelurl";
            this.labelurl.Size = new System.Drawing.Size(0, 13);
            this.labelurl.TabIndex = 11;
            // 
            // labelMistakes
            // 
            this.labelMistakes.AutoSize = true;
            this.labelMistakes.Location = new System.Drawing.Point(45, 362);
            this.labelMistakes.Name = "labelMistakes";
            this.labelMistakes.Size = new System.Drawing.Size(57, 13);
            this.labelMistakes.TabIndex = 12;
            this.labelMistakes.Text = "Точность:";
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Location = new System.Drawing.Point(135, 362);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(0, 13);
            this.labelAccuracy.TabIndex = 13;
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Метод Куттера",
            "Метод Брундокса"});
            this.comboBoxMethod.Location = new System.Drawing.Point(48, 147);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMethod.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберете метод встраивания";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.labelMistakes);
            this.Controls.Add(this.labelurl);
            this.Controls.Add(this.kutterbutton);
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
        private System.Windows.Forms.Button kutterbutton;
        private System.Windows.Forms.Label labelurl;
        private System.Windows.Forms.Label labelMistakes;
        private System.Windows.Forms.Label labelAccuracy;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label label2;
    }
}

