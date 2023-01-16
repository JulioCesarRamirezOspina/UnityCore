﻿using System;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Runtime.Reactor.Internal
{
    public static class ReactionPool
    {
        public static List<Reaction> pool { get; private set; } = new List<Reaction>();

        private static bool initialized { get; set; }

        private static void Initialize()
        {
            if (initialized) return;
            pool ??= new List<Reaction>();
            initialized = true;
        }
        
        /// <summary> Get a reaction from the given reaction type, either from the pool or a new one </summary>
        /// <typeparam name="T"> Reaction Type </typeparam>
        public static T Get<T>() where T : Reaction
        {
            Initialize();
            pool.Remove(null);
            T reaction = null;
            foreach (Reaction pooledItem in pool)
            {
                if (!(pooledItem is T castedItem))
                    continue;
                if(castedItem.GetType().IsSubclassOf(typeof(T)))
                    continue;
                    
                reaction = castedItem;
                pool.Remove(castedItem);
                break;
            }

            reaction ??= Activator.CreateInstance<T>();
            reaction.state = ReactionState.Idle;
            return reaction;
        }

        /// <summary> Return the given reaction to the pool </summary>
        public static void AddToPool<T>(this T reaction) where T : Reaction
        {
            Initialize();
            reaction.Reset();
            reaction.state = ReactionState.Pooled;
            pool.Add(reaction);
        }
    }
}
