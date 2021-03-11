using System;
using System.ComponentModel.DataAnnotations;

namespace UpskillManager.Shared.Validation
{
    /// <summary>
    /// Attribute for date validation using DataAnnotations
    /// It validates any date from now up to 100 years ago
    /// </summary>
    public class DateAttribute : RangeAttribute
    {
        public DateAttribute()
            : base(typeof(DateTime), DateTime.Now.AddYears(-100).ToShortDateString(), DateTime.Now.AddYears(2).ToShortDateString()) 
            
        { }
    }

}
