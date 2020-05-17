using FluentValidation;
using ServerlessProdutos.Models;

namespace ServerlessProdutos.Validators
{
    public class ProdutoValidator : AbstractValidator<CadastroProduto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.CodigoBarras).NotEmpty().WithMessage("Preencha o campo 'CodigoBarras'")
                .MinimumLength(3).WithMessage("O campo 'CodigoBarras' deve possuir no mínimo 3 caracteres")
                .MaximumLength(13).WithMessage("O campo 'CodigoBarras' deve possuir no máximo 13 caracteres");

            RuleFor(c => c.Nome).NotEmpty().WithMessage("Preencha o campo 'Nome'")
                .MinimumLength(5).WithMessage("O campo 'Nome' deve possuir no mínimo 5 caracteres")
                .MaximumLength(60).WithMessage("O campo 'Nome' deve possuir no máximo 60 caracteres");

            RuleFor(c => c.Preco).NotEmpty().WithMessage("Preencha o campo 'Preco'")
                .GreaterThan(0).WithMessage("O campo 'Preco' deve ser maior do 0");
        }
    }
}