
namespace WebApplication1.Serwices.Lab4
{
    public class Polish : Language, ILanguage
    {
        public Polish(string name)
        {
            name = name;
        }
        public override string getLang()
        {
            return "PL";
        }

        public override string getLangCode()
        {
            throw new NotImplementedExsception();
        }

        public override  translate(string key)
        {
            throw new NotImplementedException();
        }


    }

}
