using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSelectScript : MonoBehaviour
{
    [SerializeField] private Toggle _villageToggle;
    [SerializeField] private Toggle _marketToggle;
    [SerializeField] private Toggle _hospitalToggle;
    [SerializeField] private Toggle _gasStationToggle;
    [SerializeField] private GarageResourceBackendScript _garageResourceBackendScript;
    [SerializeField] private KitchenResourceBackendScript _kitchenResorceBackendScript;
    [SerializeField] private DayManagerScript _dayManagerScript;
    [SerializeField] private ZombieManagerScript _zombieManager;
    ChooseCharacterManagerScript _chooseCharacterManagerScript;

    private void Start()
    {
        _garageResourceBackendScript.GetComponent<GarageResourceBackendScript>();
        _kitchenResorceBackendScript.GetComponent<KitchenResourceBackendScript>();
        _zombieManager.GetComponent<ZombieManagerScript>();
        _dayManagerScript.GetComponent<DayManagerScript>();
        _chooseCharacterManagerScript = GameObject.FindGameObjectWithTag("ChooseCharacterManager").GetComponent<ChooseCharacterManagerScript>();
    }

    public void NextDayButtonClick()
    {
        if (_villageToggle.isOn == true)
        {
            for(int i = 0; i < 10; i++)
            {
                int randomNumber = Random.Range(1, 101);
                switch (randomNumber)
                {
                    case <=25:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 0);
                        break;

                    case <=45:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 1);
                        break;

                    case <=55:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 5);
                        break;

                    case <=70:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 6);
                        break;

                    case <=80:
                        _kitchenResorceBackendScript.ReceiveRawFood(1);
                        break;

                    case <=90:
                        _kitchenResorceBackendScript.ReceiveCannedFood(1);
                        break;

                    case <=100:
                        _kitchenResorceBackendScript.ReceiveWater(1);
                        break;

                }

            }
            gameObject.SetActive(false);
        }
        else if (_marketToggle.isOn == true)
        {
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = Random.Range(1, 101);
                switch (randomNumber)
                {
                    case <=20:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 1);
                        break;

                    case <=30:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 2);
                        break;

                    case <=50:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 3);
                        break;

                    case <=60:
                        _kitchenResorceBackendScript.ReceiveRawFood(1);
                        break;

                    case <=70:
                        _kitchenResorceBackendScript.ReceiveVegetableFood(1);
                        break;

                    case <=80:
                        _kitchenResorceBackendScript.ReceiveCannedFood(1);
                        break;

                    case <=95:
                        _kitchenResorceBackendScript.ReceiveWater(1);
                        break;

                    case <= 100:
                        _kitchenResorceBackendScript.ReceiveBandage(1);
                        break;

                }

            }
            gameObject.SetActive(false);
        }
        else if(_hospitalToggle.isOn == true)
        {
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = Random.Range(1, 101);
                switch (randomNumber)
                {
                    case <= 5:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 2);
                        break;

                    case <= 15:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 3);
                        break;

                    case <= 35:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 3);
                        break;

                    case <= 45:
                        _kitchenResorceBackendScript.ReceiveWater(1);
                        break;

                    case <= 75:
                        _kitchenResorceBackendScript.ReceiveMedicine(1);
                        break;

                    case <= 100:
                        _kitchenResorceBackendScript.ReceiveBandage(1);
                        break;

                }

            }
            gameObject.SetActive(false);
        }
        else if(_gasStationToggle.isOn == true)
        {
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = Random.Range(1, 101);
                switch (randomNumber)
                {
                    case <= 25:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 0);
                        break;

                    case <= 45:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 1);
                        break;

                    case <= 55:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 5);
                        break;

                    case <= 70:
                        _garageResourceBackendScript.ReceiveResourceToList(1, 6);
                        break;

                    case <= 80:
                        _kitchenResorceBackendScript.ReceiveRawFood(1);
                        break;

                    case <= 90:
                        _kitchenResorceBackendScript.ReceiveCannedFood(1);
                        break;

                    case <= 100:
                        _kitchenResorceBackendScript.ReceiveWater(1);
                        break;

                }

            }
            gameObject.SetActive(false);
        }
        _zombieManager.ZombieRaidChanceAfterEndDay();
        _dayManagerScript.DayIncrese(1);
    }
}
