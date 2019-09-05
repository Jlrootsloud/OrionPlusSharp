
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections;
using System.Linq;


using Engine;

namespace Engine
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class FrmHouse : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
            this.DarkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.lstIndex = new System.Windows.Forms.ListBox();
            this.DarkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.nudFurniture = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel6 = new DarkUI.Controls.DarkLabel();
            this.nudPrice = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel5 = new DarkUI.Controls.DarkLabel();
            this.nudY = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel4 = new DarkUI.Controls.DarkLabel();
            this.nudX = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel3 = new DarkUI.Controls.DarkLabel();
            this.nudBaseMap = new DarkUI.Controls.DarkNumericUpDown();
            this.DarkLabel2 = new DarkUI.Controls.DarkLabel();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.DarkLabel1 = new DarkUI.Controls.DarkLabel();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.DarkGroupBox1.SuspendLayout();
            this.DarkGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFurniture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseMap)).BeginInit();
            this.SuspendLayout();
            // 
            // DarkGroupBox1
            // 
            this.DarkGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DarkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.DarkGroupBox1.Controls.Add(this.lstIndex);
            this.DarkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.DarkGroupBox1.Name = "DarkGroupBox1";
            this.DarkGroupBox1.Size = new System.Drawing.Size(200, 364);
            this.DarkGroupBox1.TabIndex = 0;
            this.DarkGroupBox1.TabStop = false;
            this.DarkGroupBox1.Text = "House List";
            // 
            // lstIndex
            // 
            this.lstIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lstIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIndex.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstIndex.FormattingEnabled = true;
            this.lstIndex.Location = new System.Drawing.Point(6, 19);
            this.lstIndex.Name = "lstIndex";
            this.lstIndex.Size = new System.Drawing.Size(188, 340);
            this.lstIndex.TabIndex = 1;
            this.lstIndex.Click += new System.EventHandler(this.LstIndex_Click);
            // 
            // DarkGroupBox2
            // 
            this.DarkGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DarkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.DarkGroupBox2.Controls.Add(this.nudFurniture);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel6);
            this.DarkGroupBox2.Controls.Add(this.nudPrice);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel5);
            this.DarkGroupBox2.Controls.Add(this.nudY);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel4);
            this.DarkGroupBox2.Controls.Add(this.nudX);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel3);
            this.DarkGroupBox2.Controls.Add(this.nudBaseMap);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel2);
            this.DarkGroupBox2.Controls.Add(this.txtName);
            this.DarkGroupBox2.Controls.Add(this.DarkLabel1);
            this.DarkGroupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkGroupBox2.Location = new System.Drawing.Point(209, 3);
            this.DarkGroupBox2.Name = "DarkGroupBox2";
            this.DarkGroupBox2.Size = new System.Drawing.Size(272, 335);
            this.DarkGroupBox2.TabIndex = 1;
            this.DarkGroupBox2.TabStop = false;
            this.DarkGroupBox2.Text = "House Properties";
            // 
            // nudFurniture
            // 
            this.nudFurniture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFurniture.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFurniture.Location = new System.Drawing.Point(199, 220);
            this.nudFurniture.Name = "nudFurniture";
            this.nudFurniture.Size = new System.Drawing.Size(62, 20);
            this.nudFurniture.TabIndex = 11;
            this.nudFurniture.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFurniture.ValueChanged += new System.EventHandler(this.NudFurniture_ValueChanged);
            // 
            // DarkLabel6
            // 
            this.DarkLabel6.AutoSize = true;
            this.DarkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DarkLabel6.Location = new System.Drawing.Point(6, 222);
            this.DarkLabel6.Name = "DarkLabel6";
            this.DarkLabel6.Size = new System.Drawing.Size(188, 13);
            this.DarkLabel6.TabIndex = 10;
            this.DarkLabel6.Text = "Max Pieces of Furniture (0 for no max):";
            // 
            // nudPrice
            // 
            this.nudPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudPrice.Location = new System.Drawing.Point(84, 180);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(177, 20);
            this.nudPrice.TabIndex = 9;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.ValueChanged += new System.EventHandler(this.NudPrice_ValueChanged);
            // 
            // DarkLabel5
            // 
            this.DarkLabel5.AutoSize = true;
            this.DarkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DarkLabel5.Location = new System.Drawing.Point(6, 182);
            this.DarkLabel5.Name = "DarkLabel5";
            this.DarkLabel5.Size = new System.Drawing.Size(34, 13);
            this.DarkLabel5.TabIndex = 8;
            this.DarkLabel5.Text = "Price:";
            // 
            // nudY
            // 
            this.nudY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudY.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudY.Location = new System.Drawing.Point(84, 137);
            this.nudY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(177, 20);
            this.nudY.TabIndex = 7;
            this.nudY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY.ValueChanged += new System.EventHandler(this.NudY_ValueChanged);
            // 
            // DarkLabel4
            // 
            this.DarkLabel4.AutoSize = true;
            this.DarkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DarkLabel4.Location = new System.Drawing.Point(6, 139);
            this.DarkLabel4.Name = "DarkLabel4";
            this.DarkLabel4.Size = new System.Drawing.Size(63, 13);
            this.DarkLabel4.TabIndex = 6;
            this.DarkLabel4.Text = "Entrance Y:";
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudX.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudX.Location = new System.Drawing.Point(84, 94);
            this.nudX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(177, 20);
            this.nudX.TabIndex = 5;
            this.nudX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX.ValueChanged += new System.EventHandler(this.NudX_ValueChanged);
            // 
            // DarkLabel3
            // 
            this.DarkLabel3.AutoSize = true;
            this.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DarkLabel3.Location = new System.Drawing.Point(6, 96);
            this.DarkLabel3.Name = "DarkLabel3";
            this.DarkLabel3.Size = new System.Drawing.Size(63, 13);
            this.DarkLabel3.TabIndex = 4;
            this.DarkLabel3.Text = "Entrance X:";
            // 
            // nudBaseMap
            // 
            this.nudBaseMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBaseMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBaseMap.Location = new System.Drawing.Point(84, 51);
            this.nudBaseMap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseMap.Name = "nudBaseMap";
            this.nudBaseMap.Size = new System.Drawing.Size(177, 20);
            this.nudBaseMap.TabIndex = 3;
            this.nudBaseMap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseMap.ValueChanged += new System.EventHandler(this.NudBaseMap_ValueChanged);
            // 
            // DarkLabel2
            // 
            this.DarkLabel2.AutoSize = true;
            this.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DarkLabel2.Location = new System.Drawing.Point(6, 53);
            this.DarkLabel2.Name = "DarkLabel2";
            this.DarkLabel2.Size = new System.Drawing.Size(58, 13);
            this.DarkLabel2.TabIndex = 2;
            this.DarkLabel2.Text = "Base Map:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(84, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // DarkLabel1
            // 
            this.DarkLabel1.AutoSize = true;
            this.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DarkLabel1.Location = new System.Drawing.Point(6, 19);
            this.DarkLabel1.Name = "DarkLabel1";
            this.DarkLabel1.Size = new System.Drawing.Size(72, 13);
            this.DarkLabel1.TabIndex = 0;
            this.DarkLabel1.Text = "House Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(485, 371);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DarkGroupBox2);
            this.Controls.Add(this.DarkGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmHouse";
            this.Text = "House Editor";
            this.Load += new System.EventHandler(this.FrmHouse_Load);
            this.DarkGroupBox1.ResumeLayout(false);
            this.DarkGroupBox2.ResumeLayout(false);
            this.DarkGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFurniture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseMap)).EndInit();
            this.ResumeLayout(false);

		}
		
		internal DarkUI.Controls.DarkGroupBox DarkGroupBox1;
		internal ListBox lstIndex;
		internal DarkUI.Controls.DarkGroupBox DarkGroupBox2;
		internal DarkUI.Controls.DarkTextBox txtName;
		internal DarkUI.Controls.DarkLabel DarkLabel1;
		internal DarkUI.Controls.DarkNumericUpDown nudBaseMap;
		internal DarkUI.Controls.DarkLabel DarkLabel2;
		internal DarkUI.Controls.DarkNumericUpDown nudY;
		internal DarkUI.Controls.DarkLabel DarkLabel4;
		internal DarkUI.Controls.DarkNumericUpDown nudX;
		internal DarkUI.Controls.DarkLabel DarkLabel3;
		internal DarkUI.Controls.DarkNumericUpDown nudPrice;
		internal DarkUI.Controls.DarkLabel DarkLabel5;
		internal DarkUI.Controls.DarkNumericUpDown nudFurniture;
		internal DarkUI.Controls.DarkLabel DarkLabel6;
		internal DarkUI.Controls.DarkButton btnCancel;
		internal DarkUI.Controls.DarkButton btnSave;
	}
	
}
