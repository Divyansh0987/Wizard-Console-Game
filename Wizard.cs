using System.Runtime.InteropServices;

class Wizard
{
    public string Name;

    private float _hp;

    public float Hp
    {
        get => _hp;
        set
        {
            value = Math.Clamp(value, 0, maxHp);
            _hp = value;
        }
    }

    public float maxHp = 100;

    public int maxNumOfSpells;

    // public List<Spell> Spells;

    public Wizard([Optional] string name)
    {
        this.Name = name;
        this.Hp = maxHp;
    }
}