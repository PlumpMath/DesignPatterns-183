using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbType.Items.AddRange(new object[]
            {
                "正常收费","打八折","满300返100"
            });
            cbbType.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                CashContext cashContext = new CashContext(cbbType.SelectedItem.ToString());
                double totalPrice = cashContext.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtAmount.Text));
                lbxList.Items.Add($"{cbbType.Text}：单价:{txtPrice.Text}，数量:{txtAmount.Text}，合计:{totalPrice}");
                lblTotalPrice.Text = totalPrice.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrice.Text = string.Empty;
            txtAmount.Text = string.Empty;
            lblTotalPrice.Text = 0.ToString();
            lbxList.Items.Clear();
        }
    }
}
