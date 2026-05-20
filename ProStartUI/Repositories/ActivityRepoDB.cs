using Microsoft.Data.SqlClient;
using ProStartUI.DataModel;
using System.Data;

namespace ProStartUI.Repositories
{
    public class ActivityRepoDB : IRepo
    {

        private readonly string _conn;

        public ActivityRepoDB(string connectionString) => _conn = connectionString;

        public List<Activity> GetAllActivities()
        {
            var results = new List<Activity>();

            using var conn = new SqlConnection(_conn);
            using var cmd  = new SqlCommand("GetAllActivities", conn);
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
                        ActivityID    = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                        DateStartTime = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                        Title         = rdr.GetString(rdr.GetOrdinal("Title")),
                        Cost          = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                        ActivityType  = activityType,
                        Location      = rdr.IsDBNull(rdr.GetOrdinal("Location"))
                                            ? ""
                                            : rdr.GetString(rdr.GetOrdinal("Location"))
                    });
                }
                else // Entertainment
                {
                    results.Add(new EntertainmentActivity
                    {
                        ActivityID      = rdr.GetInt32(rdr.GetOrdinal("ActivityID")),
                        DateStartTime   = rdr.GetDateTime(rdr.GetOrdinal("DateStartTime")),
                        Title           = rdr.GetString(rdr.GetOrdinal("Title")),
                        Cost            = rdr.GetDecimal(rdr.GetOrdinal("Cost")),
                        ActivityType    = activityType,
                        MinParticipants = rdr.IsDBNull(rdr.GetOrdinal("MinParticipants"))
                                              ? 0
                                              : rdr.GetInt32(rdr.GetOrdinal("MinParticipants"))
                    });
                }
            }

            return results;
        }
    }
}
