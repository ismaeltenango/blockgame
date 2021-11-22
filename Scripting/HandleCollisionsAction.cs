using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {

        PhysicsService _physicsService = new PhysicsService();
        AudioService _audio = new AudioService();
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }
         public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];
            Actor paddle = cast["paddle"][0];
            List<Actor> bricks = cast["bricks"];
            // bool collapseBrick =false;
            if (_physicsService.IsCollision(ball, paddle))
            {
                Point velocity = (ball.GetVelocity());
                Point point = ball.GetVelocity();
                point = new Point(velocity.GetY()* -1,velocity.GetX());
                ball.SetVelocity(point);
                _audio.PlaySound(Constants.SOUND_BOUNCE);
            }
            
            foreach (Actor brick in bricks)
            {
                if (_physicsService.IsCollision(ball, brick))
                {
                    Point velocity = (ball.GetVelocity());
                    Point point = ball.GetVelocity();
                    // collapseBrick= true;
                    cast["bricks"].Remove(brick);
                    point = new Point(velocity.GetY()* -1,velocity.GetX());
                    ball.SetVelocity(point);
                    _audio.PlaySound(Constants.SOUND_START);
                    break;
                }
            }
                    
        }
        // public override void Execute(Dictionary<string, List<Actor>> cast)
        // {
        //     Actor ball = cast["balls"][0];
        //     Actor paddle = cast["paddle"][0];
        //     Point direction = ball.GetPosition();
        //     Point velocity = (ball.GetVelocity());
        //     Point point = ball.GetVelocity();
        //     if (direction.GetX() > Constants.MAX_X || direction.GetX() <= 0)
        //     {
        //         point = new Point(velocity.GetX() * -1,velocity.GetY());
                
        //     }
        //     else if(direction.GetY() > Constants.MAX_Y || direction.GetY() <= 0)
        //     {
        //         point = new Point(velocity.GetX(),velocity.GetY() * -1);
        //     }
        //     ball.SetVelocity(point);
        // }
    }
}