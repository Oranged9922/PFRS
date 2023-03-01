namespace PFRS.Application.Operations.Options
{
    using PFRS.Application.Interfaces;
    using PFRS.Domain;

    public sealed class GetOptionsOperation
    {
        private readonly IOptionsRepository repository;

        public GetOptionsOperation(IOptionsRepository optionsRepository)
        {
            repository = optionsRepository;
        }

        public OptionsModel Execute()
        {
            return repository.GetOptions();
        }
    }
}
