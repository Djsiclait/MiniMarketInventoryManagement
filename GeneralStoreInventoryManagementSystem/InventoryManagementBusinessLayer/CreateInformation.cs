using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class CreateInformation
    {
        /// <summary>
        /// This function recieves a user profile object to create its respective information for prosperity
        /// </summary>
        /// <param name="newUser">The user object that houses the necessary information to create a new profile</param>
        /// <returns>A message that confirms or denies the user profile creation process</returns>
        public static String CreateNewUserProfileInformation(UserProfile newUser)
        {
            // Requesting creation of new user account
            String message = CreateData.CreateNewUserProfileData(newUser);

            if (message == "User created")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("USE3", newUser.Username, null);
                return "SUCCESS";
            }
            else
                return "";
        }

        /// <summary>
        /// This function receives a product object to register its information
        /// </summary>
        /// <param name="product">Product object which contains necessary information</param>
        /// <returns>A message that confirms or denies the creation process</returns>
        public static String RegisterNewProductInformation(Product product)
        {
            // Identifying the user that is requesting the product registration 
            product.RegisteredBy = SystemResources.UserInSession.Username;

            // Requesting creation of new product
            String message = CreateData.RegisterNewProductData(product);

            if (message == "Product created successfully!")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO4", product.Name, null);
                return "SUCCESS";
            }
            else
                return "";
        }

        /// <summary>
        /// This function registers new brands for product classification
        /// </summary>
        /// <param name="name">Name of new brand</param>
        /// <returns>A message that confirms or denies the brand creation process</returns>
        public static String RegisterNewProductBrandInformation(String name)
        {
            // Requesting creation of a new brand
            String message = CreateData.RegisterNewProductBrandData(name);

            if (message == "Brand has been registered successfully!")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO3", name, null);
                return "SUCCESS";
            }
            else
                return "";
        }

        /// <summary>
        /// This function registers any system or user activity
        /// </summary>
        /// <param name="activity">Activity entity with necessary information</param>
        public static void RegisterNewUserActivityInformation(Activity activity)
        {
            CreateData.RegisterNewUserActivityData(activity);
        }

        /// <summary>
        /// This function registers new suppliers
        /// </summary>
        /// <param name="name">Name of new supplier</param>
        /// <param name="phoneNumber">Phone number of new supplier</param>
        /// <param name="email">Email of new supplier</param>
        /// <returns>A message that confirms or denies the supplier creation process</returns>
        public static String RegisterNewProductSupplierInformation(String name, String phoneNumber, String email)
        {
            // Requesting creation of new product supplier
            String message = CreateData.RegisterNewProductSupplierData(name, phoneNumber, email);

            if (message == "Supplier has been registered successfully!")
            {
                if (phoneNumber == null && email == null)
                    SystemProtocols.ApplyActivityProtocols("SPE4", name, null); // Quick (incomplete) registration of new supplier
                else
                    SystemProtocols.ApplyActivityProtocols("SUP1", name, null); // Full registration of new supplier

                return "SUCCESS";
            }
            else
                return "";
        }
    }
}
