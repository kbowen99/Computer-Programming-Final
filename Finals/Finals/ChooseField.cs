using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Frm_ChooseField : Form
    {
        public int MaxRange = 38;
        public int MinRange = 0;
        const int MaximumRange = 38;
        public Frm_ChooseField()
        {
            InitializeComponent(); //The almighty
        }

        private void Frm_ChooseField_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            //if safe to, update min/max
            if ((Convert.ToInt32(Txt_Max.Text)) < MaximumRange && (Convert.ToInt32(Txt_Min.Text)) < MaximumRange){
                using (Frm_Final f2 = new Frm_Final())
                {
                    MinRange = Convert.ToInt32(Txt_Min.Text); //update Variables Used for min/Max
                    MaxRange = Convert.ToInt32(Txt_Max.Text);
                }
            }
            else
            {
                MessageBox.Show("I'm sorry dave, I just can't Let you do that", "out of range"); // nothing like a little humor
            }

        }

        private void Frm_ChooseField_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
