namespace Mission11_Rasband.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
