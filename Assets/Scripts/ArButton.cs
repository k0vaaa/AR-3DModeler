using Microsoft.MixedReality.Toolkit.UI;
using System;
using TMPro;
using UnityEngine;

public class ArButton : MonoBehaviour
{
    public event Action OnButtonClicked;
    [SerializeField] private TextMeshPro _title;
    [SerializeField] private Interactable _interactable;
    private GameObject _prefab;
    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.pref;
        _interactable.OnClick.AddListener(ProcessClick);


    }
    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        CreateSomething();  
    }

    public void CreateSomething()
    {
        Instantiate(_prefab);
        print("meow");
    }
}
