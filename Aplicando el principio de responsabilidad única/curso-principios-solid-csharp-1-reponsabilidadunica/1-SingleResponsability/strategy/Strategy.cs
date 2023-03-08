namespace SingleResponsability.strategy;

public interface Strategy
{
   void ExportStudents(IEnumerable<Student> students);
}