public class Todo
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public bool Done { get; init; }

    public Todo(Guid id, string title, bool done)
    {
        Id = id;
        Title = title;
        Done = done;
    }
}
