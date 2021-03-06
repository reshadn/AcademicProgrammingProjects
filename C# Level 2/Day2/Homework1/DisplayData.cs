/*
Project:		Sam's Shoes
Programmer:		Reshad Noorzay
Date:			10/08/08
Description:	This program allow's Sam's Shoe Store to calculate the cost of
                shoes, accessories and a shine. 
*/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SamsShoeStore
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class DisplayDataForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton standardRadioButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox accessoriesTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox salesTaxTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox amountDueTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TextBox subtotalTextBox;
		private System.Windows.Forms.CheckBox travelBagCheckBox;
		private System.Windows.Forms.CheckBox shoeTreeCheckBox;
		private System.Windows.Forms.CheckBox shoeLacesCheckBox;
		private System.Windows.Forms.RadioButton waterproofRadioButton;
		private System.Windows.Forms.RadioButton highGlossRadioButton;
		private System.Windows.Forms.TextBox oldShoeAllowanceTextBox;
		private System.Windows.Forms.TextBox shoePriceTextBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DisplayDataForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.travelBagCheckBox = new System.Windows.Forms.CheckBox();
			this.shoeTreeCheckBox = new System.Windows.Forms.CheckBox();
			this.shoeLacesCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.waterproofRadioButton = new System.Windows.Forms.RadioButton();
			this.highGlossRadioButton = new System.Windows.Forms.RadioButton();
			this.standardRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.accessoriesTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.salesTaxTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.subtotalTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.oldShoeAllowanceTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.amountDueTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.shoePriceTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.travelBagCheckBox);
			this.groupBox1.Controls.Add(this.shoeTreeCheckBox);
			this.groupBox1.Controls.Add(this.shoeLacesCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(24, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Accessories";
			// 
			// travelBagCheckBox
			// 
			this.travelBagCheckBox.Location = new System.Drawing.Point(24, 96);
			this.travelBagCheckBox.Name = "travelBagCheckBox";
			this.travelBagCheckBox.Size = new System.Drawing.Size(144, 24);
			this.travelBagCheckBox.TabIndex = 2;
			this.travelBagCheckBox.Text = "Travel &Bag";
			// 
			// shoeTreeCheckBox
			// 
			this.shoeTreeCheckBox.Location = new System.Drawing.Point(24, 60);
			this.shoeTreeCheckBox.Name = "shoeTreeCheckBox";
			this.shoeTreeCheckBox.Size = new System.Drawing.Size(136, 24);
			this.shoeTreeCheckBox.TabIndex = 1;
			this.shoeTreeCheckBox.Text = "Shoe &Tree";
			// 
			// shoeLacesCheckBox
			// 
			this.shoeLacesCheckBox.Location = new System.Drawing.Point(24, 24);
			this.shoeLacesCheckBox.Name = "shoeLacesCheckBox";
			this.shoeLacesCheckBox.Size = new System.Drawing.Size(152, 24);
			this.shoeLacesCheckBox.TabIndex = 0;
			this.shoeLacesCheckBox.Text = "&Extra set of shoe laces";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.waterproofRadioButton);
			this.groupBox2.Controls.Add(this.highGlossRadioButton);
			this.groupBox2.Controls.Add(this.standardRadioButton);
			this.groupBox2.Location = new System.Drawing.Point(24, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 160);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Shoe Shine";
			// 
			// waterproofRadioButton
			// 
			this.waterproofRadioButton.Location = new System.Drawing.Point(24, 112);
			this.waterproofRadioButton.Name = "waterproofRadioButton";
			this.waterproofRadioButton.Size = new System.Drawing.Size(152, 24);
			this.waterproofRadioButton.TabIndex = 2;
			this.waterproofRadioButton.Text = "&Waterproof";
			// 
			// highGlossRadioButton
			// 
			this.highGlossRadioButton.Location = new System.Drawing.Point(24, 72);
			this.highGlossRadioButton.Name = "highGlossRadioButton";
			this.highGlossRadioButton.TabIndex = 1;
			this.highGlossRadioButton.Text = "&High Gloss";
			// 
			// standardRadioButton
			// 
			this.standardRadioButton.Location = new System.Drawing.Point(24, 32);
			this.standardRadioButton.Name = "standardRadioButton";
			this.standardRadioButton.TabIndex = 0;
			this.standardRadioButton.Text = "&Standard";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(248, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Shoe Sales &Price:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// accessoriesTextBox
			// 
			this.accessoriesTextBox.Enabled = false;
			this.accessoriesTextBox.Location = new System.Drawing.Point(416, 88);
			this.accessoriesTextBox.Name = "accessoriesTextBox";
			this.accessoriesTextBox.Size = new System.Drawing.Size(152, 20);
			this.accessoriesTextBox.TabIndex = 5;
			this.accessoriesTextBox.Text = "";
			this.accessoriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(248, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Accessories && Shine:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// salesTaxTextBox
			// 
			this.salesTaxTextBox.Enabled = false;
			this.salesTaxTextBox.Location = new System.Drawing.Point(416, 128);
			this.salesTaxTextBox.Name = "salesTaxTextBox";
			this.salesTaxTextBox.Size = new System.Drawing.Size(152, 20);
			this.salesTaxTextBox.TabIndex = 7;
			this.salesTaxTextBox.Text = "";
			this.salesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(248, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Sales Tax (8.5%):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// subtotalTextBox
			// 
			this.subtotalTextBox.Enabled = false;
			this.subtotalTextBox.Location = new System.Drawing.Point(416, 168);
			this.subtotalTextBox.Name = "subtotalTextBox";
			this.subtotalTextBox.Size = new System.Drawing.Size(152, 20);
			this.subtotalTextBox.TabIndex = 9;
			this.subtotalTextBox.Text = "";
			this.subtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(248, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Subtotal:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// oldShoeAllowanceTextBox
			// 
			this.oldShoeAllowanceTextBox.Location = new System.Drawing.Point(416, 216);
			this.oldShoeAllowanceTextBox.Name = "oldShoeAllowanceTextBox";
			this.oldShoeAllowanceTextBox.Size = new System.Drawing.Size(152, 20);
			this.oldShoeAllowanceTextBox.TabIndex = 11;
			this.oldShoeAllowanceTextBox.Text = "";
			this.oldShoeAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(248, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "&Old Shoe Allowance:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// amountDueTextBox
			// 
			this.amountDueTextBox.Enabled = false;
			this.amountDueTextBox.Location = new System.Drawing.Point(416, 264);
			this.amountDueTextBox.Name = "amountDueTextBox";
			this.amountDueTextBox.Size = new System.Drawing.Size(152, 20);
			this.amountDueTextBox.TabIndex = 13;
			this.amountDueTextBox.Text = "";
			this.amountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(248, 264);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Amount Due:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(288, 360);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.TabIndex = 14;
			this.calculateButton.Text = "&Calculate";
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.clearButton.Location = new System.Drawing.Point(392, 360);
			this.clearButton.Name = "clearButton";
			this.clearButton.TabIndex = 15;
			this.clearButton.Text = "C&lear";
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(496, 360);
			this.exitButton.Name = "exitButton";
			this.exitButton.TabIndex = 16;
			this.exitButton.Text = "E&xit";
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// shoePriceTextBox
			// 
			this.shoePriceTextBox.Location = new System.Drawing.Point(416, 40);
			this.shoePriceTextBox.Name = "shoePriceTextBox";
			this.shoePriceTextBox.Size = new System.Drawing.Size(152, 20);
			this.shoePriceTextBox.TabIndex = 17;
			this.shoePriceTextBox.Text = "";
			this.shoePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// DisplayDataForm
			// 
			this.AcceptButton = this.calculateButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.clearButton;
			this.ClientSize = new System.Drawing.Size(592, 430);
			this.Controls.Add(this.shoePriceTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.amountDueTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.oldShoeAllowanceTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.subtotalTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.salesTaxTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.accessoriesTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "DisplayDataForm";
			this.Text = "Sam\'s Shoe Store";
			this.Load += new System.EventHandler(this.DisplayCarDataForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new DisplayDataForm());
		}

		// Class level variables and constants

		const decimal
			decLACES_PRICE = 2.50M,
			decTREE_PRICE = 15.0M,
			decBAG_PRICE = 6.99M,
			decSTANDARD_PRICE = 0M,
			decGLOSS_PRICE = 4.75M,
			decWATERPROOF_PRICE = 5.25M,
			decTAX_RATE = .085M;

		private void exitButton_Click(object sender, System.EventArgs e)
		{
			// End program
			this.Close();
		}

		private void DisplayCarDataForm_Load(object sender, System.EventArgs e)
		{
			oldShoeAllowanceTextBox.Text = 0.ToString("C"); //create $0.00
			standardRadioButton.Select();   // default radio button
		}

		private void clearButton_Click(object sender, System.EventArgs e)
		{
			// Reset input controls
			shoePriceTextBox.Text = "";
			accessoriesTextBox.Text = "";
			salesTaxTextBox.Text = "";
			subtotalTextBox.Text = "";
			oldShoeAllowanceTextBox.Text = "";
			amountDueTextBox.Text = "";

			oldShoeAllowanceTextBox.Text = 0.ToString("C");

			shoeLacesCheckBox.Checked = false;
			shoeTreeCheckBox.Checked = false;
			travelBagCheckBox.Checked = false;

			standardRadioButton.Select();
		}

		private void calculateButton_Click(object sender, System.EventArgs e)
		{
			//Calculate and display current amounts and add to totals
			decimal decAccessoriesFinishTotal =0M, 
				decPrice = 0M, decSalesTax, decSubTotal,
				decOldShoeAllowance = 0M, decAmountDue;
			string strMessage,
				holdString;

			//Start price computations by examining selected options
			if (shoeLacesCheckBox.Checked)
			{
				decAccessoriesFinishTotal += decLACES_PRICE;
			}
			if (shoeTreeCheckBox.Checked)
			{
				decAccessoriesFinishTotal += decTREE_PRICE;
			}
			if (travelBagCheckBox.Checked)
			{
				decAccessoriesFinishTotal += decBAG_PRICE;
			}

			if (standardRadioButton.Checked)
			{
				decAccessoriesFinishTotal += decSTANDARD_PRICE;
			}
			else if (highGlossRadioButton.Checked)
			{
				decAccessoriesFinishTotal += decGLOSS_PRICE;
			}
			else
			{
				decAccessoriesFinishTotal += decWATERPROOF_PRICE;
			}

			accessoriesTextBox.Text = decAccessoriesFinishTotal.ToString("C");

			// Start basic price computations
			if (shoePriceTextBox.Text != "")   // Not blank
			{
				try
				{
					decPrice = decimal.Parse(shoePriceTextBox.Text);  //Needs improvement
					shoePriceTextBox.Text = decPrice.ToString("C");
				}

				catch (FormatException)
				{
					strMessage = "Illegal data entered for price.";
					MessageBox.Show(strMessage, "Data Entry Error",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					shoePriceTextBox.Focus(); //refocus cursor in the box that needs to be updated
				}

				catch
				{
					strMessage = "Calculation error." ;
					MessageBox.Show(strMessage, "Data Entry Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				strMessage = "Enter price.";
				MessageBox.Show(strMessage, "Data Entry Error",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				shoePriceTextBox.Focus();
			} // end if

			// Calculate and display intermediate calculations
			decSalesTax = (decPrice + decAccessoriesFinishTotal) * decTAX_RATE;
			salesTaxTextBox.Text = decSalesTax.ToString("C");

			decSubTotal = decPrice + decSalesTax + decAccessoriesFinishTotal;
			subtotalTextBox.Text = decSubTotal.ToString("C");

			if (oldShoeAllowanceTextBox.Text != "$0.00")   
			{
				try
				{
					if (oldShoeAllowanceTextBox.Text[0] == '$')  //What is the better way here?
					{
						holdString = oldShoeAllowanceTextBox.Text;
						holdString = holdString.Replace("$", " ");
						oldShoeAllowanceTextBox.Text = holdString;
					}
					decOldShoeAllowance = decimal.Parse(oldShoeAllowanceTextBox.Text);
					oldShoeAllowanceTextBox.Text = decOldShoeAllowance.ToString("C");
				}

				catch (FormatException)
				{
					strMessage = "Illegal data entered for trade-in.";
					MessageBox.Show(strMessage, "Data Entry Error",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					oldShoeAllowanceTextBox.Focus();
				}

				catch
				{
					strMessage = "Calculation error." ;
					MessageBox.Show(strMessage, "Data Entry Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} // end if

			//Calculate and display final amount due			
			decAmountDue = decSubTotal - decOldShoeAllowance;
			amountDueTextBox.Text = decAmountDue.ToString("C");			
		}
	}
}
