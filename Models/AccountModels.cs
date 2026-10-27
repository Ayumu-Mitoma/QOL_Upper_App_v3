namespace QOL_Upper_App_v3.Models
{
        public class ExpenseItem
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public DateTime Date { get; set; } = DateTime.Today;
            public string Category { get; set; } = "";
            public decimal Amount { get; set; }
            public string Memo { get; set; } = "";
            public bool IsFixed { get; set; } = false;
        }

        public class IncomeItem
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public DateTime Date { get; set; } = DateTime.Today;
            public string Category { get; set; } = "";
            public decimal Amount { get; set; }
            public string Memo { get; set; } = "";
        }
}
