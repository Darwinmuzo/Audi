using System;
using ConsoleApplication7.Gui;

namespace ConsoleApplication7.Mitsubishi
{
    public class MitsubishiBujia : Button
    {
        string Label;
        public MitsubishiBujia(string Label)

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
