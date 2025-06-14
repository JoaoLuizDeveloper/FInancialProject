using FinancialProject.Domain.Entities.Abstractions;

namespace FinancialProject.Domain.Entities
{
    // A classe TransactionBill esta herdando da classe Transaction, que � abstrata 
    // Como se ela pertencesse a classe Transaction
    public class TransactionBill : Transaction
    {
        public string Barcode { get; set; } = string.Empty;

        // Gerando a descri��o da transa��o de pagamento de conta
        public override string Description()
        {
            return $"Payment of Bill: {Barcode}, Value: {Value:C}";
        }
    }
}