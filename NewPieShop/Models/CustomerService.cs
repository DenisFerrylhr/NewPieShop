using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPieShop.Models
{
    public class CustomerService : ICustomerRepository
    {
        private readonly NewPieShopContext _context;

        public CustomerService(NewPieShopContext context)
        {
            _context = context;
        }

        public void AddNewCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChangesAsync();
        }

        public Customer GetCustomerById(int? id)
        {
            var customer = _context.Customer
                .FirstOrDefault(c => c.Id == id);

            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }

        public void RemoveCustomer(Customer customer)
        {
            _context.Customer.Remove(customer);
            _context.SaveChangesAsync();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChangesAsync();
        }
    }
}
