namespace FinancialProject.Domain.Entities.Abstractions
{
    public abstract class Transaction
    {
        public decimal Value { get; set; }

        // Declarando metodo abstrato que deve ser implementado nas classes filhas
        public abstract string Description();

        // Gerando um m�todo virtual para retornar um resumo da transa��o
        public virtual string Resume()
        {
            return $"Value of Transaction: {Value:C}";
        }
    }
}