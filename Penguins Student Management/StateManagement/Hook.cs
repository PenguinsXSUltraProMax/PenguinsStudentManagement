namespace Penguins_Student_Management.StateManagement
{
    public class Hook
    {
        static public T of<T>(TheRiver River)
        {
            T Subject = (T)River.Subjects.Find(x => x.GetType() == typeof(T));
            return Subject;
        }
    }
}
