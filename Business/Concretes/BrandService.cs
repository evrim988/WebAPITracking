using Business.Abstracts;
using Business.DTO.Requests;
using Business.DTO.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandService : IBrandService
{
    private readonly IBrandRepository _brandRepository;   
    public BrandService(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public CreatedBrandResponse Add(CreateBrandRequest model)
    {
        //mapping
        Brand brand = new Brand();
        brand.Name = model.Name;
        brand.CreatedDate = DateTime.Now;
        _brandRepository.Add(brand);
        //Önce veritabanına ekledik ve daha sonra bunu response modelle doldurduk.bunu son kullanıcıya ulaştıracağız.
        CreatedBrandResponse response = new CreatedBrandResponse();
        response.ID = 4;
        response.Name = model.Name;
        response.CreatedDate = brand.CreatedDate;
        return response;
    }

    public List<GetListBrandResponse> GetList()
    {
        List<Brand> brands = _brandRepository.GetList();

        List<GetListBrandResponse> getlistBrandResponses = new List<GetListBrandResponse>();

        foreach (var item in brands)
        {
            GetListBrandResponse getListBrand = new GetListBrandResponse();
            getListBrand.ID = item.ID;
            getListBrand.Name = item.Name;
            getListBrand.CreatedDate = item.CreatedDate;

            getlistBrandResponses.Add(getListBrand);
        }

        return getlistBrandResponses;
    }
}
