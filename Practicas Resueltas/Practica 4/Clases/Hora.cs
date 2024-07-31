public class Hora{
    private String tiempo;

    public Hora (int hora, int minutos,int segundos){
        this.tiempo = $"{hora} Horas, {minutos} minutos , {segundos} segundos."; 
    }

    public Hora (double decimalHora){
        int horas = (int)decimalHora;
        int minutos = (int)((decimalHora - horas) * 60);
        int segundos = (int)(((decimalHora - horas) * 60 - minutos) * 60);

        this.tiempo = $"{horas} Horas, {minutos} minutos, {segundos} segundos.";
    }

    public void imprimir(){
        Console.WriteLine(this.tiempo);
    }


}