using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreInventoryManagementSystem
{
    public class FormsMenuList
    {
        // This is to create the forms used to browse the inventory in search of a product
        // This is not used to make add products to the cart nor register purchases or restock products
        // This form displays the basic information of products such as name, brand, category, cost*, price, and number of units instock 
        // The inventory will be organized according to FIFO/LIFO for admin users
        public static InventorySearchForm inventorySearchForm = new InventorySearchForm();
        
        // This form is used to log in to begin a new user session 
        public static LoginForm loginForm = new LoginForm();

        // This window form allows users to registe new products according to FIFO/LIFO standards
        // Only available to admins
        public static RegisterNewProduct registerNewProduct = new RegisterNewProduct();

        // This form is to register a new sale of products
        // Only allows to sell products that are instock ( > 0) and are not discontinued 
        // This form of viewing the inventory is not organized according to FIFO/LIFO
        public static RegisterSaleFrom registerSaleForm = new RegisterSaleFrom();

        // This form is used to restock products in the inventory, taking into account FIFO/LIFO
        // Only available to admins
        public static RestockProductsForm restockProductsFrom = new RestockProductsForm();

        // This form is dedicated to view the recent sales depending the requested time interval
        // Displays sales record information according to users' access level 
        public static SalesRecordForm salesRecordForm = new SalesRecordForm();
    }
}
