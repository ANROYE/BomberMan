using UnityEngine;

public class ExitTrigger : MonoBehaviour {
         /// <summary>
         ///當玩家退出炸彈時，觸發器被設置為false
         ///所以玩家不能穿越炸彈
         /// <Author> Wumenghua </ Author>
         /// </ summary>

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            gameObject.GetComponent<Collider>().isTrigger = false;
        }

        
    }


}
