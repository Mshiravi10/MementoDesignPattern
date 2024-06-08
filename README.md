
---

# MementoDesignPattern

### Memento Design Pattern in C#

#### Description:
This project demonstrates the implementation of the Memento Design Pattern in C#. The Memento Pattern allows saving and restoring an object's state, enabling undo and redo functionalities. This is useful in applications that require state management like text editors, graphics editors, etc.

#### Features:
- **Dynamic State Storage**: Uses generics to store any type of state.
- **State Management**: Save and restore the state efficiently.
- **Undo and Redo Functionality**: Supports multiple levels of undo and redo.
- **Clear Separation of Concerns**: Organized into distinct classes and namespaces.

#### Classes:
- **Memento<T>**: Stores the state of an object.
- **Originator<T>**: The object whose state is saved and restored.
- **Caretaker<T>**: Manages the saving and restoring of the Originator's state using Mementos.

#### Usage:
```csharp
var originator = new Originator<string>();
var caretaker = new Caretaker<string>(originator);

originator.State = "State 1";
caretaker.Backup();

originator.State = "State 2";
caretaker.Backup();

originator.State = "State 3";

Console.WriteLine("Current State: " + originator.State);
caretaker.Undo();
Console.WriteLine("After Undo: " + originator.State);
caretaker.Undo();
Console.WriteLine("After Second Undo: " + originator.State);
caretaker.Redo();
Console.WriteLine("After Redo: " + originator.State);
```

---

This project serves as a template for applications requiring dynamic and flexible state management using the Memento Design Pattern.

---

Feel free to customize this description according to your project's specifics and requirements.

---

