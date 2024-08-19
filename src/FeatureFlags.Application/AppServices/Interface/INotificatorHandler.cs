using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnimedFESP.FeatureFlags.Application.AppServices.Interface
{
    public interface INotificatorHandler
    {
        bool HasErrors();

        List<Notification> GetErrors();

        void AddError(string error);

        void AddError(List<ValidationFailure> failures);
    }
}
