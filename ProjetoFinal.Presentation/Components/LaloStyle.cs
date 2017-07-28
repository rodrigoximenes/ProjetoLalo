using System.Collections.Generic;
using System.Drawing;

namespace ProjetoFinal.Presentation.Components
{
    public class LaloStyle
    {
        // ----------------------------------------------------------------------------------------
        // Private and static data
        // ----------------------------------------------------------------------------------------
        private static IDictionary<string, FontFamily> _fonts = new Dictionary<string, FontFamily>();

        // ----------------------------------------------------------------------------------------
        // Public and static data
        // ----------------------------------------------------------------------------------------
        /// <summary>
        /// Font size type: Pixel / Point
        /// </summary>
        public static GraphicsUnit FONTSIZETYPE = GraphicsUnit.Pixel;

        // ----------------------------------------------------------------------------------------
        // Public methods
        // ----------------------------------------------------------------------------------------

        // Branco
        public static Color ColorWhite
        {
            get { return Color.White; }
        }

        // Cinza mais claro: 229, 229, 229
        public static Color ColorLighterGray
        {
            get { return Color.FromArgb(229, 229, 229); }
        }

        // Cinza claro: 204, 204, 204
        public static Color ColorLightGray
        {
            get { return Color.FromArgb(204, 204, 204); }
        }

        // Cinza escuro: 136, 136, 136
        public static Color ColorDarkGray
        {
            get { return Color.FromArgb(136, 136, 136); }
        }

        /// <summary>
        /// Cinza claro para fundo com tracejado: 247,247,247
        /// </summary>
        public static Color ColorDashedBack
        {
            get { return Color.FromArgb(247, 247, 247); }
        }

        /// <summary>
        /// Cor padrão da linha tracejada: 247,247,247
        /// </summary>
        public static Color ColorDashedLine
        {
            get { return Color.FromArgb(206, 206, 206); }
        }

        // Azul: 116, 151, 202
        public static Color ColorBlue
        {
            get { return Color.FromArgb(116, 151, 202); }
        }

        // Usado para o background do botão primário durante hover
        public static Color ColorDarkBlue
        {
            get { return Color.FromArgb(93, 120, 162); }
        }

        // Vermelho: 251, 100, 108 
        public static Color ColorRed
        {
            get { return Color.FromArgb(251, 100, 108); }
        }

        // Usado para o background do botão secundário durante hover
        public static Color ColorDarkRed
        {
            get { return Color.FromArgb(201, 80, 86); }
        }

        public static Color ColorRedValidated
        {
            get { return Color.FromArgb(254, 224, 226); }
        }

        public static Color ColorGreen
        {
            get { return Color.FromArgb(88, 191, 146); }
        }

        public static Color ColorGreenValidated
        {
            get { return Color.FromArgb(222, 242, 233); }
        }

        public static Color ColorMenuHeader
        {
            get { return ColorDarkGray; }
        }

        public static Color ColorMenuItem
        {
            get { return ColorBlue; }
        }

        public static Color ColorTheme
        {
            get { return Color.FromArgb(119, 194, 197); }
        }

        public static Color ColorDivider
        {
            get { return ColorLightGray; }
        }

        public static Color ColorDividerMessage
        {
            get { return ColorLighterGray; }
        }

        public static Color ColorDelete
        {
            get { return ColorRed; }
        }

        public static Color ColorNormalText
        {
            get { return ColorLightGray; }
        }

        public static Color ColorBackgroundContent
        {
            get { return Color.FromArgb(242, 242, 242); }
        }

        public static Color ColorYellowValidated
        {
            get { return Color.FromArgb(255, 250, 231); }
        }

        public static Color ColorBackgroundHorizontalMenu
        {
            get { return Color.FromArgb(232, 232, 232); }
        }

        public static Color ColorSelectionGrid
        {
            get { return Color.FromArgb(223, 245, 224); }
        }

        public static Color ColorGrid
        {
            get { return ColorLighterGray; }
        }

        public static Color ColorHeaderGrid
        {
            get { return ColorDarkGray; }
        }

        public static Color ColorThemeHoverButton
        {
            get { return ColorDarkBlue; }
        }

        public static Color ColorRedHoverButton
        {
            get { return ColorDarkRed; }
        }

        public static Color ColorTool
        {
            get { return Color.FromArgb(95, 204, 102); }
        }

        public static Color ColorInactiveTabPageButton
        {
            get { return Color.FromArgb(185, 202, 228); }
        }

        public static Color ColorHoverActiveTabPageButton
        {
            get { return Color.FromArgb(100, 100, 100); }
        }
    }
}
