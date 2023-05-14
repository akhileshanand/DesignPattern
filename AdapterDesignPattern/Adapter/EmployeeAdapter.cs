using AdapterDesignPattern.Adaptee;
using AdapterDesignPattern.Target;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern.Adapter
{
    public class EmployeeAdapter : EmployeeManager, IEmployee 
    {
        public EmployeeAdapter() { }
        public override string GetEmployee()
        {
            string returnXml = base.GetEmployee();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc , Newtonsoft.Json.Formatting.Indented);
        }
    }
}
