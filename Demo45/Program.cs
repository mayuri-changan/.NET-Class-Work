using Demo45.DAL;
using Demo45.Models;

namespace Demo45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IETDbContext _dbContext = new IETDbContext();

            #region Select Query
            var result = _dbContext.emps.ToList();
            foreach (Emp emp in result)
            {
                Console.WriteLine($"Id: {emp.Id},Name:{emp.Name},Address: {emp.Address}");
            }
            #endregion

            #region Insert
            //Emp empToBeInserted = new Emp() { Name = "Ron", Address = "Rome" };
            //_dbContext.emps.Add(empToBeInserted);
            //_dbContext.SaveChanges();
            #endregion

            #region Update
            int id = 3;
            Emp empToBeUpdated = _dbContext.emps.Find(id);
            empToBeUpdated.Name = "Prachi";
            empToBeUpdated.Address = "Nagar";

            _dbContext.SaveChanges();
            #endregion

            #region Delete
            //int idToBeDeleted = 2;
            //Emp empToBDeleted = _dbContext.emps.Find(idToBeDeleted);
            //_dbContext.emps.Remove(empToBDeleted);
            //_dbContext.SaveChanges();
            #endregion

        }
    }
}
