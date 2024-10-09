using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts.Service;
using Assets.Scripts.UnitUI;

[RequireComponent(typeof(IHealth))]
public class SliderHealthBar : SliderUI
{
    public override void ChangeData()
    {
        base.ChangeData();

        Slider.value = Health.HealthAmount;
    }
}
