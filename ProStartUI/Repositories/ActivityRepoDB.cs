using Microsoft.Data.SqlClient;
using ProStartUI.DataModel;
using System.Data;

namespace ProStartUI.Repositories
{
    public class ActivityRepoDB : IRepo
    {
        private readonly string _conn;

        public ActivityRepoDB(string connectionString) => _conn = connectionString;

        /// <summary>
        /// Returns a list of all activities, regardless of type.
        /// </summary>
        public List<Activity> GetAllActivities()
        {
            var results = new List<Activity>();

            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("GetAllActivities", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string activityType = rdr.GetString(rdr.GetOrdinal("ActivityType"));

                if (activityType == "Fitness")
                {
                    results.Add(new FitnessActivity
                    {
                        ActivityID = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                        DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                        Title = rdr.GetString(rdr.GetOrdinal("Title")),
                        Cost = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                        ActivityType = activityType,
                        Location = rdr.IsDBNull(rdr.GetOrdinal("Location"))
                                            ? ""
                                            : rdr.GetString(rdr.GetOrdinal("Location"))
                    });
                }
                else // Entertainment
                {
                    results.Add(new EntertainmentActivity
                    {
                        ActivityID = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                        DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                        Title = rdr.GetString(rdr.GetOrdinal("Title")),
                        Cost = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                        ActivityType = activityType,
                        MinParticipants = rdr.IsDBNull(rdr.GetOrdinal("MinParticipants"))
                                              ? 0
                                              : rdr.GetInt32(rdr.GetOrdinal("MinParticipants"))
                    });
                }
            }

            return results;
        }

        /// <summary>
        /// Returns a list of all fitness activities.
        /// </summary>
        public List<FitnessActivity> GetAllFitnessActivities()
        {
            var results = new List<FitnessActivity>();

            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("GetAllFitnessActivities", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                results.Add(new FitnessActivity
                {
                    ActivityID = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                    DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                    Title = rdr.GetString(rdr.GetOrdinal("Title")),
                    Cost = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                    ActivityType = "Fitness",
                    Location = rdr.IsDBNull(rdr.GetOrdinal("Location"))
                                        ? ""
                                        : rdr.GetString(rdr.GetOrdinal("Location"))
                });
            }

            return results;
        }

        /// <summary>
        /// Returns a list of all entertainment activities.
        /// </summary>
        public List<EntertainmentActivity> GetAllEntertainmentActivities()
        {
            var results = new List<EntertainmentActivity>();

            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("GetAllEntertainmentActivities", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                results.Add(new EntertainmentActivity
                {
                    ActivityID = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                    DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                    Title = rdr.GetString(rdr.GetOrdinal("Title")),
                    Cost = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                    ActivityType = "Entertainment",
                    MinParticipants = rdr.IsDBNull(rdr.GetOrdinal("MinParticipants"))
                                          ? 0
                                          : rdr.GetInt32(rdr.GetOrdinal("MinParticipants"))
                });
            }

            return results;
        }

        /// <summary>
        /// Checks if an activity exists on the specified date.
        /// </summary>
        /// <param name="dateToCheck">The date to check for activity existence.</param>
        /// <returns>true if at least one activity is found, false otherwise.</returns>
        public bool CheckActivityExistsByDate(DateTime dateToCheck)
        {
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("CheckActivityExistsByDate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DateToCheck", DateOnly.FromDateTime(dateToCheck));

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            if (rdr.Read())
                return rdr.GetInt32(rdr.GetOrdinal("ActivityExists")) == 1;

            return false;
        }

        /// <summary>
        /// Adds a new fitness activity to the DB
        /// </summary>
        public void AddFitnessActivity(DateTime dateStartTime, string title, decimal cost, string location)
        {
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("AddFitnessActivity", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DateStartTime", dateStartTime);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Cost", cost);
            cmd.Parameters.AddWithValue("@Location", location);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds a new entertainment activity to the DB
        /// </summary>
        public void AddEntertainmentActivity(DateTime dateStartTime, string title, decimal cost, int minParticipants)
        {
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("AddEntertainmentActivity", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DateStartTime", dateStartTime);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Cost", cost);
            cmd.Parameters.AddWithValue("@MinParticipants", minParticipants);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates an existing activity with the specified ID.
        /// If the activity is not found, an exception will be thrown.
        /// </summary>
        public void UpdateActivityWithTypeCheck(int activityID, DateTime newDateStartTime, string newTitle,
                                                decimal newCost, string newType,
                                                string? location = null, int? minParticipants = null)
        {
            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("UpdateActivityWithTypeCheck", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ActivityID", activityID);
            cmd.Parameters.AddWithValue("@NewDateStartTime", newDateStartTime);
            cmd.Parameters.AddWithValue("@NewTitle", newTitle);
            cmd.Parameters.AddWithValue("@NewCost", newCost);
            cmd.Parameters.AddWithValue("@NewType", newType);

            // Optional parameters — pass DBNull when not provided so SQL defaults kick in
            cmd.Parameters.AddWithValue("@Location", (object?)location ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MinParticipants", (object?)minParticipants ?? DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Searches for activities based on the specified date and operator.
        /// </summary>
        public List<Activity> SearchActivitiesByDate(DateTime searchDate, string operatorStr)
        {
            var results = new List<Activity>();

            using var conn = new SqlConnection(_conn);
            using var cmd = new SqlCommand("SearchActivitiesByDate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SearchDate", DateOnly.FromDateTime(searchDate));
            cmd.Parameters.AddWithValue("@Operator", operatorStr);

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                // Determine type by which subtype column is populated
                bool hasFitness = !rdr.IsDBNull(rdr.GetOrdinal("Location"));
                bool hasEntertainment = !rdr.IsDBNull(rdr.GetOrdinal("MinParticipants"));

                if (hasFitness)
                {
                    results.Add(new FitnessActivity
                    {
                        ActivityID = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                        DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                        Title = rdr.GetString(rdr.GetOrdinal("Title")),
                        Cost = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                        ActivityType = "Fitness",
                        Location = rdr.GetString(rdr.GetOrdinal("Location"))
                    });
                }
                else if (hasEntertainment)
                {
                    results.Add(new EntertainmentActivity
                    {
                        ActivityID = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                        DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                        Title = rdr.GetString(rdr.GetOrdinal("Title")),
                        Cost = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                        ActivityType = "Entertainment",
                        MinParticipants = rdr.GetInt32(rdr.GetOrdinal("MinParticipants"))
                    });
                }
            }

            return results;
        }
    }
}
