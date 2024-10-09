using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts.Service.Health;

namespace Assets.Scripts.UnitUI
{
    [RequireComponent(typeof(Button))]
    public class ButtonUI: MonoBehaviour
    {
        [SerializeField] private HealthSystem _health;

        public Button Button {get; private set;}
        public HealthSystem Health { get; private set; }

        public virtual void Awake()
        {
            Button = GetComponent<Button>();
            Health = _health;
        }
    }
}
