namespace Fafnir.Mjollnir.Architecture
{
    using UnityEngine;
    using UnityEngine.Events;

    public class BaseListener<T, E, UE> : MonoBehaviour, IListener<T> where E : BaseEvent<T> where UE : UnityEvent<T>
    {
        [SerializeField] private E _event;
        [SerializeField] private UE _response;

        private void OnEnable()
        {
            if (_event != null)
            {
                _event.Register(this);
            }
        }

        private void OnDisable()
        {
            if (_event != null)
            {
                _event.Unregister(this);
            }
        }

        public void Raise(T value)
        {
            if (_response != null)
            {
                _response.Invoke(value);
            }
        }
    }
}