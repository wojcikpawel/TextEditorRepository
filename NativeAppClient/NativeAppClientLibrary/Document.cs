using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

//using Newtonsoft.Json;
//using System.Windows.Controls;
//using System.Windows.Forms;
//using ToggleSwitch;

using System.Drawing;
using System.Reflection;

using System.Net.Sockets;
using System.Net.WebSockets;
using System.Net.Mail;


namespace NativeAppClientLibrary
{
    public class Document
    {
        public int documentId { get; set; }
        public string documentName { get; set; }
        public string documentContent { get; set; }
        public DateTime documentCreationDate { get; set; }

        //skończyłem na 25 minucie // plik się nie nadpisuje
        //konstruktor
        /*
        public Document(string documentName)
        {
            this.documentName = documentName;
        }
        */

        //adding empty comment
    }
}
