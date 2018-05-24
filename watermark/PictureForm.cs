﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace watermark
{
    public partial class PictureForm : Form
    {
        public PictureForm(Bitmap bmpafter, Bitmap bmpbefore, string url, string wmBits)
        {
            InitializeComponent();
            Incorporation.Generator generator = new Incorporation.Generator(720, 16, 45, 6, wmBits.Length);
            float[] pseudo = generator.Generate();
            Image image = Image.FromFile(url);
            pictureBoxA.Image = bmpbefore;
            pictureBoxB.Image = bmpafter;
        }
    }
}
