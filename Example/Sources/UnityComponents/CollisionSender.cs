﻿using UnityEngine;

namespace CeresECL.Example
{
    public class CollisionSender : MonoBehaviour
    {
        Entity entity;
        
        void Start() => entity = GetComponent<Entity>();

        void OnTriggerEnter2D(Collider2D other)
        {
            if (!entity)
                return;

            var hitEvent = new ColliderHitEvent
            {
                HitCollider = other
            };
            
            entity.Events.Add(hitEvent);
        }
    }
}