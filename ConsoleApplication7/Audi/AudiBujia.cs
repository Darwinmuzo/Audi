using ConsoleApplication7.Gui;

namespace ConsoleApplication7.Audi
{
    class AudiBujia : Label
    {
        string Label;
        public AudiBujia(string Label)

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
