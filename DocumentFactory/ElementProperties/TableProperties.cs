﻿using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    internal class TableProperties : IElementProperties
    {
        public List<string> rows { get; set; }
    }
}
