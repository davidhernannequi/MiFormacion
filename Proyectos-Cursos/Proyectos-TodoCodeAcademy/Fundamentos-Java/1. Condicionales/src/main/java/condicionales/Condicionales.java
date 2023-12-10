/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package condicionales;
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class Condicionales {

    public static void main(String[] args) {
        double sueldoFinal = 0;
        int categoria;
        
        System.out.println("Ingrese la categoria: 1 - 2 - 3");
        System.out.println("1(Repositor), 2(Cajero), 3(Supervisor)");
        Scanner teclado = new Scanner(System.in);
        categoria = teclado.nextInt();
        
        switch(categoria){
            case 1:
                sueldoFinal = 15890 * 1.1;
                break;
            case 2:
                sueldoFinal = 25630.89;
                break;
            case 3:
                sueldoFinal = 35560.20 * 0.89;
                System.out.println("La categoria " + categoria + " tiene un sueldo final de $" + sueldoFinal);
                break;
            default:
                System.out.println("Ingrese una categoria valida entre 1,2 y 3.");
                break;
        } 
        
        //if(categoria == 1 || categoria == 2 || categoria == 3)
            //System.out.println("La categoria " + categoria + " tiene un sueldo final de $" + sueldoFinal);
    }
}
