using MediatR;

namespace Application.Companies.Commands.CreateCompany;

public class CreateCompanyCommand : IRequest<int>
{
    public string? Name { get; set; }

    public string? Headquarters { get; set; }
}

public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, int>
{
    public Task<int> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(1);
    }
}