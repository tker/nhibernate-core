using System;

namespace NHibernate.Test.NHSpecificTest.NH3992
{
	public class BaseEntity
	{
		public virtual Guid Id { get; set; }
		public virtual string BaseField { get; set; }
	}

	public class MappedEntity : UnmappedEntity
	{
		public virtual string TopLevelField { get; set; }
	}

	public class UnmappedEntity : BaseEntity
	{
		public virtual string ExtendedField { get; set; }
	}

	public interface IBaseInterface
	{
		Guid Id { get; set; }
		string BaseField { get; set; }
	}

	public interface IUnmappedInterface : IBaseInterface
	{
		string ExtendedField { get; set; }
	}

	public class MappedEntityFromInterface : IUnmappedInterface
	{
		public virtual Guid Id { get; set; }
		public virtual string BaseField { get; set; }
		public virtual string ExtendedField { get; set; }
		public virtual string TopLevelField { get; set; }
	}

}
