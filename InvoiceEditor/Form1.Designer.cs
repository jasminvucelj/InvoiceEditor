namespace InvoiceEditor
{
    partial class NewInvoiceForm
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
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.numericUpDownInvoiceNumber = new System.Windows.Forms.NumericUpDown();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5Approved = new System.Windows.Forms.Label();
            this.textBoxApproved = new System.Windows.Forms.TextBox();
            this.buttonApprovedByM = new System.Windows.Forms.Button();
            this.buttonApprovedByF = new System.Windows.Forms.Button();
            this.buttonMunicipalityPresidentF = new System.Windows.Forms.Button();
            this.buttonMunicipalityPresidentM = new System.Windows.Forms.Button();
            this.buttonMayorF = new System.Windows.Forms.Button();
            this.buttonMayorM = new System.Windows.Forms.Button();
            this.buttonPrincipalF = new System.Windows.Forms.Button();
            this.buttonPrincipalM = new System.Windows.Forms.Button();
            this.buttonProf = new System.Windows.Forms.Button();
            this.buttonIng = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.numericUpDownZipCode = new System.Windows.Forms.NumericUpDown();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label1Quantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelUnitCost = new System.Windows.Forms.Label();
            this.textBoxUnitCost = new System.Windows.Forms.TextBox();
            this.labelSumInitial = new System.Windows.Forms.Label();
            this.textBoxSumInitial = new System.Windows.Forms.TextBox();
            this.labelShippingCost = new System.Windows.Forms.Label();
            this.textBoxSumTotal = new System.Windows.Forms.TextBox();
            this.labelSumTotal = new System.Windows.Forms.Label();
            this.buttonClearApproval = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.comboBoxShippingCost = new System.Windows.Forms.ComboBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonMunicipality = new System.Windows.Forms.Button();
            this.buttonCity = new System.Windows.Forms.Button();
            this.buttonSchool2 = new System.Windows.Forms.Button();
            this.buttonSchool1 = new System.Windows.Forms.Button();
            this.buttonDZ = new System.Windows.Forms.Button();
            this.buttonPharmacy = new System.Windows.Forms.Button();
            this.buttonMoveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvoiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(12, 9);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(64, 13);
            this.labelInvoiceNumber.TabIndex = 19;
            this.labelInvoiceNumber.Text = "Broj računa:";
            // 
            // numericUpDownInvoiceNumber
            // 
            this.numericUpDownInvoiceNumber.Location = new System.Drawing.Point(93, 7);
            this.numericUpDownInvoiceNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownInvoiceNumber.Name = "numericUpDownInvoiceNumber";
            this.numericUpDownInvoiceNumber.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownInvoiceNumber.TabIndex = 2;
            this.numericUpDownInvoiceNumber.TabStop = false;
            this.numericUpDownInvoiceNumber.Enter += new System.EventHandler(this.numericUpDownInvoiceNumber_Enter);
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(12, 40);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(75, 13);
            this.labelOrderNumber.TabIndex = 3;
            this.labelOrderNumber.Text = "Broj narudžbe:";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(93, 37);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(112, 20);
            this.textBoxOrderNumber.TabIndex = 4;
            this.textBoxOrderNumber.Enter += new System.EventHandler(this.textBoxOrderNumber_Enter);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(75, 69);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerDate.TabIndex = 5;
            this.dateTimePickerDate.TabStop = false;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 69);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Datum:";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(12, 101);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(57, 13);
            this.labelDueDate.TabIndex = 7;
            this.labelDueDate.Text = "Dospijeva:";
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(75, 101);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerDueDate.TabIndex = 8;
            this.dateTimePickerDueDate.TabStop = false;
            // 
            // label5Approved
            // 
            this.label5Approved.AutoSize = true;
            this.label5Approved.Location = new System.Drawing.Point(12, 197);
            this.label5Approved.Name = "label5Approved";
            this.label5Approved.Size = new System.Drawing.Size(87, 13);
            this.label5Approved.TabIndex = 9;
            this.label5Approved.Text = "Tekst odobrenja:";
            // 
            // textBoxApproved
            // 
            this.textBoxApproved.Location = new System.Drawing.Point(13, 214);
            this.textBoxApproved.Name = "textBoxApproved";
            this.textBoxApproved.Size = new System.Drawing.Size(581, 20);
            this.textBoxApproved.TabIndex = 9;
            this.textBoxApproved.Enter += new System.EventHandler(this.textBoxApproved_Enter);
            // 
            // buttonApprovedByM
            // 
            this.buttonApprovedByM.Location = new System.Drawing.Point(13, 241);
            this.buttonApprovedByM.Name = "buttonApprovedByM";
            this.buttonApprovedByM.Size = new System.Drawing.Size(86, 23);
            this.buttonApprovedByM.TabIndex = 11;
            this.buttonApprovedByM.TabStop = false;
            this.buttonApprovedByM.Text = "+ ODOBRIO";
            this.buttonApprovedByM.UseVisualStyleBackColor = true;
            this.buttonApprovedByM.Click += new System.EventHandler(this.buttonApprovedByM_Click);
            // 
            // buttonApprovedByF
            // 
            this.buttonApprovedByF.Location = new System.Drawing.Point(12, 270);
            this.buttonApprovedByF.Name = "buttonApprovedByF";
            this.buttonApprovedByF.Size = new System.Drawing.Size(87, 23);
            this.buttonApprovedByF.TabIndex = 12;
            this.buttonApprovedByF.TabStop = false;
            this.buttonApprovedByF.Text = "+ ODOBRILA";
            this.buttonApprovedByF.UseVisualStyleBackColor = true;
            this.buttonApprovedByF.Click += new System.EventHandler(this.buttonApprovedByF_Click);
            // 
            // buttonMunicipalityPresidentF
            // 
            this.buttonMunicipalityPresidentF.Location = new System.Drawing.Point(103, 270);
            this.buttonMunicipalityPresidentF.Name = "buttonMunicipalityPresidentF";
            this.buttonMunicipalityPresidentF.Size = new System.Drawing.Size(86, 23);
            this.buttonMunicipalityPresidentF.TabIndex = 14;
            this.buttonMunicipalityPresidentF.TabStop = false;
            this.buttonMunicipalityPresidentF.Text = "+ NAČELNICA";
            this.buttonMunicipalityPresidentF.UseVisualStyleBackColor = true;
            this.buttonMunicipalityPresidentF.Click += new System.EventHandler(this.buttonMunicipalityPresidentF_Click);
            // 
            // buttonMunicipalityPresidentM
            // 
            this.buttonMunicipalityPresidentM.Location = new System.Drawing.Point(105, 241);
            this.buttonMunicipalityPresidentM.Name = "buttonMunicipalityPresidentM";
            this.buttonMunicipalityPresidentM.Size = new System.Drawing.Size(85, 23);
            this.buttonMunicipalityPresidentM.TabIndex = 13;
            this.buttonMunicipalityPresidentM.TabStop = false;
            this.buttonMunicipalityPresidentM.Text = "+ NAČELNIK";
            this.buttonMunicipalityPresidentM.UseVisualStyleBackColor = true;
            this.buttonMunicipalityPresidentM.Click += new System.EventHandler(this.buttonMunicipalityPresidentM_Click);
            // 
            // buttonMayorF
            // 
            this.buttonMayorF.Location = new System.Drawing.Point(195, 269);
            this.buttonMayorF.Name = "buttonMayorF";
            this.buttonMayorF.Size = new System.Drawing.Size(127, 23);
            this.buttonMayorF.TabIndex = 16;
            this.buttonMayorF.TabStop = false;
            this.buttonMayorF.Text = "+ GRADONAČELNICA";
            this.buttonMayorF.UseVisualStyleBackColor = true;
            this.buttonMayorF.Click += new System.EventHandler(this.buttonMayorF_Click);
            // 
            // buttonMayorM
            // 
            this.buttonMayorM.Location = new System.Drawing.Point(196, 240);
            this.buttonMayorM.Name = "buttonMayorM";
            this.buttonMayorM.Size = new System.Drawing.Size(126, 23);
            this.buttonMayorM.TabIndex = 15;
            this.buttonMayorM.TabStop = false;
            this.buttonMayorM.Text = "+ GRADONAČELNIK";
            this.buttonMayorM.UseVisualStyleBackColor = true;
            this.buttonMayorM.Click += new System.EventHandler(this.buttonMayorM_Click);
            // 
            // buttonPrincipalF
            // 
            this.buttonPrincipalF.Location = new System.Drawing.Point(328, 269);
            this.buttonPrincipalF.Name = "buttonPrincipalF";
            this.buttonPrincipalF.Size = new System.Drawing.Size(112, 23);
            this.buttonPrincipalF.TabIndex = 18;
            this.buttonPrincipalF.TabStop = false;
            this.buttonPrincipalF.Text = "+ RAVNATELJICA";
            this.buttonPrincipalF.UseVisualStyleBackColor = true;
            this.buttonPrincipalF.Click += new System.EventHandler(this.buttonPrincipalF_Click);
            // 
            // buttonPrincipalM
            // 
            this.buttonPrincipalM.Location = new System.Drawing.Point(328, 240);
            this.buttonPrincipalM.Name = "buttonPrincipalM";
            this.buttonPrincipalM.Size = new System.Drawing.Size(111, 23);
            this.buttonPrincipalM.TabIndex = 17;
            this.buttonPrincipalM.TabStop = false;
            this.buttonPrincipalM.Text = "+ RAVNATELJ";
            this.buttonPrincipalM.UseVisualStyleBackColor = true;
            this.buttonPrincipalM.Click += new System.EventHandler(this.buttonPrincipalM_Click);
            // 
            // buttonProf
            // 
            this.buttonProf.Location = new System.Drawing.Point(444, 269);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(49, 23);
            this.buttonProf.TabIndex = 20;
            this.buttonProf.TabStop = false;
            this.buttonProf.Text = "+, prof.";
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // buttonIng
            // 
            this.buttonIng.Location = new System.Drawing.Point(445, 240);
            this.buttonIng.Name = "buttonIng";
            this.buttonIng.Size = new System.Drawing.Size(48, 23);
            this.buttonIng.TabIndex = 19;
            this.buttonIng.TabStop = false;
            this.buttonIng.Text = "+, ing.";
            this.buttonIng.UseVisualStyleBackColor = true;
            this.buttonIng.Click += new System.EventHandler(this.buttonIng_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(238, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Naziv:";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(281, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(238, 75);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(79, 13);
            this.labelZipCode.TabIndex = 24;
            this.labelZipCode.Text = "Poštanski broj: ";
            // 
            // numericUpDownZipCode
            // 
            this.numericUpDownZipCode.Location = new System.Drawing.Point(323, 73);
            this.numericUpDownZipCode.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownZipCode.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZipCode.Name = "numericUpDownZipCode";
            this.numericUpDownZipCode.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownZipCode.TabIndex = 25;
            this.numericUpDownZipCode.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZipCode.Enter += new System.EventHandler(this.numericUpDownZipCode_Enter);
            // 
            // textBoxCity
            // 
            this.textBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCity.Location = new System.Drawing.Point(323, 105);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(179, 20);
            this.textBoxCity.TabIndex = 27;
            this.textBoxCity.Enter += new System.EventHandler(this.textBoxCity_Enter);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(238, 108);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(70, 13);
            this.labelCity.TabIndex = 26;
            this.labelCity.Text = "Naziv mjesta:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(323, 137);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxAddress.TabIndex = 29;
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(238, 140);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(43, 13);
            this.labelAddress.TabIndex = 28;
            this.labelAddress.Text = "Adresa:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(323, 169);
            this.textBoxID.MaxLength = 11;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(179, 20);
            this.textBoxID.TabIndex = 31;
            this.textBoxID.Enter += new System.EventHandler(this.textBoxID_Enter);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(238, 172);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 13);
            this.labelID.TabIndex = 30;
            this.labelID.Text = "OIB: ";
            // 
            // label1Quantity
            // 
            this.label1Quantity.AutoSize = true;
            this.label1Quantity.Location = new System.Drawing.Point(530, 9);
            this.label1Quantity.Name = "label1Quantity";
            this.label1Quantity.Size = new System.Drawing.Size(47, 13);
            this.label1Quantity.TabIndex = 32;
            this.label1Quantity.Text = "Količina:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(607, 6);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownQuantity.TabIndex = 33;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            this.numericUpDownQuantity.Enter += new System.EventHandler(this.numericUpDownQuantity_Enter);
            // 
            // labelUnitCost
            // 
            this.labelUnitCost.AutoSize = true;
            this.labelUnitCost.Location = new System.Drawing.Point(530, 37);
            this.labelUnitCost.Name = "labelUnitCost";
            this.labelUnitCost.Size = new System.Drawing.Size(61, 13);
            this.labelUnitCost.TabIndex = 34;
            this.labelUnitCost.Text = "Jed. cijena:";
            // 
            // textBoxUnitCost
            // 
            this.textBoxUnitCost.Location = new System.Drawing.Point(607, 32);
            this.textBoxUnitCost.Name = "textBoxUnitCost";
            this.textBoxUnitCost.Size = new System.Drawing.Size(84, 20);
            this.textBoxUnitCost.TabIndex = 35;
            this.textBoxUnitCost.TextChanged += new System.EventHandler(this.costChanged);
            this.textBoxUnitCost.Enter += new System.EventHandler(this.textBoxUnitCost_Enter);
            // 
            // labelSumInitial
            // 
            this.labelSumInitial.AutoSize = true;
            this.labelSumInitial.Location = new System.Drawing.Point(530, 66);
            this.labelSumInitial.Name = "labelSumInitial";
            this.labelSumInitial.Size = new System.Drawing.Size(35, 13);
            this.labelSumInitial.TabIndex = 36;
            this.labelSumInitial.Text = "Iznos:";
            // 
            // textBoxSumInitial
            // 
            this.textBoxSumInitial.Location = new System.Drawing.Point(607, 62);
            this.textBoxSumInitial.Name = "textBoxSumInitial";
            this.textBoxSumInitial.ReadOnly = true;
            this.textBoxSumInitial.Size = new System.Drawing.Size(84, 20);
            this.textBoxSumInitial.TabIndex = 37;
            this.textBoxSumInitial.TabStop = false;
            this.textBoxSumInitial.TextChanged += new System.EventHandler(this.totalCostChanged);
            // 
            // labelShippingCost
            // 
            this.labelShippingCost.AutoSize = true;
            this.labelShippingCost.Location = new System.Drawing.Point(530, 98);
            this.labelShippingCost.Name = "labelShippingCost";
            this.labelShippingCost.Size = new System.Drawing.Size(74, 13);
            this.labelShippingCost.TabIndex = 38;
            this.labelShippingCost.Text = "Pošt. troškovi:";
            // 
            // textBoxSumTotal
            // 
            this.textBoxSumTotal.Location = new System.Drawing.Point(607, 126);
            this.textBoxSumTotal.Name = "textBoxSumTotal";
            this.textBoxSumTotal.ReadOnly = true;
            this.textBoxSumTotal.Size = new System.Drawing.Size(84, 20);
            this.textBoxSumTotal.TabIndex = 41;
            this.textBoxSumTotal.TabStop = false;
            // 
            // labelSumTotal
            // 
            this.labelSumTotal.AutoSize = true;
            this.labelSumTotal.Location = new System.Drawing.Point(530, 129);
            this.labelSumTotal.Name = "labelSumTotal";
            this.labelSumTotal.Size = new System.Drawing.Size(48, 13);
            this.labelSumTotal.TabIndex = 40;
            this.labelSumTotal.Text = "Ukupno:";
            // 
            // buttonClearApproval
            // 
            this.buttonClearApproval.Location = new System.Drawing.Point(600, 214);
            this.buttonClearApproval.Name = "buttonClearApproval";
            this.buttonClearApproval.Size = new System.Drawing.Size(91, 21);
            this.buttonClearApproval.TabIndex = 42;
            this.buttonClearApproval.TabStop = false;
            this.buttonClearApproval.Text = "Obriši";
            this.buttonClearApproval.UseVisualStyleBackColor = true;
            this.buttonClearApproval.Click += new System.EventHandler(this.buttonClearApproval_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(600, 240);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(95, 52);
            this.buttonSaveAll.TabIndex = 45;
            this.buttonSaveAll.Text = "Spremi";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // comboBoxShippingCost
            // 
            this.comboBoxShippingCost.FormattingEnabled = true;
            this.comboBoxShippingCost.Location = new System.Drawing.Point(607, 93);
            this.comboBoxShippingCost.Name = "comboBoxShippingCost";
            this.comboBoxShippingCost.Size = new System.Drawing.Size(84, 21);
            this.comboBoxShippingCost.TabIndex = 42;
            this.comboBoxShippingCost.TabStop = false;
            this.comboBoxShippingCost.TextChanged += new System.EventHandler(this.totalCostChanged);
            this.comboBoxShippingCost.Enter += new System.EventHandler(this.comboBoxShippingCost_Enter);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Location = new System.Drawing.Point(12, 300);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(676, 13);
            this.textBoxMessage.TabIndex = 46;
            this.textBoxMessage.TabStop = false;
            // 
            // buttonMunicipality
            // 
            this.buttonMunicipality.Location = new System.Drawing.Point(281, 36);
            this.buttonMunicipality.Name = "buttonMunicipality";
            this.buttonMunicipality.Size = new System.Drawing.Size(67, 23);
            this.buttonMunicipality.TabIndex = 47;
            this.buttonMunicipality.TabStop = false;
            this.buttonMunicipality.Text = "+ OPĆINA";
            this.buttonMunicipality.UseVisualStyleBackColor = true;
            this.buttonMunicipality.Click += new System.EventHandler(this.buttonMunicipality_Click);
            // 
            // buttonCity
            // 
            this.buttonCity.Location = new System.Drawing.Point(354, 37);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(55, 23);
            this.buttonCity.TabIndex = 48;
            this.buttonCity.TabStop = false;
            this.buttonCity.Text = "+ GRAD";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonSchool2
            // 
            this.buttonSchool2.Location = new System.Drawing.Point(461, 37);
            this.buttonSchool2.Name = "buttonSchool2";
            this.buttonSchool2.Size = new System.Drawing.Size(41, 23);
            this.buttonSchool2.TabIndex = 50;
            this.buttonSchool2.TabStop = false;
            this.buttonSchool2.Text = "+ SŠ";
            this.buttonSchool2.UseVisualStyleBackColor = true;
            this.buttonSchool2.Click += new System.EventHandler(this.buttonSchool2_Click);
            // 
            // buttonSchool1
            // 
            this.buttonSchool1.Location = new System.Drawing.Point(415, 36);
            this.buttonSchool1.Name = "buttonSchool1";
            this.buttonSchool1.Size = new System.Drawing.Size(40, 23);
            this.buttonSchool1.TabIndex = 49;
            this.buttonSchool1.TabStop = false;
            this.buttonSchool1.Text = "+ OŠ";
            this.buttonSchool1.UseVisualStyleBackColor = true;
            this.buttonSchool1.Click += new System.EventHandler(this.buttonSchool1_Click);
            // 
            // buttonDZ
            // 
            this.buttonDZ.Location = new System.Drawing.Point(234, 37);
            this.buttonDZ.Name = "buttonDZ";
            this.buttonDZ.Size = new System.Drawing.Size(41, 23);
            this.buttonDZ.TabIndex = 52;
            this.buttonDZ.TabStop = false;
            this.buttonDZ.Text = "+ DZ";
            this.buttonDZ.UseVisualStyleBackColor = true;
            this.buttonDZ.Click += new System.EventHandler(this.buttonDZ_Click);
            // 
            // buttonPharmacy
            // 
            this.buttonPharmacy.Location = new System.Drawing.Point(461, 6);
            this.buttonPharmacy.Name = "buttonPharmacy";
            this.buttonPharmacy.Size = new System.Drawing.Size(41, 23);
            this.buttonPharmacy.TabIndex = 53;
            this.buttonPharmacy.TabStop = false;
            this.buttonPharmacy.Text = "+ LJ";
            this.buttonPharmacy.UseVisualStyleBackColor = true;
            this.buttonPharmacy.Click += new System.EventHandler(this.buttonPharmacy_Click);
            // 
            // buttonMoveAll
            // 
            this.buttonMoveAll.Location = new System.Drawing.Point(499, 240);
            this.buttonMoveAll.Name = "buttonMoveAll";
            this.buttonMoveAll.Size = new System.Drawing.Size(95, 52);
            this.buttonMoveAll.TabIndex = 54;
            this.buttonMoveAll.TabStop = false;
            this.buttonMoveAll.Text = "Premjesti sve";
            this.buttonMoveAll.UseVisualStyleBackColor = true;
            this.buttonMoveAll.Click += new System.EventHandler(this.buttonMoveAll_Click);
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 331);
            this.Controls.Add(this.buttonMoveAll);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonPharmacy);
            this.Controls.Add(this.buttonDZ);
            this.Controls.Add(this.buttonSchool2);
            this.Controls.Add(this.buttonSchool1);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonMunicipality);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.comboBoxShippingCost);
            this.Controls.Add(this.buttonClearApproval);
            this.Controls.Add(this.textBoxSumTotal);
            this.Controls.Add(this.labelSumTotal);
            this.Controls.Add(this.labelShippingCost);
            this.Controls.Add(this.textBoxSumInitial);
            this.Controls.Add(this.labelSumInitial);
            this.Controls.Add(this.textBoxUnitCost);
            this.Controls.Add(this.labelUnitCost);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label1Quantity);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.numericUpDownZipCode);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonProf);
            this.Controls.Add(this.buttonIng);
            this.Controls.Add(this.buttonPrincipalF);
            this.Controls.Add(this.buttonPrincipalM);
            this.Controls.Add(this.buttonMayorF);
            this.Controls.Add(this.buttonMayorM);
            this.Controls.Add(this.buttonMunicipalityPresidentF);
            this.Controls.Add(this.buttonMunicipalityPresidentM);
            this.Controls.Add(this.buttonApprovedByF);
            this.Controls.Add(this.buttonApprovedByM);
            this.Controls.Add(this.textBoxApproved);
            this.Controls.Add(this.label5Approved);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.numericUpDownInvoiceNumber);
            this.Controls.Add(this.labelInvoiceNumber);
            this.Name = "NewInvoiceForm";
            this.Text = "Novi račun";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvoiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownInvoiceNumber;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label5Approved;
        private System.Windows.Forms.TextBox textBoxApproved;
        private System.Windows.Forms.Button buttonApprovedByM;
        private System.Windows.Forms.Button buttonApprovedByF;
        private System.Windows.Forms.Button buttonMunicipalityPresidentF;
        private System.Windows.Forms.Button buttonMunicipalityPresidentM;
        private System.Windows.Forms.Button buttonMayorF;
        private System.Windows.Forms.Button buttonMayorM;
        private System.Windows.Forms.Button buttonPrincipalF;
        private System.Windows.Forms.Button buttonPrincipalM;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.Button buttonIng;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.NumericUpDown numericUpDownZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1Quantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelUnitCost;
        private System.Windows.Forms.TextBox textBoxUnitCost;
        private System.Windows.Forms.Label labelSumInitial;
        private System.Windows.Forms.TextBox textBoxSumInitial;
        private System.Windows.Forms.Label labelShippingCost;
        private System.Windows.Forms.TextBox textBoxSumTotal;
        private System.Windows.Forms.Label labelSumTotal;
        private System.Windows.Forms.Button buttonClearApproval;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.ComboBox comboBoxShippingCost;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonMunicipality;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonSchool2;
        private System.Windows.Forms.Button buttonSchool1;
        private System.Windows.Forms.Button buttonDZ;
        private System.Windows.Forms.Button buttonPharmacy;
        private System.Windows.Forms.Button buttonMoveAll;
    }
}

