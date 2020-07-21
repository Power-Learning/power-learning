using System;
using UnityEngine;

namespace LearningPower.Observer
{
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
            OnPOIEntered?.Invoke(this._poiName);
        }
    }
}