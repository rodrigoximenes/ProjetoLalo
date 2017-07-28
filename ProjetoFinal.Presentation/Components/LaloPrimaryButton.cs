using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Components
{
    public partial class LaloPrimaryButton : Button
    {

        public LaloPrimaryButton()
        {
            this.Cursor = Cursors.Hand;
            this.FlatStyle = FlatStyle.Standard;
            this.Width = 180;
            this.Height = 33;
            this.UseVisualStyleBackColor = false;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }


    }
}

