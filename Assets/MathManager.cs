using TMPro;
using UnityEngine;

public class MathManager : MonoBehaviour
{
    public TextMeshProUGUI NumberText;
    private int _currentValue;
    public static MathManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
            _currentValue = int.Parse(NumberText.text);
    }

    public void ChangeValue(int value)
    {
        _currentValue += value;
        NumberText.text = _currentValue.ToString();
    }
}
