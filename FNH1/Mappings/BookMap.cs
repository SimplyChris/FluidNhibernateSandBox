using FluentNHibernate;
using FluentNHibernate.Mapping;

namespace FNH1
{
    public class BookMap : ClassMap<Book>
    {
        public BookMap ()
        {
            Id(x => x.Id);
            Map(x => x.Title);
            Map(x => x.AuthorId);
            Map(x => x.GenreId);
            Map(x => x.Isbn);            
        }
    }
}