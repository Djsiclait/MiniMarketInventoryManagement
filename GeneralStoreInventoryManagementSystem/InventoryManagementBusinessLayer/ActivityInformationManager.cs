using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class ActivityInformationManager
    {
        #region Consults
        /// <summary>
        /// This function retrieves the information needed for the activity log list, according to the user's role
        /// It also allows the user to specify key words loosely to filter the information via username, description, and type
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <param name="last24Hours">Indicator to specify if searches should be limmited to the last 24 hours of activity</param>
        /// <returns>A list of activities registered in the system</returns>
        public static List<Activity> ConsultActivityListInformation(String keyWord, bool last24Hours)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ActivityDataManager.ConsultActivityListData(SystemResources.UserInSession.Role, keyWord, last24Hours);
            else
                return new List<Activity>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This fucntion fetches the activities of a specific user
        /// </summary>
        /// <param name="username">Target username</param>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of activities registered in the system by the target user</returns>
        public static List<Activity> ConsultActivityListInformationByUsername(String username, String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ActivityDataManager.ConsultActivityListDataByUsername(SystemResources.UserInSession.Role, username, keyWord);
            else
                return new List<Activity>(); // returning an empty list given invalid user status
        }
        #endregion

        #region Creates
        /// <summary>
        /// This function registers any system or user activity
        /// </summary>
        /// <param name="activity">Activity entity with necessary information</param>
        public static void RegisterNewActivityInformation(Activity activity)
        {
            ActivityDataManager.RegisterNewActivityData(activity);
        }
        #endregion

        #region Updates
        // No updates at this point
        #endregion
    }
}
