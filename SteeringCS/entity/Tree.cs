using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.entity
{
    class Tree : BaseGameEntity
    {

        private static int _incrementalId;

        public int Id { get; private set; }
        public double Scale { get; set; }
        public Vector2D Position { get; set; }
        public Bitmap Model { get; set; }

        protected Tree(Vector2D positon, World w, Bitmap model, double scale = 1) : base(positon, w)
        {
            Id = _incrementalId;
            Scale = scale;
            Position = positon;
            Model = model;
            _incrementalId++;
        }


        public void Renderer(Graphics graphics)
        {
            graphics.DrawImage(Model, new Point((int)Position.X, (int)Position.Y));
        }

        public override void Update(float delta)
        {
            throw new NotImplementedException();
        }
    }
}
