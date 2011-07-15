using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFCombine
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
            richTextBoxInfo.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset238 Calibri;}{\f1\fnil\fcharset0 Calibri;}{\f2\fnil\fcharset2 Symbol;}}
{\*\generator Msftedit 5.41.21.2509;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang1048\b\f0\fs22 PDFCombine\par
\pard{\pntext\f2\'B7\tab}{\*\pn\pnlvlblt\pnf2\pnindent0{\pntxtb\'B7}}\fi-360\li720\sa200\sl276\slmult1\b0 Open images\lang1033\f1\par
\lang1048\f0{\pntext\f2\'B7\tab}Open PDF's\lang1033\f1\par
}
";
        }
    }
}
