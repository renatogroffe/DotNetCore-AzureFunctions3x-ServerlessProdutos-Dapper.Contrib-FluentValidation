using FluentValidation;
using ServerlessProdutos.Models;

namespace ServerlessProdutos.Validators
{
    public class ReajustePrecoValidator : AbstractValidator<ReajustePreco>
    {
        public ReajustePrecoValidator()
        {
            RuleFor(c => c.IndiceReajuste).NotEmpty().WithMessage("Preencha o campo 'IndiceReajuste'")
                .GreaterThan(0).WithMessage("O campo 'IndiceReajuste' deve ser maior do 0");

            RuleFor(c => c.ObservacaoReajustePreco).NotEmpty().WithMessage("Preencha o campo 'ObservacaoReajustePreco'");
        }
    }
}