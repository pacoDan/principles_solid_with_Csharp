using System.Text;
namespace SingleResponsability.strategy;

public class StrategyPrintByCSV : Strategy
{
        public void ExportStudents( IEnumerable<Student> students)
        {
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StudentsStrategy_v2.csv"), sb.ToString(), Encoding.Unicode);
            Console.WriteLine("Exportado por CSV estrategia");
        }
}