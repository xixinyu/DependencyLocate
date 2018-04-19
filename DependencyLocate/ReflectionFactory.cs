using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DependencyLocate
{
    internal static class ReflectionFactory
    {
        private static String _buttonType;

        static ReflectionFactory()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "Config.xml");
            XmlNode xmlNode = xmlDoc.ChildNodes[1].ChildNodes[0];

            _buttonType = xmlNode.ChildNodes[0].Value;
        }

      

        public static IButton MakeButton()
        {
            return Assembly.Load("DependencyLocate").CreateInstance("DependencyLocate." + _buttonType) as IButton;
        }

      
    }
}
