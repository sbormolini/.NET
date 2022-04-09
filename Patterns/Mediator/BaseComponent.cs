// See https://refactoring.guru/design-patterns/mediator/csharp/example#lang-features for more information

namespace DesignPatterns.Mediator;

// The Base Component provides the basic functionality of storing a
// mediator's instance inside component objects.
class BaseComponent
{
    protected IMediator _mediator;

    public BaseComponent(IMediator mediator = null) => _mediator = mediator;

    public void SetMediator(IMediator mediator) => _mediator = mediator;
}
