using SteeringCS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.behaviour
{
    class FleeBehaviour : SteeringBehaviour
    {
        public FleeBehaviour(MovingEntity me) : base(me) { }
        // to do
        public override Vector2D Calculate()
        {
            //const double PanicDistance = 100.00 * 100.00;
            Vector2D targetPos = new Vector2D(ME.MyWorld.Target.Pos.X, ME.MyWorld.Target.Pos.Y);
            if (ME.Pos.Sub(targetPos).Length() > 1.00)
            {
                return new Vector2D(0,0);
            }

            Vector2D DesiredVelocity = ME.Pos.Sub(targetPos).Normalize().Multiply(ME.MaxSpeed);
            return (DesiredVelocity.Sub(ME.Velocity));
        }
    }
}