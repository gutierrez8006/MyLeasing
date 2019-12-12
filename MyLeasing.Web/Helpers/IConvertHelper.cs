using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helpers
{
    public interface IConvertHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
    }
}