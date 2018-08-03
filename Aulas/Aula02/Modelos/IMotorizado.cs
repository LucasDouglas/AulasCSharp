namespace Aula02.Modelos
{
    interface IMotorizado
    {


        int Velocidade { get; set; }
        void Acelerar();
        void Desacelerar();


    }
}
