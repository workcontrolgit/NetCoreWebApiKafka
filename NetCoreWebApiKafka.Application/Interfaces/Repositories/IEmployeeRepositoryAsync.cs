using NetCoreWebApiKafka.Application.Features.Employees.Queries.GetEmployees;
using NetCoreWebApiKafka.Application.Parameters;
using NetCoreWebApiKafka.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreWebApiKafka.Application.Interfaces.Repositories
{
    /// <summary>
    /// Interface for retrieving paged employee response asynchronously.
    /// </summary>
    /// <param name="requestParameters">The request parameters.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// </returns>
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeResponseAsync(GetEmployeesQuery requestParameters);
    }
}