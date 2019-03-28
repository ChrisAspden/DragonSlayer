using System;

public class Dragon
{

    private int Health;
    private int Defence;
    private int Attack;




    public Dragon(int hp, int def, int atk)
	{
        Health = hp;
        Defence = def;
        Attack = atk;
	}

    public int getAtk()
    {
        return Attack;
    }


    public void setHP(int hp)
    {
        Health = hp;
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
