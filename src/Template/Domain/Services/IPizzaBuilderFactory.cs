namespace Template.Domain.Services
{
    public interface IPizzaBuilderFactory
    {
        IPizzaBuilder GetBuilder(bool isPersonalized);
    }

}
