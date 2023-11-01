using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney: MonoBehaviour
{
    [SerializeField] private int _moneyAmmount;
    [SerializeField] private TextMeshPro _moneySign;

    public void Start()
    {
        _moneySign.text = _moneyAmmount.ToString();
    }
    public void ProcessBuy(int money)
    {
        if (_moneyAmmount - money < 0)
        {
            return;
        }
        _moneyAmmount -= money;
        _moneySign.text = _moneyAmmount.ToString();
    }

    public bool CanBuy(int price)
    {
        return _moneyAmmount - price >= 0;
    }   
}
