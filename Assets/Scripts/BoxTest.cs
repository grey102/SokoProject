using UnityEngine;

public class BoxTest : MonoBehaviour
{
    public bool onCrox;

    float t = 0;
    Vector2 srcPosition = new Vector2(2.5f,-0.5f);
    Vector2 dstPosition = new Vector2(2.5f, 0.5f);

    void Update()
    {
        transform.position = Vector2.Lerp(srcPosition, dstPosition, t);
        t += Time.deltaTime * 0.5f; // will do the lerp over two seconds

        GameObject[] bombs = GameObject.FindGameObjectsWithTag("Bomb");
        foreach (var bomb in bombs)
        {
            if (transform.position.x == bomb.transform.position.x && transform.position.y == bomb.transform.position.y)
            { // если координаты "коробки" и "бомбы" совпадают
                GetComponent<SpriteRenderer>().color = Color.red; // меняем цвет "коробки" на красный
                bomb.GetComponent<Rigidbody2D>().simulated = false; //???
                onCrox = true;
                return;
            }
        }

    }
}
