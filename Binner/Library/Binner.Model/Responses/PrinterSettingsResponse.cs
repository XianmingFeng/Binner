﻿using Binner.Model.IO.Printing;

namespace Binner.Model.Responses
{
    public class PrinterSettingsResponse
    {
        /// <summary>
        /// Full name of printer
        /// </summary>
        public string? PrinterName { get; set; }

        /// <summary>
        /// Label model number
        /// </summary>
        public string? PartLabelName { get; set; }

        /// <summary>
        /// Label paper source
        /// </summary>
        public LabelSource PartLabelSource { get; set; }

        /// <summary>
        /// Printer part label template (main lines)
        /// </summary>
        public IEnumerable<LineConfiguration>? Lines { get; set; }

        /// <summary>
        /// Printer part label template (side identifiers)
        /// </summary>
        public IEnumerable<LineConfiguration>? Identifiers { get; set; }
    }
}
