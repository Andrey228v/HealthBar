using Assets.Scripts.Service.Health;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonHealth : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] private HealthSystem _health;
        
    private int _healthPoints = 10;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.image.color = Color.green;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _health.TryGetHealth(_healthPoints);
    }
}
