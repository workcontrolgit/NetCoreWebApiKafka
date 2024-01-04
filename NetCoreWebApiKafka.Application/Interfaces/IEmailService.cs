using NetCoreWebApiKafka.Application.DTOs.Email;
using System.Threading.Tasks;

namespace NetCoreWebApiKafka.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}