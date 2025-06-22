using RealEstateAPI.DTOs.HomeDTOs;
using RealEstateAPI.DTOs.PropertyDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RealEstateAPI.Service.IServices
{
    public interface IPropertyService
    {
        Task<List<PropertyResponseDTO>> GetAllPropertiesAsync(
            string? searchTerm,
            string? location,
            decimal? minPrice,
            decimal? maxPrice,
            int? minSize,
            int? maxSize,
            int? bedrooms,
            int? bathrooms,
            string? type,
            string? furnishingStatus,
            List<string>? amenities);
        Task<HomePageResponseDTO> GetHomePageDataAsync();

        Task<PropertyResponseDTO> GetPropertyByIdAsync(Guid id);

        Task<PropertyResponseDTO> AddPropertyAsync(AddPropertyDTO propertyDto, string userId);
        Task<List<string>> UploadImagesAsync(Guid propertyId, List<IFormFile> images);
        Task<bool> UpdatePropertyAsync(UpdatePropertyDTO propertyDto, string currentUserId); 
        Task<bool> DeletePropertyAsync(Guid id, string currentUserId); 
    }
}