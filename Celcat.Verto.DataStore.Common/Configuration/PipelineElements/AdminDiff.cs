﻿namespace Celcat.Verto.DataStore.Common.Configuration.PipelineElements
{
    using System.Xml.Serialization;

    [XmlType("adminDiff")]
    public class AdminDiff
    {
        [XmlAttribute("singleThreaded")]
        public bool SingleThreaded { get; set; }
    }
}
