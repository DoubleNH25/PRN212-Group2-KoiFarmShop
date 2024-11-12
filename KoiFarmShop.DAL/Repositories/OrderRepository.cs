using KoiFarmShop.DAL.Interface;
using KoiFarmShop.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                order.TotalPrice = 0;
                db.Orders.Add(order);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error to add Order: {ex.Message}");
            }
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var orders = db.Orders
                    .FirstOrDefault(br => br.OrderId == orderDetail.OrderId);
                if (orders == null)
                {
                    throw new Exception("Error: Your order ID does not exist. ");
                }
                if(orders.Status == 2)
                {
                    throw new Exception("Error: Your order status is inactive.");
                }
                var products = db.Products
                    .FirstOrDefault(p => p.ProductId == orderDetail.ProductId);
                if (products == null)
                {
                    throw new Exception("Error: Your product ID does not exist");
                }
                if(products.Stock == 0)
                {
                    throw new Exception("Error: The quantity of product is 0 now");
                }
                int temp = products.Stock - orderDetail.Quantity;
                if (temp < 0)
                {
                    throw new Exception("Error: Your quantity is incorrect");
                }
                products.Stock = temp;
                orderDetail.Price = orderDetail.Price * orderDetail.Quantity;
                db.OrderDetails.Add(orderDetail);
                if (products.Stock == 0)
                {
                    products.Status = 0;
                }
                db.SaveChanges();
                UpdateTotalPrice(orderDetail.OrderId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding order detail: {ex.Message}");
            }
        }

        public void AddShipping(Shipping shipping)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                db.Shippings.Add(shipping);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error to add Shipping: {ex.Message}");
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var ord = db.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
                if (ord != null)
                {
                    ord.Status = 2;
                    var orderDetails = db.OrderDetails
                                   .Where(od => od.OrderId == order.OrderId)
                                   .ToList();
                    foreach (var detail in orderDetails)
                    {
                        if (detail.Status == 2)
                        {
                            DeleteOrderDetail(detail);
                        }
                    }
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var existingOrderDetail = db.OrderDetails
                    .FirstOrDefault(bd => bd.OrderDetailId == orderDetail.OrderDetailId);
                if (existingOrderDetail != null)
                {
                    existingOrderDetail.Status = 0;

                    var koi = db.Products
                        .FirstOrDefault(r => r.ProductId == orderDetail.ProductId);
                    if (koi != null)
                    {
                        koi.Stock += orderDetail.Quantity;
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa Order Detail: {ex.Message}");
            }
        }

        public void DeleteShipping(Shipping shipping)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var ship = db.Shippings.SingleOrDefault(b => b.ShippingId == shipping.ShippingId);
                if (ship != null)
                {
                    db.Shippings.Remove(ship);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Order> GetAllOrders()
        {
            var listOrders = new List<Order>();
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                listOrders = db.Orders
                    .Include(b => b.OrderDetails).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($" Lỗi khi lấy danh sách Orders: {ex.Message}");
            }
            return listOrders;
        }

        public List<OrderDetail> GetAllOrdersDetail()
        {
            var listOrderDetails = new List<OrderDetail>();
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                listOrderDetails = db.OrderDetails
                    .Include(b => b.Order)
                    .Include(b => b.Product)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($" Lỗi khi lấy danh sách Shipping: {ex.Message}");
            }
            return listOrderDetails;
        }

        public List<Order> GetOrderWithUserId(int userId)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var orders = db.Orders
                    .Where(order => order.UserId == userId)
                    .Include(order => order.OrderDetails) 
                    .Include(order => order.Shippings)
                    .Include(order => order.User)
                    .ToList();

                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving orders with UserId {userId}: {ex.Message}");
            }
        }

        public List<Shipping> GetShippingByUser(int userId)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();

                // Get all orders for the given UserId
                var orders = db.Orders
                    .Where(o => o.UserId == userId)
                    .ToList();

                // Get all shipping records where OrderId matches the OrderIds of the above orders
                var shippingList = db.Shippings
                    .Where(s => orders.Select(o => o.OrderId).Contains(s.OrderId))
                    .ToList();

                return shippingList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching shipping records for UserId {userId}: {ex.Message}");
            }
        }


        public List<OrderDetail> GetOrderDetailWithUserId(int userId)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var orders = db.Orders
                    .Where(order => order.UserId == userId)
                    .Include(order => order.OrderDetails)
                    .ThenInclude(orderDetail => orderDetail.Product)
                    .ToList();
                var orderDetails = orders
                    .SelectMany(order => order.OrderDetails)
                    .ToList();

                return orderDetails;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving order details for UserId {userId}: {ex.Message}");
            }
        }

        public List<Shipping> GetAllShipping()
        {
            var listShipping = new List<Shipping>();
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                listShipping = db.Shippings
                    .Include(b => b.Order)
                    .Include(b => b.Employee)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($" Lỗi khi lấy danh sách Shipping: {ex.Message}");
            }
            return listShipping;
        }

        public List<Shipping> GetShippingByEmployee(int employeeId)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();

                // Get all shipping records where EmployeeId matches the given employeeId
                var shippingList = db.Shippings
                    .Where(s => s.EmployeeId == employeeId)
                    .Include (b => b.Employee)
                    .ToList();

                return shippingList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching shipping records for EmployeeId {employeeId}: {ex.Message}");
            }
        }

        public Order? GetOrderById(int id)
        {
            using var db = new Fu2024koiFarmShopContext();
            return db.Orders.FirstOrDefault(b => b.OrderId.Equals(id));
        }
        public List<Order> GetOrdersByStatus(byte status)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var orders = db.Orders
                    .Where(order => order.Status == status)
                    .Include(order => order.OrderDetails)
                    .Include(order => order.Shippings)  
                    .Include(order => order.User)          
                    .ToList();

                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving orders with status {status}: {ex.Message}");
            }
        }


        public OrderDetail? GetOrderDetailById(int id)
        {
            using var db = new Fu2024koiFarmShopContext();
            return db.OrderDetails.FirstOrDefault(b => b.OrderId.Equals(id));
        }

        public Shipping? GetShippingById(int id)
        {
            using var db = new Fu2024koiFarmShopContext();
            return db.Shippings.FirstOrDefault(b => b.ShippingId.Equals(id));
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật Order: {ex.Message}");
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                db.Entry<OrderDetail>(orderDetail).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("You are just updated quantity and status. However," +
                    "if you want to update other information, you must delete current and add again ");
            }
        }

        public void UpdateShipping(Shipping shipping)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                db.Entry(shipping).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật Shipping: {ex.Message}");
            }
        }

        public void UpdateTotalPrice(int orderId)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var orderDetails = db.OrderDetails
                    .Where(b => b.OrderId == orderId)
                    .ToList();

                decimal totalPrice = orderDetails.Sum(b => b.Price);

                var order = db.Orders
                    .FirstOrDefault(br => br.OrderId == orderId);

                if (order != null)
                {
                    order.TotalPrice = totalPrice;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error to update TotalPrice: {ex.Message}");
            }
        }

    }
}
