﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoLine_Computers
{
    public partial class ConfirmationPopup : Form
    {
        public ConfirmationPopup( string msg)
        {
            InitializeComponent();
            lbl_message.Text = msg;
        }
    }
}
