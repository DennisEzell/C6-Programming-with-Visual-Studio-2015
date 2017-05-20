using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace LoopThroughXmlNodes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string XML_PATH = @"C:\Users\Deeze814\Source\Repos\C6-Programming-with-Visual-Studio-2015\Chapter19\books.xml";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonLoop_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\Deeze814\Source\Repos\C6-Programming-with-Visual-Studio-2015\Chapter19\books.xml");
            textBlockResults.Text = FormatText(document.DocumentElement, "", "");
        }

        private string FormatText(XmlNode node, string text, string indent)
        {
            if (string.IsNullOrEmpty(indent))
            {
                indent = "";
            }

            text += node is XmlText
                ? node.Value
                : "\r\n" + node.Value;
            
            if(node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }

            text += XmlResource.open + node.Name;
            if (node.Attributes?.Count > 0)
            {
                AddAttributes(node, ref text);
            }

            if (node.HasChildNodes)
            {
                text += ">";
                foreach(XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + "  ");
                }
                text += node.ChildNodes.Count == 1 &&
                        (node.FirstChild is XmlText || node.FirstChild is XmlComment)
                    ? "</" + node.Name + ">"
                    : "\r\n" + indent + "</" + node.Name + ">";
            }
            else
            {
                text += "/>";
            }
         return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach(XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }
    }
}
