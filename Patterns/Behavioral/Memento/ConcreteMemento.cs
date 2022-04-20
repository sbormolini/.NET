﻿
namespace DesignPatterns.Memento;

// The Concrete Memento contains the infrastructure for storing the
// Originator's state.
class ConcreteMemento : IMemento
{
    private string _state;

    private DateTime _date;

    public ConcreteMemento(string state)
    {
        _state = state;
        _date = DateTime.Now;
    }

    // The Originator uses this method when restoring its state.
    public string GetState() => _state;

    // The rest of the methods are used by the Caretaker to display
    // metadata.
    public string GetName() => $"{this._date} / ({this._state.Substring(0, 9)})...";

    public DateTime GetDate() => _date;
}
