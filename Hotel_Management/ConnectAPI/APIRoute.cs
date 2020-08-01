namespace ConnectAPI
{
    public class APIRoute
    {
        static string Base = @"/api";

        public static class Account
        {
            public static string Login = Base + "/Account";
            public static string GetManvByAcc = Base + "/Account?maacc={0}";
        }
    }
}
