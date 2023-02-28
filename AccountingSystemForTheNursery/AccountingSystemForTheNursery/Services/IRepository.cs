namespace AccountingSystemForTheNursery.Services
{
    public interface IRepository<T, TId> where T : class
    {
        IList<T> GetAll(); // список сущностей
        T GetById(TId id); // получить сущность по идентификатору
        int Create(T item);
        int Update(T item);
        int Delete(TId id);
    }
}
