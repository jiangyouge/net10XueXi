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
            Console.WriteLine("No transactions found.");
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

}