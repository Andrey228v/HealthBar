using Assets.Scripts.Service;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(IHealth))]
public class SmothSliderHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private int _speedReduction;

    private IHealth _health;

    private void Awake()
    {
        _health = GetComponent<IHealth>();
    }

    private void Start()
    {
        _slider.value = _health.HealthAmount;
        _slider.maxValue = _health.MaxHealth;
    }

    public void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health.HealthAmount, _speedReduction * Time.deltaTime);
    }
}
