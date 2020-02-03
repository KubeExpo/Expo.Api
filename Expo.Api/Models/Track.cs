using System;

namespace Expo.Api.Models
{
    public class Track
    {
        public string Purpose { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}