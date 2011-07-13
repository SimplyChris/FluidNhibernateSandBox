using FluentNHibernate.Mapping;
using FluentNHibernate;
namespace FNH1
{
    public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap ()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}