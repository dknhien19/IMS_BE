using Data.DataAccess;
using Data.Entities;
using Data.Model;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface ICollocationService
{
    Task<ResultModel> AttempCreate(CollocationCreateModel model, CustomerModel customer);
}

public class CollocationService : ICollocationService
{
    private readonly AppDbContext _dbContext;

    public CollocationService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Create a new collocation for the customer created previous. Will hard delete the customer on fail
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The result model contain the new collocation</returns>
    public async Task<ResultModel> AttempCreate(CollocationCreateModel model, CustomerModel customerModel)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var services = new List<Service>();
            foreach (var additionalService in model.AdditionalServices)
            {
                var service = _dbContext.Services.FirstOrDefault(x => x.Name == additionalService.Name);
                if (service == null)
                {
                    validPrecondition = false;
                }
                else
                {
                    services.Add(service);
                }
            }

            if (validPrecondition)
            {
                var collocation = new Collocation
                {
                    IsApproved = false,
                    Note = model.Note,
                    InspectorNote = model.InspectorNote,
                    DateCreated = model.DateCreate,
                    DateAllocate = model.DateAllocate,
                    DateStop = model.DateStop,
                    CustomerId = customerModel.Id,
                };

                _dbContext.Collocations.Add(collocation);
                _dbContext.SaveChanges();

                foreach (var service in services)
                {
                    var additionalService = model.AdditionalServices.FirstOrDefault(x => x.Name == service.Name);
                    _dbContext.AdditionalServices.Add(new AdditionalService
                    {
                        ServiceId = service.Id,
                        CollocationId = collocation.Id,
                        Quantity = additionalService.Quantity
                    });
                }

                _dbContext.SaveChanges();
                result.Succeed = true;
            }
        }
        catch (Exception ex)
        {
            result.ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }

        if (!result.Succeed)
        {
            // Delete customer and user on fail to create collocation
            Customer customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == customerModel.Id);
            User user = customer.User;
            _dbContext.Remove(customer);
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        return result;
    }
}
