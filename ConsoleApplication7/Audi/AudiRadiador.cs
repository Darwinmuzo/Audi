using using ConsoleApplication7.Gui;

namespace ConsoleApplication7.Audi
{
    public class AudiRadiador :Icon
    {
     this.type = type;
    }

    public override string Paint()
    {
        string res = "";
        switch (type)
        {
            case "alerta":
                res = "-------" +
                    "-----------" +
                         "ALERTA" +
                         "------------" +
                         "---------";
                break;
            case "peligro":
                break;
        }
        return res;
    }
}
