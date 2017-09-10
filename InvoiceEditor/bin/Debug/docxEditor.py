#!/usr/bin/env python
# -*- coding: utf-8 -*-
import io
import os
import shutil
import zipfile


# placeholder strings in the document
PLACEHOLDER_INVOICE_NUMBER = '000/00'
PLACEHOLDER_ORDER_NUMBER = '0-0000'
PLACEHOLDER_DATE = '00.00.0000.'
PLACEHOLDER_DUE_DATE = '11.11.1111.'

PLACEHOLDER_APPROVED = '(ODOBRENJE)'
PLACEHOLDER_NAME = '(NAZIV)'
PLACEHOLDER_ZIP_CODE = '12345'
PLACEHOLDER_CITY = '(M J E S T O)'
PLACEHOLDER_ADDRESS = '(adresa)'
PLACEHOLDER_ID = '01010101010'

PLACEHOLDER_QUANTITY = 'XX'
PLACEHOLDER_SUM_INITIAL = '=150,00'
PLACEHOLDER_SHIPPING_COST = '=14,00'
PLACEHOLDER_SUM_TOTAL = '=164,00'


#
# data to edit into the document
# TODO read from file!
#
data = [line.rstrip('\n') for line in io.open('InvoiceData.txt', encoding='UTF-8')]
DATA_INVOICE_NUMBER = data[0]
DATA_ORDER_NUMBER = data[1]
DATA_DATE = data[2]
DATA_INVOICE_NUMBER += '/' + DATA_DATE[-3] + DATA_DATE[-2]
DATA_DUE_DATE = data[3]

DATA_APPROVED = data[4]
DATA_NAME = data[5]
DATA_ZIP_CODE = data[6]
DATA_CITY = data[7]
DATA_ADDRESS = data[8]
DATA_ID = data[9]

DATA_QUANTITY = data[10]
DATA_UNIT_COST = data[11]
DATA_SHIPPING_COST = data[12]

DATA_SUM_INITIAL_VALUE = float(DATA_UNIT_COST.replace(",", ".")) * int(DATA_QUANTITY)
DATA_SUM_TOTAL_VALUE = DATA_SUM_INITIAL_VALUE + float(DATA_SHIPPING_COST.replace(",", "."))

DATA_SUM_INITIAL = '=' + "{:.2f}".format(DATA_SUM_INITIAL_VALUE).replace(".", ",")
DATA_SHIPPING_COST = '=' + DATA_SHIPPING_COST
DATA_SUM_TOTAL = '=' + "{:.2f}".format(DATA_SUM_TOTAL_VALUE).replace(".", ",")


f = io.open('docxEditorConfig.txt', 'r')

filepath = f.readline().rstrip('\n')
filename = f.readline().rstrip('\n').split('.')[0]

f.close()


WORKING_DIR = filepath  # os.getcwd()
TEMP_DOCX = os.path.join(WORKING_DIR, filename + '.docx')
TEMP_DOCX_NEW = os.path.join(WORKING_DIR, DATA_INVOICE_NUMBER.replace('/', '-') + '.docx')
TEMP_ZIP = os.path.join(WORKING_DIR, filename + '.zip')
TEMP_FOLDER = os.path.join(WORKING_DIR, filename)

# remove old copy, zip file or folder
if os.path.exists(TEMP_DOCX_NEW):
    os.remove(TEMP_DOCX_NEW)
if os.path.exists(TEMP_ZIP):
    os.remove(TEMP_ZIP)
if os.path.exists(TEMP_FOLDER):
    shutil.rmtree(TEMP_FOLDER)

# make a copy of the docx file
shutil.copyfile(TEMP_DOCX, TEMP_DOCX_NEW)

# reformat template.docx's extension
os.rename(TEMP_DOCX_NEW, TEMP_ZIP)

# unzip file zip to specific folder
with zipfile.ZipFile(TEMP_ZIP, 'r') as z:
    z.extractall(TEMP_FOLDER)


#
# change document xml file
#
document_xml = os.path.join(TEMP_FOLDER, "word", "document.xml")
xmlstring = io.open(document_xml, 'r', encoding='UTF-8').read()

xmlstring = xmlstring.replace(PLACEHOLDER_INVOICE_NUMBER, DATA_INVOICE_NUMBER)
xmlstring = xmlstring.replace(PLACEHOLDER_ORDER_NUMBER, DATA_ORDER_NUMBER)
xmlstring = xmlstring.replace(PLACEHOLDER_DATE, DATA_DATE)
xmlstring = xmlstring.replace(PLACEHOLDER_DUE_DATE, DATA_DUE_DATE)

xmlstring = xmlstring.replace(PLACEHOLDER_APPROVED, DATA_APPROVED)  # !
xmlstring = xmlstring.replace(PLACEHOLDER_NAME, DATA_NAME)  # !
xmlstring = xmlstring.replace(PLACEHOLDER_ZIP_CODE, DATA_ZIP_CODE)
xmlstring = xmlstring.replace(PLACEHOLDER_CITY, DATA_CITY)  # !
xmlstring = xmlstring.replace(PLACEHOLDER_ADDRESS, DATA_ADDRESS)  # !
xmlstring = xmlstring.replace(PLACEHOLDER_ID, DATA_ID)

xmlstring = xmlstring.replace(PLACEHOLDER_QUANTITY, DATA_QUANTITY)
xmlstring = xmlstring.replace(PLACEHOLDER_SUM_INITIAL, DATA_SUM_INITIAL)
xmlstring = xmlstring.replace(PLACEHOLDER_SHIPPING_COST, DATA_SHIPPING_COST)
xmlstring = xmlstring.replace(PLACEHOLDER_SUM_TOTAL, DATA_SUM_TOTAL)

with open(document_xml, "wb") as f:
    f.write(xmlstring.encode("UTF-8"))


# zip temp folder to zip file
os.remove(TEMP_ZIP)
shutil.make_archive(TEMP_ZIP.replace(".zip", ""), 'zip', TEMP_FOLDER)

# rename zip file to docx
os.rename(TEMP_ZIP, TEMP_DOCX_NEW)  # new
shutil.rmtree(TEMP_FOLDER)
