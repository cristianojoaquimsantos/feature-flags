using FeatureFlags.Domain.Commands.Entities;
using FluentValidation;

namespace FeatureFlags.Domain.Commands.Validations
{
    public abstract class SistemaValidation<T> : AbstractValidator<T> where T : SistemaCommand
    {
    }
}
