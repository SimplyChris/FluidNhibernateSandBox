namespace FNH1
{
    public class Book
    {
        public virtual int Id { get; private set; }
        public virtual string Title { get; set; }
        public virtual int AuthorId { get; set; }
        public virtual string Isbn { get; set; }
        public virtual int GenreId { get; set; }       
    }
}