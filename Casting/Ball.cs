using System;

namespace cse210_batter_csharp.Casting
{
    public class Ball : Actor
    {
        public Ball()
        {
            int x = Constants.MAX_X / 2;
            int y = (Constants.MAX_Y / 2)+ Constants.PADDLE_HEIGHT;
            Point position = new Point(x, y);
            SetPosition(position);
            SetImage(Constants.IMAGE_BALL);
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetVelocity(new Point(10,10));
            GetVelocity();
        }
    }
}