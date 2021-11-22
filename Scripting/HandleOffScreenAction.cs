using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HandleOffScreenAction : Action
    {


        public HandleOffScreenAction()
        {

        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];
            Point direction = ball.GetPosition();
            Point velocity = (ball.GetVelocity());
            Point point = ball.GetVelocity();
            if (direction.GetX() > Constants.MAX_X || direction.GetX() <= 0)
            {
                point = new Point(velocity.GetX() * -1,velocity.GetY());
                
            }
            else if(direction.GetY() > Constants.MAX_Y || direction.GetY() <= 0)
            {
                point = new Point(velocity.GetX(),velocity.GetY() * -1);
            }
            ball.SetVelocity(point);
        }
    }
}