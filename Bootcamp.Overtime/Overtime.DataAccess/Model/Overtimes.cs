//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Overtime.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Overtimes
    {
        public int Id { get; set; }
        public Nullable<System.DateTimeOffset> check_in { get; set; }
        public Nullable<System.DateTimeOffset> check_out { get; set; }
        public Nullable<int> overtime_salary { get; set; }
        public Nullable<int> difference { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<System.DateTimeOffset> createDate { get; set; }
    
        public virtual Employees Employee { get; set; }
    }
}
