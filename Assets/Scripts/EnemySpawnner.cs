using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnner : MonoBehaviour
{
    public int EnemyNum;
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        ObjectEnemy(-6, 6);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > 1)
        {
            ObjectEnemy(-6, 6);
            Timer = 0;
        }
    }
    private void ObjectEnemy(float x, float y)
    {
        GameObject Enemy_prefab;
        if (EnemyNum == 1)
        {
            Enemy_prefab = Resources.Load<GameObject>("Enemy01");
        }
        else
        {
            Enemy_prefab = Resources.Load<GameObject>("Enemy02");
        }
        GameObject Enemy = Instantiate(Enemy_prefab, new Vector3(x, y, 0), Quaternion.identity);
        return;
    }
}
