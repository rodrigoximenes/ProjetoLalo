using System.ComponentModel;
using System.Drawing;

namespace ProjetoFinal.Presentation.Components
{
    public partial class LaloMenuButton : LaloPrimaryButton
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

        public LaloMenuButton()
        {
            FlatAppearance.BorderSize = 0;
            BackColor = FlatAppearance.MouseDownBackColor = FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
