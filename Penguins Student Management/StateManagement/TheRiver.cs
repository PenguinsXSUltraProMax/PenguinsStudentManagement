using System.Collections.Generic;
using System.Threading.Tasks;
using Penguins_Student_Management.StateManagement.Entity;

namespace Penguins_Student_Management.StateManagement
{
    public class TheRiver : ISubject
    {

        private List<IObserver> Observers;
        public List<IRiverSubject> Subjects;

        internal TheRiver(List<IRiverSubject> subjects)
        {
            Observers = new List<IObserver>();
            Subjects = subjects;
        }

        public static IRiverSubject CreateSubject(IRiverSubject subject)
        {
            return subject;
        }

        public void Refesh()
        {
            NotifyListeners(this);
        }

        public void CreateObservable(IObserver observer)
        {
            Observers.Add(observer);
            NotifyListeners(this);
        }

        public void CreateObservableWithoutNotify(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void DisposeObservable(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyListeners(TheRiver value)
        {
            Observers.ForEach(observer => observer.SetState(value));
        }
    }
}
