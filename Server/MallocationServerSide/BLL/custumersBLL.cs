using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class CustumersBLL
    {
      
        public int Add(CustomerDTO custumers)
        {
          return  CustomerDAL.Add(Convert(custumers));
        }

        public List<CustomerDTO> GetAll()
        {
            List<CustomerDTO> listCustomerDTO = new List<CustomerDTO>();
            List<custumers_tbl> listcustumer = CustomerDAL.GetAll();
            foreach (var item in listcustumer)
            {
                listCustomerDTO.Add(Convert(item));
            }
            return listCustomerDTO;
        }

        public bool delete(int CustumerID)
        {
            return CustomerDAL.delete(CustumerID);
        }

        public bool update(CustomerDTO customerDTO)
        {
            custumers_tbl custumers_Tbl = new custumers_tbl();
            custumers_Tbl = Convert(customerDTO);
            return CustomerDAL.update(custumers_Tbl);
        }
        public custumers_tbl Convert(CustomerDTO customerDTO)
        {
            custumers_tbl custumers_Tbl = new custumers_tbl();
            custumers_Tbl.CustumerID = customerDTO.CustumerID;
            custumers_Tbl.CustumerName = customerDTO.CustumerName;
            return custumers_Tbl;
        }
        public CustomerDTO Convert(custumers_tbl custumers_Tbl)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.CustumerID = custumers_Tbl.CustumerID;
            customerDTO.CustumerName = custumers_Tbl.CustumerName;
            return customerDTO;
        }
    }
}
