using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterDesignPattern.Adaptee
{
    public class Employee
    {
        Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "John"));
            this.employees.Add(new Employee(2, "Cena"));
        }
        public virtual string GetEmployee()
        {
            var emptyNameSpaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("id", "name"), });
            var serialzer = new XmlSerializer(employees.GetType());
            var setting = new XmlWriterSettings();
            setting.Indent = true;
            setting.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(stream, setting))
            {
                serialzer.Serialize(writer, employees, emptyNameSpaces);
                return stream.ToString();
            }
        }
    }
}
