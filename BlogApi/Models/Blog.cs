//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ImageLink { get; set; }
        public string Body { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
