using System;


public class Principal
{
    static void Main(string[] args)
    {

    }
}

public abstract class Personnage 
{
    private int vie;
    private string nom;

    public Personnage(int v,string n)
    {
        this.vie = v;
        this.nom = n;
    }
    public int getvie() 
    {
        return this.vie;
    }

    public void setVie(int v)
    {
        this.vie = v;
    }   

    public void mort(bool m)
    {
        this.mort = m;
    }

    public void attaque (bool a)
    {
        this.attaque = a;
    }
    public string getnom()
    {
        return this.nom;
    }

    public void setnom(string n)
    {
        this.nom = n;
    }
}
public class Heros
{
    private int faim;
    private int soif;

    public Heros (int f,int s)
    {
        this.faim = f;
        this.soif = s;
    }
    public void setfaim(int f)
    {
        this.faim = f;
    }
    public int getfaim()
    {
        return this.faim;
    }
    public void setsoif(int s)
    {
        this.soif = s;
    }
    public int getsoif()
    {
        return this.soif;
    }
}
public class PNJ
{
    private int degats;
    private bool hostile;

    public PNJ (int d,bool h)
    {
        this.degats = d;
        this.hostile = h;
    }
        public void setdegats(int d)
    {
        this.degats = d;
    }
    public int getdegats()
    {
        return this.degats;
    }
    public void sethostile(bool h)
    {
        this.hostile = h;
    }
    public bool gethostile()
    {
        return this.hostile;
    }
}
public class Inventaire
{
    private int place;
    private ??? Items;
}
public abstract class Items
{
    private string nom;
    private string description;
    public Items (string n, string d)
    {
        this.nom = n;
        this.description = d;
    }
    public void setnom(string n)
    {
        this.nom = n;
    }
    public string getnom()
    {
        return this.nom;
    }
    public void setdescription(string d)
    {
        this.description = d;
    }
    public string getdescription()
    {
        return this.description;
    }
}
public class Armes 
{
    private int degats;
    private int durabilite;
    public Armes (int de, int du)
    {
        this.degats = de;
        this.durabilite = du;
    }
    public void setdegats(int de)
    {
        this.degats = de;
    }
    public int getdegats()
    {
        return this.degats;
    }
    public void setdurabilite(int du)
    {
        this.durabilite = du;
    }
    public int getdurabilite()
    {
        return this.durabilite;
    }
}
public class Consommables
{
    private int addvie;
    private int addfaim;
    private int addsoif;
    public Consommables(int v, int f, int s)
    {
        this.addvie = v;
        this.addfaim = f;
        this.addsoif = s;
    }
    public void setaddvie(int v)
    {
        this.addvie = v;
    }
    public int getaddvie()
    {
        return this.addvie;
    }
    public void setaddfaim(int f)
    {
        this.addfaim = f;
    }
    public int getaddfaim()
    {
        return this.addfaim;
    }
    public void setaddsoif(int s)
    {
        this.addsoif = s;
    }
    public int getaddsoif()
    {
        return this.addsoif;
    }
}
public class Speciaux
{
    private int numobjet;
    public Speciaux(int o)
    {
        this.numobjet = o;
    }
    public void setnumobjet(int o)
    {
        this.numobjet = o;
    }
    public int getnumobjet()
    {
        return this.numobjet;
    }
}