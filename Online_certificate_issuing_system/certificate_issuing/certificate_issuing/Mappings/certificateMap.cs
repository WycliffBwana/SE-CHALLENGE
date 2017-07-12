using certificate_issuing.Domains;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace certificate_issuing.Mappings
{
    public class certificateMap: ClassMap<certificate>
    {
        public certificateMap()
        {
            Table("cert_issuing");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.AdmNo).Column("AdmNo");
            Map(x => x.course).Column("course");
            Map(x => x.DateJoined).Column("DateJoined");
            Map(x => x.dob).Column("dob");
            Map(x => x.guardianEmail).Column("guardianEmail");
            Map(x => x.guardiansContact).Column("guardiansContact");
            Map(x => x.guardiansName).Column("guardiansName");
            Map(x => x.StudentsFullNames).Column("StudentsFullNames");
            Map(x => x.StudentsID).Column("StudentsID");
            Map(x => x.year).Column("year");
        }
    }
}
