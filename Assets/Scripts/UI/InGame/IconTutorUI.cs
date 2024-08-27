using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconTutorUI : MonoBehaviour
{
    private IInputService _inputService;

    private void Awake()
    {
        _inputService = InGameIoC.Instance.InputService;
    }

    private void Start()
    {
        Show();
    }

    private void Update()
    {
        if (_inputService.GetMovementInput() != Vector2.zero)
        {
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {

    gameObject.SetActive(false); 
    }
}
