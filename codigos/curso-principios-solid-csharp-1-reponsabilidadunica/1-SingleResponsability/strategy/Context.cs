namespace SingleResponsability.strategy;

public class Context
{
    private Strategy estrategia{ get; set; }

    public Context()
    {
        
    }
    public void SetStrategy(Strategy strategy)
    {
        this.estrategia = strategy;
    }

    internal void ExportStudents(IEnumerable<Student> students)
    {
        estrategia.ExportStudents(students);
    }
}