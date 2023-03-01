namespace PFRS.Application.Facades
{
    using PFRS.Application.Operations.Options;
    using PFRS.Domain;

    public sealed class OptionsFacade
    {
        private readonly GetOptionsOperation getOptionsOperation;

        public OptionsFacade(GetOptionsOperation getOptionsOperation)
        {
            this.getOptionsOperation = getOptionsOperation;
        }

        public OptionsModel GetOptions()
        {
            return getOptionsOperation.Execute();
        }

    }
}
