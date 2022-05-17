using AutoMapper;
using System.Reflection;

namespace EmploymentData.API.Model.Data
{
    public static class IgnoreVirtualExtensions
    {
        public static IMappingExpression<TSource, TDestination>
               IgnoreAllVirtual<TSource, TDestination>(
                   this IMappingExpression<TSource, TDestination> expression)
        {
            var desType = typeof(TDestination);
            foreach (var property in desType.GetProperties().Where(p =>
                                     p.GetGetMethod().IsVirtual))
            {
                expression.ForMember(property.Name, opt => opt.Ignore());
            }

            return expression;
        }
    }

    //private static readonly Type CollectionBaseType = typeof(ICollection<>);

    //public static IMappingExpression<TSource, TDestination> IgnoreNavigationProperties<TSource, TDestination>(
    //    this IMappingExpression<TSource, TDestination> expression)
    //{
    //    var desType = typeof(TDestination);
    //    foreach (var property in desType.GetProperties()
    //                        .Where(p => IsCollectionProperty(p) || HasForeignKeyAttribute(p)))
    //    {
    //        expression.ForMember(property.Name, opt => opt.Ignore());
    //    }

    //    return expression;
    //}

    //private static bool IsCollectionProperty(PropertyInfo property)
    //{
    //    var propertyType = property.PropertyType;
    //    return propertyType.IsGenericType &&
    //           propertyType.GetGenericTypeDefinition() == CollectionBaseType;
    //}

    //private static bool HasForeignKeyAttribute(PropertyInfo property) =>
    //    property.GetCustomAttribute<ForeignKeyAttribute>() != null;

}
