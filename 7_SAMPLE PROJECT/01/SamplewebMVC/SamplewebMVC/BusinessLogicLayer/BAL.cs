using SamplewebMVC.DataAccessLayer;

namespace SamplewebMVC.BusinessLogicLayer
{
    public class BAL
    {
        private readonly DAL _DAL;

        #region 01. CONSTRUCTOR:-
        public BAL()
        {
            _DAL = new DAL();
        }
        #endregion

        #region 02. VERIFY USER:-
        public int verifyUser(string username, string password)
        {
            // Construct the SQL query using string concatenation
            string query = "SELECT * FROM tbl_usercredentials WHERE username = '" + username + "' AND password = '" + password + "' AND isdeleted = FALSE;";
            int result   = _DAL.ExecuteScalar(query);
            return result;
        }
        #endregion
    }
}
