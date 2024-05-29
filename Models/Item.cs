//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int Id { get; set; }
        public string SellerId { get; set; }
        public string SellerName { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> ItemTypeId { get; set; }
        public string ItemType { get; set; }
        public string ItemDescription { get; set; }
        public string ItemImageUrl { get; set; }
        public string ItemFooterDescription { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> TotalOrder { get; set; }
        public Nullable<int> TotalRating { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
