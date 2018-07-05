namespace ConsoleApp.Mediator
{
    abstract class Colleague
    {
        protected Mediator mediator;

        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}