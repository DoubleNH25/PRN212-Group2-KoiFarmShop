using KoiFarmShop.BLL.Interface;
using KoiFarmShop.DAL.Interface;
using KoiFarmShop.DAL.Models;
using KoiFarmShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.BLL.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repo = new OrderRepository();
        public void AddOrder(Order order)
        {
            repo.AddOrder(order);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            repo.AddOrderDetail(orderDetail);
        }

        public void AddShipping(Shipping shipping)
        {
            repo.AddShipping(shipping);
        }

        public void DeleteOrder(Order order)
        {
            repo.DeleteOrder(order);
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            repo.DeleteOrderDetail(orderDetail);
        }

        public void DeleteShipping(Shipping shipping)
        {
            repo.DeleteShipping(shipping);
        }

        public List<Order> GetAllOrders()
        {
            return repo.GetAllOrders();
        }

        public List<OrderDetail> GetAllOrdersDetail()
        {
            return repo.GetAllOrdersDetail();
        }

        public List<Shipping> GetAllShipping()
        {
            return repo.GetAllShipping();
        }

        public Order? GetOrderById(int id)
        {
            return repo.GetOrderById(id);
        }

        public OrderDetail? GetOrderDetailById(int id)
        {
            return repo.GetOrderDetailById(id);
        }

        public List<OrderDetail> GetOrderDetailWithUserId(int userId)
        {
            return repo.GetOrderDetailWithUserId(userId);
        }

        public List<Order> GetOrdersByStatus(byte status)
        {
            return repo.GetOrdersByStatus(status);
        }

        public List<Order> GetOrderWithUserId(int userId)
        {
            return repo.GetOrderWithUserId(userId);
        }

        public List<Shipping> GetShippingByEmployee(int employeeId)
        {
            return repo.GetShippingByEmployee(employeeId);
        }

        public Shipping? GetShippingById(int id)
        {
            return repo.GetShippingById(id);
        }

        public List<Shipping> GetShippingByUser(int userId)
        {
            return repo.GetShippingByUser(userId);
        }

        public void UpdateOrder(Order order)
        {
            repo.UpdateOrder(order);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            repo.UpdateOrderDetail(orderDetail);
        }

        public void UpdateShipping(Shipping shipping)
        {
            repo.UpdateShipping(shipping);
        }
    }
}
