using System.Collections.Generic;
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

        public void CreateObservable(IObserver observer)
        {
            Observers.Add(observer);
            Notify();
        }

        public void CreateObservableWithoutNotify(IObserver observer)
        {
            Observers.Add(observer);
            observer.SetState(this);
        }

        public void DisposeObservable(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            Observers.ForEach(observer => observer.SetState(this));
        }
    }
}
