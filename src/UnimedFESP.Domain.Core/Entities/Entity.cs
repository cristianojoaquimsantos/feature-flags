using System.Diagnostics.CodeAnalysis;

namespace UnimedFESP.Domain.Core.Entities;

[ExcludeFromCodeCoverage]
public abstract class Entity
{
    protected Entity()
    {
        
    }

    public Entity(DateTime dataCadastro,
                  DateTime dataAlteracao)
    {
        DataCadastro = dataCadastro;
        DataAlteracao = dataAlteracao;
    }

    public DateTime DataCadastro { get; private set; }
    public DateTime DataAlteracao { get; private set; }
}