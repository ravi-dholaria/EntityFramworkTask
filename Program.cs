using EntityFramworkTask1.Contoller;

namespace EntityFramworkTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Passport
            PassportController pc = new PassportController();
            pc.AddPassport();



            #endregion

        }
    }
}