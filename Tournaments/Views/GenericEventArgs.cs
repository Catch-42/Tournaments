using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Models;

namespace Tournaments.Views
{
    public class GenericEventArgs<Entity> : EventArgs where Entity: class
    {
        public GenericEventArgs(Entity entity)
        {
            this.EntityProp = entity;
        }

        public Entity EntityProp{get;private set;}
    }
}