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
    
    public partial class InvoiceDetail
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> DetailTypeID { get; set; }
        public Nullable<int> DetailID { get; set; }
        public Nullable<int> CancerTypeID { get; set; }
        public Nullable<int> BillingLevelID { get; set; }
        public Nullable<System.DateTime> DateLastService { get; set; }
        public Nullable<decimal> FederalAllocation { get; set; }
        public Nullable<decimal> StateAllocation { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}