using ConsoleApplication7.Gui;


namespace ConsoleApplication7.Mitsubishi
{
    public class VolkswagenRadiador : Label
    {
        string Label;
        public VolkswagenRadiador(string Label)

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
