public class Transaction
{
    public DateTime Date { get; set; }
    public bool IsIncome { get; set; } // True for income收入, false for expense支出
    public decimal Amount { get; set; }
    public string Note { get; set; }
    public Transaction(DateTime date, bool isIncome, decimal amount, string note)
    {
        Date = date;
        IsIncome = isIncome;
        Amount = amount;
        Note = note;
    }
    public string GetInfo()
    {
        string type = IsIncome ? "Income" : "Expense";
        return $"{Date.ToShortDateString()} - {type}: {Amount:C} - Note: {Note}"; // C（Currency，货币） = 货币符号 + 千分位 + 默认 2 位小数。它由当前区域设置决定：
    }
}