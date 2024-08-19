using FeatureFlags.Domain.Core.Message;
using FluentValidation.Results;

namespace FeatureFlags.Domain.Core.Mediator;

public interface IMediatorHandler
{
    Task PublishEvent<T>(T @event) where T : Event;
    Task<ValidationResult> SendCommand<T>(T command) where T : Command;
}