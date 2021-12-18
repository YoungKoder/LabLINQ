using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataAccess dataAcc = DataAccess.GetInstance();


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataAcc.context.STUDENTS_ONE;

            dataGridView21Example.DataSource = dataAcc.Query21Example();
            dataGridView21.DataSource = dataAcc.Query21();

            dataGridView22Example.DataSource = dataAcc.Query22Example();
            dataGridView22.DataSource = dataAcc.Query22();
            if ((dataGridView21.RowCount > 0) || (dataGridView22.RowCount > 0))
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery2"];

            dataGridView3Example.DataSource = dataAcc.Query3Example();
            dataGridView3.DataSource = dataAcc.Query3();
            if (dataGridView3.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery3"];

            dataGridView4Example.DataSource = dataAcc.Query4Example();
            dataGridView4.DataSource = dataAcc.Query4();
            if (dataGridView4.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery4"];

            dataGridView5Example.DataSource = dataAcc.Query5Example();
            dataGridView5.DataSource = dataAcc.Query5();
            if (dataGridView5.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery5"];

            labelAgrExample61.Text = dataAcc.Query61Example().ToString();
            labelAgr61.Text = dataAcc.Query61().ToString();
            labelAgrExample62.Text = dataAcc.Query62Example().ToString();
            labelAgr62.Text = dataAcc.Query62().ToString();
            if ((labelAgr61.Text != "-1") || (labelAgr62.Text != "-1"))
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery6"];

            dataGridViewComplex1.DataSource = dataAcc.ComplexQuery1();
            if (dataGridViewComplex1.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabComplexQuery1"];

            dataGridViewComplex2.DataSource = dataAcc.ComplexQuery2();
            if (dataGridViewComplex2.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabComplexQuery2"];

            dataGridViewComplex3.DataSource = dataAcc.ComplexQuery3();
            if (dataGridViewComplex3.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabComplexQuery3"];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
