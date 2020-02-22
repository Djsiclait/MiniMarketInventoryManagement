using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementBusinessLayer.ActivityInformation;
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.Activity;
using InventoryManagementEntityLayer.Product;
using InventoryManagementEntityLayer.UserProfile;

namespace InventoryManagementBusinessLayer
{
    namespace Resources
    {
        public static class SystemResources
        {
            private static UserProfile userInSession; // object used to track open active session

            private static List<Product> cart; // list to store all products a client desires to purchase

            #region Resource Functions
            /// <summary>
            /// Function used to instantiate the session variable
            /// Must be executed once before every session  
            /// </summary>
            /// <param name="username">Username requesting to log in</param>
            public static void BeginUserSession(String username)
            {
                userInSession = UserInformationManager.ConsultUserInformationByUsername(username); // opening an active session

                // Updating the user's last loggin information before finalizing process
                UserInformationManager.UpdateUserLastLoginInformation(userInSession.Username);

                // Recording log in activity for user logging in
                RecordActivity(
                    userInSession.Username, // username of user in session 
                    userInSession.Role + ", " + userInSession.Username + ", has successfully logged in", // description of activity
                    "LOG IN"); // type of activity
            }

            /// <summary>
            /// Function used to end the session variable
            /// Must be executed once before logging out of every session  
            /// </summary>
            public static void EndUserSession()
            {
                // Recording log out activity for user logging out
                RecordActivity(
                    userInSession.Username, // username of user in session 
                    userInSession.Role + ", " + userInSession.Username + ", has successfully logged out", // description of activity
                    "LOG OUT"); // type of activity

                // Updating the user's last loggin information before finalizing process
                UserInformationManager.UpdateUserLastLoginInformation(userInSession.Username);

                userInSession = null; // closing the current session
            }

            /// <summary>
            /// Function used to record system and user activities 
            /// </summary>
            /// <param name="username">Username of user responsible for the activity</param>
            /// <param name="description">Description of the activity</param>
            /// <param name="type">Type of activity</param>
            public static void RecordActivity(String username, String description, String type)
            {
                // Registering new activity
                ActivityInformationManager.RegisterNewActivityInformation(new Activity(username, description, type));
            }

            /// <summary>
            /// Function to remove all items from the cart
            /// </summary>
            public static void EmptyCart()
            {
                cart = null;
            }

            /// <summary>
            /// Function to remove one item from the cart 
            /// </summary>
            /// <param name="productId">Id of the product that will be removed</param>
            public static void RemoveItem(String productId)
            {
                Product itemToRemove = null;

                foreach (Product item in cart)
                {
                    if (item.Id == productId)
                    {
                        itemToRemove = item;
                        break;
                    }
                }

                cart.Remove(itemToRemove);
            }

            /// <summary>
            /// Function that removes one unit of a specific item in the cart
            /// </summary>
            /// <param name="productId">Id of the desired product</param>
            public static void RemoveOneFromAnItem(String productId, decimal productPrice)
            {
                Product itemToRemove = null;

                foreach (Product item in cart)
                    if (item.Id == productId)
                    {
                        item.Quantity--;
                        item.UnitPrice -= productPrice;

                        if (item.Quantity == 0)
                            itemToRemove = item;

                        break;
                    }

                cart.Remove(itemToRemove);
            }

            /// <summary>
            /// Function that add one unit of a specific item in the cart
            /// </summary>
            /// <param name="productId">Id of the desired product</param>
            public static void AddUnitsToAnItem(String productId, string productUnit, decimal productPrice, int productQuantity, int limit)
            {
                foreach (Product item in cart)
                    if (item.Id == productId && item.Unit == productUnit && item.Quantity < limit)
                    {
                        item.Quantity = (item.Quantity + productQuantity) < limit ? item.Quantity + productQuantity : limit;
                        item.UnitPrice = productPrice * item.Quantity;
                        break;
                    }
                    else if (item.Id == productId && item.Unit == productUnit && item.Quantity >= limit)
                        break;
            }
            #endregion

            #region Getters and setters
            public static UserProfile UserInSession
            {
                get
                {
                    return userInSession;
                }
            }

            public static List<Product> Cart
            {
                get
                {
                    if (cart == null)
                        cart = new List<Product>();

                    return cart;
                }

                set
                {
                    cart = value;
                }
            }
            #endregion
        }
    }
}
