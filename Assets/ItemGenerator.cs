using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;

    public GameObject unitychan;
    //スタート地点
    private int startPos = -160;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    void Generate(int a)
    {
        int i = startPos;
        //どのアイテムを出すのかをランダムに設定
            if (a <= 1)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
    }
}
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j< 2; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
//アイテムを置くZ座標のオフセットをランダムに設定
int offsetZ = Random.Range(-5, 6);
                    //60%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
coin.transform.position = new Vector3(posRange* j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
car.transform.position = new Vector3(posRange* j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float a = unitychan.transform.position.z;
        if(a+45 >= startPos && startPos <=120)
        {
            int num = Random.Range(0, 10);
            Generate(num);
            startPos += 15;
        }

    }
}