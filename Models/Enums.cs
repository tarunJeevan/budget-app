namespace BudgetApp.Models;

public enum TransactionFrequency
{
    OneTime,
    Daily,
    Weekly,
    BiWeekly,
    Monthly,
    Quarterly,
    SemiAnnually,
    Annually
}

public enum TransactionType
{
    Income,
    Expense
}

public enum AllocationType
{
    Percentage,
    FixedAmount
}