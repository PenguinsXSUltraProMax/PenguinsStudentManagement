namespace Penguins_Student_Management.StateManagement.Entity
{
    public interface ISubject
    {
        void CreateObservable(IObserver observer);
        void DisposeObservable(IObserver observer);
        void NotifyListeners(TheRiver value);
    }
}
