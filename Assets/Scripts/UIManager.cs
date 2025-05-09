using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _amountCoins;
    private int _amountMoney;
    private void Start()
    {
        if (_amountCoins == null) Debug.LogWarning("Amount Coint TMP - not Fount!");
        else _amountCoins.text = $"COINS: {_amountMoney}";
    }
    public void WriteAmountMoney(Player player)
    {
        //amountMoney = player.Wallet;
        _amountCoins.text = $"COINS: {_amountMoney}";
    }
}
