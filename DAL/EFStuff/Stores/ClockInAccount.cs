//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EFStuff.Stores
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClockInAccount
    {
        public int StoreID { get; set; }
        public int AccountID { get; set; }
        public int SortBy { get; set; }
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
    }
}