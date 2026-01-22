using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField] private GameObject goldCoinPrefab, healtGlobePrefab, staminaGlobePrefab;

    public void DropItems()
    {
        int randomNum = Random.Range(1, 5);
        if (randomNum == 1)
        {
            Instantiate(healtGlobePrefab, transform.position, Quaternion.identity);
        }

        if (randomNum == 2)
        {
            Instantiate(staminaGlobePrefab, transform.position, Quaternion.identity);

        }

        if (randomNum == 3)
        {
            int randomAmountOfGold = Random.Range(1, 4);
            for (int i = 0; i < randomAmountOfGold; i++)
            {

                Instantiate(goldCoinPrefab, transform.position, Quaternion.identity);
            }

        }

    }
}
