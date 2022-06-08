using EntidadL;


namespace DatosL
{
    public class UserDAL
    {
        public List<UserCLS> ListUsers()
        {
            List<UserCLS> userList = new List<UserCLS>();
            userList.Add(new UserCLS
            {
                id_user      = 1,
                mail        = "ireneh.demorh@gmail.com",
                username    = "Irene Hernández",
                password    = "irenehDemo",
                status      = true,
                sex         = "f",
                created_at  = DateTime.Now
            });

            return userList;
        }
        
    }
}