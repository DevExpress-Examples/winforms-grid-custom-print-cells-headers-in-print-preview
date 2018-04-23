using System;
using System.Collections.Generic;
using System.Drawing;

namespace GridBeforePrint
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private List<Customer> customerList;

        private List<Customer> GetData()
        {
            List<Customer> list = new List<Customer>();
            for (int i = 0; i < 15; i++)
            {
                Customer customer = new Customer()
                {
                    FirstName = string.Format("FirstName {0}", i),
                    LastName = string.Format("LastName {0}", i),
                    Id = i
                };
                list.Add(customer);
            }
            return list;
        }

        public Form1()
        {
            InitializeComponent();
            myGridView1.OptionsView.ShowPreview = true;
            myGridView1.OptionsView.AutoCalcPreviewLineCount = false;
            myGridView1.PreviewFieldName = "FirstName";
            customerList = GetData();
            myGridControl1.DataSource = customerList;
            this.Controls.Add(myGridControl1);

            myGridView1.HeaderPrintEvent += MyGridView1_HeaderPrintEvent;
            myGridView1.SamplePrintEvent += MyGridView1_SamplePrintEvent;
        }

        private void MyGridView1_SamplePrintEvent(object sender, SamplePrintEventArgs args)
        {
            args.Brick.Style.BackColor = Color.Pink;
        }

        private void MyGridView1_HeaderPrintEvent(object sender, HeaderPrintEventArgs args)
        {
            args.Brick.Style.BackColor = Color.PowderBlue;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            myGridControl1.ShowPrintPreview();
        }
    }
}
