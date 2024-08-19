using FeatureFlags.Domain.Core.Data;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;

namespace FeatureFlags.Domain.Core.Message;

public abstract class CommandHandler
	{
		protected ValidationResult ValidationResult;
		private readonly ILogger<CommandHandler> _logger;

		protected abstract void LogAcao(params object[] dynamicValues);
		protected CommandHandler(ILogger<CommandHandler> logger)
		{
			_logger = logger;
			ValidationResult = new ValidationResult();
		}

		protected void AddError(string message)
		{
			ValidationResult.Errors.Add(new ValidationFailure(string.Empty, message));
			_logger.LogError(message);
		}

		protected void AddError(Exception ex)
		{
			ValidationResult.Errors.Add(new ValidationFailure(string.Empty, ex.Message));
			_logger.LogError(ex, ex.Message);
		}
		

		protected async Task<ValidationResult> Commit(IUnitOfWork uowEntity, IUnitOfWork uowMongo)
		{
			return await Commit(uowEntity, uowMongo, "Ocorreu um erro ao salvar os dados").ConfigureAwait(continueOnCapturedContext: false);
		}

		protected async Task<ValidationResult> Commit(IUnitOfWork uowEntity, IUnitOfWork uowMongo, string message)
		{
			try
			{
				if (!(await uowEntity.Commit()))
				{
					AddError(message);
					return ValidationResult;
				}
			}
			catch (Exception ex)
			{
				AddError(ex.Message);
				throw;
			}

			return ValidationResult;

		}

		protected async Task<ValidationResult> Commit(IEnumerable<IUnitOfWork> uowEntities, IUnitOfWork uowMongo)
		{
			return await Commit(uowEntities, uowMongo, "Ocorreu um erro ao salvar os dados").ConfigureAwait(continueOnCapturedContext: false);
		}

		protected async Task<ValidationResult> Commit(IEnumerable<IUnitOfWork> uowEntities, IUnitOfWork uowMongo, string message)
		{
			try
			{
				// Iterar sobre cada IUnitOfWork para tentar o commit
				foreach (var uowEntity in uowEntities)
				{
					if (!await uowEntity.Commit())
					{
						AddError(message);
						return ValidationResult;
					}
				}
			}
			catch (Exception ex)
			{
				AddError(ex.Message);
				throw;
			}

			return ValidationResult;
		}
	}