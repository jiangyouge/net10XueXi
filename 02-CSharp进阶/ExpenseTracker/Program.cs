var ledger = new Ledger();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("==== 记账本 ====");
    Console.WriteLine("1. 记一笔收入");
    Console.WriteLine("2. 记一笔支出");
    Console.WriteLine("3. 查看全部记录");
    Console.WriteLine("4. 删除记录");
    Console.WriteLine("5. 修改记录");
    Console.WriteLine("6. 按月统计");
    Console.WriteLine("0. 退出");
    Console.Write("请选择：");

    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "0":
            Console.WriteLine("退出程序。");
            return;
        case "1":
            AddTransaction(true);
            break;
        case "2":
            AddTransaction(false);
            break;
        case "3":
            ledger.ListAll();
            break;
        case "4":
            DeleteTransaction();
            break;
        case "5":
            UpdateTransaction();
            break;
        case "6":
            ledger.ShowMonthlyStats();
            break;
        default:
            Console.WriteLine("无效的选择，请重新输入或输入0退出。");
            break;
    }
}

void AddTransaction(bool isIncome)
{
    Console.Write("请输入金额：");
    string amountInput = Console.ReadLine() ?? "";
    if (!decimal.TryParse(amountInput, out decimal amount) || amount <= 0)
    {
        Console.WriteLine("金额输入无效，请输入一个大于0的数字。");
        return;
    }
    Console.Write("请输入备注：");
    string note = Console.ReadLine() ?? "";
    ledger.Add(new Transaction(DateTime.Now, isIncome, amount, note));
    Console.WriteLine("记录已添加。");
}
void DeleteTransaction()
{
    if (ledger.Count == 0)
    {
        Console.WriteLine("没有记录可删除。");
        return;
    }
    ledger.ListAll();
    Console.Write("请输入要删除的记录编号：");
    string numberInput = Console.ReadLine() ?? "";
    if (!int.TryParse(numberInput, out int number) || number <= 0)
    {
        Console.WriteLine("编号输入无效，请输入一个大于0的整数。");
        return;
    }
    if (ledger.Delete(number))
    {
        Console.WriteLine("记录已删除。");
    }
    else
    {
        Console.WriteLine("未找到对应的记录，请检查编号是否正确。");
    }
}
void UpdateTransaction()
{
    if (ledger.Count == 0)
    {
        Console.WriteLine("没有记录可修改。");
        return;
    }
    ledger.ListAll();
    Console.Write("请输入要修改的记录编号：");
    string numberInput = Console.ReadLine() ?? "";
    if (!int.TryParse(numberInput, out int number) || number <= 0)
    {
        Console.WriteLine("编号输入无效，请输入一个大于0的整数。");
        return;
    }
    Console.Write("请输入新的金额：");
    string newAmountInput = Console.ReadLine() ?? "";
    if (!decimal.TryParse(newAmountInput, out decimal newAmount) || newAmount <= 0)
    {
        Console.WriteLine("金额输入无效，请输入一个大于0的数字。");
        return;
    }
    Console.Write("请输入新的备注：");
    string newNote = Console.ReadLine() ?? "";
    if (ledger.Update(number, newAmount, newNote))
    {
        Console.WriteLine("记录已更新。");
    }
    else
    {
        Console.WriteLine("未找到对应的记录，请检查编号是否正确。");
    }
}