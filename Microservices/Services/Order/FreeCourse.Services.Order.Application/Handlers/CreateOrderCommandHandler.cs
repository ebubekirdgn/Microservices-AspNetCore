using FreeCourse.Services.Order.Application.Commands;
using FreeCourse.Services.Order.Application.Dtos;
using FreeCourse.Services.Order.Infrastructure;
using FreeCourse.Shared.Dtos;
using MediatR;

namespace FreeCourse.Services.Order.Application.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Response<CreatedOrderDto>>
    {
        private readonly OrderDbContext _context;

        public CreateOrderCommandHandler(OrderDbContext context)
        {
            _context = context;
        }

        public Task<Response<CreatedOrderDto>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
