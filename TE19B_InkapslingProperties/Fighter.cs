using System;

public class Fighter
{
  public string Name {get; set;}
  
  private int xp;
  public int Xp
  {
    get
    {
      return xp;
    }
    set
    {
      xp = value;
    }
  }

  public int Level
  {
    get
    {
      return xp / 10;
    }
    private set
    {

    }
  }





  private int hp = 100;

  public int Hp
  {
    get
    {
      return hp;
    }
    set
    {
      hp = value;
      hp = Math.Max(0, hp);
    }
  }



  public int GetHp()
  {
    return hp;
  }

  public void SetHp(int value)
  {
    hp = value;
    hp = Math.Max(0, hp);
  }

  public void TakeDamage(int amount)
  {
    hp -= amount;

    hp = Math.Max(0, hp);
  }



}