using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_TechLibrary.BLL
{
    public class PermissionManager
    {
        public static bool CanUserPerformAction(UserAccount user, string action)
        {
            switch (user.UserRole)
            {
                case UserRole.Administrator:
                    // Administrators can perform any action
                    return true;

                case UserRole.SalesManager:
                    // Sales Managers can add, update, delete, and search for customers
                    return action == "AddCustomer" || action == "UpdateCustomer" ||
                           action == "DeleteCustomer" || action == "SearchCustomer";

                case UserRole.InventoryController:
                    // Inventory Controllers can manage book information
                    return action == "AddBook" || action == "UpdateBook" ||
                           action == "DeleteBook" || action == "SearchBook";

                case UserRole.OrderClerk:
                    // Order Clerks can manage customer orders
                    return action == "AddOrder" || action == "UpdateOrder" ||
                           action == "CancelOrder" || action == "SearchOrder";

                case UserRole.Default:
                    // Default can only search for books
                    return action == "SearchBook";

                default:
                    // If the role is not recognized, deny permission by default
                    return false;
            }
        }
    }
}
