﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nihe_computers2
{
    public partial class Form03NewComp : Form
    {

        public Form03NewComp(Class1 C1, DialogComputerAdd Dadd)
        {
            this.DS = C1.DS;
            this.Dadd = Dadd;
            this.C1 = C1;
            InitializeComponent();
            Init();
        }

        public Form03NewComp(DialogComputer D)
        {
            this.DS = D.Comp.DS;
            this.comp = D.Comp;
            this.D = D;
            InitializeComponent();
            Init();
        }


        DialogComputerAdd Dadd = null;
        DS_NiheComputers DS = null;
        Computer comp = null;
        DialogComputer D = null;
        Class1 C1 = null;

        private void Init()
        {
            BindingSource BSProcessor = new BindingSource(DS, "Processor");
            BSProcessor.Sort = "FullName";
            cbProcessor.DataSource = BSProcessor;
            cbProcessor.ValueMember = "id";
            cbProcessor.DisplayMember = "FullName";
            //cbProcessor.SelectedIndex = 0;


            cbHDD.DataSource = DS.HDD;
            cbHDD.ValueMember = "id";
            cbHDD.DisplayMember = "FullName";

            cbRAM.DataSource = DS.RAM;
            cbRAM.ValueMember = "id";
            cbRAM.DisplayMember = "FullName";


            cbOS.DataSource = DS.OS.Select("", "Sort");
            cbOS.ValueMember = "id";
            cbOS.DisplayMember = "FullName";


            //BindingSource BSDeparmment = new BindingSource(DS, "Department");
            //BSDeparmment.Sort = "FullName";
            //cbDepartment.DataSource = BSDeparmment;

            cbDepartment.DataSource = DS.Department.Select("name <> 'списан'", "FullName");
            cbDepartment.ValueMember = "id";
            cbDepartment.DisplayMember = "FullName";
            cbDepartment.SelectedIndex = 0;





            cbDepartment.ValueMember = "id";
            cbDepartment.DisplayMember = "FullName";

            cbVendor.DataSource = DS.Vendor;
            cbVendor.ValueMember = "id";
            cbVendor.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dadd.PurchaseDate = dateTimePicker1.Value;
            Dadd.Date = dateTimePicker1.Value;
            Dadd.WarantyDate = numericUpDown1.Value;
            Dadd.HDD = (int)cbHDD.SelectedValue;
            Dadd.RAMID = (int)cbRAM.SelectedValue;
            Dadd.ProcessorID = (int)cbProcessor.SelectedValue;
            Dadd.OSID = (int)cbOS.SelectedValue;
            Dadd.Number = tbNumber.Text;
            Dadd.Room = tbRoom.Text;
            Dadd.DepartmentID = (int)cbDepartment.SelectedValue;
            Dadd.VendorID = (int)cbVendor.SelectedValue;
            //    Dialog.ValueExtInfo = textBox1.Text;
            Dadd.Username = tbUsername.Text;
            Dadd.ComputerName = tbName.Text;
            Dadd.GUID = Guid.NewGuid().ToString();
            Dadd.AcceptChanges();
            this.Close();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C1.Processor.Edit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C1.RAM.Edit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C1.HDD.Edit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            C1.OS.Edit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C1.Department.Edit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            C1.Vendor.Edit();
        }
    }
}
