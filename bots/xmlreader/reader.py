import xml.etree.ElementTree as ET

class BPMNParser:
    def __init__(self, file):
        self.tree = ET.parse(file)
        self.root = self.tree.getroot()
        self.namespaces = {
            'bpmn': 'http://www.omg.org/spec/BPMN/20100524/MODEL',
            'flowable': 'http://flowable.org/bpmn'
        }
        self.document = {
            'process': {},
            'dataObjects': [],
            'sequenceFlows': [],
            'startEvents': [],
            'serviceTasks': [],
        }

    def parse_elements(self):
        process = self.root.find('.//bpmn:process', self.namespaces)
        if process is not None:
            self.document['process'] = process.attrib

        for element in self.root.findall('.//bpmn:dataObject', self.namespaces):
            data = {'attributes': element.attrib, 'value': None}
            value_element = element.find('.//flowable:value', self.namespaces)
            if value_element is not None:
                data['value'] = value_element.text
            self.document['dataObjects'].append(data)

        for element in self.root.findall('.//bpmn:sequenceFlow', self.namespaces):
            self.document['sequenceFlows'].append(element.attrib)

        for element in self.root.findall('.//bpmn:startEvent', self.namespaces):
            self.document['startEvents'].append(element.attrib)

        for element in self.root.findall('.//bpmn:serviceTask', self.namespaces):
            self.document['serviceTasks'].append(element.attrib)

    def create_pdd(self):
        with open('pdd.txt', 'w') as file:
            for key, values in self.document.items():
                file.write(f"{key.capitalize()}:\n")
                if isinstance(values, list):
                    for value in values:
                        file.write(f"{value}\n")
                else:
                    file.write(f"{values}\n")
                file.write("\n")


if __name__ == "__main__":
    parser = BPMNParser(r'xml name')  # use your file path here
    parser.parse_elements()
    parser.create_pdd()
