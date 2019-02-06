using SteeringCS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.behaviour
{
    class wanderBehaviour : SteeringBehaviour
    {
        public wanderBehaviour(MovingEntity me) : base(me) { }

        public override Vector2D Calculate()
        {
            double WanderRadius = 10;
            double WanderDistance = 10;
            double WanderJitter = 10;
            Random rnd = new Random();
            double MIN_VALUE = -1;
            double MAX_VALUE = 1;

            //first, add a small random vector to the target’s position
            Vector2D wanderTarget = new Vector2D((rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE) * WanderJitter, (rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE) * WanderJitter);
            //reproject this new vector back onto a unit circle
            wanderTarget.Normalize();
            //increase the length of the vector to the same as the radius
            //of the wander circle
            wanderTarget.Multiply(WanderRadius);
            //move the target into a position WanderDist in front of the agent
            Vector2D targetLocal = wanderTarget.Add(new Vector2D(WanderDistance, 0));

            //project the target into world space
            Vector2D targetWorld = new Vector2D(targetLocal.X, ME.Heading.Y);

            //and steer toward it
            return targetWorld;
        }
    }
}
