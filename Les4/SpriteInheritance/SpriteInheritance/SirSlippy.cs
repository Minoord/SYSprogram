using System.Drawing;

namespace Eindopdracht
{
    class SirSlippy : Sprite
    {

        public SirSlippy(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(82, 801, 16, 16);
        }
    }
}



