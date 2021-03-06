using Grand.Api.DTOs.Catalog;
using Grand.Api.DTOs.Common;
using Grand.Api.DTOs.Customers;
using Grand.Domain.Catalog;
using Grand.Domain.Common;
using Grand.Domain.Customers;
using Grand.Domain.Media;
using Grand.Core.Mapper;

namespace Grand.Api.Extensions
{
    public static class MappingExtensions
    {

        #region Product

        public static ProductDto ToModel(this Product entity)
        {
            return entity.MapTo<Product, ProductDto>();
        }

        #endregion

        #region ToEntity
        //Product
        public static Product ToEntity(this ProductDto model)
        {
            return model.MapTo<ProductDto, Product>();
        }
        public static Product ToEntity(this ProductDto model, Product destination)
        {
            return model.MapTo(destination);
        }
        //Category
        public static Category ToEntity(this CategoryDto model)
        {
            return model.MapTo<CategoryDto, Category>();
        }
        public static Category ToEntity(this CategoryDto model, Category destination)
        {
            return model.MapTo(destination);
        }
        //Manufacturer
        public static Manufacturer ToEntity(this ManufacturerDto model)
        {
            return model.MapTo<ManufacturerDto, Manufacturer>();
        }
        public static Manufacturer ToEntity(this ManufacturerDto model, Manufacturer destination)
        {
            return model.MapTo(destination);
        }
        //ProductAttribute
        public static ProductAttribute ToEntity(this ProductAttributeDto model)
        {
            return model.MapTo<ProductAttributeDto, ProductAttribute>();
        }
        public static ProductAttribute ToEntity(this ProductAttributeDto model, ProductAttribute destination)
        {
            return model.MapTo(destination);
        }
        //ProductAttributeMapping
        public static ProductAttributeMapping ToEntity(this ProductAttributeMappingDto model)
        {
            return model.MapTo<ProductAttributeMappingDto, ProductAttributeMapping>();
        }
        public static ProductAttributeMapping ToEntity(this ProductAttributeMappingDto model, ProductAttributeMapping destination)
        {
            return model.MapTo(destination);
        }
        //SpecificationAttribute
        public static SpecificationAttribute ToEntity(this SpecificationAttributeDto model)
        {
            return model.MapTo<SpecificationAttributeDto, SpecificationAttribute>();
        }
        public static SpecificationAttribute ToEntity(this SpecificationAttributeDto model, SpecificationAttribute destination)
        {
            return model.MapTo(destination);
        }
        //TierPrice
        public static TierPrice ToEntity(this ProductTierPriceDto model)
        {
            return model.MapTo<ProductTierPriceDto, TierPrice>();
        }
        public static TierPrice ToEntity(this ProductTierPriceDto model, TierPrice destination)
        {
            return model.MapTo(destination);
        }
        //CustomerRole
        public static CustomerRole ToEntity(this CustomerRoleDto model)
        {
            return model.MapTo<CustomerRoleDto, CustomerRole>();
        }
        public static CustomerRole ToEntity(this CustomerRoleDto model, CustomerRole destination)
        {
            return model.MapTo(destination);
        }
        //Customer
        public static Customer ToEntity(this CustomerDto model)
        {
            return model.MapTo<CustomerDto, Customer>();
        }
        public static Customer ToEntity(this CustomerDto model, Customer destination)
        {
            return model.MapTo(destination);
        }
        //Address
        public static Address ToEntity(this AddressDto model)
        {
            return model.MapTo<AddressDto, Address>();
        }
        public static Address ToEntity(this AddressDto model, Address destination)
        {
            return model.MapTo(destination);
        }
        #endregion

        #region Category

        public static CategoryDto ToModel(this Category entity)
        {
            return entity.MapTo<Category, CategoryDto>();
        }


        #endregion

        #region Manufacturer
        public static ManufacturerDto ToModel(this Manufacturer entity)
        {
            return entity.MapTo<Manufacturer, ManufacturerDto>();
        }


        #endregion

        #region Product attribute
        public static ProductAttributeDto ToModel(this ProductAttribute entity)
        {
            return entity.MapTo<ProductAttribute, ProductAttributeDto>();
        }

        

        #endregion

        #region Product attribute mapping

        public static ProductAttributeMappingDto ToModel(this ProductAttributeMapping entity)
        {
            return entity.MapTo<ProductAttributeMapping, ProductAttributeMappingDto>();
        }

        

        #endregion

        #region Specification attribute
        public static SpecificationAttributeDto ToModel(this SpecificationAttribute entity)
        {
            return entity.MapTo<SpecificationAttribute, SpecificationAttributeDto>();
        }

        

        #endregion

        #region Tier prices

        public static ProductTierPriceDto ToModel(this TierPrice entity)
        {
            return entity.MapTo<TierPrice, ProductTierPriceDto>();
        }

       

        #endregion

        #region Customer Role
        public static CustomerRoleDto ToModel(this CustomerRole entity)
        {
            return entity.MapTo<CustomerRole, CustomerRoleDto>();
        }

        

        #endregion

        #region Customer

        public static CustomerDto ToModel(this Customer entity)
        {
            return entity.MapTo<Customer, CustomerDto>();
        }

        

        #endregion

        #region Customer address
        public static AddressDto ToModel(this Address entity)
        {
            return entity.MapTo<Address, AddressDto>();
        }

        


        #endregion

        #region Picture

        public static PictureDto ToModel(this Picture entity)
        {
            return entity.MapTo<Picture, PictureDto>();
        }

        #endregion
    }
}
