//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikAcademyDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public Group()
        {
            this.Users = new HashSet<User>();
        }
    
        public int Group_ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}