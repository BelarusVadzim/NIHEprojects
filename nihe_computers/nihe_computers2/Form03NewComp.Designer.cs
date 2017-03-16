namespace nihe_computers2
{
    partial class Form03NewComp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProcessor = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonX = new System.Windows.Forms.Button();
            this.cbProcessor = new System.Windows.Forms.ComboBox();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.cbHDD = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.Location = new System.Drawing.Point(37, 261);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(155, 33);
            this.tbNumber.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 261);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 33);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Информация о компьютере";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дата проведения операции";
            // 
            // lbProcessor
            // 
            this.lbProcessor.AutoSize = true;
            this.lbProcessor.Location = new System.Drawing.Point(5, 20);
            this.lbProcessor.Name = "lbProcessor";
            this.lbProcessor.Size = new System.Drawing.Size(63, 13);
            this.lbProcessor.TabIndex = 16;
            this.lbProcessor.Text = "Процессор";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.Location = new System.Drawing.Point(5, 55);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(114, 13);
            this.lbRAM.TabIndex = 17;
            this.lbRAM.Text = "Оперативная память";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Жесткий диск";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Инвентарный номер";
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(117, 310);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(75, 23);
            this.buttonX.TabIndex = 22;
            this.buttonX.Text = "Отмена";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // cbProcessor
            // 
            this.cbProcessor.BackColor = System.Drawing.SystemColors.Window;
            this.cbProcessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProcessor.FormattingEnabled = true;
            this.cbProcessor.Location = new System.Drawing.Point(158, 12);
            this.cbProcessor.Name = "cbProcessor";
            this.cbProcessor.Size = new System.Drawing.Size(179, 21);
            this.cbProcessor.TabIndex = 23;
            // 
            // cbRAM
            // 
            this.cbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Location = new System.Drawing.Point(158, 52);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(179, 21);
            this.cbRAM.TabIndex = 24;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(423, 211);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(121, 20);
            this.tbUsername.TabIndex = 26;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(357, 150);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 27;
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(357, 211);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(44, 20);
            this.tbRoom.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Имя пользователя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Имя компьютера";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Кабинет";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Операционная система";
            // 
            // cbOS
            // 
            this.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Location = new System.Drawing.Point(159, 126);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(178, 21);
            this.cbOS.TabIndex = 33;
            // 
            // cbHDD
            // 
            this.cbHDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHDD.FormattingEnabled = true;
            this.cbHDD.Location = new System.Drawing.Point(158, 85);
            this.cbHDD.Name = "cbHDD";
            this.cbHDD.Size = new System.Drawing.Size(178, 21);
            this.cbHDD.TabIndex = 34;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(158, 162);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(178, 21);
            this.cbDepartment.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Структ. подраздел.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Срок гарантии";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(448, 86);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Произодитель компа";
            // 
            // cbVendor
            // 
            this.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(158, 195);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(178, 21);
            this.cbVendor.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(133, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 42;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(133, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 43;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(133, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 44;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(133, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 45;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(133, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 46;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(133, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 20);
            this.button7.TabIndex = 47;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form03NewComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(582, 345);
            this.ControlBox = false;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVendor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbHDD);
            this.Controls.Add(this.cbOS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRoom);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.cbRAM);
            this.Controls.Add(this.cbProcessor);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbRAM);
            this.Controls.Add(this.lbProcessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form03NewComp";
            this.Text = "Добавление компьютера";
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProcessor;
        private System.Windows.Forms.Label lbRAM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.ComboBox cbProcessor;
        private System.Windows.Forms.ComboBox cbRAM;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.ComboBox cbHDD;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbVendor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}