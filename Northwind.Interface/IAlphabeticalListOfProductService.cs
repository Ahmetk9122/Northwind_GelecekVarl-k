using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Interface
{
    public interface IAlphabeticalListOfProductService: IGenericService<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>
    {
        IQueryable<DtoAlphabeticalListOfProduct> GetTotalReport();
    }
}
