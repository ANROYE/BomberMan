using UnityEngine;

public class Player2 : IMovemen
{
  
    private void SetAni(GameObject player, bool start)
    {
        player.GetComponent<Animator>().SetBool("Walking", start);
    }

    public void SetBomb(GameObject player,GameObject bomb)
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            Object.Instantiate(bomb,
             new Vector3(Mathf.RoundToInt(player.transform.position.x), 
             player.transform.position.y, 
             Mathf.RoundToInt(player.transform.position.z)), player.transform.rotation);
        }
    }

    public void MoveCalculate(GameObject player, float speed)
    {        
        player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveBack(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            SetAni(player, true);
            player.transform.rotation = Quaternion.Euler(0, 180, 0);
            MoveCalculate(player, speed);
        }
        
    }

    public void MoveForward(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SetAni(player, true);
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
            MoveCalculate(player, speed);
        }
        
    }

    public void MoveLeft(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SetAni(player, true);
            player.transform.rotation = Quaternion.Euler(0, -90, 0);
            MoveCalculate(player, speed);
        }
        
    }

    public void MoveRight(GameObject player, float speed)
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            SetAni(player, true);
            player.transform.rotation = Quaternion.Euler(0, 90, 0);
            MoveCalculate(player, speed);
        }
        
    }
}
