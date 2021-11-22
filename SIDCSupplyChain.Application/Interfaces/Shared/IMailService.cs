using SIDCSupplyChain.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace SIDCSupplyChain.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}