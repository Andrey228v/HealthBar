using Assets.Scripts.Service.Health;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonDamage : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] private HealthSystem _health;

    private int _damage = 10;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.image.color = Color.red;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _health.GetDamage(_damage);
    }
}
