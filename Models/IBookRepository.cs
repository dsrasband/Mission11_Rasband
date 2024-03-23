namespace Mission11_Rasband.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
