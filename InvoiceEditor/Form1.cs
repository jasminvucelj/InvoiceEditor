using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceEditor
{
    public partial class NewInvoiceForm : Form
    {
        string invoiceDataFile = "InvoiceData.txt";
        string invoiceEditorDataFile = "InvoiceEditorData.txt";
        string pythonExePath = @"C:\Python27\python.exe";
        string relocatorPath = Path.Combine(Directory.GetCurrentDirectory(), "InvoiceRelocator.exe");

        public NewInvoiceForm()
        {
            InitializeComponent();

            initShippingCosts();
            readDataFromFiles();

            textBoxApproved.Select();
        }


        private void initShippingCosts()
        {
            comboBoxShippingCost.Items.Add("14,00");
            comboBoxShippingCost.Items.Add("18,00");
            comboBoxShippingCost.Items.Add("36,00");
        }


        private void readDataFromFiles()
        {
            if (File.Exists(invoiceEditorDataFile) && new FileInfo(invoiceEditorDataFile).Length != 0)
            {
                pythonExePath = File.ReadLines(invoiceEditorDataFile).First();
            }

            if (File.Exists(invoiceDataFile) && new FileInfo(invoiceDataFile).Length != 0)
            {
                string[] lines = System.IO.File.ReadAllLines(invoiceDataFile);

                numericUpDownInvoiceNumber.Value = int.Parse(lines[0]) + 1;
                textBoxOrderNumber.Text = lines[1];
                dateTimePickerDate.Value = DateTime.Parse(lines[2]);
                dateTimePickerDueDate.Value = DateTime.Parse(lines[3]);

                numericUpDownQuantity.Value = int.Parse(lines[10]);
                textBoxUnitCost.Text = lines[11];
                comboBoxShippingCost.Text = lines[12];
            }

            else textBoxMessage.Text = "Datoteka s podacima o računu ne postoji - nova će biti kreirana pritiskom na gumb Spremi.";

        }


        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = "";

            if (!File.Exists(invoiceDataFile))
            {
                File.Create(invoiceDataFile);
            }

            // File.WriteAllText(fileName, String.Empty);

            string[] lines = new string[13];
            lines[0] = ((int)numericUpDownInvoiceNumber.Value).ToString("D3");
            lines[1] = textBoxOrderNumber.Text;
            lines[2] = dateTimePickerDate.Value.ToString("dd.MM.yyyy.");
            lines[3] = dateTimePickerDueDate.Value.ToString("dd.MM.yyyy.");
            lines[4] = textBoxApproved.Text;
            lines[5] = textBoxName.Text;
            lines[6] = numericUpDownZipCode.Value.ToString();
            lines[7] = textBoxCity.Text;
            lines[8] = textBoxAddress.Text;
            lines[9] = textBoxID.Text;
            lines[10] = numericUpDownQuantity.Value.ToString();
            lines[11] = textBoxUnitCost.Text;
            lines[12] = comboBoxShippingCost.Text;

            File.WriteAllLines(invoiceDataFile, lines);

            createDocx();

            textBoxMessage.Text = "Uspješno spremljeno!";

            prepareForNextInvoice();
        }


        private void createDocx()
        {
            string arg = string.Format("docxEditor.py"); // Path to the Python code

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(pythonExePath, arg);
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;

            Process processChild = Process.Start(p.StartInfo);
            processChild.WaitForExit();
            processChild.Close();
        }

        
        private void prepareForNextInvoice()
        {
            numericUpDownInvoiceNumber.Value++;
            textBoxOrderNumber.Text = "";
            textBoxName.Text= "";
            numericUpDownZipCode.Value = numericUpDownZipCode.Minimum;
            textBoxCity.Text = "";
            textBoxAddress.Text = "";
            textBoxID.Text = "";

            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonMoveAll_Click(object sender, EventArgs e)
        {
            Process.Start(relocatorPath);
        }


        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDueDate.Value = dateTimePickerDate.Value.AddDays(7);
        }


        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            adjustShippingCosts();
            costChanged(sender, e);
        }

        
        private void adjustShippingCosts()
        {
            int quantity = (int)numericUpDownQuantity.Value;
            if (quantity <= 1) comboBoxShippingCost.Text = "14,00";
            else if (quantity == 2) comboBoxShippingCost.Text = "18,00";
            else comboBoxShippingCost.Text = "36,00";
        }


        private void costChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(numericUpDownQuantity.Value.ToString()) ||  string.IsNullOrWhiteSpace(textBoxUnitCost.Text))
            {
                textBoxSumInitial.Text = "0.00";
                return;
            }

            textBoxSumInitial.Text = ((int)numericUpDownQuantity.Value * decimal.Parse(textBoxUnitCost.Text)).ToString("F");
        }


        private void totalCostChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSumInitial.Text) || string.IsNullOrWhiteSpace(comboBoxShippingCost.Text))
            {
                textBoxSumTotal.Text = "0.00";
                return;
            }

            textBoxSumTotal.Text = (decimal.Parse(textBoxSumInitial.Text) + decimal.Parse(comboBoxShippingCost.Text)).ToString("F");
        }


        private void cursorToEndOfTextBox(TextBox textBox)
        {
            textBox.Focus();
            textBox.SelectionStart = textBox.Text.Length;
        }


        private void buttonApprovedByM_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "ODOBRIO ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonApprovedByF_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "ODOBRILA ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonMunicipalityPresidentM_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "NAČELNIK ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonMunicipalityPresidentF_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "NAČELNICA ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonMayorM_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "GRADONAČELNIK ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonMayorF_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "GRADONAČELNICA ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonPrincipalM_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "RAVNATELJ ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonPrincipalF_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text += "RAVNATELJICA ";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonIng_Click(object sender, EventArgs e)
        {
            string temp = textBoxApproved.Text;
            if (temp[temp.Length - 1] == ' ')
                temp = temp.Substring(0, temp.Length - 1);
            textBoxApproved.Text = temp + ", ing. ";

            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonProf_Click(object sender, EventArgs e)
        {
            string temp = textBoxApproved.Text;
            if (temp[temp.Length - 1] == ' ')
                temp = temp.Substring(0, temp.Length - 1);
            textBoxApproved.Text = temp + ", prof. ";

            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonClearApproval_Click(object sender, EventArgs e)
        {
            textBoxApproved.Text = "";
            cursorToEndOfTextBox(textBoxApproved);
        }


        private void buttonDZ_Click(object sender, EventArgs e)
        {
            textBoxName.Text += "DOM ZDRAVLJA ";
            cursorToEndOfTextBox(textBoxName);
        }


        private void buttonMunicipality_Click(object sender, EventArgs e)
        {
            textBoxName.Text += "OPĆINA ";
            cursorToEndOfTextBox(textBoxName);
        }


        private void buttonCity_Click(object sender, EventArgs e)
        {
            textBoxName.Text += "GRAD ";
            cursorToEndOfTextBox(textBoxName);
        }


        private void buttonSchool1_Click(object sender, EventArgs e)
        {
            textBoxName.Text += "OSNOVNA ŠKOLA ";
            cursorToEndOfTextBox(textBoxName);
        }


        private void buttonSchool2_Click(object sender, EventArgs e)
        {
            textBoxName.Text += "SREDNJA ŠKOLA ";
            cursorToEndOfTextBox(textBoxName);
        }


        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            textBoxName.Text += "LJEKARNA ";
            cursorToEndOfTextBox(textBoxName);
        }


        private void buttonClearName_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            cursorToEndOfTextBox(textBoxName);
        }


        private void numericUpDownInvoiceNumber_Enter(object sender, EventArgs e)
        {
            numericUpDownInvoiceNumber.Select(0, numericUpDownInvoiceNumber.Value.ToString().Length);
        }


        private void textBoxOrderNumber_Enter(object sender, EventArgs e)
        {
            textBoxOrderNumber.Select(0, textBoxOrderNumber.Text.Length);
        }


        private void textBoxApproved_Enter(object sender, EventArgs e)
        {
            textBoxApproved.Select(0, textBoxApproved.Text.Length);
        }


        private void textBoxName_Enter(object sender, EventArgs e)
        {
            textBoxName.Select(0, textBoxName.Text.Length);
        }


        private void numericUpDownZipCode_Enter(object sender, EventArgs e)
        {
            numericUpDownZipCode.Select(0, numericUpDownZipCode.Value.ToString().Length);
        }


        private void textBoxCity_Enter(object sender, EventArgs e)
        {
            textBoxCity.Select(0, textBoxCity.Text.Length);
        }


        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            textBoxAddress.Select(0, textBoxAddress.Text.Length);
        }


        private void textBoxID_Enter(object sender, EventArgs e)
        {
            textBoxID.Select(0, textBoxID.Text.Length);
        }


        private void numericUpDownQuantity_Enter(object sender, EventArgs e)
        {
            numericUpDownQuantity.Select(0, numericUpDownQuantity.Value.ToString().Length);
        }


        private void textBoxUnitCost_Enter(object sender, EventArgs e)
        {
            textBoxUnitCost.Select(0, textBoxUnitCost.Text.Length);
        }


        private void comboBoxShippingCost_Enter(object sender, EventArgs e)
        {
            comboBoxShippingCost.Select(0, comboBoxShippingCost.Text.Length);
        }


        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddress.Text) && char.IsLower(textBoxAddress.Text[0]))
            {
                textBoxAddress.Text = ToggleCase(textBoxAddress.Text);
            }
        }


        public string ToggleCase(string input)
        {
            string result = string.Empty;
            char[] inputArray = input.ToCharArray();
            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += Char.ToUpper(c);
                else
                    result += Char.ToLower(c);
            }
            return result;
        }

    }
}
