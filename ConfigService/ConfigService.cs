namespace ConfigService;

public class ConfigService
{
    public string GetValue()
    {
        string result = System.Configuration.ConfigurationManager.AppSettings["example"];
        return result;
    }

}
