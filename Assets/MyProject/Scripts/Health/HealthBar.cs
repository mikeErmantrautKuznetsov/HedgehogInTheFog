using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private Slider _healthSlider;

    public void Health(float health)
    {
        health = _health;

        health = Mathf.Clamp(health, 0, 100);

        _healthSlider.value = health / 100;
    }
}
