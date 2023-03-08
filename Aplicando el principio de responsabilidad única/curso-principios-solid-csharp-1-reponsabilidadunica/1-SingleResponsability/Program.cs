using SingleResponsability;
using SingleResponsability.strategy;

// StudentRepository studentRepository = new();
// ExportHelper exportHelper = new();
// exportHelper.ExportStudents(studentRepository.GetAll());
// Console.WriteLine("Proceso Completado");

Console.WriteLine("apply strategy pattern");
StudentRepository studentRepository = new();
// ExportHelper exportHelper = new();
Context contexto = new();
contexto.SetStrategy(new StrategyPrintByCSV());
contexto.ExportStudents(studentRepository.GetAll());
// exportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");