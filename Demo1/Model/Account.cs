//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public string accountName { get; set; }
        public string accountPassword { get; set; }
        public int accessRightID { get; set; }
        public string Salt { get; set; }
    
        public virtual AccessRight AccessRight { get; set; }
    }
}
