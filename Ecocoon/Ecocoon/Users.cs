//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecocoon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public int Role { get; set; }
        public bool Active { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
