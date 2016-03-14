﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweco.Services.MapExport
{
    public class MapExportItem
    {
        public List<FeatureInfo> vectorLayers { get; set; }
        public List<WMSInfo> wmsLayers { get; set; }
        public int resolution { get; set; }
        public int[] size { get; set; }
        public double[] bbox { get; set; }
    }
}