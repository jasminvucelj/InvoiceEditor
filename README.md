# InvoiceEditor

A program that can be used to create a new invoice file by editing data into a .docx template. It's made to work specifically with data and users I needed it for, so it will not be too useful to others as is (especially considering the form is in Croatian, not English), but it may contain some valuable insight into and examples of matters such as editing a .docx file by replacing existing data, inputting data from a Windows Form into it, and placing created files into desired directories. The editable form for data input was written in C#, and the creation of the invoice from existing data is handled by a Python script. The program that moves the completed forms (written in C#) is included only as an executable; the code will be uploaded in a separate repository.

## Components

All files needed for running the program are located in the /InvoiceEditor/bin/Debug/ directory (and need to be located in the same directory together, apart from invoice_template.docx), and are as follows:

- InvoiceEditor.exe - the main part of the program, contains the form for data input. Various buttons are there to ease data input by inserting commonly used strings (again, specific to the data I had, but can be relatively easily customized). The Python script for creating a new invoice, and the executable for moving invoices to the desired directories are run from this form.
- InvoiceEditorData.txt - a data file that currently contains only the location of the Python executable (needed to run the script).
- InvoiceData.txt - data contained in the last saved form, used to create the new invoice.
- invoice_template.docx - the .docx template file containing the basic structure of the invoice, as well as placeholders to be replaced with relevant data.
- docxEditor.py - the Python script that creates a new invoice from the invoice template and the data in InvoiceData.txt. It works by following this algorithm:
  - read new invoice data from InvoiceData.txt
  - create a copy of the template (rename it with respect to the invoice number)
  - change the extension of that copy to .zip
  - unzip the new zip file to a temporary folder
  - the unzipped folder contains the internal structure of the .docx document, and the file that needs changing is document.xml; replace the placeholder strings in that file with respective relevant data
  - zip the temporary folder back to a zip file, rename it to .docx, delete the temporary folder
- docxEditorData.txt - specifies the file path and file name of the invoice template
- InvoiceRelocator.exe - executable used to move (copy & delete original) all created invoices to directories specified in destinationFolders.txt
- destinationFolders.txt -  specifies a list of directories the new invoices are to be moved to
