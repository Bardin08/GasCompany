using System.Threading.Tasks;
using Application.Common.Models.EmailService;

namespace Application.Common.Interfaces
{
    public interface IEmailNotifier
    {
        Task SendEmailAsync(Email email);
    }
}
