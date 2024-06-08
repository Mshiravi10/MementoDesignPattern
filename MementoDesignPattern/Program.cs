using MementoDesignPattern.Services;

public class Program
{
    public static void Main(string[] args)
    {
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
    }
}