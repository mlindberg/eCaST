//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DD_ContractTypes
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProgramBinID { get; set; }
        public Nullable<decimal> StateRatio { get; set; }
        public Nullable<decimal> FederalRatio { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string StateAccount { get; set; }
        public string FederalAccount { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}