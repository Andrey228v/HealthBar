using Assets.Scripts.Service;
using Assets.Scripts.UnitUI;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(IHealth))]
public class SmothSliderHealthBar : SliderUI
{
    [SerializeField] private int _speedReduction;

    public override void Update()
    {
        base.Update();

        Slider.value = Mathf.MoveTowards(Slider.value, Health.HealthAmount, _speedReduction * Time.deltaTime);
    }
}
