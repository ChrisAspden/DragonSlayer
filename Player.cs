using System;

public class Player
{

    private int Health;
    private int Defence;
    private int Attack;

 

    public Player(int hp, int def, int atk)
	{
        Health = hp;
        Defence = def;
        Attack = atk;
	}



    public void setHP(int hp)
    {
        Health = hp;
    }

    public void setDef(int def)
    {
        Defence = def;
    }

    public int getHP()
    {
        return Health;
    }

    public int getDef()
    {
        return Defence;
    }

    






}
