using ConsoleApplication7.Gui;

namespace ConsoleApplication7.Mitsubishi
{
    public class Volkswagen : Button
    {
        string Label;
        public Volkswagen(string Label)

        {
            this.Label = Label;
        }

        public override string Paint()
        {
            return "-----" +
                "-- " + Label + " --" +
                  "-----" +
                      "-----";
        }
    }
}
