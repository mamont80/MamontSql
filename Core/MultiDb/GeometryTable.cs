﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ParserCore
{


    public class GeometryTable
    {
        public List<Column> Columns = new List<Column>();
        public Column IDColumn { get; set; }
        public int CoordinateSystem { get; set; }
    }
}
