using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;

public class SpawnButton : MonoBehaviour
{
    private Button button;
    public int CharacterNum;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Click()
    {
        ObjectCharacter(6, 6);
    }

    private void ObjectCharacter(float x, float y)
    {
        GameObject Character_prefab;
        if (CharacterNum == 1)
        {
            Character_prefab = Resources.Load<GameObject>("Character01");
        }
        else
        {
            Character_prefab= Resources.Load<GameObject>("Character02");
        }
        GameObject Enemy = Instantiate(Character_prefab, new Vector3(x, y, 0), Quaternion.identity);
        return;
    }
}
