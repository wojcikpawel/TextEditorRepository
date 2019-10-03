﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeAppClientLibrary
{
    public class Document
    {
        public int documentId { get; set; }
        public string documentName { get; set; }
        public string documentContent { get; set; }
        public DateTime documentCreationDate { get; set; }

    }
}