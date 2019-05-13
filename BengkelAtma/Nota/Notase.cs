using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelAtma.Nota
{
    public partial class Notase : UserControl
    {
        public Notase()
        {
            InitializeComponent();
        }

        private void btnNotaPembayaran_Click(object sender, EventArgs e)
        {
            FormNota NotaForm = new FormNota();
            NotaForm.Show();
        }
    }
}
