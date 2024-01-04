using AutoMapper;
using NetCoreWebApiKafka.Application.Features.Employees.Queries.GetEmployees;
using NetCoreWebApiKafka.Application.Features.Positions.Commands.CreatePosition;
using NetCoreWebApiKafka.Application.Features.Positions.Queries.GetPositions;
using NetCoreWebApiKafka.Domain.Entities;

namespace NetCoreWebApiKafka.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}