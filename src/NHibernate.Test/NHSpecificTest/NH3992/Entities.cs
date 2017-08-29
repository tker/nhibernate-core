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

	// Animal entities copied from NH2691
	public abstract class Animal
	{
		public virtual int Id { get; set; }
		public virtual string Description { get; set; }
		public virtual int Sequence { get; set; }
	}

	public abstract class Mammal : Animal
	{
		public virtual bool Pregnant { get; set; }
		public virtual DateTime? BirthDate { get; set; }
	}

	public class Dog : Mammal { }

}
