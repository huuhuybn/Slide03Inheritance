using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour
{
    private Slider _slider;
    public Image FillImage;
    public Gradient FillGradient;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener(UpdateColor);
        UpdateColor(_slider.value);
    }

    public void UpdateColor(float value)
    {
        FillImage.color = FillGradient.Evaluate(_slider.normalizedValue);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
