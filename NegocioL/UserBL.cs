using DatosL;
using EntidadL;


namespace NegocioL
{
    public class UserBL
    {
        public List<UserCLS> ListUsers()
        {
            UserDAL rh_user = new UserDAL();
            return rh_user.ListUsers();
        }
    }
}