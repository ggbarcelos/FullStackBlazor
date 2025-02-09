using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "O Título é obrigatório.")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Tipo inválido.")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Valor inválido.")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria inválida.")]
    public long CategoryId { get; set; }
    
    [Required(ErrorMessage = "Data de pagamento/recebimento inválida.")]
    public DateTime? PaydOrRecevedAt { get; set; }
}