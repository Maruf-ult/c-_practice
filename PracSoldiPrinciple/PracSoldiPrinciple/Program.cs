using PracSoldiPrinciple.Interface;
using PracSoldiPrinciple.Repository;
using PracSoldiPrinciple.Service;

namespace PracSoldiPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repository = new StudentRepository();

            IStudentService service = new StudentService(repository);

            service.ShowStudents();

        }
    }
}
