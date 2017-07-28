using System.ComponentModel;
using System.Drawing;

namespace ProjetoFinal.Presentation.Components
{
    public partial class LaloMenuLabel : LaloLabel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get
            {
                if (this.Enabled)
                    return (Focused) ? LaloStyle.ColorDarkBlue : LaloStyle.ColorBlue;
                else
                    return LaloStyle.ColorLightGray;
            }
        }

        public LaloMenuLabel()
        {

        }
    }
}
