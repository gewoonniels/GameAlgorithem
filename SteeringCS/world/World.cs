using SteeringCS.behaviour;
using SteeringCS.entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS
{
    class World
    {
        private List<MovingEntity> entities = new List<MovingEntity>();
        public Vehicle Target { get; set; }
        public Vehicle Target2 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public World(int w, int h)
        {
            Width = w;
            Height = h;
            populate();
        }

        private void populate()
        {
            //Dog with seek behaviour
            Dog dog = new Dog(new Vector2D(10, 10), this);
            dog.SB = new SeekBehaviour(dog);
            entities.Add(dog);

            //Flee behaviour on vehicle
            Dog dog2 = new Dog(new Vector2D(600, 600), this);
            dog2.SB = new FleeBehaviour(dog2);
            entities.Add(dog2);


            //Vehicle wander = new Vehicle(new Vector2D(150, 70), this);
            //wander.VColor = Color.DarkGreen;
            //wander.SB = new wanderBehaviour(wander);
            //entities.Add(wander);

            Target = new Vehicle(new Vector2D(100, 60), this);
            Target.VColor = Color.DarkRed;
            Target.Pos = new Vector2D(100, 40);
        }

        public void Update(float timeElapsed)
        {
            foreach (MovingEntity me in entities)
            {
                me.Update(timeElapsed);
            }
        }

        public void Render(Graphics g)
        {
            entities.ForEach(e => e.Render(g));
            Target.Render(g);
        }
    }
}
