using System.Collections.Generic;

public class Cadeteria{
    string Nombre;
     int Telefono;
    List<Cadete> Cadetes;
    public
    Cadeteria(string nombre, int telefono){
        this.Nombre=nombre;
        this.Telefono=telefono;
        Cadetes=new List<Cadete>();
    }

    void AgregarCadete(Cadete Cad){
        Cadetes.Add(Cad);
    }

}