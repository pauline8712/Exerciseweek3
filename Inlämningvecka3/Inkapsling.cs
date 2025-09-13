namespace Inlämningvecka3
{
    //Vi har känslig data vi vill skydda. Vi vill inte att någon annan ska kunna komma åt den.
    public class User
    {
        //Privat attribut som vi skyddar
    private string Password;

      public User(string password)
        {
            Password = password;
        }

        public string password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
