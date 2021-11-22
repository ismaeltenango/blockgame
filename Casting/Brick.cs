using System;

namespace cse210_batter_csharp.Casting
{
    public class Brick : Actor
    {
        public Brick(Point position)
        {
            SetPosition(position);
            SetImage(Constants.IMAGE_BRICK);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}