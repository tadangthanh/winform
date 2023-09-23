using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    internal interface ICustomerDAO
    {
        int save(Customer customer);
        int delete(int id);
        int update(Customer customer);
        Customer findOne(int id);
        List<Customer> findAll();
    }
}
