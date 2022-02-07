using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGame;


public class HelloWorld : MonoBehaviour
{

    public string text = "hello World";
    public bool turnOn = true;
    public float posX = 5.0f;
    public int intTest = 3;

    List<string> animals = new List<string>(){"dog","cat", "bird", "shark"};
    
    string[] names = new string[] { "jesse", "freeman"};

    Dictionary<string, string> weapons = new Dictionary<string,string>();

    // Start is called before the first frame update
    void Start()
    {
        Player cc = new Player();

        print(cc.health + "/" + cc.maxHealth);

        print("Health " + cc.CurrentHealthPercent() + "%");


        //names[0] = "Jesse";

    //    animals.Add("panda");
    //    animals.Add("fish");

    //    animals.Remove("bird");

    //    print("list to array length" + animals.ToArray().Length);

        weapons.Add("slot1", "sword");
        weapons.Add("slot2", "dagger");
        weapons.Add("slot3", "shield");

        print("Weapon in slot 1 " + weapons["slot1"]);
        print("slot 2 equiped " + weapons.ContainsKey("slot2"));

        //    //text = Test("Calling Test");

        //    print("First name " + names[1]);
        //    print("total name " + names.Length);

        //    print("total Animals " + animals.Count);
        //    print("animal 1 " + animals[0]);
        //    print("Last animal " + animals[animals.Count - 1]);

        LoopTest();

        //ConditionTest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Test(string value)
    {
        return value + "updated during Test()";
    }

    void ConditionTest()
    {
        string name = "Pedro";

        if (name == "jesse")
        {
            print("Name is Jesse");
        }
        else if (name == "Freeman")
        {
            print("Name is Freeman");
        }
        else
        {
            print("Name is Not Jesse or Freeman");
        }

        int health = 0;

        bool isDead = health <= 0;

        print(isDead);


        if (isDead)
        {
            print("player is dead");
            
        
        }
        else
        {
            print("player is not dead");
        }

        string mode = isDead == true ? "GameOver" : "IsPlaying";

        print("Game Mode " + mode);
    }

    void LoopTest()
    {
        for(int i = 0; i < 10; i ++)
        {
            print("Loop " + i);
        }
        
        for(int i = 9; i > -1; i --)
        {
            print("loop " + i);
        }

        foreach(string name in animals)
        {
            print(name);
        }

        foreach(var item in weapons)
        {
            print(item.Key + " " + item.Value);
        }
    }
}
