using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreInventoryManagementSystem
{
    public class FormsMenuList
    {
        // This form displays all activities that have transpired durring a session, also displays errors
        // Only available to admins
        public static ActivitiesLogForm activitiesLogForm = new ActivitiesLogForm();

        // This window displays all important statistics of the inventory and sales
        // Only available to admins
        public static GraphsAnalyticsForm graphsAnaliticsForm = new GraphsAnalyticsForm();

        // This is to create the forms used to browse the inventory in search of a product
        // This is not used to make add products to the cart nor register purchases or restock products
        // This form displays the basic information of products such as name, brand, category, cost*, price, and number of units instock 
        // The inventory will be organized according to FIFO/LIFO for admin users
        public static InventorySearchForm inventorySearchForm = new InventorySearchForm();
        
        // This form is used to log in to begin a new user session 
        public static LoginForm loginForm = new LoginForm();

        // This window form allows users to registe new products according to FIFO/LIFO standards
        // Only available to admins
        public static RegisterNewProductForm registerNewProduct = new RegisterNewProductForm();

        // This window is to register any new users for the system
        // Only available to admins
        public static RegisterNewUserForm registerNewUserForm = new RegisterNewUserForm();

        // This form is to register a new sale of products
        // Only allows to sell products that are instock ( > 0) and are not discontinued 
        // This form of viewing the inventory is not organized according to FIFO/LIFO
        public static RegisterSaleFrom registerSaleForm = new RegisterSaleFrom();

        // This window displays all important reports of the inventory and sales
        // Only available to admins
        public static ReportsAnalyticsForm reportsAnalyticsForm = new ReportsAnalyticsForm();

        // This form is used to restock products in the inventory, taking into account FIFO/LIFO
        // Only available to admins
        public static RestockProductsForm restockProductsFrom = new RestockProductsForm();

        // This form is dedicated to view the recent sales depending the requested time interval
        // Displays sales record information according to users' access level 
        public static SalesRecordForm salesRecordForm = new SalesRecordForm();

        // This form displays all registered users of the system and their status: username, name, status, last login
        // Only available to admins
        public static UsersRegistryForm usersRegistryForm = new UsersRegistryForm();
    }
}
