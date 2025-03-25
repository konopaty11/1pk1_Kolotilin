namespace Task_20_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client guest = new Client(AccessLevel.Guest);
            guest.Read();
            guest.DeleteContent();

            Client user = new Client(AccessLevel.User);
            user.CreateContent();
            user.Read();

            Client moderator = new Client(AccessLevel.Moderator);
            moderator.CreateContent();
            moderator.DeleteContent();

            Client admin = new Client(AccessLevel.Admin);
            admin.Read();
            admin.DeleteContent();
        }
    }
}
