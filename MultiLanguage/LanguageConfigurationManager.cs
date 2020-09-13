using System.Configuration;

namespace MultiLanguage
{
    public class LanguageConfigurationManager
    {
        public Language Texts(string lg)
        {
            var obj = new Language();
            if (string.IsNullOrWhiteSpace(lg))
            {
                lg = "en-us";
            }

            obj.Msg01 = ConfigurationManager.AppSettings["01-" + lg];
            obj.Msg02 = ConfigurationManager.AppSettings["02-" + lg];
            obj.Msg03 = ConfigurationManager.AppSettings["03-" + lg];
            return obj;
        }
    }
}
