using webApi.Data;
using webApi.Interface;
using webApi.Model.Entity;
using webApi.Shared;
using Microsoft.EntityFrameworkCore;
namespace webApi.Repository
{
    public class BasicRepo :IEmployee
    {
        private AppDbConst _appctx;
        private ILogger<BasicRepo> _logger;
        

        public BasicRepo(AppDbConst ctx, ILogger<BasicRepo> logger)
        {
            _appctx = ctx;
        
            _logger = logger;
        }


        public async Task<ReturnData<List<Employee>>> GetAllEmployees()
        {
            ReturnData<List<Employee>> rtd = new();
            try
            {

                var d = await _appctx.Employees.AsNoTracking()
                    .ToListAsync();
                rtd.Data = d;
                rtd.IsSuccess = true;
                rtd.Mesg = "";
            }
            catch (Exception ex)
            {
                rtd.IsSuccess = false;
                rtd.Mesg = ex.Message + ";" + ex.InnerException ?? ex.InnerException.Message;
                return rtd;
            }
            return rtd;
        }


    }
}
