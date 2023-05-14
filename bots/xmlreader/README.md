# Python XML Parser


This Python script allows you to read and parse XML files, extract their properties, and use this information to write a detailed Process Design Document (PDD).

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

## Prerequisites
You will need Python installed on your machine. The script has been tested with Python 3.7+.

## Installing
Clone this repository to your local machine and navigate to the project directory.

```bash
Copy code
git clone https://github.com/sefaozzer/xmlreader.git
cd xmlreader
```
## Running the Script
You can run the script using Python. Pass the path to the XML file you wish to read as a command-line argument.

```bash
Copy code
python main.py /path/to/your/xmlfile.xml
```
The script will read the XML file, parse it, extract its properties, and output the data to the console. You can use this data to write a detailed PDD.

## Sample PDD.txt file
```txt

Process:
{'id': 'SGK_LOGIN_VIZITE', 'name': 'LOGIN_CONTROL', 'isExecutable': 'true'}

Dataobjects:
{'attributes': {'id': 'minBpPriority', 'name': 'minBpPriority', 'itemSubjectRef': 'xsd:string'}, 'value': '50'}
{'attributes': {'id': 'humanEffort', 'name': 'humanEffort', 'itemSubjectRef': 'xsd:string'}, 'value': '0'}
{'attributes': {'id': 'slash', 'name': 'slash', 'itemSubjectRef': 'xsd:string'}, 'value': '\\'}
{'attributes': {'id': 'Hata', 'name': 'Hata', 'itemSubjectRef': 'xsd:string'}, 'value': None}
{'attributes': {'id': 'HataDurum', 'name': 'HataDurum', 'itemSubjectRef': 'xsd:string'}, 'value': 'false'}
{'attributes': {'id': 'downloadPDF', 'name': 'downloadPDF', 'itemSubjectRef': 'xsd:string'}, 'value': None}
{'attributes': {'id': 'hataKod', 'name': 'hataKod', 'itemSubjectRef': 'xsd:string'}, 'value': None}
{'attributes': {'id': 'HataKod1', 'name': 'HataKod1', 'itemSubjectRef': 'xsd:string'}, 'value': None}
{'attributes': {'id': 'k', 'name': 'k', 'itemSubjectRef': 'xsd:string'}, 'value': None}
{'attributes': {'id': 'kullaniciKodu', 'name': 'kullaniciKodu', 'itemSubjectRef': 'xsd:string'}, 'value': None}
{'attributes': {'id': 'sifre', 'name': 'sifre', 'itemSubjectRef': 'xsd:string'}, 'value': None}

Sequenceflows:
{'id': 'sid-8F5F2FAA-EF22-49E0-8449-27BB30EDA926', 'sourceRef': 'sid-FCD046D9-E20F-487C-83A4-BDF1F5E9ACAA', 'targetRef': 'sid-8A5C3567-5549-45F9-8BC0-23F3056B8846'}
{'id': 'sid-D6BD9798-0A20-41A7-92C4-BEC3369E3FB4', 'sourceRef': 'sid-D6F02C79-B802-46AE-BC60-7134DF4E673D', 'targetRef': 'sid-18B0EBE0-2601-4850-9943-E8CBE683633E'}

Startevents:
{'id': 'sid-FCD046D9-E20F-487C-83A4-BDF1F5E9ACAA', '{http://flowable.org/bpmn}formFieldValidation': 'true'}
{'id': 'sid-BDF6FFA3-B692-4190-B036-078074223DEB', '{http://flowable.org/bpmn}formFieldValidation': 'true'}
{'id': 'sid-546F3D6F-35AC-441E-9FC2-BFB37EEBAB8F', '{http://flowable.org/bpmn}formFieldValidation': 'true'}

Servicetasks:
{'id': 'sid-BAD02513-ED89-419A-A66D-1DD85A557DF7', 'name': 'Open: File', '{http://flowable.org/bpmn}async': 'true', '{http://flowable.org/bpmn}exclusive': 'false', '{http://flowable.org/bpmn}class': 'com.robusta.robot.web.WebOpenTask', '{http://flowable.org/bpmn}type': 'CustomWebOpen'}
{'id': 'sid-4607FC0B-AD9D-4C1D-99AD-B91AE4B587C0', 'name': 'File exists: PDF file existed', '{http://flowable.org/bpmn}async': 'true', '{http://flowable.org/bpmn}exclusive': 'false', '{http://flowable.org/bpmn}class': 'com.robusta.robot.utils.UtilsFileExistsTask', '{http://flowable.org/bpmn}type': 'CustomUtilsfileExists'}
...
```
## Built With
Python - The scripting language used.
xml.etree.ElementTree - The Python XML library used for parsing and creating XML data.
Authors

 Initial work - sefaozzer
 
## License
This project is licensed under the MIT License - see the LICENSE.md file for details

## Acknowledgments
Thanks to all the Python and open-source community.

## Next Phase
We will add more insight with openai api/autogpt for generating a pdd document 
