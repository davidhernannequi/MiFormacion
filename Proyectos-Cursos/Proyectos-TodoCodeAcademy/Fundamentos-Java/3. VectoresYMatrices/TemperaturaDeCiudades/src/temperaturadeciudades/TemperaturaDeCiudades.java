/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package temperaturadeciudades;
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class TemperaturaDeCiudades {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String ciudades [] = new String[5];
        double temperaturaMinima [] = new double[5];
        double temperaturaMaxima [] = new double[5];
       
        Scanner teclado = new Scanner(System.in);
        Scanner teclado2 = new Scanner(System.in);

        for (int i = 0; i < 10; i++) {
            System.out.print("Ingrese la ciudad");
            ciudades[i] = teclado.next();
            
            System.out.print("Ingrese la temperatura minima");
            temperaturaMinima[i] = teclado2.nextDouble();
            
            System.out.print("Ingrese la temperatura maxima");
            temperaturaMaxima[i] = teclado2.nextDouble();
        }
        
        
    }
    
}
