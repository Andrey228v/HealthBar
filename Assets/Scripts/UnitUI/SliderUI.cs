using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts.Service;

namespace Assets.Scripts.UnitUI
{
    [RequireComponent(typeof(IHealth))]
    public class SliderUI: MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        public IHealth Health {get; private set;}

        public Slider Slider { get; private set; }

        public virtual void Awake()
        {
            Health = GetComponent<IHealth>();
            Slider = _slider;

            Health.isDamaged += ChangeData;
            Health.isHealed += ChangeData;
        }

        private void Start()
        {
            Slider.value = Health.HealthAmount;
            Slider.maxValue = Health.MaxHealth;
        }

        private void OnDestroy()
        {
            Health.isDamaged -= ChangeData;
            Health.isHealed -= ChangeData;
        }

        public virtual void Update(){}

        public virtual void ChangeData(){}
    }
}
