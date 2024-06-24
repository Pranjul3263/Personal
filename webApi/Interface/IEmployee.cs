using webApi.Model.Entity;
using webApi.Shared;

namespace webApi.Interface
{
    public interface IEmployee
    {
        public Task<ReturnData<List<Employee>>> GetAllEmployees();
    }
}
