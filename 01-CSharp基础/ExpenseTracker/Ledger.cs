public class Ledger
{
    private readonly List<Transaction> _item = new List<Transaction>();
    public int Count
    {
        get { return _item.Count; }
    }
    public void Add(Transaction transaction)
    {
        _item.Add(transaction);
    }
    public void ListAll()
    {
        if (_item.Count == 0)
        {
            Console.WriteLine("还没有任何记录。");
            return;
        }
        for(int i = 0; i < _item.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_item[i].GetInfo()}");
        }
    }
    public bool Delete(int number)
    {
        int index = number - 1;
        if (index < 0 || index >= _item.Count)
        {
            return false;
        }
        _item.RemoveAt(index);
        return true;
    }
    public bool Update(int number, decimal newAmount, string newNote)
    {
        int index = number - 1;
        if (index < 0 || index >= _item.Count)
        {
            return false;
        }
        _item[index].Amount = newAmount;
        _item[index].Note = newNote;
        return true;
    }
    public void ShowMonthlyStats ()
    {
        if (_item.Count == 0)
        {
            Console.WriteLine("还没有任何记录，无法统计。");
            return;
        }
        //收入集合
        var incomeByMonth = new Dictionary<string, decimal>();
        //支出集合
        var expenseByMonth = new Dictionary<string, decimal>();
        foreach (Transaction transaction in _item)
        {
            string month = transaction.Date.ToString("yyyy-MM");
            if (transaction.IsIncome)
            {
                if (!incomeByMonth.ContainsKey(month))
                {
                    incomeByMonth[month] = 0m;
                }
                incomeByMonth[month] += transaction.Amount;

            }
            else
            {
                if (!expenseByMonth.ContainsKey(month))
                {
                    expenseByMonth[month] = 0m;
                }
                expenseByMonth[month] += transaction.Amount;
            }
        }
        var months = new List<string>();
        foreach (var item in incomeByMonth)
        {
            if (!months.Contains(item.Key))
            {
                months.Add(item.Key);
            }
        }
        foreach (var item in expenseByMonth)
        {
            if (!months.Contains(item.Key))
            {
                months.Add(item.Key);
            }
        }
        months.Sort();
        foreach (string month in months)
        {
            decimal income = incomeByMonth.ContainsKey(month) ? incomeByMonth[month] : 0m;
            decimal expense = expenseByMonth.ContainsKey(month) ? expenseByMonth[month] : 0m;
            decimal net = income - expense;
            Console.WriteLine($"{month} - Income: {income:C}, Expense: {expense:C}, Net: {net:C}");
        }

    }

}