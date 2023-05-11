using System;

public class TiposDeDados
{
	int x = 0;
	float y = 0.1f;
	double d = 0.1d;

	string z = "";

    bool b1 = true;

    char c1 = 'a';
      

    public TiposDeDados(int x, float y, double d, string z, bool b1, char c1)
    {
        this.x = x;
        this.y = y;
        this.d = d;
        this.z = z;
        this.b1 = b1;
        this.c1 = c1;

        var cidade = "blumenau";

        var idade = 30;

        const string pais = "paragua";

        this.y = (float)x;

    }
}
