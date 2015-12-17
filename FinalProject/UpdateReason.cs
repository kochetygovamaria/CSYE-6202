using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateReason : Form
    {
        internal ListOfReasons listOfReasons;
        private BindingList<Reason> reasons;
        int index;

        public UpdateReason(Reason reason, int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void UpdateReason_Load(object sender, EventArgs e)
        {

            reasons = ClassHelper.LoadReason();
            ReasonName.Text = reasons[index].reasonName;
            Price_txt.Text = reasons[index].reasonPrice.ToString();

        }

        private void ReasonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            double price;
            price = Convert.ToDouble(Price_txt.Text);
            if (price != this.reasons[index].reasonPrice)
            {
                DialogResult dialogresult = MessageBox.Show("Do you want to update  the reason?", "Update the reason's info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    reasons[index].reasonPrice = price;
                    updateReason();
                }
                this.Close();




            }
        }
        public void updateReason()
        {
            ClassHelper.addReason(new List<Reason>(reasons));

        }

        
    }
    }

