//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EFStuff.Assembly
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssemblySetting
    {
        public bool MakeSuborders { get; set; }
        public bool UnloadNoWait { get; set; }
        public bool SaveOutfiles { get; set; }
        public bool ShowAllExtractions { get; set; }
        public bool UsePercentOnly { get; set; }
        public string MaxPerc { get; set; }
        public string MaxItems { get; set; }
        public string LogFilesFolder { get; set; }
        public int PollingDelay { get; set; }
    }
}
