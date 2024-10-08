using Assets.Scripts.Service;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(IHealth))]
public class SmothSliderHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private int _speedReduction;

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

    public void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health.HealthAmount, _speedReduction * Time.deltaTime);
    }

    public void ChangeData(){}
}
