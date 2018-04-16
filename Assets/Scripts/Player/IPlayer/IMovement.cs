using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Move
{
    /// <summary>
    /// This is the namespace
    /// Have a abstract clss for other script inherit
    /// <Author> Wumenghua </Author>
    /// </summary>
    public abstract class IMovement {

        public abstract void _forward(GameObject player);
        public abstract void _back(GameObject player);
        public abstract void _left(GameObject player);
        public abstract void _right(GameObject player);

    }
}

