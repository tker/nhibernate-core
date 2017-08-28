﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace NHibernate.Test.NHSpecificTest.NH3992
{
	public class BaseEntityMapping : ClassMapping<BaseEntity>
	{
		public BaseEntityMapping()
		{
			Id(i => i.Id, m => m.Generator(Generators.GuidComb));
			Property(p => p.BaseField,
			         map => { map.Column("BaseField"); });
		}
	}

	public class MappedEntityJoinedSubclassMapping : JoinedSubclassMapping<MappedEntity>
	{
		public MappedEntityJoinedSubclassMapping()
		{
			Extends(typeof(BaseEntity));
			Property(p => p.ExtendedField,
			         map => { map.Column("ExtendedField"); });
			Property(p => p.TopLevelField,
			         map => { map.Column("TopLevelField"); });
		}
	}

	public class MappedEntityUnionSubclassMapping : UnionSubclassMapping<MappedEntity>
	{
		public MappedEntityUnionSubclassMapping()
		{
			Extends(typeof(BaseEntity));
			Property(p => p.ExtendedField,
			         map => { map.Column("ExtendedField"); });
			Property(p => p.TopLevelField,
			         map => { map.Column("TopLevelField"); });
		}
	}

	public class MappedEntitySubclassMapping : SubclassMapping<MappedEntity>
	{
		public MappedEntitySubclassMapping()
		{
			Extends(typeof(BaseEntity));
			Property(p => p.ExtendedField,
			         map => { map.Column("ExtendedField"); });
			Property(p => p.TopLevelField,
			         map => { map.Column("TopLevelField"); });
		}
	}

	public class BaseInterfaceMapping : ClassMapping<IBaseInterface>
	{
		public BaseInterfaceMapping()
		{
			Id(i => i.Id, m => m.Generator(Generators.GuidComb));
			Property(p => p.BaseField,
			         map => { map.Column("BaseField"); });
		}
	}

	public class MappedEntityFromInterfaceJoinedSubclassMapping : JoinedSubclassMapping<MappedEntityFromInterface>
	{
		public MappedEntityFromInterfaceJoinedSubclassMapping()
		{
			Extends(typeof(IBaseInterface));
			Property(p => p.ExtendedField,
			         map => { map.Column("ExtendedField"); });
			Property(p => p.TopLevelField,
			         map => { map.Column("TopLevelField"); });
		}
	}

	public class MappedEntityFromInterfaceUnionSubclassMapping : UnionSubclassMapping<MappedEntityFromInterface>
	{
		public MappedEntityFromInterfaceUnionSubclassMapping()
		{
			Extends(typeof(IBaseInterface));
			Property(p => p.ExtendedField,
			         map => { map.Column("ExtendedField"); });
			Property(p => p.TopLevelField,
			         map => { map.Column("TopLevelField"); });
		}
	}

	public class MappedEntityFromInterfaceSubclassMapping : SubclassMapping<MappedEntityFromInterface>
	{
		public MappedEntityFromInterfaceSubclassMapping()
		{
			Extends(typeof(IBaseInterface));
			Property(p => p.ExtendedField,
			         map => { map.Column("ExtendedField"); });
			Property(p => p.TopLevelField,
			         map => { map.Column("TopLevelField"); });
		}
	}
}
