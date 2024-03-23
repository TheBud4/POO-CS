
namespace Exercicio_10;
public class ConversorDeMoedas {

    private double _dolarReal = 5.0;
    public double DolarEmReal {
        get { return _dolarReal; }
    }

    private double _euroReal = 5.4;

    public double EuroEmReal {
        get { return _euroReal; }
    }
    public double RealParaDolar(double valor) => valor * DolarEmReal;
    public double RealParaEuro(double valor) => valor * EuroEmReal;
    public double DolarParaReal(double valor) => DolarEmReal / valor;
    public double EuroParaReal(double valor) => EuroEmReal / valor;
}
