using NHibernate.Mapping.ByCode;
using NUnit.Framework;
using System.Linq;

namespace NHibernate.Test.NHSpecificTest.NH3992
{
	/// <summary>
	/// Fixture using 'by code' mappings
	/// </summary>
	public class ByCodeFixture
	{
		[Test]
		public void Test_MappedSubclass_AllMapsAtTopLevel()
		{
			var mapper = new ModelMapper();
			mapper.AddMapping(typeof(BaseEntityMapping));
			mapper.AddMapping(typeof(MappedEntitySubclassMapping));

			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			// Check that the subclass was mapped
			var baseMapping = mapping.RootClasses.SingleOrDefault(x => x.Name == "BaseEntity");
			Assert.IsNotNull(baseMapping, "Mapping did not return mapping for BaseEntity");
			var targetMapping = mapping.SubClasses.SingleOrDefault(x => x.Name == "MappedEntity");
			Assert.IsNotNull(targetMapping, "Mapping did not return mapping for subclass MappedEntity");
			// Check that all three fields are mapped
			var baseProperty = baseMapping.Properties.SingleOrDefault(p => p.Name == "BaseField");
			Assert.IsNotNull(baseProperty, "Base class mapping did not map base class property");
			var extendedProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "ExtendedField");
			Assert.IsNotNull(extendedProperty, "Sub class mapping did not map extended (class not mapped) class property");
			var topLevelProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "TopLevelField");
			Assert.IsNotNull(topLevelProperty, "Sub class mapping did not map base class property");

		}

		[Test]
		public void Test_MappedJoinedSubclass_AllMapsAtTopLevel()
		{
			var mapper = new ModelMapper();
			mapper.AddMapping(typeof(BaseEntityMapping));
			mapper.AddMapping(typeof(MappedEntityJoinedSubclassMapping));

			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			// Check that the subclass was mapped
			var baseMapping = mapping.RootClasses.SingleOrDefault(x => x.Name == "BaseEntity");
			Assert.IsNotNull(baseMapping, "Mapping did not return mapping for BaseEntity");
			var targetMapping = mapping.JoinedSubclasses.SingleOrDefault(x => x.Name == "MappedEntity");
			Assert.IsNotNull(targetMapping, "Mapping did not return mapping for subclass MappedEntity");
			// Check that all three fields are mapped
			var baseProperty = baseMapping.Properties.SingleOrDefault(p => p.Name == "BaseField");
			Assert.IsNotNull(baseProperty, "Base class mapping did not map base class property");
			var extendedProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "ExtendedField");
			Assert.IsNotNull(extendedProperty, "Sub class mapping did not map extended (class not mapped) class property");
			var topLevelProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "TopLevelField");
			Assert.IsNotNull(topLevelProperty, "Sub class mapping did not map base class property");

		}

		[Test]
		public void Test_MappedUnionSubclass_AllMapsAtTopLevel()
		{
			var mapper = new ModelMapper();
			mapper.AddMapping(typeof(BaseEntityMapping));
			mapper.AddMapping(typeof(MappedEntityUnionSubclassMapping));

			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			// Check that the subclass was mapped
			var baseMapping = mapping.RootClasses.SingleOrDefault(x => x.Name == "BaseEntity");
			Assert.IsNotNull(baseMapping, "Mapping did not return mapping for BaseEntity");
			var targetMapping = mapping.UnionSubclasses.SingleOrDefault(x => x.Name == "MappedEntity");
			Assert.IsNotNull(targetMapping, "Mapping did not return mapping for subclass MappedEntity");
			// Check that all three fields are mapped
			var baseProperty = baseMapping.Properties.SingleOrDefault(p => p.Name == "BaseField");
			Assert.IsNotNull(baseProperty, "Base class mapping did not map base class property");
			var extendedProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "ExtendedField");
			Assert.IsNotNull(extendedProperty, "Sub class mapping did not map extended (class not mapped) class property");
			var topLevelProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "TopLevelField");
			Assert.IsNotNull(topLevelProperty, "Sub class mapping did not map base class property");

		}

		[Test]
		public void Test_MappedSubclassInterface_AllMapsAtTopLevel()
		{
			var mapper = new ModelMapper();
			mapper.AddMapping(typeof(BaseInterfaceMapping));
			mapper.AddMapping(typeof(MappedEntityFromInterfaceSubclassMapping));

			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			// Check that the subclass was mapped
			var baseMapping = mapping.RootClasses.SingleOrDefault(x => x.Name == "IBaseInterface");
			Assert.IsNotNull(baseMapping, "Mapping did not return mapping for IBaseInterface");
			var targetMapping = mapping.SubClasses.SingleOrDefault(x => x.Name == "MappedEntityFromInterface");
			Assert.IsNotNull(targetMapping, "Mapping did not return mapping for subclass MappedEntityFromInterface");
			// Check that all three fields are mapped
			var baseProperty = baseMapping.Properties.SingleOrDefault(p => p.Name == "BaseField");
			Assert.IsNotNull(baseProperty, "Base class mapping did not map base class property");
			var extendedProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "ExtendedField");
			Assert.IsNotNull(extendedProperty, "Sub class mapping did not map extended (class not mapped) class property");
			var topLevelProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "TopLevelField");
			Assert.IsNotNull(topLevelProperty, "Sub class mapping did not map base class property");

		}

		[Test]
		public void Test_MappedJoinedSubclassInterface_AllMapsAtTopLevel()
		{
			var mapper = new ModelMapper();
			mapper.AddMapping(typeof(BaseInterfaceMapping));
			mapper.AddMapping(typeof(MappedEntityFromInterfaceJoinedSubclassMapping));

			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			// Check that the subclass was mapped
			var baseMapping = mapping.RootClasses.SingleOrDefault(x => x.Name == "IBaseInterface");
			Assert.IsNotNull(baseMapping, "Mapping did not return mapping for IBaseInterface");
			var targetMapping = mapping.JoinedSubclasses.SingleOrDefault(x => x.Name == "MappedEntityFromInterface");
			Assert.IsNotNull(targetMapping, "Mapping did not return mapping for subclass MappedEntityFromInterface");
			// Check that all three fields are mapped
			var baseProperty = baseMapping.Properties.SingleOrDefault(p => p.Name == "BaseField");
			Assert.IsNotNull(baseProperty, "Base class mapping did not map base class property");
			var extendedProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "ExtendedField");
			Assert.IsNotNull(extendedProperty, "Sub class mapping did not map extended (class not mapped) class property");
			var topLevelProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "TopLevelField");
			Assert.IsNotNull(topLevelProperty, "Sub class mapping did not map base class property");

		}

		[Test]
		public void Test_MappedUnionSubclassInterface_AllMapsAtTopLevel()
		{
			var mapper = new ModelMapper();
			mapper.AddMapping(typeof(BaseInterfaceMapping));
			mapper.AddMapping(typeof(MappedEntityFromInterfaceUnionSubclassMapping));

			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			// Check that the subclass was mapped
			var baseMapping = mapping.RootClasses.SingleOrDefault(x => x.Name == "IBaseInterface");
			Assert.IsNotNull(baseMapping, "Mapping did not return mapping for IBaseInterface");
			var targetMapping = mapping.UnionSubclasses.SingleOrDefault(x => x.Name == "MappedEntityFromInterface");
			Assert.IsNotNull(targetMapping, "Mapping did not return mapping for subclass MappedEntityFromInterface");
			// Check that all three fields are mapped
			var baseProperty = baseMapping.Properties.SingleOrDefault(p => p.Name == "BaseField");
			Assert.IsNotNull(baseProperty, "Base class mapping did not map base class property");
			var extendedProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "ExtendedField");
			Assert.IsNotNull(extendedProperty, "Sub class mapping did not map extended (class not mapped) class property");
			var topLevelProperty = targetMapping.Properties.SingleOrDefault(p => p.Name == "TopLevelField");
			Assert.IsNotNull(topLevelProperty, "Sub class mapping did not map base class property");

		}

		[Test]
		public void Test_AbstractIntermediateSubclasses()
		{
			var mapper = new ConventionModelMapper();
			mapper.IsTablePerClass((type, declared) => false);
			mapper.IsTablePerClassHierarchy((type, declared) => true);
			var mappings = mapper.CompileMappingFor(new[] { typeof(Animal), typeof(Mammal), typeof(Dog) });
			
			Assert.AreEqual(1, mappings.RootClasses.Length, "Mapping should only have Animal as root class");
			Assert.AreEqual(2, mappings.SubClasses.Length, "Subclasses not mapped as expected");
			var animalMapping = mappings.RootClasses.SingleOrDefault(s => s.Name == nameof(Animal));
			Assert.IsNotNull(animalMapping, "Unable to find mapping for animal class");
			Assert.AreEqual(nameof(Animal.Id), animalMapping.Id.name, "Identifier not mapped as expected");
			CollectionAssert.AreEquivalent(new [] { nameof(Animal.Description), nameof(Animal.Sequence) }, animalMapping.Properties.Select(p => p.Name));
			var mammalMapping = mappings.SubClasses.SingleOrDefault(s => s.Name == nameof(Mammal));
			Assert.IsNotNull(mammalMapping, "Unable to find mapping for Mammal class");
			Assert.AreEqual(nameof(Animal), mammalMapping.extends, "Mammal mapping does not extend Animal as expected");
			CollectionAssert.AreEquivalent(new[] { nameof(Mammal.Pregnant), nameof(Mammal.BirthDate) }, mammalMapping.Properties.Select(p => p.Name));
			var dogMapping = mappings.SubClasses.SingleOrDefault(s => s.Name == nameof(Dog));
			Assert.IsNotNull(dogMapping, "Unable to find mapping for Dog class");
			Assert.AreEqual(nameof(Mammal), dogMapping.extends, "Dog mapping does not extend Mammal as expected");
			CollectionAssert.IsEmpty(dogMapping.Properties);
		}
	}
}