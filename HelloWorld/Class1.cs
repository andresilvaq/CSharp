using System;

public class Class1
{
	int x = 0;
	float y = 0.1f;
	double d = 0.1d;

	string z = ""; 



    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
