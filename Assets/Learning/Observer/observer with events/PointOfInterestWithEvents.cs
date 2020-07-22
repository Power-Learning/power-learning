using System;
using UnityEngine;

namespace LearningPower.LearningPatterns.Observer
{
    /// <summary>
    /// This class instead of represents a subscriber for a observer system
    /// implements it self event to get the necessary data when something changes
    /// </summary>
    public class PointOfInterestWithEvents : MonoBehaviour
    {
        public static event Action<string> OnPOIEntered;

        [SerializeField] private string _poiName;

        public string PoiName => _poiName;

        private void Start()
        {
            _poiName = name;
        }

        private void OnTriggerEnter(Collider other)
        {
            // When the event it's called, OnPOIEntered make
            // an Invoke with the specific value (his in this case)
            OnPOIEntered?.Invoke(this._poiName);
        }
    }
}