﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace watermark
{
    public partial class FormMain : Form
    {
        Encoding encoding = Encoding.Default;
        Image image;
        string url;

        public FormMain()
        {
            InitializeComponent();
        }

        private void loadimagebutton_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                labelurl.Text = url;
                image = Image.FromFile(url);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                buutonforload.Enabled = false;
            else
                buutonforload.Enabled = true;

            if (textBox1.Text == null)
                kutterbutton.Enabled = false;
            else
                kutterbutton.Enabled = true;
        }

        private void kutterbutton_Click(object sender, EventArgs e)
        {
            string wmBits = "";
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    wmBits = textBox1.Text;
                    break;
                case 1:
                    wmBits = Incorporation.Converter.StringToBinary(textBox1.Text);
                    break;
                default:
                    break;
            }
            // Генерация псевдорандомной послед-сти   
            Incorporation.Generator generator = new Incorporation.Generator(90, 16, 45, 6, wmBits.Length);
            float[] pseudo = generator.Generate();
            Bitmap bmpbefore = new Bitmap(image);
            Bitmap bmpafter;
            string result;
            switch (comboBoxMethod.SelectedIndex)
            {
                case 0:
                    bmpafter = Incorporation.Kutter.KutterEmbedding(bmpbefore, pseudo, wmBits);
                    result = Incorporation.Kutter.KutterExtracting(bmpafter, pseudo);
                    break;
                case 1:
                    bmpafter = Incorporation.Bruyndonckx.BruyndonckxEmbedding(bmpbefore, wmBits);
                    result = Incorporation.Bruyndonckx.BruyndonckxExtracting(bmpafter, wmBits.Length);
                    break;
                default:
                    bmpafter = Incorporation.Kutter.KutterEmbedding(bmpbefore, pseudo, wmBits);
                    result = Incorporation.Kutter.KutterExtracting(bmpafter, pseudo);
                    break;

            }
            // Вывод 2 изображений
            Form secondform = new PictureForm(bmpafter, bmpbefore, url, wmBits);
            labelAccuracy.Text = Convert.ToString(Incorporation.Context.Accuracy(wmBits, result));
            secondform.Show();
        }
    }
}
