using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string toEmail, string subject, string message);
    }
}
