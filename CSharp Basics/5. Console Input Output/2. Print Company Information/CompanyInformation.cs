using System;
using System.Text;
using System.Collections.Generic;

class CompanyInformation
{
    static void Main()
    {
        StringBuilder resultingInformation = new StringBuilder();
        Dictionary<string, string> information = new Dictionary<string, string>()        
        {
            {"Company Name", "Stoyanov Ltd"},
            {"Company Address", "Sofia, Drujba II"},
            {"Phone number", "+359 2 894 42 18"},
            {"Fax number", null},
            {"Web site", "Stoyanov-bg.com"},
            {"Manager first name", "Stoyan"},
            {"Manager last name", "Stoyanow"},
            {"Manager age", "41"},
            {"Manager phone","+359 898 42 17 19"}
        };

        foreach (var item in information)
        {
            resultingInformation.AppendLine(item.Key + ": " + item.Value);
        }
        
       Console.WriteLine(resultingInformation);

    }
}
