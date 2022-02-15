using System;
using UnityEngine;

namespace LearningPattern.Builder.Vehicle
{
    public abstract class Chassis : MonoBehaviour
    {
        protected abstract void OnCollisionEnter(Collision other);
    }
}