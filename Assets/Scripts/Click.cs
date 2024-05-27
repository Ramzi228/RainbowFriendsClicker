using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using YG;

public class Click : MonoBehaviour
{
    [SerializeField] int money;
    [SerializeField] GameObject Achivment1;
    [SerializeField] GameObject Defoltachive1;
    [SerializeField] GameObject Achivment2;
    [SerializeField] GameObject Defoltachive2;
    [SerializeField] GameObject Achivment3;
    [SerializeField] GameObject Defoltachive3;
    [SerializeField] GameObject Achivment4;
    [SerializeField] GameObject Defoltachive4;
    [SerializeField] GameObject Blue;
    [SerializeField] GameObject Green;
    [SerializeField] GameObject Orange;
    [SerializeField] GameObject Purple;
    [SerializeField] GameObject Red;
 
    public Text moneyText;
    public int total_money;

    

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        total_money = PlayerPrefs.GetInt("total_money");
    }

    public void ButtonClick()
    {
        money++;
        total_money++;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }

    public void ToAchivments()
    {
        SceneManager.LoadScene(1);
    }

    

    void Update()
    {
        moneyText.text = money.ToString();

        if (total_money >= 100)
        {
            Achivment1.SetActive(true);
            Defoltachive1.SetActive(false);

        }

        if (total_money >= 1000) // вторая ачивка
        {
            Achivment2.SetActive(true);
            Defoltachive2.SetActive(false);

        }

        if (total_money >= 1500) // третья ачивка
        {
            Achivment3.SetActive(true);
            Defoltachive3.SetActive(false);

        }

        if (total_money >= 5500) // четвертая ачивка
        {
            Achivment4.SetActive(true);
            Defoltachive4.SetActive(false);

        }

        if (total_money >= 1000)
        {
            Blue.SetActive(false);
            Green.SetActive(true);
            Orange.SetActive(false);
            Purple.SetActive(false);
            Red.SetActive(false);
        }

        if (total_money >= 2500)
        {
            Blue.SetActive(false);
            Green.SetActive(false);
            Orange.SetActive(true);
            Purple.SetActive(false);
            Red.SetActive(false);
        }

        if (total_money >= 4000)
        {
            Blue.SetActive(false);
            Green.SetActive(false);
            Orange.SetActive(false);
            Purple.SetActive(true);
            Red.SetActive(false);
        }

        if (total_money >= 5500)
        {
            Blue.SetActive(false);
            Green.SetActive(false);
            Orange.SetActive(false);
            Purple.SetActive(false);
            Red.SetActive(true);
        }
    }
}


