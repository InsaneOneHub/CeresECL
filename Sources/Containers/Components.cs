﻿using System;
using System.Collections.Generic;

namespace CeresECL
{
    public sealed class Components : Container
    {
        readonly List<Component> components = new List<Component>();
        
        public Components(Entity entity) : base(entity) { }
        
        /// <summary> Get (with add if dont exist) any of game Components.</summary>
        public T Get<T>() where T : Component, new()
        {
            foreach (var component in components)
                if (component is T resultComponent)
                    return resultComponent;

            var newComponent = new T
            {
                Entity = Entity
            };
            
            components.Add(newComponent);

            return newComponent;
        }
        
        /// <summary> Get (with add if dont exist) any of game Components.</summary>
        public Component Get(Type componentType)
        {
            if (!typeof(Component).IsAssignableFrom(componentType))
                return null;
            
            foreach (var comp in components)
                if (comp.GetType() == componentType)
                    return comp;
            
            var newComponent = Activator.CreateInstance(componentType) as Component;
            newComponent.Entity = Entity;
            components.Add(newComponent);
            
            return newComponent;
        }
        
        public bool Have<T>() where T : Component
        {
            foreach (var component in components)
                if (component is T)
                    return true;

            return false;
        }

        public void Delete<T>() where T : Component
        {
            foreach (var component in components)
                if (component is T)
                    components.Remove(component);
        }
                
        /// <summary> Used only for editor scripting. </summary>
        public List<Component> GetListEditor()
        {
            var list = new List<Component>();

            for (var i = 0; i < components.Count; i++)
                list.Add(components[i]);
            
            return list;
        }
    }
}