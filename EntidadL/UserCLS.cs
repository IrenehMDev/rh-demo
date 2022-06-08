namespace EntidadL
{
    public class UserCLS
    {
        public int id_user { get; set; }
        public string mail { get; set; }    = string.Empty;
        public string username { get; set; } = string.Empty;
        public string password { get; set; } =  string.Empty;
        public bool status { get; set; }     = false;
        public string sex { get; set; }      = "F";
        public DateTime created_at { get; set; } = DateTime.Now;
    }
}