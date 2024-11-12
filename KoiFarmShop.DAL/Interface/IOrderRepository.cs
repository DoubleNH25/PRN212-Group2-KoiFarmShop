using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.DAL.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        public List<Order> GetOrderWithUserId(int userId);

        public List<Order> GetOrdersByStatus(byte status);

        public List<Shipping> GetShippingByUser(int userId);

        public List<OrderDetail> GetOrderDetailWithUserId(int userId);

        public List<Shipping> GetShippingByEmployee(int employeeId);
        public void AddOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(Order order);
        List<OrderDetail> GetAllOrdersDetail();
        public void AddOrderDetail(OrderDetail orderDetail);
        public void UpdateOrderDetail(OrderDetail orderDetail);
        public void DeleteOrderDetail(OrderDetail orderDetail);
        List<Shipping> GetAllShipping();
        public void AddShipping(Shipping shipping);
        public void UpdateShipping(Shipping shipping);
        public void DeleteShipping(Shipping shipping);
        Order? GetOrderById(int id);
        OrderDetail? GetOrderDetailById(int id);
        Shipping? GetShippingById(int id);
    }
}
