using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts.Service;

[RequireComponent(typeof(IHealth))]
public class SliderHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private IHealth _health;
    private int _currentAmount;
    private int _maxAmount;

    private void Awake()
    {
        _health = GetComponent<IHealth>();

        _health.isDamaged += ChangeData;
        _health.isHealed += ChangeData;
    }

    private void Start()
    {
        _slider.value = _health.HealthAmount;
        _slider.maxValue = _health.MaxHealth;
    }

    private void OnDestroy()
    {
        _health.isDamaged -= ChangeData;
        _health.isHealed -= ChangeData;
    }

    public void ChangeData()
    {
        _slider.value = _health.HealthAmount;
    }
}
