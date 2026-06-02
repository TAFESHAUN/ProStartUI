using ProStartUI.DataModel;

namespace ProStartUI.Repositories
{
    public interface IRepo
    {
        /// <summary>
        /// Returns a list of all activities, regardless of type.
        /// </summary>
        List<Activity> GetAllActivities();

        /// <summary>
        /// Returns a list of all fitness activities.
        /// </summary>
        List<FitnessActivity> GetAllFitnessActivities();

        /// <summary>
        /// Returns a list of all entertainment activities.
        /// </summary>
        List<EntertainmentActivity> GetAllEntertainmentActivities();

        /// <summary>
        /// Checks if an activity exists on the specified date. Returns true if at least one activity is found, false otherwise.
        /// </summary>
        bool CheckActivityExistsByDate(DateTime dateToCheck);

        /// <summary>
        /// Adds a new fitness activity to the DB
        /// </summary>
        void AddFitnessActivity(DateTime dateStartTime, string title, decimal cost, string location);

        /// <summary>
        /// Adds a new entertainment activity to the DB
        /// </summary>
        void AddEntertainmentActivity(DateTime dateStartTime, string title, decimal cost, int minParticipants);

        /// <summary>
        /// Updates an existing activity with the specified ID.
        /// If the activity is not found, an exception will be thrown.
        /// </summary>
        void UpdateActivityWithTypeCheck(int activityID, DateTime newDateStartTime, string newTitle, decimal newCost,
                                         string newType, string? location = null, int? minParticipants = null);

        /// <summary>
        /// Searches for activities based on the specified date and operator.
        /// </summary>
        List<Activity> SearchActivitiesByDate(DateTime searchDate, string operatorStr);
    }
}
