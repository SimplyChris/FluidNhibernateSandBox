using FluentNHibernate;
using FluentNHibernate.Mapping;
namespace FNH1
{
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap ()
        {
            Id(x => x.Id);
            Map(x => x.Description);
        }
    }
}