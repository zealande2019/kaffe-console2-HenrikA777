using System;
using System.Collections.Generic;
using System.Text;

namespace KaffeConsoleAppNetCore
{
    using kaffe;
    class FlatWhite : Kaffe, Imælk
    {
        public FlatWhite(int rabat)
        :base(rabat)
        {
        }

        public FlatWhite()
        {
        }
        public override int Pris()
        {
            return 45;
        }

        public int MlMælk()
        {
            return 160;
        }

        public override string Navn()
        {
            return "FlatWhite";
        }

        public override string Styrke()
        {
            return "Mild";
        }
    }
}
