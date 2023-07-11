namespace COM;

public class Complex {

    private int real;
    private int imag;

    public Complex(){

        this.real = 0;
        this.imag = 0;
    }
 
    public Complex(int real, int imag){

        this.real = real;
        this.imag = imag;
    }

    public int REAL{
        get{return this.real;}
        set{this.real = value;}
    }

    public int IMAG{
        get{return this.imag;}
        set{this.imag = value;}
    }

    public static Complex operator+(Complex C1, Complex C2){

        Complex temp = new Complex();

        temp.real = C1.real + C2.real;
        temp.imag = C1.imag + C2.imag;

        return temp;

    }//end of Addition 

    public static Complex operator-(Complex C1, Complex C2){

        Complex temp = new Complex();

        temp.real = C1.real - C2.real;
        temp.imag = C1.imag - C2.imag;

        return temp;

    }//end of Subtraction

    public static Complex operator*(Complex C1, Complex C2){

        Complex temp = new Complex();

        temp.real = C1.real * C2.real;
        temp.imag = C1.imag * C2.imag;

        return temp;

    }//end of Multiplication 

    public static Complex operator/(Complex C1, Complex C2){

        Complex temp = new Complex();

        temp.real = C1.real / C2.real;
        temp.imag = C1.imag / C2.imag;

        return temp;

    }//end of Division 

    public override string ToString(){

        return this.real + " + " + this.imag + "i";
    }

}