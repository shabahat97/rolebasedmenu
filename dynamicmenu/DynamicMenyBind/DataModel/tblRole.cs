//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicMenyBind.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRole
    {
        public tblRole()
        {
            this.tblSubMenus = new HashSet<tblSubMenu>();
        }
    
        public int Id { get; set; }
        public string Roles { get; set; }
    
        public virtual tblLogin tblLogin { get; set; }
        public virtual ICollection<tblSubMenu> tblSubMenus { get; set; }
    }
}
