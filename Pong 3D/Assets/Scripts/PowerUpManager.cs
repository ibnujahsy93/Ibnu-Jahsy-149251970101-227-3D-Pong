using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

    public Transform spawnArea;
    public int maxPowerUpAmount;
    public int spawnInterval;
    public int destroyInterval;
    public Vector3 powerUpAreaMin;
    public Vector3 powerUpAreaMax;
    public List<GameObject> powerUpTemplateList;
    private List<GameObject> powerUpList;
    [SerializeField]private float timer;
    [SerializeField] private float timerDestroy;
    // Start is called before the first frame update
    void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
        timerDestroy = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer = 0;

        }
        timerDestroy += Time.deltaTime;
        if (timerDestroy > destroyInterval)
        {

            Destroy(powerUpList[0].gameObject);
            powerUpList.Remove(powerUpList[0].gameObject);

            timerDestroy = 0;

        }
    }

    public void GenerateRandomPowerUp(Vector3 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x || position.x > powerUpAreaMax.x ||
            position.z < powerUpAreaMin.z || position.z > powerUpAreaMax.z)
        {
            return;
        }
        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, powerUpTemplateList[randomIndex].transform.position.y, position.z ), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    public void GenerateRandomPowerUp()
    {

        GenerateRandomPowerUp(new Vector3(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), transform.position.y, Random.Range(powerUpAreaMin.z, powerUpAreaMax.z)));

    }




    public void RemovePowerUp(GameObject powerup)
    {
        powerUpList.Remove(powerup);
        Destroy(powerup);
    }


    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}
