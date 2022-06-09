namespace TP2MVC.Models.Repositories
{
    public interface IEmployeeRepository
    {
        Employe GetEmploye(int Id);
        IEnumerable<Employe> GetAllEmploye();
        Employe Add(Employe employe);
        Employe Update(Employe employeChanges);
        Employe Delete(int Id);
    }
}
